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

namespace CSDLPT_QuanLyBanHang
{
    public partial class Form_NhanVien : Form
    {
        string flag = "";
        DataTable dt_NV = new DataTable();
        string oldMaCN = "", oldMaNV = "", oldHoten = "", oldDiaChi = "", oldSDT = "", oldLuong = "";
        DateTime oldNgaySinh = DateTime.Now, oldNVL = DateTime.Now;
        public Form_NhanVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = tbMaNV.Enabled = tB_HoTen.Enabled = tB_Luong.Enabled = tB_SDT.Enabled = tB_MaCN.Enabled = dTP_NGVL.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataNHANVIEN();
        }
        void LoadDataNHANVIEN()
        {
            string strLenh = "SELECT MANV, HOTEN, DIACHI, SODT, NGAYSINH, NGAYVL, LUONG, MACN FROM NHANVIEN";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dt_NV = dt;
            dGW_NhanVien.DataSource = dt;
            dGW_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGW_NhanVien.Columns[0].HeaderText = "Mã NV";
            dGW_NhanVien.Columns[1].HeaderText = "Họ tên";
            dGW_NhanVien.Columns[2].HeaderText = "Địa chỉ";
            dGW_NhanVien.Columns[3].HeaderText = "Số điện thoại";
            dGW_NhanVien.Columns[4].HeaderText = "Ngày sinh";
            dGW_NhanVien.Columns[5].HeaderText = "Ngày vào làm";
            dGW_NhanVien.Columns[6].HeaderText = "lương";
            foreach (DataGridViewRow row in dGW_NhanVien.Rows)
            {
                int luong = Convert.ToInt32(row.Cells[6].Value);
                row.Cells[6].Value = luong;
            }
            dGW_NhanVien.Columns[7].HeaderText = "Mã CN";
        }
        void LoadDataPHIEUNHAP()
        {
            string strLenh = "SELECT MAPN, NGAYNHAP, MANCC, MANV, MAKHO FROM PHIEUNHAP WHERE MANV = '" + tbMaNV.Text.ToString().Trim() +"'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_PhieuNhap.DataSource = dt;
            dGV_PhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dGV_PhieuNhap.Columns[0].HeaderText = "Mã phiếu nhập";
            dGV_PhieuNhap.Columns[1].HeaderText = "Ngày nhập";
            dGV_PhieuNhap.Columns[2].HeaderText = "Mã nhà cung cấp";
            dGV_PhieuNhap.Columns[3].HeaderText = "Mã nhân viên";
            dGV_PhieuNhap.Columns[4].HeaderText = "Mã kho";
        }
        void LoadDataHOADON()
        {
            string strLenh = "SELECT SOHD, NGHD, MAKH, MANV, TONGTRIGIA, MACN FROM HOADON WHERE MANV = '" + tbMaNV.Text.ToString().Trim() +"'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_HoaDon.DataSource = dt;
            dGV_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dGV_HoaDon.Columns[0].HeaderText = "Số hóa đơn";
            dGV_HoaDon.Columns[1].HeaderText = "Ngày hóa đơn";
            dGV_HoaDon.Columns[2].HeaderText = "Mã khách hàng";
            dGV_HoaDon.Columns[3].HeaderText = "Mã nhân viên";
            dGV_HoaDon.Columns[4].HeaderText = "Tổng trị giá";
            foreach (DataGridViewRow row in dGV_HoaDon.Rows)
            {
                int tongTriGia = Convert.ToInt32(row.Cells[4].Value);
                row.Cells[4].Value = tongTriGia;
            }
            dGV_HoaDon.Columns[5].HeaderText = "Mã chi nhánh";
        }

