﻿
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SinhVien));
            this.dGV_DiemSo = new System.Windows.Forms.DataGridView();
            this.dGV_HocPhan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGW_SinhVien = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_DiaChi = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.them_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sua_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tB_SDT = new System.Windows.Forms.TextBox();
            this.tB_HoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_GioiTinh = new System.Windows.Forms.ComboBox();
            this.cB_Lop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DiemSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HocPhan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_SinhVien)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_DiemSo
            // 
            this.dGV_DiemSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DiemSo.Location = new System.Drawing.Point(4, 4);
            this.dGV_DiemSo.Name = "dGV_DiemSo";
            this.dGV_DiemSo.RowHeadersVisible = false;
            this.dGV_DiemSo.RowHeadersWidth = 62;
            this.dGV_DiemSo.RowTemplate.Height = 28;
            this.dGV_DiemSo.Size = new System.Drawing.Size(979, 368);
            this.dGV_DiemSo.TabIndex = 0;
            // 
            // dGV_HocPhan
            // 
            this.dGV_HocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_HocPhan.Location = new System.Drawing.Point(4, 4);
            this.dGV_HocPhan.Name = "dGV_HocPhan";
            this.dGV_HocPhan.RowHeadersVisible = false;
            this.dGV_HocPhan.RowHeadersWidth = 62;
            this.dGV_HocPhan.RowTemplate.Height = 28;
            this.dGV_HocPhan.Size = new System.Drawing.Size(976, 374);
            this.dGV_HocPhan.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGV_HocPhan);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Học phần đăng ký";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGW_SinhVien
            // 
            this.dGW_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_SinhVien.Location = new System.Drawing.Point(6, 7);
            this.dGW_SinhVien.Name = "dGW_SinhVien";
            this.dGW_SinhVien.RowHeadersVisible = false;
            this.dGW_SinhVien.RowHeadersWidth = 62;
            this.dGW_SinhVien.RowTemplate.Height = 28;
            this.dGW_SinhVien.Size = new System.Drawing.Size(973, 371);
            this.dGW_SinhVien.TabIndex = 0;
            this.dGW_SinhVien.SelectionChanged += new System.EventHandler(this.dGW_SinhVien_SelectionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGW_SinhVien);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 417);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dGV_DiemSo);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(986, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Điểm sinh viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tB_Email
            // 
            this.tB_Email.Location = new System.Drawing.Point(655, 54);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(281, 26);
            this.tB_Email.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // dTP_NgaySinh
            // 
            this.dTP_NgaySinh.Location = new System.Drawing.Point(655, 13);
            this.dTP_NgaySinh.Name = "dTP_NgaySinh";
            this.dTP_NgaySinh.Size = new System.Drawing.Size(281, 26);
            this.dTP_NgaySinh.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp";
            // 
            // tB_DiaChi
            // 
            this.tB_DiaChi.Location = new System.Drawing.Point(160, 130);
            this.tB_DiaChi.Name = "tB_DiaChi";
            this.tB_DiaChi.Size = new System.Drawing.Size(291, 26);
            this.tB_DiaChi.TabIndex = 1;
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
            this.menuStrip1.Size = new System.Drawing.Size(1022, 33);
            this.menuStrip1.TabIndex = 3;
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
            // tB_SDT
            // 
            this.tB_SDT.Location = new System.Drawing.Point(161, 91);
            this.tB_SDT.Name = "tB_SDT";
            this.tB_SDT.Size = new System.Drawing.Size(290, 26);
            this.tB_SDT.TabIndex = 1;
            // 
            // tB_HoTen
            // 
            this.tB_HoTen.Location = new System.Drawing.Point(161, 54);
            this.tB_HoTen.Name = "tB_HoTen";
            this.tB_HoTen.Size = new System.Drawing.Size(290, 26);
            this.tB_HoTen.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(161, 15);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(290, 26);
            this.tbMaSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cB_GioiTinh);
            this.panel1.Controls.Add(this.cB_Lop);
            this.panel1.Controls.Add(this.tB_Email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dTP_NgaySinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tB_DiaChi);
            this.panel1.Controls.Add(this.tB_SDT);
            this.panel1.Controls.Add(this.tB_HoTen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbMaSV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 180);
            this.panel1.TabIndex = 4;
            // 
            // cB_GioiTinh
            // 
            this.cB_GioiTinh.FormattingEnabled = true;
            this.cB_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cB_GioiTinh.Location = new System.Drawing.Point(655, 94);
            this.cB_GioiTinh.Name = "cB_GioiTinh";
            this.cB_GioiTinh.Size = new System.Drawing.Size(281, 28);
            this.cB_GioiTinh.TabIndex = 4;
            // 
            // cB_Lop
            // 
            this.cB_Lop.FormattingEnabled = true;
            this.cB_Lop.Location = new System.Drawing.Point(655, 136);
            this.cB_Lop.Name = "cB_Lop";
            this.cB_Lop.Size = new System.Drawing.Size(281, 28);
            this.cB_Lop.TabIndex = 4;
            // 
            // Form_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 667);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_SinhVien";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DiemSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HocPhan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGW_SinhVien)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DiemSo;
        private System.Windows.Forms.DataGridView dGV_HocPhan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGW_SinhVien;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTP_NgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_DiaChi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem them_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoa_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sua_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undo_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refresh_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoat_ToolStripMenuItem;
        private System.Windows.Forms.TextBox tB_SDT;
        private System.Windows.Forms.TextBox tB_HoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cB_GioiTinh;
        private System.Windows.Forms.ComboBox cB_Lop;
    }
}