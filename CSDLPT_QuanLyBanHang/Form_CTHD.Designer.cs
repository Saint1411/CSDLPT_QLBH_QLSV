
namespace CSDLPT_QuanLyBanHang
{
    partial class Form_CTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CTHD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_SoHD = new System.Windows.Forms.TextBox();
            this.cB_MaSP = new System.Windows.Forms.ComboBox();
            this.tB_DonGia = new System.Windows.Forms.TextBox();
            this.tB_SoLuong = new System.Windows.Forms.TextBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // tB_SoHD
            // 
            this.tB_SoHD.Location = new System.Drawing.Point(167, 35);
            this.tB_SoHD.Name = "tB_SoHD";
            this.tB_SoHD.Size = new System.Drawing.Size(321, 26);
            this.tB_SoHD.TabIndex = 1;
            // 
            // cB_MaSP
            // 
            this.cB_MaSP.FormattingEnabled = true;
            this.cB_MaSP.Location = new System.Drawing.Point(167, 84);
            this.cB_MaSP.Name = "cB_MaSP";
            this.cB_MaSP.Size = new System.Drawing.Size(321, 28);
            this.cB_MaSP.TabIndex = 2;
            // 
            // tB_DonGia
            // 
            this.tB_DonGia.Location = new System.Drawing.Point(167, 134);
            this.tB_DonGia.Name = "tB_DonGia";
            this.tB_DonGia.Size = new System.Drawing.Size(321, 26);
            this.tB_DonGia.TabIndex = 1;
            // 
            // tB_SoLuong
            // 
            this.tB_SoLuong.Location = new System.Drawing.Point(167, 181);
            this.tB_SoLuong.Name = "tB_SoLuong";
            this.tB_SoLuong.Size = new System.Drawing.Size(321, 26);
            this.tB_SoLuong.TabIndex = 1;
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_Luu.Image")));
            this.bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Luu.Location = new System.Drawing.Point(557, 55);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(101, 49);
            this.bt_Luu.TabIndex = 3;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.Color.Maroon;
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_Thoat.Image")));
            this.bt_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Thoat.Location = new System.Drawing.Point(557, 131);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(101, 50);
            this.bt_Thoat.TabIndex = 3;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // Form_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 264);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.cB_MaSP);
            this.Controls.Add(this.tB_SoLuong);
            this.Controls.Add(this.tB_DonGia);
            this.Controls.Add(this.tB_SoHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CTHD";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.Form_CTHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_SoHD;
        private System.Windows.Forms.ComboBox cB_MaSP;
        private System.Windows.Forms.TextBox tB_DonGia;
        private System.Windows.Forms.TextBox tB_SoLuong;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Thoat;
    }
}