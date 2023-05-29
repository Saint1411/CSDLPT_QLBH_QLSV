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
    public partial class Form_HoaDon : Form
    {
        int flag = 0;
        SqlConnection conn_Publisher = new SqlConnection();
        DataTable dt_NV = new DataTable();
        string oldSoHD = "", oldMaKH = "", oldMaNV = "", oldMaCN = "";
        double oldTongTG = 0;
        DateTime oldNgHD = DateTime.Now;
        string SoHD = "", MaSp = "";
        int soLuong = 0;
        double donGia = 0;

        public Form_HoaDon()
        {
            InitializeComponent();
            tB_SoHD.Enabled = dTP_NgayTao.Enabled = cB_MaKH.Enabled = cB_MaNV.Enabled = cB_MaCN.Enabled = tB_TongTG.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            if (KetNoiMayChu() == true)
                return;
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 1;
            tB_SoHD.Enabled = dTP_NgayTao.Enabled = cB_MaKH.Enabled = cB_MaNV.Enabled = tB_TongTG.Enabled = true;
            cB_MaCN.Enabled = false;
            cB_MaCN.Text = dt_NV.Rows[0]["MACN"].ToString().Trim();
            tB_SoHD.Text = dTP_NgayTao.Text = cB_MaKH.Text = cB_MaNV.Text = "";
            tB_TongTG.Text = "0";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldSoHD = tB_SoHD.Text.Trim();
            oldNgHD = dTP_NgayTao.Value;
            oldMaKH = cB_MaKH.Text.ToString().Trim();
            oldMaNV = cB_MaNV.Text.ToString().Trim();
            oldTongTG = double.Parse(tB_TongTG.Text.Trim());
            oldMaCN = cB_MaCN.Text.ToString().Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 2;
            tB_SoHD.Enabled = dTP_NgayTao.Enabled = cB_MaKH.Enabled = cB_MaNV.Enabled = cB_MaCN.Enabled = tB_TongTG.Enabled = false;
            sua_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 3;
            dTP_NgayTao.Enabled = cB_MaKH.Enabled = cB_MaNV.Enabled = cB_MaCN.Enabled = tB_TongTG.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldSoHD = tB_SoHD.Text.Trim();
            oldNgHD = dTP_NgayTao.Value;
            oldMaKH = cB_MaKH.Text.ToString().Trim();
            oldMaNV = cB_MaNV.Text.ToString().Trim();
            oldTongTG = double.Parse(tB_TongTG.Text.Trim());
            oldMaCN = cB_MaCN.Text.ToString().Trim();
        }

        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tB_SoHD, "Mã hóa đơn không được rỗng!")) return;
            if (!checkValidate(tB_TongTG, "Tổng trị giá không được rỗng!")) return;
            int n = 0;
            if (!int.TryParse(tB_SoHD.Text, out n))
            {
                MessageBox.Show("Mã hóa đơn phải là số", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tB_SoHD.Text.Contains(" "))
            {
                MessageBox.Show("Mã hóa đơn không được chứa khoảng trắng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkExistSoHD(Convert.ToInt32(tB_SoHD.Text.Trim())) && flag == 1)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (flag == 1)
                {
                    string strLenh = "sp_InsertHOADON";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@sohd", int.Parse(tB_SoHD.Text.Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@ngayhd", dTP_NgayTao.Value));
                    sqlCommand.Parameters.Add(new SqlParameter("@makh", cB_MaKH.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@manv", cB_MaNV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@tongtrigia", double.Parse(tB_TongTG.Text.Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@macn", cB_MaCN.SelectedValue.ToString().Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                    MessageBox.Show("Thêm hóa đơn thành công!");
                }
                else if (flag == 3)
                {
                    string strLenh = "sp_UpdateHOADON";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@sohd", int.Parse(tB_SoHD.Text.Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@ngayhd", dTP_NgayTao.Value));
                    sqlCommand.Parameters.Add(new SqlParameter("@makh", cB_MaKH.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@manv", cB_MaNV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@tongtrigia", double.Parse(tB_TongTG.Text.Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@macn", cB_MaCN.SelectedValue.ToString().Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                    MessageBox.Show("Cập nhật hóa đơn thành công!");
                }
                else if (flag == 2)
                {
                    if (dGV_CTHD.Rows[0].Cells[0].Value == null)
                    {
                        string strLenh = "sp_DeleteHOADON";
                        SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = 600;
                        sqlCommand.Parameters.Add(new SqlParameter("@sohd", int.Parse(tB_SoHD.Text.Trim())));
                        Program.ExecSQLCommand(sqlCommand);
                        MessageBox.Show("Xóa hóa đơn thành công!");
                    }
                    else
                        MessageBox.Show("Phải xóa chi tiết hóa đơn trước!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tB_SoHD.Enabled = dTP_NgayTao.Enabled = cB_MaKH.Enabled = cB_MaNV.Enabled = cB_MaCN.Enabled = tB_TongTG.Enabled = false;
                them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
                luu_ToolStripMenuItem.Enabled = false;
                LoadDataHoaDon();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_SoHD.Text = oldSoHD;
            dTP_NgayTao.Value = oldNgHD;
            cB_MaKH.SelectedValue = oldMaKH;
            cB_MaNV.SelectedValue = oldMaNV;
            tB_TongTG.Text = oldTongTG.ToString();
            cB_MaCN.SelectedValue = oldMaCN;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_HoaDon.Refresh();
            dGV_CTHD.Refresh();
            tB_SoHD.Enabled = dTP_NgayTao.Enabled = cB_MaKH.Enabled = cB_MaNV.Enabled = cB_MaCN.Enabled = tB_TongTG.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon();
            HienThi_CB_KhachHang();
            HienThi_CB_NhanVien();
            HienThi_CB_ChiNhanh();
        }
        
        public void LoadDataHoaDon()
        {
                string strLenh = "SELECT HOADON.SOHD, HOADON.NGHD, KHACHHANG.HOTEN AS TEN_KHACHHANG, NHANVIEN.HOTEN AS TEN_NHANVIEN," +
                    " HOADON.TONGTRIGIA, HOADON.MACN FROM HOADON JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH" +
                    " JOIN NHANVIEN ON HOADON.MANV = NHANVIEN.MANV";
                DataTable dt = Program.ExecSQLDataTable(strLenh);
                dt_NV = dt;
                dGV_HoaDon.DataSource = dt;
                dGV_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dGV_HoaDon.Columns[0].HeaderText = "Số hóa đơn";
                dGV_HoaDon.Columns[1].HeaderText = "Ngày tạo";
                dGV_HoaDon.Columns[2].HeaderText = "Tên khách hàng";
                dGV_HoaDon.Columns[3].HeaderText = "Nhân viên tạo";
                dGV_HoaDon.Columns[4].HeaderText = "Tổng trị giá";
                dGV_HoaDon.Columns[5].HeaderText = "Mã chi nhánh";
            foreach (DataGridViewRow row in dGV_HoaDon.Rows)
            {
                int tongTG = Convert.ToInt32(row.Cells[4].Value);
                row.Cells[4].Value = tongTG;

                if (row.Cells[2].Value != null)
                {
                    string tenKH = row.Cells[2].Value.ToString();
                    row.Cells[2].Value = tenKH;
                }
                else 
                    row.Cells[2].Value = "";

                if (row.Cells[3].Value != null)
                {
                    string tenNV = row.Cells[3].Value.ToString();
                    row.Cells[3].Value = tenNV;
                }
                else 
                    row.Cells[3].Value = "";
            }
        }

        public void LoadDataCTHD()
        {
            string strLenh = "SELECT CTHD.SOHD,  CTHD.MASP, CTHD.DONGIA, CTHD.SOLUONG FROM CTHD " +
                "JOIN SANPHAM ON SANPHAM.MASP = CTHD.MASP WHERE CTHD.SOHD = '" + tB_SoHD.Text.Trim() +"'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_CTHD.DataSource = dt;
            dGV_CTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_CTHD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV_CTHD.Columns[0].HeaderText = "Số hóa đơn";
            dGV_CTHD.Columns[1].HeaderText = "Sản phẩm";
            dGV_CTHD.Columns[2].HeaderText = "Đơn giá";
            dGV_CTHD.Columns[3].HeaderText = "Số lượng";
            foreach (DataGridViewRow row in dGV_CTHD.Rows)
            {
                int donGia = Convert.ToInt32(row.Cells[2].Value);
                row.Cells[2].Value = donGia;
                row.Cells[1].Value = row.Cells[1].Value?.ToString().Trim();
            }
        }

        private void dGV_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_HoaDon.CurrentCell != null)
            {
                int index = dGV_HoaDon.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_HoaDon.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_SoHD.Text = dGV_HoaDon.Rows[index].Cells[0].Value.ToString().Trim();
                    dTP_NgayTao.Text = dGV_HoaDon.Rows[index].Cells[1].Value.ToString().Trim();
                    cB_MaKH.Text = dGV_HoaDon.Rows[index].Cells[2].Value.ToString().Trim();
                    cB_MaNV.Text = dGV_HoaDon.Rows[index].Cells[3].Value.ToString().Trim();
                    tB_TongTG.Text = dGV_HoaDon.Rows[index].Cells[4].Value.ToString().Trim();
                    cB_MaCN.Text = dGV_HoaDon.Rows[index].Cells[5].Value.ToString().Trim();
                }
                LoadDataCTHD();
            } 
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
        private bool checkExistSoHD(int sohd)
        {
            DataTable dt = new DataTable();
            if (conn_Publisher.State == ConnectionState.Closed)
                conn_Publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SOHD FROM HOADON", conn_Publisher);
            da.Fill(dt);
            conn_Publisher.Close();
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow data in dt.Rows)
                {
                    int sohdGW = Convert.ToInt32(data["SOHD"].ToString());
                    if (sohdGW == sohd)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        private bool KetNoiMayChu()
        {
            if (conn_Publisher != null && conn_Publisher.State == ConnectionState.Open)
                conn_Publisher.Close();
            try
            {
                conn_Publisher.ConnectionString = Program.conString_Publisher;
                conn_Publisher.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về dữ liệu gốc");
                return false;
            }
        }
        private void dGV_CTHD_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            int pos_xy_mouse_row = dGV_CTHD.HitTest(e.X, e.Y).RowIndex;
            if (pos_xy_mouse_row < 0)
            {
                return;
            }

            ContextMenuStrip rightMenu = new ContextMenuStrip();
            rightMenu.Items.Add("Thêm").Name = "Thêm";
            rightMenu.Items.Add("Xóa").Name = "Xóa";
            rightMenu.Items.Add("Sửa").Name = "Sửa";
            dGV_CTHD.ClearSelection();
            dGV_CTHD.Rows[pos_xy_mouse_row].Selected = true;
            rightMenu.Show(dGV_CTHD, new Point(e.X, e.Y));

            rightMenu.ItemClicked += new ToolStripItemClickedEventHandler(rightMenu_ItemClicked);
        }

        private void dGV_CTHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_CTHD.CurrentCell != null)
            {
                int index = dGV_CTHD.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_CTHD.DataSource;
                if (dt.Rows.Count > 0)
                {
                    SoHD = dGV_CTHD.Rows[index].Cells[0].Value.ToString().Trim();
                    MaSp = dGV_CTHD.Rows[index].Cells[1].Value.ToString().Trim();
                    soLuong = int.Parse(dGV_CTHD.Rows[index].Cells[3].Value.ToString().Trim());
                    donGia = double.Parse(dGV_CTHD.Rows[index].Cells[2].Value.ToString().Trim());
                }
            }
        }

        public void rightMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form_CTHD frm = new Form_CTHD();
            if (e.ClickedItem.Name == "Thêm")
            {
                frm.luaChon = 1;
                frm.soHD = tB_SoHD.Text.Trim();
                frm.soLuong = 0;
                frm.donGia = 0;
                frm.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Sửa")
            {
                frm.luaChon = 3;
                frm.soHD = SoHD;
                frm.Masp = MaSp;
                frm.soLuong = soLuong;
                frm.donGia = donGia;
                frm.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Xóa")
            {
                frm.luaChon = 2;
                string strLenh = "sp_DeleteCTHD";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@sohd", int.Parse(tB_SoHD.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@masp", MaSp));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
            }
            LoadDataCTHD();
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
        private void HienThi_CB_KhachHang()
        {
            string lenh = "SELECT MAKH, HOTEN FROM KHACHHANG";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_MaKH.DataSource = bindingSource;
            cB_MaKH.DisplayMember = "HOTEN";
            cB_MaKH.ValueMember = "MAKH";
        }
        private void HienThi_CB_ChiNhanh()
        {
            string lenh = "SELECT MACN, TENCN FROM CHINHANH";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_MaCN.DataSource = bindingSource;
            cB_MaCN.DisplayMember = "TENCN";
            cB_MaCN.ValueMember = "MACN";
        }
    }
}
