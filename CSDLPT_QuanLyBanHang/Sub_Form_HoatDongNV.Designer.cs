
namespace CSDLPT_QuanLyBanHang
{
    partial class Sub_Form_HoatDongNV
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
            this.cB_MaNV = new System.Windows.Forms.ComboBox();
            this.cB_Loai = new System.Windows.Forms.ComboBox();
            this.dTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.dTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(197, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "HOẠT ĐỘNG CỦA NHÂN VIÊN";
            // 
            // cB_MaNV
            // 
            this.cB_MaNV.FormattingEnabled = true;
            this.cB_MaNV.Location = new System.Drawing.Point(203, 109);
            this.cB_MaNV.Name = "cB_MaNV";
            this.cB_MaNV.Size = new System.Drawing.Size(290, 28);
            this.cB_MaNV.TabIndex = 1;
            // 
            // cB_Loai
            // 
            this.cB_Loai.FormattingEnabled = true;
            this.cB_Loai.Items.AddRange(new object[] {
            "Hóa đơn",
            "Phiếu nhập"});
            this.cB_Loai.Location = new System.Drawing.Point(203, 148);
            this.cB_Loai.Name = "cB_Loai";
            this.cB_Loai.Size = new System.Drawing.Size(290, 28);
            this.cB_Loai.TabIndex = 1;
            // 
            // dTP_TuNgay
            // 
            this.dTP_TuNgay.Location = new System.Drawing.Point(203, 192);
            this.dTP_TuNgay.Name = "dTP_TuNgay";
            this.dTP_TuNgay.Size = new System.Drawing.Size(290, 26);
            this.dTP_TuNgay.TabIndex = 2;
            // 
            // dTP_DenNgay
            // 
            this.dTP_DenNgay.Location = new System.Drawing.Point(203, 233);
            this.dTP_DenNgay.Name = "dTP_DenNgay";
            this.dTP_DenNgay.Size = new System.Drawing.Size(290, 26);
            this.dTP_DenNgay.TabIndex = 2;
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(552, 163);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(173, 49);
            this.btn_Preview.TabIndex = 3;
            this.btn_Preview.Text = "Hiển thị hoạt động";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // Sub_Form_HoatDongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.dTP_DenNgay);
            this.Controls.Add(this.dTP_TuNgay);
            this.Controls.Add(this.cB_Loai);
            this.Controls.Add(this.cB_MaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Sub_Form_HoatDongNV";
            this.Text = "Sub_Form_HoatDongNV";
            this.Load += new System.EventHandler(this.Sub_Form_HoatDongNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cB_MaNV;
        private System.Windows.Forms.ComboBox cB_Loai;
        private System.Windows.Forms.DateTimePicker dTP_TuNgay;
        private System.Windows.Forms.DateTimePicker dTP_DenNgay;
        private System.Windows.Forms.Button btn_Preview;
    }
}