using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QuanLyBanHang
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form isExists(Type fType)
        {
            foreach(Form form in this.MdiChildren)
            {
                if (form.GetType() == fType)
                    return form;
            }
            return null;
        }
        private void rBDangNhap_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(FormDangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                FormDangNhap formDN = new FormDangNhap();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        public void HienThiMenu()
        {
            MANV.Text = "Mã NV = " + Program.userName;
            HOTEN.Text = "Họ tên = " + Program.mHoTen;
            NHOM.Text = "Tên nhóm = " + Program.mGroup;
            //Phân quyền
            rT_BaoCao.Visible = rT_NghiepVu.Visible = rT_DanhMuc.Visible = true;
            rBTaoTK.Visible = true;
        }

        private void rB_Kho_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_Kho));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_Kho formDN = new Form_Kho();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_NhanVien_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_NhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_NhanVien formDN = new Form_NhanVien();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rBTaoTK_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_TaoTaiKhoan));
            if (frm != null)    
                frm.Activate();
            else
            {
                Form_TaoTaiKhoan formDN = new Form_TaoTaiKhoan();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void ribbonButton_HD_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_HoaDon));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_HoaDon formDN = new Form_HoaDon();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void ribbonButton_PN_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_PhieuNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_PhieuNhap formDN = new Form_PhieuNhap();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_SanPham_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_SanPham));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_SanPham formDN = new Form_SanPham();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_KhachHang_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_KhachHang));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_KhachHang formDN = new Form_KhachHang();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_BCDSNV_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_DSNV));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_DSNV formDN = new Form_DSNV();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_HD_NV_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_DSPhieu_CuaNV));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_DSPhieu_CuaNV formDN = new Form_DSPhieu_CuaNV();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_HDNV_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Sub_Form_HoatDongNV));
            if (frm != null)
                frm.Activate();
            else
            {
                Sub_Form_HoatDongNV formDN = new Sub_Form_HoatDongNV();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }
    }
}
