﻿
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_DanhSachSinhVien
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
            this.rV_DSSV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rV_DSSV
            // 
            this.rV_DSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rV_DSSV.Location = new System.Drawing.Point(0, 0);
            this.rV_DSSV.Name = "rV_DSSV";
            this.rV_DSSV.ServerReport.BearerToken = null;
            this.rV_DSSV.Size = new System.Drawing.Size(993, 543);
            this.rV_DSSV.TabIndex = 0;
            this.rV_DSSV.Load += new System.EventHandler(this.rV_DSSV_Load);
            // 
            // Form_DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 543);
            this.Controls.Add(this.rV_DSSV);
            this.Name = "Form_DanhSachSinhVien";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.Form_DanhSachSinhVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rV_DSSV;
    }
}