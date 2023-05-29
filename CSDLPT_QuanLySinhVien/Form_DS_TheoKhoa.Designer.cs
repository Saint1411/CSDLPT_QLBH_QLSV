
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_DS_TheoKhoa
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
            this.cB_Khoa = new System.Windows.Forms.ComboBox();
            this.cB_DoiTuong = new System.Windows.Forms.ComboBox();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rV_DS_TheoKhoa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_HienThi);
            this.panel1.Controls.Add(this.cB_DoiTuong);
            this.panel1.Controls.Add(this.cB_Khoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 121);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đối tượng";
            // 
            // cB_Khoa
            // 
            this.cB_Khoa.FormattingEnabled = true;
            this.cB_Khoa.Location = new System.Drawing.Point(142, 24);
            this.cB_Khoa.Name = "cB_Khoa";
            this.cB_Khoa.Size = new System.Drawing.Size(240, 28);
            this.cB_Khoa.TabIndex = 1;
            // 
            // cB_DoiTuong
            // 
            this.cB_DoiTuong.FormattingEnabled = true;
            this.cB_DoiTuong.Items.AddRange(new object[] {
            "Sinh viên",
            "Giảng viên"});
            this.cB_DoiTuong.Location = new System.Drawing.Point(142, 68);
            this.cB_DoiTuong.Name = "cB_DoiTuong";
            this.cB_DoiTuong.Size = new System.Drawing.Size(240, 28);
            this.cB_DoiTuong.TabIndex = 1;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_HienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HienThi.Location = new System.Drawing.Point(460, 36);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(276, 44);
            this.btn_HienThi.TabIndex = 2;
            this.btn_HienThi.Text = "Hiển thị báo cáo";
            this.btn_HienThi.UseVisualStyleBackColor = false;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rV_DS_TheoKhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 547);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // rV_DS_TheoKhoa
            // 
            this.rV_DS_TheoKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rV_DS_TheoKhoa.Location = new System.Drawing.Point(3, 22);
            this.rV_DS_TheoKhoa.Name = "rV_DS_TheoKhoa";
            this.rV_DS_TheoKhoa.ServerReport.BearerToken = null;
            this.rV_DS_TheoKhoa.Size = new System.Drawing.Size(1003, 522);
            this.rV_DS_TheoKhoa.TabIndex = 0;
            // 
            // Form_DS_TheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DS_TheoKhoa";
            this.Text = "Danh sách theo khoa";
            this.Load += new System.EventHandler(this.Form_DS_TheoKhoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.ComboBox cB_DoiTuong;
        private System.Windows.Forms.ComboBox cB_Khoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rV_DS_TheoKhoa;
    }
}