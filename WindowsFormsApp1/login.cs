using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        static readonly HttpClientHandler handler = new HttpClientHandler();
        static readonly HttpClient client = new HttpClient(handler);
        private async void Dang_Nhap_Click(object sender, EventArgs e)
        {
            try
            {
                
                string tk = tbTK.Text;
                string mk = tbMK.Text;
                if (tk == "")
                {
                    MessageBox.Show("Chưa đăng nhập Tài khoản");
                    return;
                }
                if (mk == "")
                {
                    MessageBox.Show("Chưa đăng nhập Mật khẩu");
                    return;
                }
                await login_odoo(Static_API_path.url_server, tk, mk);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            catch 
            {
                MessageBox.Show("Lỗi kết nối");
            }
        
        }

        async Task login_odoo(string url_server, string tk, string mk)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url_server + "/web/session/authenticate")
                {
                    Content = new StringContent("{\"params\":" + JsonConvert.SerializeObject(new param_login(tk, mk, "nsp.t4tek.tk")) + "}", Encoding.UTF8, "application/json")
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
