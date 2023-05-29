using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QuanLySinhVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form isExists(Type fType)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == fType)
                    return form;
            }
            return null;
        }
        private void rB_DangNhap_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_DangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_DangNhap formDN = new Form_DangNhap();
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
            MAGV.Text = "Mã NV = " + Program.userName;
            HOTEN.Text = "Họ tên = " + Program.mHoTen;
            NHOM.Text = "Tên nhóm = " + Program.mGroup;
            //Phân quyền
            rB_DanhMuc.Visible = rB_NghiepVu.Visible = rB_BaoCao.Visible = true;
            rB_TaoTK.Visible = true;
        }

        private void rB_Khoa_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_Khoa));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_Khoa formDN = new Form_Khoa();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_TaoTK_Click(object sender, EventArgs e)
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

        private void rB_SinhVien_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_SinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_SinhVien formDN = new Form_SinhVien();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_GiangVien_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_GiangVien));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_GiangVien formDN = new Form_GiangVien();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_Lop_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_Lop));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_Lop formDN = new Form_Lop();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void tB_HocPhan_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_HocPhanVaCTDT));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_HocPhanVaCTDT formDN = new Form_HocPhanVaCTDT();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_DKHP_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_DangKyHocPhan));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_DangKyHocPhan formDN = new Form_DangKyHocPhan();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_TimKiem_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_TimKiemSinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_TimKiemSinhVien formDN = new Form_TimKiemSinhVien();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_DSSV_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_DanhSachSinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_DanhSachSinhVien formDN = new Form_DanhSachSinhVien();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }

        private void rB_DSTheoKhoa_Click(object sender, EventArgs e)
        {
            Form frm = this.isExists(typeof(Form_DS_TheoKhoa));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_DS_TheoKhoa formDN = new Form_DS_TheoKhoa();
                formDN.MdiParent = this;
                formDN.Show();
            }
        }
    }
}
