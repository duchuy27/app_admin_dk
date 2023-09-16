using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Stock_lot;
using WindowsFormsApp1.stock_product;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly int FLAG_IN_INVENTORY = BitVector32.CreateMask();
        private static readonly int FLAG_STOP_INVENTORY = BitVector32.CreateMask(FLAG_IN_INVENTORY);
        private static readonly ushort s_usStopInventoryTimeout = 10000;
        private string path_image_conect_rfid = Application.StartupPath.Replace(@"\bin\Debug", "") + @"\images\Connect_rfid.png";
        private string path_image_disconnect_rfid = Application.StartupPath.Replace(@"\bin\Debug", "") + @"\images\Disconnect_rfid.png";
        private string path_image_conect_internet = Application.StartupPath.Replace(@"\bin\Debug", "") + @"\images\server_connect.png";
        private string path_image_disconnect_internet = Application.StartupPath.Replace(@"\bin\Debug", "") + @"\images\server_disconnect.png";
        private Bitmap image_connect_rfid;
        private Bitmap image_connect_internet;
        private string isFull = "1";

        public Reader Reader
        {
            get { return m_reader; }
        }

        // Bộ nhận dạng
        BitVector32 m_flags = new BitVector32();

        Devicepara devicepara = new Devicepara();
        Reader m_reader = new Reader();
        static readonly HttpClientHandler handler = new HttpClientHandler();
        static readonly HttpClient client = new HttpClient(handler);
        Thread m_thInventory = null;


        protected bool InInventory
        {
            get { return m_flags[FLAG_IN_INVENTORY]; }
            set { m_flags[FLAG_IN_INVENTORY] = value; }
        }

        public bool StopInventory
        {
            get { return m_flags[FLAG_STOP_INVENTORY]; }
            set { m_flags[FLAG_STOP_INVENTORY] = value; }
        }

        private void CloseInventoryThread()
        {
            try
            {
                StopInventory = true;
                if (!m_thInventory.Join(4000))
                    m_thInventory.Abort();
            }
            catch { }
        }

        private void OnInventoryEnd()
        {
            InInventory = false;
            StopInventory = true;
        }

        private void DoStopInventory()
        {
            try
            {
                InInventory = false;
                StopInventory = true;
                try
                {
                    Reader reader = this.Reader;
                    if (reader != null)
                    {
                        reader.InventoryStop(s_usStopInventoryTimeout);
                    }
                }
                catch (Exception) { };
            }
            catch { }
            try
            {
                this.BeginInvoke(new ThreadStart(OnInventoryEnd));
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Open_USB.Enabled = false;
            Close_USB.Enabled = false;

            ShowImage_Connect_RFID(path_image_disconnect_rfid);

            //Tạo luồng để ktra kết nối mạng
            initThread(4);
            //Tạo luồng DS xe
            initThread(2);
            //Tạo luồng DS 
            initThread(0);
            initThread(1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn muốn thoát chương trình?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void initThread(int num)
        {
            if (num == 0)
            {
                Thread thrd_update_lot = new Thread(update_DS);
                thrd_update_lot.IsBackground = true;
                thrd_update_lot.Start();
                return;
            }
            if (num == 1)
            {
                Thread thrd_locations = new Thread(update_DS_Ng);
                thrd_locations.IsBackground = true;
                thrd_locations.Start();
                return;
            }
            if (num == 2)
            {
                Thread thrd_move_history = new Thread(update_DS_Xe);
                thrd_move_history.IsBackground = true;
                thrd_move_history.Start();
                return;
            }
            if (num == 3)
            {
                m_thInventory = new Thread(InventoryThread);
                m_thInventory.IsBackground = true;
                m_thInventory.Start();
                return;
            }

            if (num == 4)
            {
                Thread thread_check_connect = new Thread(threadCheckConnect);
                thread_check_connect.IsBackground = true;
                thread_check_connect.Start();
                return;
            }
        }

        private void Scan_USB_Click(object sender, EventArgs e)
        {
            string strSN = "";
            byte[] arrBuffer = new byte[256];
            string flag = "";
            cbxusbpath.Items.Clear();

            int iHidNumber = m_reader.CFHid_GetUsbCount();
            for (UInt16 iIndex = 0; iIndex < iHidNumber; iIndex++)
            {
                m_reader.CFHid_GetUsbInfo(iIndex, arrBuffer); //Lấy thông tin của thiết bị USB thứ iIndex và lưu vào mảng byte arrBuffer
                strSN = System.Text.Encoding.Default.GetString(arrBuffer).Replace("\0", ""); //Chuyển đổi mảng byte arrBuffer thành chuỗi và gán cho biến strSN. Loại bỏ ký tự \0 trong chuỗi.
                flag = strSN.Substring(strSN.Length - 3); //Lấy 3 ký tự cuối cùng của chuỗi strSN và gán cho biến flag
                if (flag == "kbd")    //Bàn phím
                {
                    cbxusbpath.Items.Add("\\Keyboard-can'topen");
                }
                else                    // HID
                {
                    cbxusbpath.Items.Add("\\USB-open");
                }
                strSN = "";                   //đặt lại chuỗi strSN về ko giá trị
                arrBuffer = new byte[256];   //đặt lại mảng arrBuffer về không giá trị
            }
            if (iHidNumber > 0)
            {
                Open_USB.Enabled = true;
                cbxusbpath.SelectedIndex = 0; // Chọn phần tử đầu tiên trong danh sách của đối tượng cbxusbpath
                message_ra.Text = "Quét USB thành công!\r\n";

            }
            else
            {
                message_ra.Text = "Không có thiết bị nào được quét!\r\n";

            }
            ClearMessage.Enabled = true;
        }

        private async void Open_USB_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_reader.IsOpened)
                {
                    MessageBox.Show(this, "Máy đọc thẻ vẫn đang chạy, tắt máy nếu muốn mở lần nữa", this.Text);
                    return;
                }
                m_reader.Open((byte)cbxusbpath.SelectedIndex);     // Mở đường dẫn đã chọn

                Scan_USB.Enabled = false;
                Open_USB.Enabled = false;
                Close_USB.Enabled = true;

                ShowImage_Connect_RFID(path_image_conect_rfid);
                //await login_odoo(Static_API_path.url_server);
                message_ra.Text = "Kết nối máy đọc thẻ và đăng nhập thành công!\r\n";
                ClearMessage.Enabled = true;
            }
            catch (Exception ex)
            {
                try
                {
                    Reader reader = this.Reader;
                    if (reader.IsOpened)
                        reader.Close();
                }
                catch { }
                message_handle('7', null, ex.Message);
                ShowImage_Connect_RFID(path_image_disconnect_rfid);
            }
            InitReader();
        }

        private void Close_USB_Click(object sender, EventArgs e)
        {
            try
            {
                Scan_USB.Enabled = true;
                Open_USB.Enabled = true;
                Close_USB.Enabled = false;


                Reader reader = this.Reader;
                if (reader == null)
                    return;
                reader.Close();
                ShowImage_Connect_RFID(path_image_disconnect_rfid);
                message_ra.Text = "Đóng kết nối máy đọc thẻ thành công!\r\n";
                ClearMessage.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text);
            }
        }

        private async void Luu_Ng_New_Click(object sender, EventArgs e)
        {
            Start_invetory();
            Stop_inventory();

            if (tbEPC_Ng.Text == "" || tbName.Text == "" || tbSDT.Text == "")
            {
                message_ra.Text = "Lưu thất bại!! Thông tin không được trống!!";
                ClearMessage.Enabled = true;
                tbEPC_Ng.Text = null;
                tbEPC_Xe.Text = null;
                return;
            }

            //API gửi thông tin của người lên hệ thống gồm Tên, sđt, EPC của người
            await save_Ng(Static_API_path.url_server + Static_API_path.api_save_Ng);

            tbName.Text = null;
            tbSDT.Text = null;
            tbEPC_Xe.Text = null;
            tbEPC_Ng.Text = null;
            message_ra.Text = "Lưu thành công";
            ClearMessage.Enabled = true;
            initThread(1);
            initThread(0);
        }

        private async void Luu_Xe_New_Click(object sender, EventArgs e)
        {
            Start_invetory();
            Stop_inventory();

            if (tbEPC_Xe.Text == "" || tb_Bienso.Text == "")
            {
                message_ra.Text = "Lưu thất bại!! Thông tin không được trống!!";
                ClearMessage.Enabled = true;
                tbEPC_Ng.Text = null;
                tbEPC_Xe.Text = null;
                return;
            }
            //API gửi thông tin của xe lên hệ thống gồm tên người, biển số , EPC của xe
            await save_Xe(Static_API_path.url_server + Static_API_path.api_save_Xe);

            tbEPC_Xe.Text = null;
            tbEPC_Ng.Text = null;
            tb_Bienso.Text = null;
            message_ra.Text = "Lưu thành công";
            ClearMessage.Enabled = true;
            initThread(2);
            initThread(0);
        }

        private void Start_invetory()
        {
            try
            {
                Reader reader = this.Reader;
                if (reader == null)
                    throw new Exception("Máy đọc không kết nối được");

                if (cmbWorkmode.SelectedIndex == 0)
                {
                    devicepara.Workmode = (byte)cmbWorkmode.SelectedIndex;
                    reader.SetDevicePara(devicepara);

                    InInventory = true;
                    StopInventory = false;

                    System.Threading.Thread.Sleep(100);
                    reader.Inventory(0, 0);
                    initThread(3);

                }
                else
                {
                    devicepara.Workmode = (byte)cmbWorkmode.SelectedIndex;
                    reader.SetDevicePara(devicepara);

                    InInventory = true;
                    StopInventory = false;

                    initThread(3);
                }

            }
            catch (Exception ex)
            {
                InInventory = false;
                StopInventory = true;
                message_handle('1', null, ex.Message);
            }
        }

        private void Stop_inventory()
        {
            try
            {
                Reader reader = this.Reader;
                if (reader == null)
                    throw new Exception("Máy đọc không kết nối được");

                if (InInventory)
                {
                    StopInventory = true;
                    InInventory = false;
                    CloseInventoryThread();
                    if (devicepara.Workmode == 0)
                    {
                        reader.InventoryStop(s_usStopInventoryTimeout);
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                message_handle('2', null, ex.Message);
            }
        }

        private void InitReader()
        {
            try
            {
                Reader reader = this.Reader;
                if (reader.IsOpened)
                {

                    devicepara = reader.GetDevicePara();
                    devicepara.Power.ToString();
                    if (devicepara.Workmode > 1)
                    {
                        cmbWorkmode.SelectedIndex = 0;//answer mode
                    }
                    else
                    {
                        cmbWorkmode.SelectedIndex = devicepara.Workmode; // active mode
                    }
                }
            }
            catch (Exception ex)
            {
                message_handle('3', null, ex.Message);
                return;
            }
        }

        private void InventoryThread()
        {
            try
            {
                Reader reader = this.Reader;
                if (reader == null)
                {
                    DoStopInventory();
                    return;
                }
                TagItem item;             //Biến nhận dữ liệu thẻ

                item = reader.GetTagUii(1000);

                if (item == null)
                {
                    return;
                }

                ShowTagItem sitem;
                sitem = new ShowTagItem(item);

                tbEPC_Ng.Text = Util.HexArrayToString(sitem.Code);

                tbEPC_Xe.Text = Util.HexArrayToString(sitem.Code);

                if (tbEPC_Ng.Text != null || tbEPC_Xe.Text != null)
                {
                    message_ra.Text = "Quét thẻ thành công!\r\n";
                    ClearMessage.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                try
                {
                    message_handle('4', null, ex.Message);
                }
                catch { }
                DoStopInventory();
            }
        }

        private void ShowImage_Connect_RFID(string fileToDisplay)
        {
            if (image_connect_rfid != null)
            {
                image_connect_rfid.Dispose();
            }
            Connect_RFID.SizeMode = PictureBoxSizeMode.Zoom;
            image_connect_rfid = new Bitmap(fileToDisplay);
            Connect_RFID.Image = (System.Drawing.Image)image_connect_rfid;
        }

        private void ShowImage_internet_connect(string fileToDisplay)
        {
            if (image_connect_internet != null)
            {
                image_connect_internet.Dispose();
            }
            Invoke(new Action(() =>
            {
                Connect_internet.SizeMode = PictureBoxSizeMode.Zoom;
                image_connect_internet = new Bitmap(fileToDisplay);
                Connect_internet.Image = (System.Drawing.Image)image_connect_internet;
            }));

        }

        private void threadCheckConnect()
        {
            bool check_update_con = true;
            bool check_update_dis = true;

            while (true)
            {
                if (!IsConnectedToInternet())
                {
                    if (check_update_dis)
                        ShowImage_internet_connect(path_image_disconnect_internet);
                    check_update_dis = false;
                    check_update_con = true;
                }
                else
                {
                    if (check_update_con)
                        ShowImage_internet_connect(path_image_conect_internet);
                    check_update_dis = true;
                    check_update_con = false;
                }
                Thread.Sleep(3000);
            }
        }

        public static bool IsConnectedToInternet()
        {
            bool result = false;
            string host = "nsp.t4tek.tk";
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
        }

        private async void update_DS()
        {
            Task<Json_stock_lot> DTOs = get_all_stock_lot_api_odoo(Static_API_path.url_server + Static_API_path.api_get_all_stock_lot);
            await DTOs;
            Task<json_product> DTO_Ng = get_all_prodcut_api_odoo(Static_API_path.url_server + Static_API_path.api_get_all_product);
            await DTO_Ng;
            Invoke(new Action(() =>
            {
                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();
                int dem_nguoi = 0; //số thứ tự cho từng node0
                //chạy từng người trong danh sách
                foreach (stock_product_DTO stock_product in DTO_Ng.Result.result)
                {
                    TreeNode Node = new TreeNode();
                    Node.Text = stock_product.name;
                    treeView1.Nodes.Add(Node);
                    //node1 cho từng người
                    for (int i = 0; i < 1; i++)
                    {
                        TreeNode subnode = new TreeNode();
                        subnode.Text = stock_product.ma_dinh_danh;
                        treeView1.Nodes[dem_nguoi].Nodes.Add(subnode);
                        TreeNode subnode1 = new TreeNode();
                        subnode1.Text = "Xe";
                        treeView1.Nodes[dem_nguoi].Nodes.Add(subnode1);
                        //Tim xe cua 1 nguoi
                        int dem_xe = 0;
                        foreach (Stock_lot_DTO stock_lot in DTOs.Result.result)
                        {
                            if (stock_lot.product_id[1].ToString() == stock_product.name)
                            {
                                TreeNode subnode11 = new TreeNode();
                                subnode11.Text = stock_lot.bien_so;
                                treeView1.Nodes[dem_nguoi].Nodes[1].Nodes.Add(subnode11);
                                //Thông tin từng xe
                                TreeNode subnode111 = new TreeNode();
                                subnode111.Text = stock_lot.name;
                                treeView1.Nodes[dem_nguoi].Nodes[1].Nodes[dem_xe].Nodes.Add(subnode111);
                                TreeNode subnode112 = new TreeNode();
                                subnode112.Text = stock_lot.location_id[1].ToString();
                                treeView1.Nodes[dem_nguoi].Nodes[1].Nodes[dem_xe].Nodes.Add(subnode112);
                                TreeNode subnode113 = new TreeNode();
                                subnode113.Text = stock_lot.state;
                                treeView1.Nodes[dem_nguoi].Nodes[1].Nodes[dem_xe].Nodes.Add(subnode113);
                                //Tăng xe lên
                                dem_xe++;
                            }
                        }
                    }
                    dem_nguoi++;
                }
                treeView1.EndUpdate();
            }));
        }

        private async void update_DS_Ng()
        {
            Task<json_product> DTOs = get_all_prodcut_api_odoo(Static_API_path.url_server + Static_API_path.api_get_all_product);
            await DTOs;
            Invoke(new Action(() =>
            {
                listView1.BeginUpdate();
                listView1.Items.Clear();
                cbx_Ng.Items.Clear();
                foreach (stock_product_DTO stock_product in DTOs.Result.result)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { stock_product.id.ToString(), stock_product.name,stock_product.sdt,
                    stock_product.ma_dinh_danh}));
                    cbx_Ng.Items.Add(stock_product.id.ToString() + "." + stock_product.name);
                }
                listView1.EndUpdate();

            }));
        }

        private async void update_DS_Xe()
        {
            Task<Json_stock_lot> DTOs = get_all_stock_lot_api_odoo(Static_API_path.url_server + Static_API_path.api_get_all_stock_lot);
            await DTOs;
            Invoke(new Action(() =>
            {
                listView2.BeginUpdate();
                listView2.Items.Clear();
                foreach (Stock_lot_DTO stock_lot in DTOs.Result.result)
                {
                    listView2.Items.Add(new ListViewItem(new string[] { stock_lot.id.ToString(), stock_lot.name,stock_lot.bien_so,
                        stock_lot.product_id[1].ToString(),stock_lot.location_id[1].ToString(),stock_lot.state}));
                }
                listView2.EndUpdate();

            }));
        }

        async Task<Json_stock_lot> get_all_stock_lot_api_odoo(string url_server)
        {
            try
            {
                Json_stock_lot DTO_list = null;
                //Consume web api using HTTPClient class.
                var request = new HttpRequestMessage(HttpMethod.Post, url_server)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                try
                {
                    isFull = response.Content.ReadAsStringAsync().Result;
                    DTO_list = JsonConvert.DeserializeObject<Json_stock_lot>(isFull);
                    return DTO_list;
                }
                catch
                {
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                message_handle('6', null, e.Message);
                return null;
            }
        }

        async Task<json_product> get_all_prodcut_api_odoo(string url_server)
        {
            try
            {
                json_product DTO_list = null;
                //Consume web api using HTTPClient class.
                var request = new HttpRequestMessage(HttpMethod.Post, url_server)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                try
                {
                    isFull = response.Content.ReadAsStringAsync().Result;
                    DTO_list = JsonConvert.DeserializeObject<json_product>(isFull);
                    return DTO_list;
                }
                catch
                {
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                message_handle('6', null, e.Message);
                return null;
            }
        }

        private void message_handle(char message_mode, string sEPC, string excep_message)
        {
            Invoke(new Action(() =>
            {
                switch (message_mode)
                {
                    case '1':
                        message_ra.Text = "Khởi động quét thẻ thất bại!\r\n";
                        break;
                    case '2':
                        message_ra.Text = "Tắt quét thẻ thất bại!\r\n";
                        break;
                    case '3':
                        message_ra.Text = "Lỗi khi cài đặt thông số cho máy!";
                        break;
                    case '4':
                        message_ra.Text = "Bạn chưa đặt thẻ lên máy!\r\n";
                        break;
                    case '5':
                        message_ra.Text = "Đăng nhập thất bại!\r\n";
                        break;
                    case '6':
                        message_ra.Text = "Exception Caught!\r\n";
                        message_ra.Text = "Message :{0} " + excep_message + "\r\n";
                        break;
                    case '7':
                        message_ra.Text = "Kết nối máy đọc thẻ thất bại!\r\n";
                        break;
                    default: break;
                }
                ClearMessage.Enabled = true;
            }));
        }

        async Task save_Ng(string url_server)
        {
            try
            {
                tbEPC_Ng.Text = tbEPC_Ng.Text.Replace(" ", "");

                var request = new HttpRequestMessage(HttpMethod.Post, url_server)
                {
                    Content = new StringContent("{\"params\":" + JsonConvert.SerializeObject(new Params_product(tbEPC_Ng.Text, tbName.Text, tbSDT.Text)) + "}", Encoding.UTF8, "application/json")
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                message_handle('5', null, e.Message);
            }
        }

        async Task save_Xe(string url_server)
        {
            try
            {
                tbEPC_Xe.Text = tbEPC_Xe.Text.Replace(" ", "");
                int i = Int32.Parse(cbx_Ng.Text.Split('.')[0]);
                var request = new HttpRequestMessage(HttpMethod.Post, url_server)
                {
                    Content = new StringContent("{\"params\":" + JsonConvert.SerializeObject(new Params_lot(tbEPC_Xe.Text, tb_Bienso.Text, i)) + "}", Encoding.UTF8, "application/json")
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                message_handle('5', null, e.Message);
            }
        }

        private void ClearMessage_Tick(object sender, EventArgs e)
        {
            message_ra.Text = "";
            ClearMessage.Enabled = false;
        }

        async Task login_odoo(string url_server)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url_server + "/web/session/authenticate")
                {
                    Content = new StringContent("{\"params\":" + JsonConvert.SerializeObject(new param_login("HuyHVD", "123456aA@", "nsp.t4tek.tk")) + "}", Encoding.UTF8, "application/json")
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

    }

}
