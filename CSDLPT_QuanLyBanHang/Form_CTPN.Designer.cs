
namespace CSDLPT_QuanLyBanHang
{
    partial class Form_CTPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CTPN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_TenSP = new System.Windows.Forms.ComboBox();
            this.tB_MaPN = new System.Windows.Forms.TextBox();
            this.tB_SL = new System.Windows.Forms.TextBox();
            this.tB_DonGia = new System.Windows.Forms.TextBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá nhập";
            // 
            // tB_TenSP
            // 
            this.tB_TenSP.FormattingEnabled = true;
            this.tB_TenSP.Location = new System.Drawing.Point(178, 68);
            this.tB_TenSP.Name = "tB_TenSP";
            this.tB_TenSP.Size = new System.Drawing.Size(319, 28);
            this.tB_TenSP.TabIndex = 1;
            // 
            // tB_MaPN
            // 
            this.tB_MaPN.Location = new System.Drawing.Point(178, 23);
            this.tB_MaPN.Name = "tB_MaPN";
            this.tB_MaPN.Size = new System.Drawing.Size(319, 26);
            this.tB_MaPN.TabIndex = 2;
            // 
            // tB_SL
            // 
            this.tB_SL.Location = new System.Drawing.Point(178, 114);
            this.tB_SL.Name = "tB_SL";
            this.tB_SL.Size = new System.Drawing.Size(319, 26);
            this.tB_SL.TabIndex = 2;
            // 
            // tB_DonGia
            // 
            this.tB_DonGia.Location = new System.Drawing.Point(178, 157);
            this.tB_DonGia.Name = "tB_DonGia";
            this.tB_DonGia.Size = new System.Drawing.Size(319, 26);
            this.tB_DonGia.TabIndex = 2;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_Luu.Image")));
            this.bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Luu.Location = new System.Drawing.Point(178, 214);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(112, 47);
            this.bt_Luu.TabIndex = 3;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_Thoat.Image")));
            this.bt_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Thoat.Location = new System.Drawing.Point(385, 214);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(112, 47);
            this.bt_Thoat.TabIndex = 3;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // Form_CTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 293);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.tB_DonGia);
            this.Controls.Add(this.tB_SL);
            this.Controls.Add(this.tB_MaPN);
            this.Controls.Add(this.tB_TenSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_CTPN";
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.Form_CTPN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tB_TenSP;
        private System.Windows.Forms.TextBox tB_MaPN;
        private System.Windows.Forms.TextBox tB_SL;
        private System.Windows.Forms.TextBox tB_DonGia;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Thoat;
    }
}