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
    public partial class Form_SanPham : Form
    {
        DataTable dt_NV = new DataTable();
        string oldMaSP = "", oldTenSP = "", oldDVT = "", oldNocSX = "";
        double oldGiaBan = 0;
        int flag = 0;
        public Form_SanPham()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tb_MaSP.Enabled = tB_TenSP.Enabled = tB_DVT.Enabled = tB_NuocSX.Enabled = tB_GiaBan.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
        }
        private void Form_SanPham_Load(object sender, EventArgs e)
        {
            LoadDataSANPHAM();
        }
        void LoadDataSANPHAM()
        {
            string strLenh = "SELECT MASP, TENSP, DVT, NUOCSX, GIABAN FROM SANPHAM";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dt_NV = dt;
            dGW_SanPham.DataSource = dt;
            dGW_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGW_SanPham.Columns[0].HeaderText = "Mã SP";
            dGW_SanPham.Columns[1].HeaderText = "Tên SP";
            dGW_SanPham.Columns[2].HeaderText = "Đơn vị tính";
            dGW_SanPham.Columns[3].HeaderText = "Nước sản xuất";
            dGW_SanPham.Columns[4].HeaderText = "Giá bán";
            foreach (DataGridViewRow row in dGW_SanPham.Rows)
            {
                int luong = Convert.ToInt32(row.Cells[4].Value);
                row.Cells[4].Value = luong;
            }
        }

        private void dGW_SanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dGW_SanPham.CurrentCell != null)
            {
                int index = dGW_SanPham.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGW_SanPham.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tb_MaSP.Text = dGW_SanPham.Rows[index].Cells[0].Value.ToString();
                    tB_TenSP.Text = dGW_SanPham.Rows[index].Cells[1].Value.ToString();
                    tB_DVT.Text = dGW_SanPham.Rows[index].Cells[2].Value.ToString();
                    tB_NuocSX.Text = dGW_SanPham.Rows[index].Cells[3].Value.ToString();
                    tB_GiaBan.Text = dGW_SanPham.Rows[index].Cells[4].Value.ToString();
                }
            }
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 1;
            tb_MaSP.Enabled = tB_TenSP.Enabled = tB_DVT.Enabled = tB_NuocSX.Enabled = tB_GiaBan.Enabled = true;
            tb_MaSP.Text = tB_TenSP.Text = tB_DVT.Text = tB_NuocSX.Text = "";
            tB_GiaBan.Text = "0";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaSP = tb_MaSP.Text.Trim();
            oldTenSP = tB_TenSP.Text.Trim();
            oldDVT = tB_DVT.Text.Trim();
            oldNocSX = tB_NuocSX.Text.Trim();
            oldGiaBan = double.Parse(tB_GiaBan.Text.Trim());
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 2;
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 3;
            tb_MaSP.Enabled = tB_TenSP.Enabled = tB_DVT.Enabled = tB_NuocSX.Enabled = tB_GiaBan.Enabled = true;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaSP = tb_MaSP.Text.Trim();
            oldTenSP = tB_TenSP.Text.Trim();
            oldDVT = tB_DVT.Text.Trim();
            oldNocSX = tB_NuocSX.Text.Trim();
            oldGiaBan = double.Parse(tB_GiaBan.Text.Trim());
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
        private bool checkExistMaSP(string maSP)
        {
            foreach (DataRow data in dt_NV.Rows)
            {
                string maSPGV = data["MASP"].ToString();
                if (maSPGV.Trim() == maSP.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tb_MaSP, "Mã sản phẩm không được trống!"))
                return;
            if (!checkValidate(tB_TenSP, "Tên sản phẩm không được trống!"))
                return;
            if (!checkValidate(tB_DVT, "Đơn vị tính không được trống!"))
                return;
            if (!checkValidate(tB_NuocSX, "Nước sản xuất không được trống!"))
                return;
            if (tb_MaSP.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã nhân viên không được lớn hơn 4 ký tự", "Cảnh báo MaSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tB_GiaBan.Text.ToString().Trim() == "0")
            {
                MessageBox.Show("Đơn giá phải lớn hơn không", "Cảnh báo đơn giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tb_MaSP.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Mã sản phẩm không được chứa khoảng trắng", "Cảnh báo mã sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkExistMaSP(tb_MaSP.Text.Trim()) && flag == 1)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại", "Cảnh báo Mã SP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Xử lý
            if (flag == 1)
            {
                string strLenh = "sp_InsertSANPHAM";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@masp", tb_MaSP.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@tensp", tB_TenSP.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@dvt", tB_DVT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@nuocsx", tB_NuocSX.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", double.Parse(tB_GiaBan.Text.Trim())));
                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == 3)
            {
                string strLenh = "sp_UpdateSANPHAM";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@masp", tb_MaSP.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@tensp", tB_TenSP.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@dvt", tB_DVT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@nuocsx", tB_NuocSX.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", double.Parse(tB_GiaBan.Text.Trim())));
                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == 2)
            {
                string strLenh = "sp_DeleteSANPHAM";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@masp", tb_MaSP.Text.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
            }
            LoadDataSANPHAM();
            tb_MaSP.Enabled = tB_TenSP.Enabled = tB_DVT.Enabled = tB_NuocSX.Enabled = tB_GiaBan.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_MaSP.Text = oldMaSP;
            tB_TenSP.Text = oldTenSP;
            tB_DVT.Text = oldDVT;
            tB_NuocSX.Text = oldNocSX;
            tB_GiaBan.Text = oldGiaBan.ToString();
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGW_SanPham.Refresh();
            tb_MaSP.Enabled = tB_TenSP.Enabled = tB_DVT.Enabled = tB_NuocSX.Enabled = tB_GiaBan.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
