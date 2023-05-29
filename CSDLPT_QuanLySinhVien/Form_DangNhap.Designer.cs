
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_DangNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_Khoa = new System.Windows.Forms.ComboBox();
            this.tBMatKhau = new System.Windows.Forms.TextBox();
            this.tBTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(432, 221);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(180, 221);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(141, 45);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cB_Khoa);
            this.panel1.Controls.Add(this.tBMatKhau);
            this.panel1.Controls.Add(this.tBTaiKhoan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 158);
            this.panel1.TabIndex = 4;
            // 
            // cB_Khoa
            // 
            this.cB_Khoa.FormattingEnabled = true;
            this.cB_Khoa.Location = new System.Drawing.Point(128, 22);
            this.cB_Khoa.Name = "cB_Khoa";
            this.cB_Khoa.Size = new System.Drawing.Size(390, 28);
            this.cB_Khoa.TabIndex = 2;
            this.cB_Khoa.SelectedIndexChanged += new System.EventHandler(this.cB_Khoa_SelectedIndexChanged);
            // 
            // tBMatKhau
            // 
            this.tBMatKhau.Location = new System.Drawing.Point(125, 112);
            this.tBMatKhau.Name = "tBMatKhau";
            this.tBMatKhau.PasswordChar = '*';
            this.tBMatKhau.Size = new System.Drawing.Size(393, 26);
            this.tBMatKhau.TabIndex = 1;
            // 
            // tBTaiKhoan
            // 
            this.tBTaiKhoan.Location = new System.Drawing.Point(125, 70);
            this.tBTaiKhoan.Name = "tBTaiKhoan";
            this.tBTaiKhoan.Size = new System.Drawing.Size(393, 26);
            this.tBTaiKhoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 324);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DangNhap";
            this.Text = "Form_DangNhap";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_DangNhap_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cB_Khoa;
        private System.Windows.Forms.TextBox tBMatKhau;
        private System.Windows.Forms.TextBox tBTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}