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
    public partial class Form_PhieuNhap : Form
    {
        int flag = 0;
        SqlConnection conn_Publisher = new SqlConnection();
        DataTable dt_NV = new DataTable();
        string oldMaPN = "", oldMaNCC = "", oldMaNV = "", oldMaKho = "";
        DateTime oldNgNhap = DateTime.Now;
        string MaPN = "", MaSp = "";
        int soLuong = 0;
        double donGia = 0;
        public Form_PhieuNhap()
        {
            InitializeComponent();
            tB_MaPN.Enabled = dTP_NgayNhap.Enabled = cB_MaNV.Enabled = cB_MaNCC.Enabled = cB_MaKho.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            if (KetNoiMayChu() == true)
                return;
        }
        
        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 1;
            tB_MaPN.Enabled = dTP_NgayNhap.Enabled = cB_MaNCC.Enabled = cB_MaNV.Enabled = cB_MaKho.Enabled = true;
            cB_MaKho.Enabled = true;
            cB_MaKho.Text = tB_MaPN.Text = dTP_NgayNhap.Text = cB_MaNCC.Text = cB_MaNV.Text = "";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaPN = tB_MaPN.Text.Trim();
            oldNgNhap = dTP_NgayNhap.Value;
            oldMaNCC = cB_MaNCC.Text.ToString().Trim();
            oldMaNV = cB_MaNV.Text.ToString().Trim();
            oldMaKho = cB_MaKho.Text.ToString().Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 2;
            tB_MaPN.Enabled = dTP_NgayNhap.Enabled = cB_MaNCC.Enabled = cB_MaNV.Enabled = cB_MaKho.Enabled = false;
            sua_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 3;
            dTP_NgayNhap.Enabled = cB_MaNCC.Enabled = cB_MaNV.Enabled = cB_MaKho.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaPN = tB_MaPN.Text.Trim();
            oldNgNhap = dTP_NgayNhap.Value;
            oldMaNCC = cB_MaNCC.Text.ToString().Trim();
            oldMaNV = cB_MaNV.Text.ToString().Trim();
            oldMaKho = cB_MaKho.Text.ToString().Trim();
        }

        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tB_MaPN, "Mã phiếu nhập không được rỗng!")) return;
            int n = 0;
            if (!int.TryParse(tB_MaPN.Text, out n))
            {
                MessageBox.Show("Mã phiếu nhập phải là số", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tB_MaPN.Text.Contains(" "))
            {
                MessageBox.Show("Mã phiếu nhâp không được chứa khoảng trắng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkExistMaPN(Convert.ToInt32(tB_MaPN.Text.Trim())) && flag == 1)
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (flag == 1)
                {
                    string strLenh = "sp_InsertPHIEUNHAP";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@mapn", int.Parse(tB_MaPN.Text.Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@ngaynhap", dTP_NgayNhap.Value));
                    sqlCommand.Parameters.Add(new SqlParameter("@mancc", cB_MaNCC.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@manv", cB_MaNV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@makho", cB_MaKho.SelectedValue.ToString().Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                    MessageBox.Show("Thêm phiếu nhập thành công!");
                }
                else if (flag == 3)
                {
                    string strLenh = "sp_UpdatePHIEUNHAP";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@mapn", int.Parse(tB_MaPN.Text.Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@ngaynhap", dTP_NgayNhap.Value));
                    sqlCommand.Parameters.Add(new SqlParameter("@mancc", cB_MaNCC.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@manv", cB_MaNV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@makho", cB_MaKho.SelectedValue.ToString().Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                    MessageBox.Show("Sửa phiếu nhập thành công!");
                }
                else if (flag == 2)
                {
                    if (dGV_CTPN.Rows[0].Cells[0].Value == null)
                    {
                        string strLenh = "sp_DeletePHIEUNHAP";
                        SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = 600;
                        sqlCommand.Parameters.Add(new SqlParameter("@mapn", int.Parse(tB_MaPN.Text.Trim())));
                        Program.ExecSQLCommand(sqlCommand);
                        MessageBox.Show("Xóa phiếu nhập thành công!");
                    }
                    else
                        MessageBox.Show("Phải xóa chi tiết phiếu nhập trước!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tB_MaPN.Enabled = dTP_NgayNhap.Enabled = cB_MaNCC.Enabled = cB_MaNV.Enabled = cB_MaKho.Enabled = false;
                them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
                luu_ToolStripMenuItem.Enabled = false;
                LoadDataPHIEUNHAP();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }
       
        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaPN.Text = oldMaPN;
            dTP_NgayNhap.Value = oldNgNhap;
            cB_MaNCC.SelectedValue = oldMaNCC;
            cB_MaNV.SelectedValue = oldMaNV;
            cB_MaKho.SelectedValue = oldMaKho;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_CTPN.Refresh();
            dGV_PhieuNhap.Refresh();
            tB_MaPN.Enabled = dTP_NgayNhap.Enabled = cB_MaNV.Enabled = cB_MaNCC.Enabled = cB_MaKho.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDataPHIEUNHAP();
            HienThi_CB_NhanVien();
            HienThi_CB_NhaCungCap();
            HienThi_CB_Kho();
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
        private bool checkExistMaPN(int mapn)
        {
            DataTable dt = new DataTable();
            if (conn_Publisher.State == ConnectionState.Closed)
                conn_Publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAPN FROM PHIEUNHAP", conn_Publisher);
            da.Fill(dt);
            conn_Publisher.Close();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow data in dt.Rows)
                {
                    int mapnGW = Convert.ToInt32(data["MAPN"].ToString());
                    if (mapnGW == mapn)
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
        private void HienThi_CB_NhaCungCap()
        {
            string lenh = "SELECT MANCC, TENNCC FROM NHACC";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_MaNCC.DataSource = bindingSource;
            cB_MaNCC.DisplayMember = "TENNCC";
            cB_MaNCC.ValueMember = "MANCC";
        }
        private void HienThi_CB_Kho()
        {
            string lenh = "SELECT MAKHO, DIACHI FROM KHO";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_MaKho.DataSource = bindingSource;
            cB_MaKho.DisplayMember = "DIACHI";
            cB_MaKho.ValueMember = "MAKHO";
        }
        private void dGV_CTPN_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            int pos_xy_mouse_row = dGV_CTPN.HitTest(e.X, e.Y).RowIndex;
            if (pos_xy_mouse_row < 0)
            {
                return;
            }

            ContextMenuStrip rightMenu = new ContextMenuStrip();
            rightMenu.Items.Add("Thêm").Name = "Thêm";
            rightMenu.Items.Add("Xóa").Name = "Xóa";
            rightMenu.Items.Add("Sửa").Name = "Sửa";
            dGV_CTPN.ClearSelection();
            dGV_CTPN.Rows[pos_xy_mouse_row].Selected = true;
            rightMenu.Show(dGV_CTPN, new Point(e.X, e.Y));

            rightMenu.ItemClicked += new ToolStripItemClickedEventHandler(rightMenu_ItemClicked);
        }
        public void rightMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form_CTPN frm = new Form_CTPN();
            if (e.ClickedItem.Name == "Thêm")
            {
                frm.luaChon = 1;
                frm.MaPN = tB_MaPN.Text.Trim();
                frm.soLuong = 0;
                frm.donGia = 0;
                frm.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Sửa")
            {
                frm.luaChon = 3;
                frm.MaPN = MaPN;
                frm.Masp = MaSp;
                frm.soLuong = soLuong;
                frm.donGia = donGia;
                frm.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Xóa")
            {
                frm.luaChon = 2;
                string strLenh = "sp_DeleteCTPN";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@mapn", int.Parse(tB_MaPN.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@masp", MaSp));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Xóa chi tiết phiếu nhập thành công!");
            }
            LoadDataCTPN();
        }
        private void LoadDataPHIEUNHAP()
        {
            SqlCommand cmd = new SqlCommand("sp_GetListPHIEUNHAP", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt_NV = dt;
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            dGV_PhieuNhap.DataSource = dt;
            dGV_PhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_PhieuNhap.Columns[0].HeaderText = "Mã PN";
            dGV_PhieuNhap.Columns[1].HeaderText = "Ngày nhập";
            dGV_PhieuNhap.Columns[2].HeaderText = "Nhà cung cấp";
            dGV_PhieuNhap.Columns[3].HeaderText = "Nhân viên";
            dGV_PhieuNhap.Columns[4].HeaderText = "Mã kho";
            foreach (DataGridViewRow row in dGV_PhieuNhap.Rows)
            {
                if (row.Cells[2].Value != null)
                    row.Cells[2].Value = row.Cells[2].Value?.ToString().Trim();
                else
                    row.Cells[2].Value = "";
            }
        }
        private void LoadDataCTPN()
        {
            string strLenh = "SELECT CTPN.MAPN,  CTPN.MASP, CTPN.SOLUONG, CTPN.DONGIANHAP FROM CTPN " +
                "JOIN SANPHAM ON SANPHAM.MASP = CTPN.MASP WHERE CTPN.MAPN = '" + tB_MaPN.Text.Trim() + "'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_CTPN.DataSource = dt;
            dGV_CTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_CTPN.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV_CTPN.Columns[0].HeaderText = "Mã PN";
            dGV_CTPN.Columns[1].HeaderText = "Sản phẩm";
            dGV_CTPN.Columns[2].HeaderText = "Số lượng";
            dGV_CTPN.Columns[3].HeaderText = "Đơn giá nhập";
            foreach (DataGridViewRow row in dGV_CTPN.Rows)
            {
                int donGia = Convert.ToInt32(row.Cells[3].Value);
                row.Cells[3].Value = donGia;
                row.Cells[1].Value = row.Cells[1].Value?.ToString().Trim();
            }
        }
        private void dGV_PhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_PhieuNhap.CurrentCell != null)
            {
                int index = dGV_PhieuNhap.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_PhieuNhap.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_MaPN.Text = dGV_PhieuNhap.Rows[index].Cells[0].Value.ToString().Trim();
                    dTP_NgayNhap.Text = dGV_PhieuNhap.Rows[index].Cells[1].Value.ToString().Trim();
                    cB_MaNCC.Text = dGV_PhieuNhap.Rows[index].Cells[2].Value.ToString().Trim();
                    cB_MaNV.Text = dGV_PhieuNhap.Rows[index].Cells[3].Value.ToString().Trim();
                    cB_MaKho.Text = dGV_PhieuNhap.Rows[index].Cells[4].Value.ToString().Trim();
                }
                LoadDataCTPN();
            }
        }
        private void dGV_CTPN_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_CTPN.CurrentCell != null)
            {
                int index = dGV_CTPN.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_CTPN.DataSource;
                if (dt.Rows.Count > 0)
                {
                    MaPN = dGV_CTPN.Rows[index].Cells[0].Value.ToString().Trim();
                    MaSp = dGV_CTPN.Rows[index].Cells[1].Value.ToString().Trim();
                    soLuong = int.Parse(dGV_CTPN.Rows[index].Cells[2].Value.ToString().Trim());
                    donGia = double.Parse(dGV_CTPN.Rows[index].Cells[3].Value.ToString().Trim());
                }
            }
        }

    }
}
