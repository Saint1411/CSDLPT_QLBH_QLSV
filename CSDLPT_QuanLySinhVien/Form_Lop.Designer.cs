
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_Lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lop));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.them_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sua_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGV_Lop = new System.Windows.Forms.DataGridView();
            this.tB_TenLop = new System.Windows.Forms.TextBox();
            this.tB_MaLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_Khoa = new System.Windows.Forms.ComboBox();
            this.tB_SoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Lop)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(864, 33);
            this.menuStrip1.TabIndex = 12;
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
            // dGV_Lop
            // 
            this.dGV_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Lop.Location = new System.Drawing.Point(12, 181);
            this.dGV_Lop.Name = "dGV_Lop";
            this.dGV_Lop.RowHeadersWidth = 62;
            this.dGV_Lop.RowTemplate.Height = 28;
            this.dGV_Lop.Size = new System.Drawing.Size(837, 318);
            this.dGV_Lop.TabIndex = 14;
            this.dGV_Lop.SelectionChanged += new System.EventHandler(this.dGV_Lop_SelectionChanged);
            // 
            // tB_TenLop
            // 
            this.tB_TenLop.Location = new System.Drawing.Point(118, 60);
            this.tB_TenLop.Name = "tB_TenLop";
            this.tB_TenLop.Size = new System.Drawing.Size(253, 26);
            this.tB_TenLop.TabIndex = 1;
            // 
            // tB_MaLop
            // 
            this.tB_MaLop.Location = new System.Drawing.Point(118, 16);
            this.tB_MaLop.Name = "tB_MaLop";
            this.tB_MaLop.Size = new System.Drawing.Size(253, 26);
            this.tB_MaLop.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cB_Khoa);
            this.panel1.Controls.Add(this.tB_TenLop);
            this.panel1.Controls.Add(this.tB_SoLuong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_MaLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 116);
            this.panel1.TabIndex = 13;
            // 
            // cB_Khoa
            // 
            this.cB_Khoa.FormattingEnabled = true;
            this.cB_Khoa.Location = new System.Drawing.Point(535, 66);
            this.cB_Khoa.Name = "cB_Khoa";
            this.cB_Khoa.Size = new System.Drawing.Size(251, 28);
            this.cB_Khoa.TabIndex = 2;
            // 
            // tB_SoLuong
            // 
            this.tB_SoLuong.Location = new System.Drawing.Point(535, 16);
            this.tB_SoLuong.Name = "tB_SoLuong";
            this.tB_SoLuong.Size = new System.Drawing.Size(251, 26);
            this.tB_SoLuong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng";
            // 
            // Form_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 519);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dGV_Lop);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Lop";
            this.Text = "Danh sách lớp";
            this.Load += new System.EventHandler(this.Form_Lop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Lop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dGV_Lop;
        private System.Windows.Forms.TextBox tB_TenLop;
        private System.Windows.Forms.TextBox tB_MaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cB_Khoa;
        private System.Windows.Forms.TextBox tB_SoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}