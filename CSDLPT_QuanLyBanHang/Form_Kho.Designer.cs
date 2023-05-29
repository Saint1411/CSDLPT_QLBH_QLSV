
namespace CSDLPT_QuanLyBanHang
{
    partial class Form_Kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kho));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sua_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Luu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_ChiNhanh = new System.Windows.Forms.TextBox();
            this.tB_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_MaKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGV_Kho = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kho)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.xoa_ToolStripMenuItem,
            this.sua_ToolStripMenuItem,
            this.Luu_ToolStripMenuItem,
            this.undo_ToolStripMenuItem,
            this.refresh_ToolStripMenuItem,
            this.thoat_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("themToolStripMenuItem.Image")));
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.themToolStripMenuItem.Text = "Thêm";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
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
            // Luu_ToolStripMenuItem
            // 
            this.Luu_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Luu_ToolStripMenuItem.Image")));
            this.Luu_ToolStripMenuItem.Name = "Luu_ToolStripMenuItem";
            this.Luu_ToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.Luu_ToolStripMenuItem.Text = "Lưu";
            this.Luu_ToolStripMenuItem.Click += new System.EventHandler(this.Luu_ToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tB_ChiNhanh);
            this.panel1.Controls.Add(this.tB_DiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_MaKho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 134);
            this.panel1.TabIndex = 1;
            // 
            // tB_ChiNhanh
            // 
            this.tB_ChiNhanh.Location = new System.Drawing.Point(642, 61);
            this.tB_ChiNhanh.Name = "tB_ChiNhanh";
            this.tB_ChiNhanh.Size = new System.Drawing.Size(259, 26);
            this.tB_ChiNhanh.TabIndex = 1;
            // 
            // tB_DiaChi
            // 
            this.tB_DiaChi.Location = new System.Drawing.Point(642, 20);
            this.tB_DiaChi.Name = "tB_DiaChi";
            this.tB_DiaChi.Size = new System.Drawing.Size(259, 26);
            this.tB_DiaChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chi nhánh";
            // 
            // tB_MaKho
            // 
            this.tB_MaKho.Location = new System.Drawing.Point(143, 20);
            this.tB_MaKho.Name = "tB_MaKho";
            this.tB_MaKho.Size = new System.Drawing.Size(259, 26);
            this.tB_MaKho.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kho";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dGV_Kho);
            this.panel2.Location = new System.Drawing.Point(27, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 348);
            this.panel2.TabIndex = 2;
            // 
            // dGV_Kho
            // 
            this.dGV_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Kho.Location = new System.Drawing.Point(4, 4);
            this.dGV_Kho.Name = "dGV_Kho";
            this.dGV_Kho.RowHeadersVisible = false;
            this.dGV_Kho.RowHeadersWidth = 62;
            this.dGV_Kho.RowTemplate.Height = 28;
            this.dGV_Kho.Size = new System.Drawing.Size(982, 339);
            this.dGV_Kho.TabIndex = 0;
            this.dGV_Kho.SelectionChanged += new System.EventHandler(this.dGV_Kho_SelectionChanged);
            // 
            // Form_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Kho";
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.Form_Kho_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoa_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sua_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Luu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undo_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refresh_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoat_ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_ChiNhanh;
        private System.Windows.Forms.TextBox tB_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_MaKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGV_Kho;
    }
}