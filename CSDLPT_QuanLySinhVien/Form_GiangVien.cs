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
    public partial class Form_GiangVien : Form
    {
        string flag = "";
        DataTable dt_SV = new DataTable();
        string oldKhoa = "", oldHoten = "", oldDiaChi = "", oldSDT = "";
        public Form_GiangVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tB_MaGV.Enabled = tB_DiaChi.Enabled = tB_HoTen.Enabled = tB_Email.Enabled = tB_SDT.Enabled = cB_Khoa.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void dGV_GiangVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_GiangVien.CurrentCell != null)
            {
                int index = dGV_GiangVien.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_GiangVien.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_MaGV.Text = dGV_GiangVien.Rows[index].Cells[0].Value.ToString();
                    tB_HoTen.Text = dGV_GiangVien.Rows[index].Cells[1].Value.ToString();
                    tB_DiaChi.Text = dGV_GiangVien.Rows[index].Cells[2].Value.ToString();
                    tB_SDT.Text = dGV_GiangVien.Rows[index].Cells[3].Value.ToString();
                    tB_Email.Text = dGV_GiangVien.Rows[index].Cells[4].Value.ToString();
                    cB_Khoa.Text = dGV_GiangVien.Rows[index].Cells[5].Value.ToString();
                }
            }
        }
        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaGV.Enabled = tB_Email.Enabled = false;
            flag = "add";
            tB_HoTen.Enabled = tB_DiaChi.Enabled = tB_SDT.Enabled = cB_Khoa.Enabled = true;
            tB_DiaChi.Text = tB_HoTen.Text = tB_SDT.Text = tB_MaGV.Text = tB_Email.Text = "";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldHoten = tB_HoTen.Text.Trim();
            oldDiaChi = tB_DiaChi.Text.Trim();
            oldSDT = tB_SDT.Text.Trim();
            oldKhoa = cB_Khoa.Text.Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = "delete";
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaGV.Enabled = tB_Email.Enabled = false;
            flag = "edit";
            tB_DiaChi.Enabled = cB_Khoa.Enabled = tB_HoTen.Enabled = tB_SDT.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldHoten = tB_HoTen.Text.Trim();
            oldDiaChi = tB_DiaChi.Text.Trim();
            oldSDT = tB_SDT.Text.Trim();
            oldKhoa = cB_Khoa.Text.Trim();
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
                string strLenh = "sp_Them_GiangVien";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@hoten", tB_HoTen.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sodienthoai", tB_SDT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@makhoa", cB_Khoa.SelectedValue.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Thêm giảng viên thành công!");
            }
            else if (flag == "edit")
            {
                string strLenh = "sp_CapNhat_GiangVien";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@magv", tB_MaGV.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@hoten", tB_HoTen.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", tB_DiaChi.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sodienthoai", tB_SDT.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@makhoa", cB_Khoa.SelectedValue.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Cập nhật thông tin giảng viên thành công!");
            }
            else if (flag == "delete")
            {
                string strLenh = "sp_Xoa_GiangVien";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@magv", tB_MaGV.Text.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Xóa viên thành công!");
            }
            loadData();
            tB_MaGV.Enabled = tB_Email.Enabled = false;
            tB_DiaChi.Enabled = tB_HoTen.Enabled = tB_Email.Enabled = tB_SDT.Enabled = cB_Khoa.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_HoTen.Text = oldHoten;
            cB_Khoa.SelectedItem = oldKhoa;
            tB_DiaChi.Text = oldDiaChi;
            tB_SDT.Text = oldSDT;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_GiangVien.Refresh();
            tB_DiaChi.Enabled = tB_MaGV.Enabled = tB_HoTen.Enabled = tB_Email.Enabled = tB_SDT.Enabled = cB_Khoa.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            them_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = true;
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_GiangVien_Load(object sender, EventArgs e)
        {
            loadData();
            HienThi_CB_Lop();
        }
        void loadData()
        {
            string strLenh = "SELECT MAGV, HoTen, DIACHI, SODIENTHOAI, EMAIL, KHOA.TENKHOA FROM GIANGVIEN " +
                "JOIN KHOA ON KHOA.MAKHOA = GIANGVIEN.MAKHOA";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dt_SV = dt;
            dGV_GiangVien.DataSource = dt;
            dGV_GiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_GiangVien.Columns[0].HeaderText = "Mã GV";
            dGV_GiangVien.Columns[1].HeaderText = "Họ tên";
            dGV_GiangVien.Columns[2].HeaderText = "Địa chỉ";
            dGV_GiangVien.Columns[3].HeaderText = "Số điện thoại";
            dGV_GiangVien.Columns[4].HeaderText = "Email";
            dGV_GiangVien.Columns[5].HeaderText = "Mã khoa";
        }
        void HienThi_CB_Lop()
        {
            string lenh = "SELECT Makhoa, TenKhoa FROM Khoa";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Khoa.DataSource = bindingSource;
            cB_Khoa.DisplayMember = "TenKhoa";
            cB_Khoa.ValueMember = "Makhoa";
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
    }
}
