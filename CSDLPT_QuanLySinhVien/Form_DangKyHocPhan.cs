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
    public partial class Form_DangKyHocPhan : Form
    {
        string flag = "";
        public Form_DangKyHocPhan()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            cB_MaSV.Enabled = cB_HocKy.Enabled = cB_TrangThai.Enabled = cB_HocPhan.Enabled = cB_NamHoc.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void Form_DangKyHocPhan_Load(object sender, EventArgs e)
        {
            loadData();
            HienThi_CB_SinhVien();
            HienThi_CB_HocPhan();
        }

        private void dGV_DKHP_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_DKHP.CurrentCell != null)
            {
                int index = dGV_DKHP.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_DKHP.DataSource;
                if (dt.Rows.Count > 0)
                {
                    cB_HocPhan.Text = dGV_DKHP.Rows[index].Cells[0].Value.ToString();
                    cB_MaSV.Text = dGV_DKHP.Rows[index].Cells[1].Value.ToString();
                    cB_HocKy.Text = dGV_DKHP.Rows[index].Cells[2].Value.ToString();
                    cB_NamHoc.Text = dGV_DKHP.Rows[index].Cells[3].Value.ToString();
                    cB_TrangThai.Text = dGV_DKHP.Rows[index].Cells[4].Value.ToString();
                }
            }
        }
        void loadData()
        {
            string strLenh = "SELECT TenHP, HoTen, HocKy, NamHoc, TrangThai  FROM DKHP DK JOIN HocPhan HP ON HP.MaHP = DK.MaHP" +
                             " JOIN SinhVien SV ON SV.MaSV = DK.MaSV";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_DKHP.DataSource = dt;
            dGV_DKHP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_DKHP.Columns[0].HeaderText = "Học phần";
            dGV_DKHP.Columns[1].HeaderText = "Sinh viên";
            dGV_DKHP.Columns[2].HeaderText = "Học kỳ";
            dGV_DKHP.Columns[3].HeaderText = "Năm học";
            dGV_DKHP.Columns[4].HeaderText = "Trạng thái";
        }
        void HienThi_CB_SinhVien()
        {
            string lenh = "SELECT MASV, HOTEN FROM SINHVIEN";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_MaSV.DataSource = bindingSource;
            cB_MaSV.DisplayMember = "HOTEN";
            cB_MaSV.ValueMember = "MASV";
        }

        void HienThi_CB_HocPhan()
        {
            string lenh = "SELECT MAHP, TENHP FROM HOCPHAN";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_HocPhan.DataSource = bindingSource;
            cB_HocPhan.DisplayMember = "TENHP";
            cB_HocPhan.ValueMember = "MAHP";
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "add";
            cB_MaSV.Enabled = cB_HocPhan.Enabled = cB_HocKy.Enabled = cB_NamHoc.Enabled = cB_TrangThai.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
            cB_TrangThai.SelectedIndex = 0;
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "delete";
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cB_MaSV.Enabled = cB_HocPhan.Enabled = false;
            flag = "edit";
            cB_HocKy.Enabled = cB_NamHoc.Enabled = cB_TrangThai.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }
        private bool checkValidate(ComboBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(cB_MaSV, "Sinh viên không được trống!"))
                return;
            if (!checkValidate(cB_HocPhan, "Học phần không được trống!"))
                return;
            if (!checkValidate(cB_HocKy, "Học phần không được trống!"))
                return;
            if (!checkValidate(cB_NamHoc, "Học phần không được trống!"))
                return;
            try
            {
                if (flag == "add")
                {
                    string strLenh = "sp_Them_DKHP";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@masv", cB_MaSV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@mahp", cB_HocPhan.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@hocky", int.Parse(cB_HocKy.Text.ToString().Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@namhoc", int.Parse(cB_NamHoc.Text.ToString().Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@trangthai", cB_TrangThai.Text.ToString().Trim()));

                    Program.ExecSQLCommand(sqlCommand);
                }
                else if (flag == "edit")
                {
                    string strLenh = "sp_CapNhat_DKHP";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@masv", cB_MaSV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@mahp", cB_HocPhan.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@hocky", int.Parse(cB_HocKy.Text.ToString().Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@namhoc", int.Parse(cB_NamHoc.Text.ToString().Trim())));
                    sqlCommand.Parameters.Add(new SqlParameter("@trangthai", cB_TrangThai.Text.ToString().Trim()));

                    Program.ExecSQLCommand(sqlCommand);
                }
                else if (flag == "delete")
                {
                    string strLenh = "sp_Xoa_DKHP";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@masv", cB_MaSV.SelectedValue.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@mahp", cB_HocPhan.SelectedValue.ToString().Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                }
                loadData();
                cB_MaSV.Enabled = cB_HocKy.Enabled = cB_HocPhan.Enabled = cB_NamHoc.Enabled = cB_TrangThai.Enabled = false;
                them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
                luu_ToolStripMenuItem.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_DKHP.Refresh();
            cB_MaSV.Enabled = cB_HocPhan.Enabled = cB_NamHoc.Enabled = cB_HocKy.Enabled  = cB_TrangThai.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
