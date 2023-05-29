
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_HocPhan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_MaHP = new System.Windows.Forms.TextBox();
            this.tB_TenHP = new System.Windows.Forms.TextBox();
            this.tB_STC = new System.Windows.Forms.TextBox();
            this.cB_Khoa = new System.Windows.Forms.ComboBox();
            this.cB_Phong = new System.Windows.Forms.ComboBox();
            this.cB_CTDT = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tín chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa - Bộ môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chương trình đào tạo";
            // 
            // tB_MaHP
            // 
            this.tB_MaHP.Location = new System.Drawing.Point(126, 26);
            this.tB_MaHP.Name = "tB_MaHP";
            this.tB_MaHP.Size = new System.Drawing.Size(326, 26);
            this.tB_MaHP.TabIndex = 1;
            // 
            // tB_TenHP
            // 
            this.tB_TenHP.Location = new System.Drawing.Point(126, 67);
            this.tB_TenHP.Name = "tB_TenHP";
            this.tB_TenHP.Size = new System.Drawing.Size(326, 26);
            this.tB_TenHP.TabIndex = 1;
            // 
            // tB_STC
            // 
            this.tB_STC.Location = new System.Drawing.Point(126, 116);
            this.tB_STC.Name = "tB_STC";
            this.tB_STC.Size = new System.Drawing.Size(326, 26);
            this.tB_STC.TabIndex = 1;
            // 
            // cB_Khoa
            // 
            this.cB_Khoa.FormattingEnabled = true;
            this.cB_Khoa.Location = new System.Drawing.Point(669, 26);
            this.cB_Khoa.Name = "cB_Khoa";
            this.cB_Khoa.Size = new System.Drawing.Size(292, 28);
            this.cB_Khoa.TabIndex = 2;
            // 
            // cB_Phong
            // 
            this.cB_Phong.FormattingEnabled = true;
            this.cB_Phong.Location = new System.Drawing.Point(669, 71);
            this.cB_Phong.Name = "cB_Phong";
            this.cB_Phong.Size = new System.Drawing.Size(292, 28);
            this.cB_Phong.TabIndex = 2;
            // 
            // cB_CTDT
            // 
            this.cB_CTDT.FormattingEnabled = true;
            this.cB_CTDT.Location = new System.Drawing.Point(669, 115);
            this.cB_CTDT.Name = "cB_CTDT";
            this.cB_CTDT.Size = new System.Drawing.Size(292, 28);
            this.cB_CTDT.TabIndex = 2;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Luu.Location = new System.Drawing.Point(507, 193);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(169, 49);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Thoat.Location = new System.Drawing.Point(792, 193);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(169, 49);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form_HocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 302);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cB_CTDT);
            this.Controls.Add(this.cB_Phong);
            this.Controls.Add(this.cB_Khoa);
            this.Controls.Add(this.tB_STC);
            this.Controls.Add(this.tB_TenHP);
            this.Controls.Add(this.tB_MaHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_HocPhan";
            this.Text = "Học phần";
            this.Load += new System.EventHandler(this.Form_HocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_MaHP;
        private System.Windows.Forms.TextBox tB_TenHP;
        private System.Windows.Forms.TextBox tB_STC;
        private System.Windows.Forms.ComboBox cB_Khoa;
        private System.Windows.Forms.ComboBox cB_Phong;
        private System.Windows.Forms.ComboBox cB_CTDT;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
    }
}