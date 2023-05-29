using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QuanLySinhVien
{
    public partial class Form_SinhVien : Form
    {
        string flag = "";
        DataTable dt_SV = new DataTable();
        string oldLop = "", oldHoten = "", oldDiaChi = "", oldSDT = "", oldGioiTinh = "";

        private void dGW_SinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dGW_SinhVien.CurrentCell != null)
            {
                int index = dGW_SinhVien.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGW_SinhVien.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tbMaSV.Text = dGW_SinhVien.Rows[index].Cells[0].Value.ToString();
                    tB_HoTen.Text = dGW_SinhVien.Rows[index].Cells[1].Value.ToString();
                    dTP_NgaySinh.Text = dGW_SinhVien.Rows[index].Cells[2].Value.ToString();
                    cB_GioiTinh.Text = dGW_SinhVien.Rows[index].Cells[3].Value.ToString();
                    tB_DiaChi.Text = dGW_SinhVien.Rows[index].Cells[4].Value.ToString();
                    tB_SDT.Text = dGW_SinhVien.Rows[index].Cells[5].Value.ToString();
                    tB_Email.Text = dGW_SinhVien.Rows[index].Cells[6].Value.ToString();
                    cB_Lop.Text = dGW_SinhVien.Rows[index].Cells[7].Value.ToString();
                }
                loadDataDiemSo();
                loadDataHocPhan();
            }
        }
        DateTime oldNgaySinh = DateTime.Now;
        private void Form_SinhVien_Load(object sender, EventArgs e)
        {
            LoadDataSINHVIEN();
            HienThi_CB_Lop();
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMaSV.Enabled = tB_Email.Enabled = false;
            flag = "add";
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = cB_Lop.Enabled = tB_HoTen.Enabled = tB_SDT.Enabled = cB_GioiTinh.Enabled = true;
            tB_DiaChi.Text = tB_HoTen.Text = tB_SDT.Text = tbMaSV.Text = tB_Email.Text = "";
            dTP_NgaySinh.Value = DateTime.Now;
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldHoten = tB_HoTen.Text.Trim();
            oldDiaChi = tB_DiaChi.Text.Trim();
            oldSDT = tB_SDT.Text.Trim();
            oldLop = cB_Lop.Text.Trim();
            oldNgaySinh = dTP_NgaySinh.Value;
            oldGioiTinh = cB_GioiTinh.Text.Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "delete";
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMaSV.Enabled = tB_Email.Enabled = false;
            flag = "edit";
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = cB_Lop.Enabled = tB_HoTen.Enabled = tB_SDT.Enabled = cB_GioiTinh.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldHoten = tB_HoTen.Text.Trim();
            oldDiaChi = tB_DiaChi.Text.Trim();
            oldSDT = tB_SDT.Text.Trim();
            oldLop = cB_Lop.Text.Trim();
            oldNgaySinh = dTP_NgaySinh.Value;
            oldGioiTinh = cB_GioiTinh.Text.Trim();
        }

        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!checkValidate(tB_HoTen, "Họ tên không được trống!"))
                return;
            if (!checkValidate(tB_SDT, "Số điện thoại không được trống!"))
                return;
            //Xử lý
            if (flag == "add")
            {
                string strLenh = "sp_ThemSinhVien";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@hoten", tB_HoTen.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaysinh", dTP_NgaySinh.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", cB_GioiTinh.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sodienthoai", tB_SDT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@lop", cB_Lop.SelectedValue.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Thêm sinh viên thành công!");
            }
            else if (flag == "edit")
            {
                string strLenh = "sp_CapNhatSinhVien";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@masv", tbMaSV.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@hoten", tB_HoTen.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaysinh", dTP_NgaySinh.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", cB_GioiTinh.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sodienthoai", tB_SDT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@lop", cB_Lop.SelectedValue.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Cập nhật sinh viên thành công!");
            }
            else if (flag == "delete")
            {
                string strLenh = "sp_XoaSinhVien";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@masv", tbMaSV.Text.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Xóa sinh viên thành công!");
            }
            LoadDataSINHVIEN();
            loadDataDiemSo();
            loadDataHocPhan();
            tbMaSV.Enabled = tB_Email.Enabled = false;
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = tbMaSV.Enabled = tB_HoTen.Enabled = tB_Email.Enabled = tB_SDT.Enabled = cB_GioiTinh.Enabled = cB_Lop.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_HoTen.Text = oldHoten;
            dTP_NgaySinh.Value = oldNgaySinh;
            cB_Lop.SelectedItem = oldLop;
            cB_GioiTinh.SelectedItem = oldGioiTinh;
            tB_DiaChi.Text = oldDiaChi;
            tB_SDT.Text = oldSDT;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGW_SinhVien.Refresh();
            dGV_HocPhan.Refresh();
            dGV_DiemSo.Refresh();
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = tbMaSV.Enabled = tB_HoTen.Enabled = tB_Email.Enabled = tB_SDT.Enabled = cB_GioiTinh.Enabled = cB_Lop.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }
        public Form_SinhVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = tbMaSV.Enabled = tB_HoTen.Enabled = tB_Email.Enabled = tB_SDT.Enabled = cB_GioiTinh.Enabled = cB_Lop.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
        }
        void LoadDataSINHVIEN()
        {
            string strLenh = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, TENLOP FROM SINHVIEN " +
                "JOIN LOP ON LOP.MALOP = SINHVIEN.LOP";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dt_SV = dt;
            dGW_SinhVien.DataSource = dt;
            dGW_SinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGW_SinhVien.Columns[0].HeaderText = "Mã SV";
            dGW_SinhVien.Columns[1].HeaderText = "Họ tên";
            dGW_SinhVien.Columns[2].HeaderText = "Ngày sinh";
            dGW_SinhVien.Columns[3].HeaderText = "Giới tính";
            dGW_SinhVien.Columns[4].HeaderText = "Địa chỉ";
            dGW_SinhVien.Columns[5].HeaderText = "Số điện thoại";
            dGW_SinhVien.Columns[6].HeaderText = "Email";
            dGW_SinhVien.Columns[7].HeaderText = "Lop";
        }
        void loadDataDiemSo()
        {
            string strLenh = "SELECT MASV, MAHP, HOCKY, NAMHOC, DIEM FROM DIEMSO WHERE MASV = '" + tbMaSV.Text.ToString().Trim() + "'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_DiemSo.DataSource = dt;
            dGV_DiemSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dGV_DiemSo.Columns[0].HeaderText = "Mã SV";
            dGV_DiemSo.Columns[1].HeaderText = "Mã học phần";
            dGV_DiemSo.Columns[2].HeaderText = "Học kỳ";
            dGV_DiemSo.Columns[3].HeaderText = "Năm học";
            dGV_DiemSo.Columns[4].HeaderText = "Điểm";
        }
        void loadDataHocPhan()
        {
            string strLenh = "SELECT  hp.MaHP, TenHP, SoTinChi, k.TenKhoa, PhongHoc, ChuongTrinhDaoTao " +
                "FROM HocPhan hp JOIN DKHP ds ON hp.MaHP = ds.MaHP JOIN Khoa k ON k.MaKhoa = hp.Khoa_BoMon " +
                "WHERE ds.MaSV = '" + tbMaSV.Text.ToString().Trim() + "'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_HocPhan.DataSource = dt;
            dGV_HocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dGV_HocPhan.Columns[0].HeaderText = "Mã học phần";
            dGV_HocPhan.Columns[1].HeaderText = "Tên học phần";
            dGV_HocPhan.Columns[2].HeaderText = "Số tín chỉ";
            dGV_HocPhan.Columns[3].HeaderText = "Tên khoa";
            dGV_HocPhan.Columns[4].HeaderText = "Phòng học";
            dGV_HocPhan.Columns[5].HeaderText = "Chương trình đào tạo";
        }
        private void HienThi_CB_Lop()
        {
            string lenh = "SELECT MALOP, TENLOP FROM LOP";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Lop.DataSource = bindingSource;
            cB_Lop.DisplayMember = "TENLOP";
            cB_Lop.ValueMember = "MALOP";
        }

    }
}
