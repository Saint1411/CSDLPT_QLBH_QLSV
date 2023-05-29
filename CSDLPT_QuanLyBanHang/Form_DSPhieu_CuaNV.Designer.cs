
namespace CSDLPT_QuanLyBanHang
{
    partial class Form_DSPhieu_CuaNV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_Loai = new System.Windows.Forms.ComboBox();
            this.cB_Nam = new System.Windows.Forms.ComboBox();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rV_HDPN_CuaNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Preview);
            this.panel1.Controls.Add(this.cB_Nam);
            this.panel1.Controls.Add(this.cB_Loai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm";
            // 
            // cB_Loai
            // 
            this.cB_Loai.FormattingEnabled = true;
            this.cB_Loai.Items.AddRange(new object[] {
            "Hóa đơn (HD)",
            "Phiếu nhập (PN)"});
            this.cB_Loai.Location = new System.Drawing.Point(121, 17);
            this.cB_Loai.Name = "cB_Loai";
            this.cB_Loai.Size = new System.Drawing.Size(234, 28);
            this.cB_Loai.TabIndex = 1;
            // 
            // cB_Nam
            // 
            this.cB_Nam.FormattingEnabled = true;
            this.cB_Nam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cB_Nam.Location = new System.Drawing.Point(121, 69);
            this.cB_Nam.Name = "cB_Nam";
            this.cB_Nam.Size = new System.Drawing.Size(230, 28);
            this.cB_Nam.TabIndex = 2;
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(414, 36);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(165, 43);
            this.btn_Preview.TabIndex = 3;
            this.btn_Preview.Text = "Hiển thị báo cáo";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rV_HDPN_CuaNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 527);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // rV_HDPN_CuaNV
            // 
            this.rV_HDPN_CuaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rV_HDPN_CuaNV.Location = new System.Drawing.Point(3, 22);
            this.rV_HDPN_CuaNV.Name = "rV_HDPN_CuaNV";
            this.rV_HDPN_CuaNV.ServerReport.BearerToken = null;
            this.rV_HDPN_CuaNV.Size = new System.Drawing.Size(1046, 502);
            this.rV_HDPN_CuaNV.TabIndex = 0;
            // 
            // Form_DSPhieu_CuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DSPhieu_CuaNV";
            this.Text = "Form_DSPhieu_CuaNV";
            this.Load += new System.EventHandler(this.Form_DSPhieu_CuaNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.ComboBox cB_Nam;
        private System.Windows.Forms.ComboBox cB_Loai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rV_HDPN_CuaNV;
    }
}