        private void dGW_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dGW_NhanVien.CurrentCell != null)
            {
                int index = dGW_NhanVien.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGW_NhanVien.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tbMaNV.Text = dGW_NhanVien.Rows[index].Cells[0].Value.ToString();
                    tB_HoTen.Text = dGW_NhanVien.Rows[index].Cells[1].Value.ToString();
                    tB_DiaChi.Text = dGW_NhanVien.Rows[index].Cells[2].Value.ToString();
                    tB_SDT.Text = dGW_NhanVien.Rows[index].Cells[3].Value.ToString();
                    dTP_NgaySinh.Text = dGW_NhanVien.Rows[index].Cells[4].Value.ToString();
                    dTP_NGVL.Text = dGW_NhanVien.Rows[index].Cells[5].Value.ToString();
                    tB_Luong.Text = dGW_NhanVien.Rows[index].Cells[6].Value.ToString();
                    tB_MaCN.Text = dGW_NhanVien.Rows[index].Cells[7].Value.ToString();
                }
                LoadDataHOADON();
                LoadDataPHIEUNHAP();
            }
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "add";
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = tbMaNV.Enabled = tB_HoTen.Enabled = tB_Luong.Enabled = tB_SDT.Enabled = dTP_NGVL.Enabled = true;
            tB_MaCN.Enabled = false;
            tB_DiaChi.Text = tbMaNV.Text = tB_HoTen.Text = tB_Luong.Text = tB_SDT.Text = "";
            dTP_NGVL.Value = DateTime.Now;
            tB_MaCN.Text = dt_NV.Rows[0]["MACN"].ToString().Trim();
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaNV = tbMaNV.Text.Trim();
            oldHoten = tB_HoTen.Text.Trim();
            oldDiaChi = tB_DiaChi.Text.Trim();
            oldSDT = tB_SDT.Text.Trim();
            oldLuong = tB_Luong.Text.Trim();
            oldNVL = dTP_NGVL.Value;
            oldNgaySinh = dTP_NgaySinh.Value;
            oldMaCN = tB_MaCN.Text.Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "delete";
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "edit";
            dTP_NgaySinh.Enabled = tbMaNV.Enabled = tB_HoTen.Enabled = tB_Luong.Enabled = tB_SDT.Enabled = dTP_NGVL.Enabled = tB_DiaChi.Enabled = true;
            tB_MaCN.Enabled = false;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaNV = tbMaNV.Text.Trim();
            oldHoten = tB_HoTen.Text.Trim();
            oldDiaChi = tB_DiaChi.Text.Trim();
            oldSDT = tB_SDT.Text.Trim();
            oldLuong = tB_Luong.Text.Trim();
            oldNVL = dTP_NGVL.Value;
            oldNgaySinh = dTP_NgaySinh.Value;
            oldMaCN = tB_MaCN.Text.Trim();
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
        private bool checkExistMaNV(string manv)
        {
            foreach(DataRow data in dt_NV.Rows)
            {
                string manvGV = data["MaNV"].ToString();
                if(manvGV.Trim() == manv.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaNV, "Mã nhân viên không được trống!"))
                return;
            if (!checkValidate(tB_HoTen, "Họ tên không được trống!"))
                return;
            if (!checkValidate(tB_SDT, "Số điện thoại không được trống!"))
                return;
            if (!checkValidate(tB_Luong, "Số điện thoại không được trống!"))
                return;
            if (tbMaNV.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được lớn hơn 10 ký tự", "Cảnh báo MaNV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbMaNV.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Mã nhân viên không được chứa khoảng trắng", "Cảnh báo mã NV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkExistMaNV(tbMaNV.Text.Trim()) && flag == "add")
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Cảnh báo Mã NV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Xử lý
            if (flag == "add")
            {
                string strLenh = "sp_InsertNHANVIEN";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@manv", tbMaNV.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@hoten", tB_HoTen.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sodt", tB_SDT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaysinh", dTP_NgaySinh.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@luong", tB_Luong.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayvl", dTP_NGVL.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@macn", tB_MaCN.Text.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == "edit")
            {
                string strLenh = "sp_UpdateNHANVIEN";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@manv", tbMaNV.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@hoten", tB_HoTen.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sodt", tB_SDT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaysinh", dTP_NgaySinh.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@luong", tB_Luong.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayvl", dTP_NGVL.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@macn", tB_MaCN.Text.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == "delete")
            {
                string strLenh = "sp_DeteleNHANVIEN";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@manv", tbMaNV.Text.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
            }
            LoadDataNHANVIEN();
            LoadDataHOADON();
            LoadDataPHIEUNHAP();
            dTP_NgaySinh.Enabled = tB_DiaChi.Enabled = tbMaNV.Enabled = tB_HoTen.Enabled = tB_Luong.Enabled = tB_SDT.Enabled = tB_MaCN.Enabled = dTP_NGVL.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMaNV.Text = oldMaNV;
            tB_HoTen.Text = oldHoten;
            tB_DiaChi.Text = oldDiaChi;
            tB_SDT.Text = oldSDT;
            tB_Luong.Text = oldLuong;
            dTP_NGVL.Value = oldNVL;
            dTP_NgaySinh.Value = oldNgaySinh;
            tB_MaCN.Text = oldMaCN;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGW_NhanVien.Refresh();
            dGV_HoaDon.Refresh();
            dGV_PhieuNhap.Refresh();
            tbMaNV.Enabled = tB_HoTen.Enabled = tB_Luong.Enabled = tB_SDT.Enabled = tB_MaCN.Enabled = dTP_NGVL.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
