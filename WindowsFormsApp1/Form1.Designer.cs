namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Danhsach = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Danhsach_Ng = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt_Ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EPC_Ng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Danhsach_Xe = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID_Xe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EPC_Xe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bienso_Xe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten_Nguoi_Xe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tao_Ng = new System.Windows.Forms.TabPage();
            this.Creat_Ng = new System.Windows.Forms.GroupBox();
            this.Luu_Ng_New = new System.Windows.Forms.Button();
            this.tbEPC_Ng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tao_Xe = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Ng = new System.Windows.Forms.ComboBox();
            this.Luu_Xe_New = new System.Windows.Forms.Button();
            this.tbEPC_Xe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Bienso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cai_dat = new System.Windows.Forms.TabPage();
            this.cmbWorkmode = new System.Windows.Forms.ComboBox();
            this.USB_Connect = new System.Windows.Forms.GroupBox();
            this.Close_USB = new System.Windows.Forms.Button();
            this.Open_USB = new System.Windows.Forms.Button();
            this.Scan_USB = new System.Windows.Forms.Button();
            this.cbxusbpath = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect_RFID = new System.Windows.Forms.PictureBox();
            this.Connect_internet = new System.Windows.Forms.PictureBox();
            this.message_ra = new System.Windows.Forms.Label();
            this.ClearMessage = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Danhsach.SuspendLayout();
            this.Danhsach_Ng.SuspendLayout();
            this.Danhsach_Xe.SuspendLayout();
            this.Tao_Ng.SuspendLayout();
            this.Creat_Ng.SuspendLayout();
            this.Tao_Xe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Cai_dat.SuspendLayout();
            this.USB_Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Connect_RFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Connect_internet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Danhsach);
            this.tabControl1.Controls.Add(this.Danhsach_Ng);
            this.tabControl1.Controls.Add(this.Danhsach_Xe);
            this.tabControl1.Controls.Add(this.Tao_Ng);
            this.tabControl1.Controls.Add(this.Tao_Xe);
            this.tabControl1.Controls.Add(this.Cai_dat);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // Danhsach
            // 
            this.Danhsach.Controls.Add(this.treeView1);
            this.Danhsach.Location = new System.Drawing.Point(4, 22);
            this.Danhsach.Name = "Danhsach";
            this.Danhsach.Padding = new System.Windows.Forms.Padding(3);
            this.Danhsach.Size = new System.Drawing.Size(801, 372);
            this.Danhsach.TabIndex = 0;
            this.Danhsach.Text = "Danh sách";
            this.Danhsach.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(795, 366);
            this.treeView1.TabIndex = 0;
            // 
            // Danhsach_Ng
            // 
            this.Danhsach_Ng.Controls.Add(this.listView1);
            this.Danhsach_Ng.Location = new System.Drawing.Point(4, 22);
            this.Danhsach_Ng.Name = "Danhsach_Ng";
            this.Danhsach_Ng.Padding = new System.Windows.Forms.Padding(3);
            this.Danhsach_Ng.Size = new System.Drawing.Size(801, 372);
            this.Danhsach_Ng.TabIndex = 1;
            this.Danhsach_Ng.Text = "Danh sách người";
            this.Danhsach_Ng.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Ng,
            this.Name_Ng,
            this.sdt_Ng,
            this.EPC_Ng});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(795, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_Ng
            // 
            this.ID_Ng.Text = "ID";
            // 
            // Name_Ng
            // 
            this.Name_Ng.Text = "Họ và tên";
            this.Name_Ng.Width = 93;
            // 
            // sdt_Ng
            // 
            this.sdt_Ng.Text = "Số điện thoại";
            this.sdt_Ng.Width = 115;
            // 
            // EPC_Ng
            // 
            this.EPC_Ng.Text = "Mã định danh";
            this.EPC_Ng.Width = 176;
            // 
            // Danhsach_Xe
            // 
            this.Danhsach_Xe.Controls.Add(this.listView2);
            this.Danhsach_Xe.Location = new System.Drawing.Point(4, 22);
            this.Danhsach_Xe.Name = "Danhsach_Xe";
            this.Danhsach_Xe.Size = new System.Drawing.Size(801, 372);
            this.Danhsach_Xe.TabIndex = 2;
            this.Danhsach_Xe.Text = "Danh sách xe";
            this.Danhsach_Xe.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Xe,
            this.EPC_Xe,
            this.Bienso_Xe,
            this.Ten_Nguoi_Xe,
            this.Location,
            this.State});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(801, 372);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID_Xe
            // 
            this.ID_Xe.Text = "ID";
            // 
            // EPC_Xe
            // 
            this.EPC_Xe.DisplayIndex = 3;
            this.EPC_Xe.Text = "Mã định danh";
            this.EPC_Xe.Width = 213;
            // 
            // Bienso_Xe
            // 
            this.Bienso_Xe.DisplayIndex = 1;
            this.Bienso_Xe.Text = "Biển số xe";
            this.Bienso_Xe.Width = 105;
            // 
            // Ten_Nguoi_Xe
            // 
            this.Ten_Nguoi_Xe.DisplayIndex = 2;
            this.Ten_Nguoi_Xe.Text = "Chủ sở hữu";
            this.Ten_Nguoi_Xe.Width = 120;
            // 
            // Location
            // 
            this.Location.Text = "Vị trí";
            // 
            // State
            // 
            this.State.Text = "Trạng thái";
            // 
            // Tao_Ng
            // 
            this.Tao_Ng.Controls.Add(this.Creat_Ng);
            this.Tao_Ng.Controls.Add(this.label2);
            this.Tao_Ng.Location = new System.Drawing.Point(4, 22);
            this.Tao_Ng.Name = "Tao_Ng";
            this.Tao_Ng.Size = new System.Drawing.Size(801, 372);
            this.Tao_Ng.TabIndex = 3;
            this.Tao_Ng.Text = "Tạo người mới";
            this.Tao_Ng.UseVisualStyleBackColor = true;
            // 
            // Creat_Ng
            // 
            this.Creat_Ng.Controls.Add(this.Luu_Ng_New);
            this.Creat_Ng.Controls.Add(this.tbEPC_Ng);
            this.Creat_Ng.Controls.Add(this.label6);
            this.Creat_Ng.Controls.Add(this.tbSDT);
            this.Creat_Ng.Controls.Add(this.label4);
            this.Creat_Ng.Controls.Add(this.tbName);
            this.Creat_Ng.Controls.Add(this.label3);
            this.Creat_Ng.Location = new System.Drawing.Point(0, 45);
            this.Creat_Ng.Name = "Creat_Ng";
            this.Creat_Ng.Size = new System.Drawing.Size(792, 139);
            this.Creat_Ng.TabIndex = 1;
            this.Creat_Ng.TabStop = false;
            this.Creat_Ng.Text = "Người mới";
            // 
            // Luu_Ng_New
            // 
            this.Luu_Ng_New.Location = new System.Drawing.Point(709, 105);
            this.Luu_Ng_New.Name = "Luu_Ng_New";
            this.Luu_Ng_New.Size = new System.Drawing.Size(75, 23);
            this.Luu_Ng_New.TabIndex = 6;
            this.Luu_Ng_New.Text = "Lưu";
            this.Luu_Ng_New.UseVisualStyleBackColor = true;
            this.Luu_Ng_New.Click += new System.EventHandler(this.Luu_Ng_New_Click);
            // 
            // tbEPC_Ng
            // 
            this.tbEPC_Ng.Location = new System.Drawing.Point(102, 79);
            this.tbEPC_Ng.Name = "tbEPC_Ng";
            this.tbEPC_Ng.Size = new System.Drawing.Size(682, 20);
            this.tbEPC_Ng.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã định danh";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(102, 53);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(682, 20);
            this.tbSDT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(682, 20);
            this.tbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đăng kí cho người mới";
            // 
            // Tao_Xe
            // 
            this.Tao_Xe.Controls.Add(this.groupBox1);
            this.Tao_Xe.Controls.Add(this.label9);
            this.Tao_Xe.Location = new System.Drawing.Point(4, 22);
            this.Tao_Xe.Name = "Tao_Xe";
            this.Tao_Xe.Size = new System.Drawing.Size(801, 372);
            this.Tao_Xe.TabIndex = 5;
            this.Tao_Xe.Text = "Tạo xe mới";
            this.Tao_Xe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Ng);
            this.groupBox1.Controls.Add(this.Luu_Xe_New);
            this.groupBox1.Controls.Add(this.tbEPC_Xe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Bienso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(-1, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xe mới";
            // 
            // cbx_Ng
            // 
            this.cbx_Ng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Ng.FormattingEnabled = true;
            this.cbx_Ng.Location = new System.Drawing.Point(102, 22);
            this.cbx_Ng.Name = "cbx_Ng";
            this.cbx_Ng.Size = new System.Drawing.Size(682, 21);
            this.cbx_Ng.TabIndex = 7;
            // 
            // Luu_Xe_New
            // 
            this.Luu_Xe_New.Location = new System.Drawing.Point(709, 105);
            this.Luu_Xe_New.Name = "Luu_Xe_New";
            this.Luu_Xe_New.Size = new System.Drawing.Size(75, 23);
            this.Luu_Xe_New.TabIndex = 6;
            this.Luu_Xe_New.Text = "Lưu";
            this.Luu_Xe_New.UseVisualStyleBackColor = true;
            this.Luu_Xe_New.Click += new System.EventHandler(this.Luu_Xe_New_Click);
            // 
            // tbEPC_Xe
            // 
            this.tbEPC_Xe.Location = new System.Drawing.Point(102, 79);
            this.tbEPC_Xe.Name = "tbEPC_Xe";
            this.tbEPC_Xe.Size = new System.Drawing.Size(682, 20);
            this.tbEPC_Xe.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã định danh";
            // 
            // tb_Bienso
            // 
            this.tb_Bienso.Location = new System.Drawing.Point(102, 53);
            this.tb_Bienso.Name = "tb_Bienso";
            this.tb_Bienso.Size = new System.Drawing.Size(682, 20);
            this.tb_Bienso.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Biển số xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ và tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 42);
            this.label9.TabIndex = 2;
            this.label9.Text = "Đăng kí xe";
            // 
            // Cai_dat
            // 
            this.Cai_dat.Controls.Add(this.cmbWorkmode);
            this.Cai_dat.Controls.Add(this.USB_Connect);
            this.Cai_dat.Location = new System.Drawing.Point(4, 22);
            this.Cai_dat.Name = "Cai_dat";
            this.Cai_dat.Padding = new System.Windows.Forms.Padding(3);
            this.Cai_dat.Size = new System.Drawing.Size(801, 372);
            this.Cai_dat.TabIndex = 4;
            this.Cai_dat.Text = "Cài đặt";
            this.Cai_dat.UseVisualStyleBackColor = true;
            // 
            // cmbWorkmode
            // 
            this.cmbWorkmode.FormattingEnabled = true;
            this.cmbWorkmode.Items.AddRange(new object[] {
            "AnswerMode",
            "ActiveMode"});
            this.cmbWorkmode.Location = new System.Drawing.Point(281, 20);
            this.cmbWorkmode.Name = "cmbWorkmode";
            this.cmbWorkmode.Size = new System.Drawing.Size(121, 21);
            this.cmbWorkmode.TabIndex = 3;
            // 
            // USB_Connect
            // 
            this.USB_Connect.Controls.Add(this.Close_USB);
            this.USB_Connect.Controls.Add(this.Open_USB);
            this.USB_Connect.Controls.Add(this.Scan_USB);
            this.USB_Connect.Controls.Add(this.cbxusbpath);
            this.USB_Connect.Controls.Add(this.label1);
            this.USB_Connect.Location = new System.Drawing.Point(0, 0);
            this.USB_Connect.Name = "USB_Connect";
            this.USB_Connect.Size = new System.Drawing.Size(213, 145);
            this.USB_Connect.TabIndex = 0;
            this.USB_Connect.TabStop = false;
            this.USB_Connect.Text = "USB Connet";
            // 
            // Close_USB
            // 
            this.Close_USB.Location = new System.Drawing.Point(118, 102);
            this.Close_USB.Name = "Close_USB";
            this.Close_USB.Size = new System.Drawing.Size(75, 23);
            this.Close_USB.TabIndex = 4;
            this.Close_USB.Text = "Close";
            this.Close_USB.UseVisualStyleBackColor = true;
            this.Close_USB.Click += new System.EventHandler(this.Close_USB_Click);
            // 
            // Open_USB
            // 
            this.Open_USB.Location = new System.Drawing.Point(12, 102);
            this.Open_USB.Name = "Open_USB";
            this.Open_USB.Size = new System.Drawing.Size(75, 23);
            this.Open_USB.TabIndex = 3;
            this.Open_USB.Text = "Open";
            this.Open_USB.UseVisualStyleBackColor = true;
            this.Open_USB.Click += new System.EventHandler(this.Open_USB_Click);
            // 
            // Scan_USB
            // 
            this.Scan_USB.Location = new System.Drawing.Point(12, 64);
            this.Scan_USB.Name = "Scan_USB";
            this.Scan_USB.Size = new System.Drawing.Size(75, 23);
            this.Scan_USB.TabIndex = 2;
            this.Scan_USB.Text = "Scan USB";
            this.Scan_USB.UseVisualStyleBackColor = true;
            this.Scan_USB.Click += new System.EventHandler(this.Scan_USB_Click);
            // 
            // cbxusbpath
            // 
            this.cbxusbpath.FormattingEnabled = true;
            this.cbxusbpath.Location = new System.Drawing.Point(60, 26);
            this.cbxusbpath.Name = "cbxusbpath";
            this.cbxusbpath.Size = new System.Drawing.Size(133, 21);
            this.cbxusbpath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USB";
            // 
            // Connect_RFID
            // 
            this.Connect_RFID.Location = new System.Drawing.Point(4, 405);
            this.Connect_RFID.Name = "Connect_RFID";
            this.Connect_RFID.Size = new System.Drawing.Size(53, 43);
            this.Connect_RFID.TabIndex = 1;
            this.Connect_RFID.TabStop = false;
            // 
            // Connect_internet
            // 
            this.Connect_internet.Location = new System.Drawing.Point(64, 405);
            this.Connect_internet.Name = "Connect_internet";
            this.Connect_internet.Size = new System.Drawing.Size(53, 43);
            this.Connect_internet.TabIndex = 2;
            this.Connect_internet.TabStop = false;
            // 
            // message_ra
            // 
            this.message_ra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.message_ra.BackColor = System.Drawing.Color.White;
            this.message_ra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message_ra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_ra.Location = new System.Drawing.Point(140, 405);
            this.message_ra.Name = "message_ra";
            this.message_ra.Size = new System.Drawing.Size(665, 43);
            this.message_ra.TabIndex = 7;
            this.message_ra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearMessage
            // 
            this.ClearMessage.Interval = 2000;
            this.ClearMessage.Tick += new System.EventHandler(this.ClearMessage_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.message_ra);
            this.Controls.Add(this.Connect_internet);
            this.Controls.Add(this.Connect_RFID);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Danhsach.ResumeLayout(false);
            this.Danhsach_Ng.ResumeLayout(false);
            this.Danhsach_Xe.ResumeLayout(false);
            this.Tao_Ng.ResumeLayout(false);
            this.Tao_Ng.PerformLayout();
            this.Creat_Ng.ResumeLayout(false);
            this.Creat_Ng.PerformLayout();
            this.Tao_Xe.ResumeLayout(false);
            this.Tao_Xe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Cai_dat.ResumeLayout(false);
            this.USB_Connect.ResumeLayout(false);
            this.USB_Connect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Connect_RFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Connect_internet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Danhsach;
        private System.Windows.Forms.TabPage Danhsach_Ng;
        private System.Windows.Forms.TabPage Danhsach_Xe;
        private System.Windows.Forms.TabPage Tao_Ng;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_Ng;
        private System.Windows.Forms.ColumnHeader Name_Ng;
        private System.Windows.Forms.ColumnHeader sdt_Ng;
        private System.Windows.Forms.ColumnHeader EPC_Ng;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ID_Xe;
        private System.Windows.Forms.ColumnHeader Bienso_Xe;
        private System.Windows.Forms.ColumnHeader Ten_Nguoi_Xe;
        private System.Windows.Forms.ColumnHeader EPC_Xe;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage Cai_dat;
        private System.Windows.Forms.GroupBox USB_Connect;
        private System.Windows.Forms.Button Scan_USB;
        private System.Windows.Forms.ComboBox cbxusbpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_USB;
        private System.Windows.Forms.Button Open_USB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Creat_Ng;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEPC_Ng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Luu_Ng_New;
        private System.Windows.Forms.TabPage Tao_Xe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Luu_Xe_New;
        private System.Windows.Forms.TextBox tbEPC_Xe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Bienso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_Ng;
        private System.Windows.Forms.ComboBox cmbWorkmode;
        private System.Windows.Forms.PictureBox Connect_RFID;
        private System.Windows.Forms.PictureBox Connect_internet;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.Label message_ra;
        private System.Windows.Forms.Timer ClearMessage;
    }
}

