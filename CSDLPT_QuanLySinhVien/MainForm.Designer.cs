
namespace CSDLPT_QuanLySinhVien
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.rB_HeThong = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rB_DangNhap = new System.Windows.Forms.RibbonButton();
            this.rB_DangXuat = new System.Windows.Forms.RibbonButton();
            this.rB_TaoTK = new System.Windows.Forms.RibbonButton();
            this.rB_DanhMuc = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rB_SinhVien = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rB_GiangVien = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rB_Khoa = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rB_Lop = new System.Windows.Forms.RibbonButton();
            this.rB_NghiepVu = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.tB_HocPhan = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.rB_DKHP = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.rB_TimKiem = new System.Windows.Forms.RibbonButton();
            this.rB_BaoCao = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.rB_DSSV = new System.Windows.Forms.RibbonButton();
            this.rB_DSSV_TheoKhoa = new System.Windows.Forms.RibbonPanel();
            this.rB_DSTheoKhoa = new System.Windows.Forms.RibbonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1049, 200);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rB_HeThong);
            this.ribbon1.Tabs.Add(this.rB_DanhMuc);
            this.ribbon1.Tabs.Add(this.rB_NghiepVu);
            this.ribbon1.Tabs.Add(this.rB_BaoCao);
            this.ribbon1.Text = "ribbon1";
            // 
            // rB_HeThong
            // 
            this.rB_HeThong.Name = "rB_HeThong";
            this.rB_HeThong.Panels.Add(this.ribbonPanel1);
            this.rB_HeThong.Text = "Hệ thống";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rB_DangNhap);
            this.ribbonPanel1.Items.Add(this.rB_DangXuat);
            this.ribbonPanel1.Items.Add(this.rB_TaoTK);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // rB_DangNhap
            // 
            this.rB_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("rB_DangNhap.Image")));
            this.rB_DangNhap.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_DangNhap.LargeImage")));
            this.rB_DangNhap.Name = "rB_DangNhap";
            this.rB_DangNhap.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_DangNhap.SmallImage")));
            this.rB_DangNhap.Text = "Đăng nhập";
            this.rB_DangNhap.Click += new System.EventHandler(this.rB_DangNhap_Click);
            // 
            // rB_DangXuat
            // 
            this.rB_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("rB_DangXuat.Image")));
            this.rB_DangXuat.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_DangXuat.LargeImage")));
            this.rB_DangXuat.Name = "rB_DangXuat";
            this.rB_DangXuat.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_DangXuat.SmallImage")));
            this.rB_DangXuat.Text = "Đăng xuất";
            // 
            // rB_TaoTK
            // 
            this.rB_TaoTK.Image = ((System.Drawing.Image)(resources.GetObject("rB_TaoTK.Image")));
            this.rB_TaoTK.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_TaoTK.LargeImage")));
            this.rB_TaoTK.Name = "rB_TaoTK";
            this.rB_TaoTK.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_TaoTK.SmallImage")));
            this.rB_TaoTK.Text = "Tạo Login";
            this.rB_TaoTK.Visible = false;
            this.rB_TaoTK.Click += new System.EventHandler(this.rB_TaoTK_Click);
            // 
            // rB_DanhMuc
            // 
            this.rB_DanhMuc.Name = "rB_DanhMuc";
            this.rB_DanhMuc.Panels.Add(this.ribbonPanel2);
            this.rB_DanhMuc.Panels.Add(this.ribbonPanel3);
            this.rB_DanhMuc.Panels.Add(this.ribbonPanel4);
            this.rB_DanhMuc.Panels.Add(this.ribbonPanel5);
            this.rB_DanhMuc.Text = "Danh mục";
            this.rB_DanhMuc.Visible = false;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rB_SinhVien);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Sinh viên";
            // 
            // rB_SinhVien
            // 
            this.rB_SinhVien.Image = ((System.Drawing.Image)(resources.GetObject("rB_SinhVien.Image")));
            this.rB_SinhVien.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_SinhVien.LargeImage")));
            this.rB_SinhVien.Name = "rB_SinhVien";
            this.rB_SinhVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_SinhVien.SmallImage")));
            this.rB_SinhVien.Text = "Sinh viên";
            this.rB_SinhVien.Click += new System.EventHandler(this.rB_SinhVien_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rB_GiangVien);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Giảng viên";
            // 
            // rB_GiangVien
            // 
            this.rB_GiangVien.Image = ((System.Drawing.Image)(resources.GetObject("rB_GiangVien.Image")));
            this.rB_GiangVien.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_GiangVien.LargeImage")));
            this.rB_GiangVien.Name = "rB_GiangVien";
            this.rB_GiangVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_GiangVien.SmallImage")));
            this.rB_GiangVien.Text = "Giảng viên";
            this.rB_GiangVien.Click += new System.EventHandler(this.rB_GiangVien_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rB_Khoa);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Khoa";
            // 
            // rB_Khoa
            // 
            this.rB_Khoa.Image = ((System.Drawing.Image)(resources.GetObject("rB_Khoa.Image")));
            this.rB_Khoa.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_Khoa.LargeImage")));
            this.rB_Khoa.Name = "rB_Khoa";
            this.rB_Khoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_Khoa.SmallImage")));
            this.rB_Khoa.Text = "Khoa";
            this.rB_Khoa.Click += new System.EventHandler(this.rB_Khoa_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.rB_Lop);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Lớp học";
            // 
            // rB_Lop
            // 
            this.rB_Lop.Image = ((System.Drawing.Image)(resources.GetObject("rB_Lop.Image")));
            this.rB_Lop.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_Lop.LargeImage")));
            this.rB_Lop.Name = "rB_Lop";
            this.rB_Lop.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_Lop.SmallImage")));
            this.rB_Lop.Text = "Lớp ";
            this.rB_Lop.Click += new System.EventHandler(this.rB_Lop_Click);
            // 
            // rB_NghiepVu
            // 
            this.rB_NghiepVu.Name = "rB_NghiepVu";
            this.rB_NghiepVu.Panels.Add(this.ribbonPanel7);
            this.rB_NghiepVu.Panels.Add(this.ribbonPanel8);
            this.rB_NghiepVu.Panels.Add(this.ribbonPanel6);
            this.rB_NghiepVu.Text = "Nghiệp vụ";
            this.rB_NghiepVu.Visible = false;
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.tB_HocPhan);
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Text = "Học phần và CTDT";
            // 
            // tB_HocPhan
            // 
            this.tB_HocPhan.Image = ((System.Drawing.Image)(resources.GetObject("tB_HocPhan.Image")));
            this.tB_HocPhan.LargeImage = ((System.Drawing.Image)(resources.GetObject("tB_HocPhan.LargeImage")));
            this.tB_HocPhan.Name = "tB_HocPhan";
            this.tB_HocPhan.SmallImage = ((System.Drawing.Image)(resources.GetObject("tB_HocPhan.SmallImage")));
            this.tB_HocPhan.Text = "";
            this.tB_HocPhan.Click += new System.EventHandler(this.tB_HocPhan_Click);
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.rB_DKHP);
            this.ribbonPanel8.Name = "ribbonPanel8";
            this.ribbonPanel8.Text = "Đăng ký học phần";
            // 
            // rB_DKHP
            // 
            this.rB_DKHP.Image = ((System.Drawing.Image)(resources.GetObject("rB_DKHP.Image")));
            this.rB_DKHP.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_DKHP.LargeImage")));
            this.rB_DKHP.Name = "rB_DKHP";
            this.rB_DKHP.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_DKHP.SmallImage")));
            this.rB_DKHP.Click += new System.EventHandler(this.rB_DKHP_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.rB_TimKiem);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "Tìm kiếm sinh viên";
            // 
            // rB_TimKiem
            // 
            this.rB_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("rB_TimKiem.Image")));
            this.rB_TimKiem.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_TimKiem.LargeImage")));
            this.rB_TimKiem.Name = "rB_TimKiem";
            this.rB_TimKiem.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_TimKiem.SmallImage")));
            this.rB_TimKiem.Click += new System.EventHandler(this.rB_TimKiem_Click);
            // 
            // rB_BaoCao
            // 
            this.rB_BaoCao.Name = "rB_BaoCao";
            this.rB_BaoCao.Panels.Add(this.ribbonPanel9);
            this.rB_BaoCao.Panels.Add(this.rB_DSSV_TheoKhoa);
            this.rB_BaoCao.Text = "Báo cáo";
            this.rB_BaoCao.Visible = false;
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.rB_DSSV);
            this.ribbonPanel9.Name = "ribbonPanel9";
            this.ribbonPanel9.Text = "Danh sách sinh viên";
            // 
            // rB_DSSV
            // 
            this.rB_DSSV.Image = ((System.Drawing.Image)(resources.GetObject("rB_DSSV.Image")));
            this.rB_DSSV.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_DSSV.LargeImage")));
            this.rB_DSSV.Name = "rB_DSSV";
            this.rB_DSSV.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_DSSV.SmallImage")));
            this.rB_DSSV.Click += new System.EventHandler(this.rB_DSSV_Click);
            // 
            // rB_DSSV_TheoKhoa
            // 
            this.rB_DSSV_TheoKhoa.Items.Add(this.rB_DSTheoKhoa);
            this.rB_DSSV_TheoKhoa.Name = "rB_DSSV_TheoKhoa";
            this.rB_DSSV_TheoKhoa.Text = "Danh sách theo khoa";
            // 
            // rB_DSTheoKhoa
            // 
            this.rB_DSTheoKhoa.Image = ((System.Drawing.Image)(resources.GetObject("rB_DSTheoKhoa.Image")));
            this.rB_DSTheoKhoa.LargeImage = ((System.Drawing.Image)(resources.GetObject("rB_DSTheoKhoa.LargeImage")));
            this.rB_DSTheoKhoa.Name = "rB_DSTheoKhoa";
            this.rB_DSTheoKhoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("rB_DSTheoKhoa.SmallImage")));
            this.rB_DSTheoKhoa.Click += new System.EventHandler(this.rB_DSTheoKhoa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(63, 25);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(69, 25);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(68, 25);
            this.NHOM.Text = "NHOM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 656);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rB_HeThong;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton rB_DangNhap;
        private System.Windows.Forms.RibbonButton rB_DangXuat;
        private System.Windows.Forms.RibbonButton rB_TaoTK;
        private System.Windows.Forms.RibbonTab rB_DanhMuc;
        private System.Windows.Forms.RibbonTab rB_NghiepVu;
        private System.Windows.Forms.RibbonTab rB_BaoCao;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton rB_SinhVien;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton rB_GiangVien;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton rB_Khoa;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton rB_Lop;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton tB_HocPhan;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton rB_DKHP;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton rB_TimKiem;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonButton rB_DSSV;
        private System.Windows.Forms.RibbonPanel rB_DSSV_TheoKhoa;
        private System.Windows.Forms.RibbonButton rB_DSTheoKhoa;
    }
}