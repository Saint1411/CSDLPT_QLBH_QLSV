
namespace CSDLPT_QuanLyBanHang
{
    partial class Form_HoatDongNV
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
            this.rV_HoatDongNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rV_HoatDongNV
            // 
            this.rV_HoatDongNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rV_HoatDongNV.Location = new System.Drawing.Point(0, 0);
            this.rV_HoatDongNV.Name = "rV_HoatDongNV";
            this.rV_HoatDongNV.ServerReport.BearerToken = null;
            this.rV_HoatDongNV.Size = new System.Drawing.Size(800, 450);
            this.rV_HoatDongNV.TabIndex = 0;
            this.rV_HoatDongNV.Load += new System.EventHandler(this.rV_HoatDongNV_Load);
            // 
            // Form_HoatDongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rV_HoatDongNV);
            this.Name = "Form_HoatDongNV";
            this.Text = "Hoạt động của nhân viên";
            this.Load += new System.EventHandler(this.Form_HoatDongNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rV_HoatDongNV;
    }
}