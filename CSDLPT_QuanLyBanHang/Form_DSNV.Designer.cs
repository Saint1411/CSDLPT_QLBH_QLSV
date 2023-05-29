
namespace CSDLPT_QuanLyBanHang
{
    partial class Form_DSNV
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
            this.rV_DSNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rV_DSNV
            // 
            this.rV_DSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rV_DSNV.Location = new System.Drawing.Point(0, 0);
            this.rV_DSNV.Name = "rV_DSNV";
            this.rV_DSNV.ServerReport.BearerToken = null;
            this.rV_DSNV.Size = new System.Drawing.Size(943, 530);
            this.rV_DSNV.TabIndex = 0;
            this.rV_DSNV.Load += new System.EventHandler(this.rV_DSNV_Load);
            // 
            // Form_DSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 530);
            this.Controls.Add(this.rV_DSNV);
            this.Name = "Form_DSNV";
            this.Text = "Form_DSNV";
            this.Load += new System.EventHandler(this.Form_DSNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rV_DSNV;
    }
}