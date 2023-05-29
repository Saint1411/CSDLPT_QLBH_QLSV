
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_DangKyHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKyHocPhan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.them_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sua_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_TrangThai = new System.Windows.Forms.ComboBox();
            this.cB_NamHoc = new System.Windows.Forms.ComboBox();
            this.cB_HocPhan = new System.Windows.Forms.ComboBox();
            this.cB_HocKy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_MaSV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGV_DKHP = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DKHP)).BeginInit();
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
            this.refresh_ToolStripMenuItem,
            this.thoat_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 33);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cB_TrangThai);
            this.panel1.Controls.Add(this.cB_NamHoc);
            this.panel1.Controls.Add(this.cB_HocPhan);
            this.panel1.Controls.Add(this.cB_HocKy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cB_MaSV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 164);
            this.panel1.TabIndex = 13;
            // 
            // cB_TrangThai
            // 
            this.cB_TrangThai.FormattingEnabled = true;
            this.cB_TrangThai.Items.AddRange(new object[] {
            "Thành công",
            "Hủy bỏ"});
            this.cB_TrangThai.Location = new System.Drawing.Point(637, 112);
            this.cB_TrangThai.Name = "cB_TrangThai";
            this.cB_TrangThai.Size = new System.Drawing.Size(319, 28);
            this.cB_TrangThai.TabIndex = 2;
            // 
            // cB_NamHoc
            // 
            this.cB_NamHoc.FormattingEnabled = true;
            this.cB_NamHoc.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cB_NamHoc.Location = new System.Drawing.Point(637, 65);
            this.cB_NamHoc.Name = "cB_NamHoc";
            this.cB_NamHoc.Size = new System.Drawing.Size(319, 28);
            this.cB_NamHoc.TabIndex = 2;
            // 
            // cB_HocPhan
            // 
            this.cB_HocPhan.FormattingEnabled = true;
            this.cB_HocPhan.Location = new System.Drawing.Point(151, 65);
            this.cB_HocPhan.Name = "cB_HocPhan";
            this.cB_HocPhan.Size = new System.Drawing.Size(319, 28);
            this.cB_HocPhan.TabIndex = 2;
            // 
            // cB_HocKy
            // 
            this.cB_HocKy.FormattingEnabled = true;
            this.cB_HocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cB_HocKy.Location = new System.Drawing.Point(637, 22);
            this.cB_HocKy.Name = "cB_HocKy";
            this.cB_HocKy.Size = new System.Drawing.Size(319, 28);
            this.cB_HocKy.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng thái";
            // 
            // cB_MaSV
            // 
            this.cB_MaSV.FormattingEnabled = true;
            this.cB_MaSV.Location = new System.Drawing.Point(151, 22);
            this.cB_MaSV.Name = "cB_MaSV";
            this.cB_MaSV.Size = new System.Drawing.Size(319, 28);
            this.cB_MaSV.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học kỳ";
            // 
            // dGV_DKHP
            // 
            this.dGV_DKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DKHP.Location = new System.Drawing.Point(13, 214);
            this.dGV_DKHP.Name = "dGV_DKHP";
            this.dGV_DKHP.RowHeadersWidth = 62;
            this.dGV_DKHP.RowTemplate.Height = 28;
            this.dGV_DKHP.Size = new System.Drawing.Size(990, 364);
            this.dGV_DKHP.TabIndex = 14;
            this.dGV_DKHP.SelectionChanged += new System.EventHandler(this.dGV_DKHP_SelectionChanged);
            // 
            // Form_DangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 592);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGV_DKHP);
            this.Name = "Form_DangKyHocPhan";
            this.Text = "Đăng ký học phần";
            this.Load += new System.EventHandler(this.Form_DangKyHocPhan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DKHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem them_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoa_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sua_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refresh_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoat_ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cB_NamHoc;
        private System.Windows.Forms.ComboBox cB_HocPhan;
        private System.Windows.Forms.ComboBox cB_HocKy;
        private System.Windows.Forms.ComboBox cB_MaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV_DKHP;
        private System.Windows.Forms.ComboBox cB_TrangThai;
        private System.Windows.Forms.Label label6;
    }
}