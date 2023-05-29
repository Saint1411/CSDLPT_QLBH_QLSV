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
    public partial class Form_Lop : Form
    {
        string oldMalop = "", oldTenLop = "";
        string flag = "";
        SqlConnection conn_Publisher = new SqlConnection();
        DataTable dt_SV = new DataTable();
        public Form_Lop()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tB_MaLop.Enabled = tB_TenLop.Enabled = tB_SoLuong.Enabled = cB_Khoa.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void Form_Lop_Load(object sender, EventArgs e)
        {
            loadData();
            HienThi_CB_Khoa();
        }

        private void dGV_Lop_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_Lop.CurrentCell != null)
            {
                int index = dGV_Lop.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_Lop.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_MaLop.Text = dGV_Lop.Rows[index].Cells[0].Value.ToString();
                    tB_TenLop.Text = dGV_Lop.Rows[index].Cells[1].Value.ToString();
                    tB_SoLuong.Text = dGV_Lop.Rows[index].Cells[2].Value.ToString();
                    cB_Khoa.Text = dGV_Lop.Rows[index].Cells[3].Value.ToString();
                }
            }
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_SoLuong.Enabled = false;
            tB_SoLuong.Text = "0";
            flag = "add";
            tB_MaLop.Enabled = tB_TenLop.Enabled = cB_Khoa.Enabled = true;
            tB_MaLop.Text = tB_TenLop.Text = "";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMalop = tB_MaLop.Text.Trim();
            oldTenLop = tB_TenLop.Text.Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "delete";
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_SoLuong.Enabled = false;
            flag = "edit";
            cB_Khoa.Enabled = tB_TenLop.Enabled = true;
            tB_MaLop.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMalop = tB_MaLop.Text.Trim();
            oldTenLop = tB_TenLop.Text.Trim();
        }

        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tB_MaLop, "Họ tên không được trống!"))
                return;
            if (!checkValidate(tB_TenLop, "Số điện thoại không được trống!"))
                return;
            try
            {
                if (flag == "add")
                {
                    string strLenh = "sp_Them_Lop";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@malop", tB_MaLop.Text.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@tenlop", tB_TenLop.Text.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@khoa", cB_Khoa.SelectedValue.ToString().Trim()));
                   
                    Program.ExecSQLCommand(sqlCommand);
                }
                else if (flag == "edit")
                {
                    string strLenh = "sp_CapNhat_Lop";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@malop", tB_MaLop.Text.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@tenlop", tB_TenLop.Text.ToString().Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@khoa", cB_Khoa.SelectedValue.ToString().Trim()));

                    Program.ExecSQLCommand(sqlCommand);
                }
                else if (flag == "delete")
                {
                    string strLenh = "sp_Xoa_Lop";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@malop", tB_MaLop.Text.ToString().Trim()));

                    Program.ExecSQLCommand(sqlCommand);
                }
                loadData();
                tB_MaLop.Enabled = tB_TenLop.Enabled = cB_Khoa.Enabled = tB_SoLuong.Enabled = false;
                them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
                luu_ToolStripMenuItem.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaLop.Text = oldMalop;
            tB_TenLop.Text = oldTenLop;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_Lop.Refresh();
            tB_MaLop.Enabled = tB_TenLop.Enabled = tB_SoLuong.Enabled = cB_Khoa.Enabled = false;
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
        
        void loadData()
        {
            string strLenh = "SELECT MALOP, TENLOP, SOLUONG, KHOA.TENKHOA FROM LOP " +
                "JOIN KHOA ON KHOA.MAKHOA = LOP.KHOA";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dt_SV = dt;
            dGV_Lop.DataSource = dt;
            dGV_Lop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Lop.Columns[0].HeaderText = "Mã Lớp";
            dGV_Lop.Columns[1].HeaderText = "Tên lớp";
            dGV_Lop.Columns[2].HeaderText = "Số lượng";
            dGV_Lop.Columns[3].HeaderText = "Khoa";
        }
        void HienThi_CB_Khoa()
        {
            string lenh = "SELECT Makhoa, TenKhoa FROM Khoa";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Khoa.DataSource = bindingSource;
            cB_Khoa.DisplayMember = "TenKhoa";
            cB_Khoa.ValueMember = "Makhoa";
        }
    }
}
