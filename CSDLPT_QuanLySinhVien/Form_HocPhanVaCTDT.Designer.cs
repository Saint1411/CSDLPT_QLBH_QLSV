
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_HocPhanVaCTDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HocPhanVaCTDT));
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tB_loaiDT = new System.Windows.Forms.TextBox();
            this.tB_MaCTDT = new System.Windows.Forms.TextBox();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_CTDT = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dGV_HocPhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sua_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.them_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.luu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_TenCTDT = new System.Windows.Forms.TextBox();
            this.tB_STC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CTDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HocPhan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // undo_ToolStripMenuItem
            // 
            this.undo_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undo_ToolStripMenuItem.Image")));
            this.undo_ToolStripMenuItem.Name = "undo_ToolStripMenuItem";
            this.undo_ToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.undo_ToolStripMenuItem.Text = "Undo";
            this.undo_ToolStripMenuItem.Click += new System.EventHandler(this.undo_ToolStripMenuItem_Click);
            // 
            // tB_loaiDT
            // 
            this.tB_loaiDT.Location = new System.Drawing.Point(892, 83);
            this.tB_loaiDT.Name = "tB_loaiDT";
            this.tB_loaiDT.Size = new System.Drawing.Size(341, 26);
            this.tB_loaiDT.TabIndex = 1;
            // 
            // tB_MaCTDT
            // 
            this.tB_MaCTDT.Location = new System.Drawing.Point(237, 25);
            this.tB_MaCTDT.Name = "tB_MaCTDT";
            this.tB_MaCTDT.Size = new System.Drawing.Size(314, 26);
            this.tB_MaCTDT.TabIndex = 1;
            // 
            // thoat_ToolStripMenuItem
            // 
            this.thoat_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoat_ToolStripMenuItem.Image")));
            this.thoat_ToolStripMenuItem.Name = "thoat_ToolStripMenuItem";
            this.thoat_ToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.thoat_ToolStripMenuItem.Text = "Thoát";
            this.thoat_ToolStripMenuItem.Click += new System.EventHandler(this.thoat_ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGV_CTDT);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 357);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chương trình đào tạo";
            // 
            // dGV_CTDT
            // 
            this.dGV_CTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CTDT.Location = new System.Drawing.Point(6, 25);
            this.dGV_CTDT.Name = "dGV_CTDT";
            this.dGV_CTDT.RowHeadersVisible = false;
            this.dGV_CTDT.RowHeadersWidth = 62;
            this.dGV_CTDT.RowTemplate.Height = 28;
            this.dGV_CTDT.Size = new System.Drawing.Size(509, 323);
            this.dGV_CTDT.TabIndex = 0;
            this.dGV_CTDT.SelectionChanged += new System.EventHandler(this.dGV_CTDT_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại đào tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số tín chỉ";
            // 
            // refresh_ToolStripMenuItem
            // 
            this.refresh_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refresh_ToolStripMenuItem.Image")));
            this.refresh_ToolStripMenuItem.Name = "refresh_ToolStripMenuItem";
            this.refresh_ToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.refresh_ToolStripMenuItem.Text = "Refresh";
            this.refresh_ToolStripMenuItem.Click += new System.EventHandler(this.refresh_ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên CTDT";
            // 
            // dGV_HocPhan
            // 
            this.dGV_HocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_HocPhan.Location = new System.Drawing.Point(6, 23);
            this.dGV_HocPhan.Name = "dGV_HocPhan";
            this.dGV_HocPhan.RowHeadersVisible = false;
            this.dGV_HocPhan.RowHeadersWidth = 62;
            this.dGV_HocPhan.RowTemplate.Height = 28;
            this.dGV_HocPhan.Size = new System.Drawing.Size(796, 320);
            this.dGV_HocPhan.TabIndex = 0;
            this.dGV_HocPhan.SelectionChanged += new System.EventHandler(this.dGV_HocPhan_SelectionChanged);
            this.dGV_HocPhan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGV_HocPhan_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CTDT";
            // 
            // sua_ToolStripMenuItem
            // 
            this.sua_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sua_ToolStripMenuItem.Image")));
            this.sua_ToolStripMenuItem.Name = "sua_ToolStripMenuItem";
            this.sua_ToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.sua_ToolStripMenuItem.Text = "Sửa";
            this.sua_ToolStripMenuItem.Click += new System.EventHandler(this.sua_ToolStripMenuItem_Click);
            // 
            // xoa_ToolStripMenuItem
            // 
            this.xoa_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xoa_ToolStripMenuItem.Image")));
            this.xoa_ToolStripMenuItem.Name = "xoa_ToolStripMenuItem";
            this.xoa_ToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.xoa_ToolStripMenuItem.Text = "Xóa";
            this.xoa_ToolStripMenuItem.Click += new System.EventHandler(this.xoa_ToolStripMenuItem_Click);
            // 
            // them_ToolStripMenuItem
            // 
            this.them_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("them_ToolStripMenuItem.Image")));
            this.them_ToolStripMenuItem.Name = "them_ToolStripMenuItem";
            this.them_ToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.them_ToolStripMenuItem.Text = "Thêm";
            this.them_ToolStripMenuItem.Click += new System.EventHandler(this.them_ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_HocPhan);
            this.groupBox2.Location = new System.Drawing.Point(539, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 355);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học phần";
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
            this.menuStrip1.Size = new System.Drawing.Size(1359, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // luu_ToolStripMenuItem
            // 
            this.luu_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("luu_ToolStripMenuItem.Image")));
            this.luu_ToolStripMenuItem.Name = "luu_ToolStripMenuItem";
            this.luu_ToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.luu_ToolStripMenuItem.Text = "Lưu";
            this.luu_ToolStripMenuItem.Click += new System.EventHandler(this.luu_ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tB_TenCTDT);
            this.panel1.Controls.Add(this.tB_loaiDT);
            this.panel1.Controls.Add(this.tB_STC);
            this.panel1.Controls.Add(this.tB_MaCTDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 153);
            this.panel1.TabIndex = 4;
            // 
            // tB_TenCTDT
            // 
            this.tB_TenCTDT.Location = new System.Drawing.Point(892, 25);
            this.tB_TenCTDT.Name = "tB_TenCTDT";
            this.tB_TenCTDT.Size = new System.Drawing.Size(341, 26);
            this.tB_TenCTDT.TabIndex = 1;
            // 
            // tB_STC
            // 
            this.tB_STC.Location = new System.Drawing.Point(237, 82);
            this.tB_STC.Name = "tB_STC";
            this.tB_STC.Size = new System.Drawing.Size(314, 26);
            this.tB_STC.TabIndex = 1;
            // 
            // Form_HocPhanVaCTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_HocPhanVaCTDT";
            this.Text = "Chương trình đào tạo và học phần";
            this.Load += new System.EventHandler(this.Form_HocPhanVaCTDT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CTDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HocPhan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem undo_ToolStripMenuItem;
        private System.Windows.Forms.TextBox tB_loaiDT;
        private System.Windows.Forms.TextBox tB_MaCTDT;
        private System.Windows.Forms.ToolStripMenuItem thoat_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_CTDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem refresh_ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGV_HocPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sua_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoa_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem them_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem luu_ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_TenCTDT;
        private System.Windows.Forms.TextBox tB_STC;
    }
}