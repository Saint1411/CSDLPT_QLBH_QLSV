using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSDLPT_QuanLyBanHang
{
    public partial class Form_Kho : Form
    {
        SqlConnection conn_publisher = new SqlConnection();
        DataTable dt = new DataTable();
        string flag = "";
        string oldMaKho = "", oldDiachi = "", oldCN = "";
        public Form_Kho()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string strLenh = "SELECT MAKHO, DIACHI, MACN FROM KHO";
            dt = Program.ExecSQLDataTable(strLenh);
            dGV_Kho.DataSource = dt;
            dGV_Kho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Kho.Columns[0].HeaderText = "Mã kho";
            dGV_Kho.Columns[1].HeaderText = "Địa chỉ";
            dGV_Kho.Columns[2].HeaderText = "Mã chi nhánh";
            conn_publisher.Close();
        }
        private void Form_Kho_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadData();
            Luu_ToolStripMenuItem.Enabled = false;
            tB_MaKho.Enabled = tB_DiaChi.Enabled = tB_ChiNhanh.Enabled = false;

        }

        private void dGV_Kho_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_Kho.CurrentCell != null)
            {
                int index = dGV_Kho.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_Kho.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_MaKho.Text = dGV_Kho.Rows[index].Cells[0].Value.ToString().Trim();
                    tB_DiaChi.Text = dGV_Kho.Rows[index].Cells[1].Value.ToString().Trim();
                    tB_ChiNhanh.Text = dGV_Kho.Rows[index].Cells[2].Value.ToString().Trim();
                }
            }
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaKho.Enabled = tB_DiaChi.Enabled = tB_ChiNhanh.Enabled = true;
            tB_MaKho.Text = tB_DiaChi.Text = tB_ChiNhanh.Text = "";
            flag = "add";
            tB_ChiNhanh.Enabled = false;
            tB_ChiNhanh.Text = dt.Rows[0]["MaCN"].ToString().Trim();
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            Luu_ToolStripMenuItem.Enabled = true;

            oldMaKho = tB_MaKho.Text.Trim();
            oldDiachi = tB_DiaChi.Text.Trim();
            oldCN = tB_ChiNhanh.Text.Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "delete";
            themToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            Luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "edit";
            tB_MaKho.Enabled = tB_DiaChi.Enabled = true;
            tB_ChiNhanh.Enabled = false;
            themToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = false;
            Luu_ToolStripMenuItem.Enabled = true;

            oldMaKho = tB_MaKho.Text.Trim();
            oldDiachi = tB_DiaChi.Text.Trim();
            oldCN = tB_ChiNhanh.Text.Trim();
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
        private bool CheckExistMaKho(string makho)
        {
            foreach (DataRow row in dt.Rows)
            {
                string makhoDGV = row["MaKho"].ToString();
                if (makhoDGV.Trim() == makho.Trim())
                    return true;
            }
            return false;
        }
        private void Luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!CheckValidate(tB_MaKho, "Mã kho không được trống!"))
                return;
            if (!CheckValidate(tB_DiaChi, "Địa chỉ không được trống!"))
                return;
            if (tB_MaKho.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã kho không được lớn hơn 4 ký tự", "Cảnh báo mã kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tB_MaKho.Text.Contains(" "))
            {
                MessageBox.Show("Mã kho không được chứa khoảng trắng", "Cảnh báo mã kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CheckExistMaKho(tB_MaKho.Text) && flag == "add")
            {
                MessageBox.Show("Mã kho đã tồn tại", "Cảnh báo mã kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Xử lý
            if (flag == "add")
            {
                string strLenh = "sp_InsertKHO";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@makho", tB_MaKho.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@macn", tB_ChiNhanh.Text.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == "edit")
            {
                string strLenh = "sp_UpdateKHO";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@makho", tB_MaKho.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@macn", tB_ChiNhanh.Text.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
            }
            else if (flag == "delete")
            {
                string strLenh = "sp_DeleteKHO";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@makho", tB_MaKho.Text.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
            }
            LoadData();
            tB_MaKho.Enabled = tB_DiaChi.Enabled = tB_ChiNhanh.Enabled = false;
            themToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            Luu_ToolStripMenuItem.Enabled = false;
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaKho.Text = oldMaKho;
            tB_ChiNhanh.Text = oldCN;
            tB_DiaChi.Text = oldDiachi;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_Kho.Refresh();
            LoadData();
            tB_MaKho.Enabled = tB_DiaChi.Enabled = tB_ChiNhanh.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = themToolStripMenuItem.Enabled = true;

        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
