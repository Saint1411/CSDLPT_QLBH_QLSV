
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_Khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Khoa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.them_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sua_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tB_TenKhoa = new System.Windows.Forms.TextBox();
            this.tB_MaKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_Khoa = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.them_ToolStripMenuItem,
            this.xoa_ToolStripMenuItem,
            this.sua_ToolStripMenuItem,
            this.luu_ToolStripMenuItem,
            this.undo_ToolStripMenuItem,
            this.refresh_ToolStripMenuItem,
            this.thoat_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // them_ToolStripMenuItem
            // 
            this.them_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("them_ToolStripMenuItem.Image")));
            this.them_ToolStripMenuItem.Name = "them_ToolStripMenuItem";
            this.them_ToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.them_ToolStripMenuItem.Text = "Thêm";
            this.them_ToolStripMenuItem.Click += new System.EventHandler(this.them_ToolStripMenuItem_Click);
            // 
            // xoa_ToolStripMenuItem
            // 
            this.xoa_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xoa_ToolStripMenuItem.Image")));
            this.xoa_ToolStripMenuItem.Name = "xoa_ToolStripMenuItem";
            this.xoa_ToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.xoa_ToolStripMenuItem.Text = "Xóa";
            this.xoa_ToolStripMenuItem.Click += new System.EventHandler(this.xoa_ToolStripMenuItem_Click);
            // 
            // sua_ToolStripMenuItem
            // 
            this.sua_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sua_ToolStripMenuItem.Image")));
            this.sua_ToolStripMenuItem.Name = "sua_ToolStripMenuItem";
            this.sua_ToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.sua_ToolStripMenuItem.Text = "Sửa";
            this.sua_ToolStripMenuItem.Click += new System.EventHandler(this.sua_ToolStripMenuItem_Click);
            // 
            // luu_ToolStripMenuItem
            // 
            this.luu_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("luu_ToolStripMenuItem.Image")));
            this.luu_ToolStripMenuItem.Name = "luu_ToolStripMenuItem";
            this.luu_ToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.luu_ToolStripMenuItem.Text = "Lưu";
            this.luu_ToolStripMenuItem.Click += new System.EventHandler(this.luu_ToolStripMenuItem_Click);
            // 
            // undo_ToolStripMenuItem
            // 
            this.undo_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undo_ToolStripMenuItem.Image")));
            this.undo_ToolStripMenuItem.Name = "undo_ToolStripMenuItem";
            this.undo_ToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.undo_ToolStripMenuItem.Text = "Undo";
            this.undo_ToolStripMenuItem.Click += new System.EventHandler(this.undo_ToolStripMenuItem_Click);
            // 
            // refresh_ToolStripMenuItem
            // 
            this.refresh_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refresh_ToolStripMenuItem.Image")));
            this.refresh_ToolStripMenuItem.Name = "refresh_ToolStripMenuItem";
            this.refresh_ToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.refresh_ToolStripMenuItem.Text = "Refresh";
            this.refresh_ToolStripMenuItem.Click += new System.EventHandler(this.refresh_ToolStripMenuItem_Click);
            // 
            // thoat_ToolStripMenuItem
            // 
            this.thoat_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoat_ToolStripMenuItem.Image")));
            this.thoat_ToolStripMenuItem.Name = "thoat_ToolStripMenuItem";
            this.thoat_ToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.thoat_ToolStripMenuItem.Text = "Thoát";
            this.thoat_ToolStripMenuItem.Click += new System.EventHandler(this.thoat_ToolStripMenuItem_Click);
            // 
            // tB_TenKhoa
            // 
            this.tB_TenKhoa.Location = new System.Drawing.Point(198, 61);
            this.tB_TenKhoa.Name = "tB_TenKhoa";
            this.tB_TenKhoa.Size = new System.Drawing.Size(321, 26);
            this.tB_TenKhoa.TabIndex = 1;
            // 
            // tB_MaKhoa
            // 
            this.tB_MaKhoa.Location = new System.Drawing.Point(198, 17);
            this.tB_MaKhoa.Name = "tB_MaKhoa";
            this.tB_MaKhoa.Size = new System.Drawing.Size(321, 26);
            this.tB_MaKhoa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tB_TenKhoa);
            this.panel1.Controls.Add(this.tB_MaKhoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 116);
            this.panel1.TabIndex = 10;
            // 
            // dGV_Khoa
            // 
            this.dGV_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Khoa.Location = new System.Drawing.Point(13, 184);
            this.dGV_Khoa.Name = "dGV_Khoa";
            this.dGV_Khoa.RowHeadersVisible = false;
            this.dGV_Khoa.RowHeadersWidth = 62;
            this.dGV_Khoa.RowTemplate.Height = 28;
            this.dGV_Khoa.Size = new System.Drawing.Size(625, 318);
            this.dGV_Khoa.TabIndex = 11;
            this.dGV_Khoa.SelectionChanged += new System.EventHandler(this.dGV_Khoa_SelectionChanged);
            // 
            // Form_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 510);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGV_Khoa);
            this.Name = "Form_Khoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.Form_Khoa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem them_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoa_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sua_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undo_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refresh_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoat_ToolStripMenuItem;
        private System.Windows.Forms.TextBox tB_TenKhoa;
        private System.Windows.Forms.TextBox tB_MaKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGV_Khoa;
    }
}