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
    public partial class Sub_Form_HoatDongNV : Form
    {
        public Sub_Form_HoatDongNV()
        {
            InitializeComponent();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_HoatDongNV frm = new Form_HoatDongNV();
            frm.maNV = cB_MaNV.SelectedValue.ToString().Trim();
            frm.loaiPhieu = cB_Loai.SelectedItem.ToString().Trim();
            frm.tuNgay = dTP_TuNgay.Value;
            frm.denNgay = dTP_DenNgay.Value;
            frm.ShowDialog();
        }

        private void Sub_Form_HoatDongNV_Load(object sender, EventArgs e)
        {
            HienThi_CB_NhanVien();
            cB_Loai.SelectedIndex = 0;
        }
        private void HienThi_CB_NhanVien()
        {
            string lenh = "SELECT MANV, HOTEN FROM NHANVIEN";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_MaNV.DataSource = bindingSource;
            cB_MaNV.DisplayMember = "HOTEN";
            cB_MaNV.ValueMember = "MANV";
        }

    }
}
