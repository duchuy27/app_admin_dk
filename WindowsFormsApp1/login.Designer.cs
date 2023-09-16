namespace WindowsFormsApp1
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.Dang_Nhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(147, 26);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(174, 20);
            this.tbTK.TabIndex = 2;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(147, 54);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(174, 20);
            this.tbMK.TabIndex = 3;
            this.tbMK.UseSystemPasswordChar = true;
            // 
            // Dang_Nhap
            // 
            this.Dang_Nhap.Location = new System.Drawing.Point(246, 80);
            this.Dang_Nhap.Name = "Dang_Nhap";
            this.Dang_Nhap.Size = new System.Drawing.Size(75, 23);
            this.Dang_Nhap.TabIndex = 4;
            this.Dang_Nhap.Text = "Đăng nhập";
            this.Dang_Nhap.UseVisualStyleBackColor = true;
            this.Dang_Nhap.Click += new System.EventHandler(this.Dang_Nhap_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 133);
            this.Controls.Add(this.Dang_Nhap);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Button Dang_Nhap;
    }
}