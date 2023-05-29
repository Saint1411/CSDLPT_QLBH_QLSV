
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_TaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TaoTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaoLogin = new System.Windows.Forms.Button();
            this.rB_ChuyenVien = new System.Windows.Forms.RadioButton();
            this.rB_User = new System.Windows.Forms.RadioButton();
            this.rB_GiangVien = new System.Windows.Forms.RadioButton();
            this.cB_UserName = new System.Windows.Forms.ComboBox();
            this.tB_Pass = new System.Windows.Forms.TextBox();
            this.tB_LoginName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaoLogin);
            this.groupBox1.Controls.Add(this.rB_ChuyenVien);
            this.groupBox1.Controls.Add(this.rB_User);
            this.groupBox1.Controls.Add(this.rB_GiangVien);
            this.groupBox1.Controls.Add(this.cB_UserName);
            this.groupBox1.Controls.Add(this.tB_Pass);
            this.groupBox1.Controls.Add(this.tB_LoginName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản";
            // 
            // btn_TaoLogin
            // 
            this.btn_TaoLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TaoLogin.ForeColor = System.Drawing.Color.White;
            this.btn_TaoLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoLogin.Image")));
            this.btn_TaoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoLogin.Location = new System.Drawing.Point(394, 338);
            this.btn_TaoLogin.Name = "btn_TaoLogin";
            this.btn_TaoLogin.Size = new System.Drawing.Size(153, 47);
            this.btn_TaoLogin.TabIndex = 4;
            this.btn_TaoLogin.Text = "Tạo tài khoản";
            this.btn_TaoLogin.UseVisualStyleBackColor = false;
            // 
            // rB_ChuyenVien
            // 
            this.rB_ChuyenVien.AutoSize = true;
            this.rB_ChuyenVien.Location = new System.Drawing.Point(310, 273);
            this.rB_ChuyenVien.Name = "rB_ChuyenVien";
            this.rB_ChuyenVien.Size = new System.Drawing.Size(120, 24);
            this.rB_ChuyenVien.TabIndex = 3;
            this.rB_ChuyenVien.TabStop = true;
            this.rB_ChuyenVien.Text = "Chuyên viên";
            this.rB_ChuyenVien.UseVisualStyleBackColor = true;
            // 
            // rB_User
            // 
            this.rB_User.AutoSize = true;
            this.rB_User.Location = new System.Drawing.Point(653, 271);
            this.rB_User.Name = "rB_User";
            this.rB_User.Size = new System.Drawing.Size(68, 24);
            this.rB_User.TabIndex = 3;
            this.rB_User.TabStop = true;
            this.rB_User.Text = "User";
            this.rB_User.UseVisualStyleBackColor = true;
            // 
            // rB_GiangVien
            // 
            this.rB_GiangVien.AutoSize = true;
            this.rB_GiangVien.Location = new System.Drawing.Point(487, 273);
            this.rB_GiangVien.Name = "rB_GiangVien";
            this.rB_GiangVien.Size = new System.Drawing.Size(109, 24);
            this.rB_GiangVien.TabIndex = 3;
            this.rB_GiangVien.TabStop = true;
            this.rB_GiangVien.Text = "Giảng viên";
            this.rB_GiangVien.UseVisualStyleBackColor = true;
            // 
            // cB_UserName
            // 
            this.cB_UserName.FormattingEnabled = true;
            this.cB_UserName.Location = new System.Drawing.Point(310, 217);
            this.cB_UserName.Name = "cB_UserName";
            this.cB_UserName.Size = new System.Drawing.Size(411, 28);
            this.cB_UserName.TabIndex = 2;
            // 
            // tB_Pass
            // 
            this.tB_Pass.Location = new System.Drawing.Point(310, 170);
            this.tB_Pass.Name = "tB_Pass";
            this.tB_Pass.Size = new System.Drawing.Size(411, 26);
            this.tB_Pass.TabIndex = 1;
            // 
            // tB_LoginName
            // 
            this.tB_LoginName.Location = new System.Drawing.Point(310, 125);
            this.tB_LoginName.Name = "tB_LoginName";
            this.tB_LoginName.Size = new System.Drawing.Size(411, 26);
            this.tB_LoginName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Login name";
            // 
            // Form_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 523);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_TaoTaiKhoan";
            this.Text = "Tạo tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TaoLogin;
        private System.Windows.Forms.RadioButton rB_ChuyenVien;
        private System.Windows.Forms.RadioButton rB_User;
        private System.Windows.Forms.RadioButton rB_GiangVien;
        private System.Windows.Forms.ComboBox cB_UserName;
        private System.Windows.Forms.TextBox tB_Pass;
        private System.Windows.Forms.TextBox tB_LoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}