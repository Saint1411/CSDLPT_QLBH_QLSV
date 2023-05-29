using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CSDLPT_QuanLySinhVien
{
    public partial class Form_Khoa : Form
    {
        SqlConnection conn_publisher = new SqlConnection();
        DataTable dt = new DataTable();
        string flag = "";
        string oldMaKhoa = "",  oldTenKhoa = "";
        public Form_Khoa()
        {
            InitializeComponent();
        }

        private void Form_Khoa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadData();
            luu_ToolStripMenuItem.Enabled = false;
            tB_MaKhoa.Enabled = tB_TenKhoa.Enabled = false;
        }
        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckValidate(tB_MaKhoa, "Mã kho không được trống!"))
                return;
            if (!CheckValidate(tB_TenKhoa, "Tên khoa không được trống!"))
                return;
            if (tB_MaKhoa.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã khoa không được lớn hơn 4 ký tự", "Cảnh báo mã khoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tB_MaKhoa.Text.Contains(" "))
            {
                MessageBox.Show("Mã kho không được chứa khoảng trắng", "Cảnh báo mã kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CheckExistMaKho(tB_MaKhoa.Text) && flag == "add")
            {
                MessageBox.Show("Mã khoa đã tồn tại", "Cảnh báo mã khoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Xử lý
            if (flag == "add")
            {
                string strLenh = "sp_Insert_KHOA";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@makhoa", tB_MaKhoa.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@tenkhoa", tB_TenKhoa.Text.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == "edit")
            {
                string strLenh = "sp_Update_KHOA";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@makhoa", tB_MaKhoa.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@tenkhoa", tB_TenKhoa.Text.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == "delete")
            {
                string strLenh = "sp_Delete_KHOA";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@makhoa", tB_MaKhoa.Text.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
            }
            LoadData();
            tB_MaKhoa.Enabled = tB_TenKhoa.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
        }
        private void dGV_Khoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_Khoa.CurrentCell != null)
            {
                int index = dGV_Khoa.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_Khoa.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_MaKhoa.Text = dGV_Khoa.Rows[index].Cells[0].Value.ToString().Trim();
                    tB_TenKhoa.Text = dGV_Khoa.Rows[index].Cells[1].Value.ToString().Trim();
                }
            }
        }

        private void LoadData()
        {
            string strLenh = "SELECT MAKHOA, TENKHOA FROM KHOA";
            dt = Program.ExecSQLDataTable(strLenh);
            dGV_Khoa.DataSource = dt;
            dGV_Khoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Khoa.Columns[0].HeaderText = "Mã khoa";
            dGV_Khoa.Columns[1].HeaderText = "Tên khoa";
            conn_publisher.Close();
        }
        private bool CheckValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_TenKhoa.Enabled = tB_MaKhoa.Enabled = true;
            tB_TenKhoa.Text = tB_MaKhoa.Text = "";
            flag = "add";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaKhoa = tB_MaKhoa.Text.Trim();
            oldTenKhoa = tB_TenKhoa.Text.Trim();
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
            tB_MaKhoa.Enabled = tB_TenKhoa.Enabled = true;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMaKhoa = tB_MaKhoa.Text.Trim();
            oldTenKhoa = tB_TenKhoa.Text.Trim();
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaKhoa.Text = oldMaKhoa;
            tB_TenKhoa.Text = oldTenKhoa;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_Khoa.Refresh();
            LoadData();
            tB_TenKhoa.Enabled = tB_MaKhoa.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckExistMaKho(string makhoa)
        {
            foreach (DataRow row in dt.Rows)
            {
                string makhoaDGV = row["MaKhoa"].ToString();
                if (makhoaDGV.Trim() == makhoa.Trim())
                    return true;
            }
            return false;
        }
    }
}
