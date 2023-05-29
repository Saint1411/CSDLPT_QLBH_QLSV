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
    public partial class Form_HocPhanVaCTDT : Form
    {
        string oldMCTDT = "", oldTCTDT = "", oldLoaiDT = "";
        int oldSTC = 0, sotinchi = 0;
        int flag = 0;
        string maHP = "", tenHP = "", khoa_BoMon = "", phongHoc = "", chuongTDT = "";
        SqlConnection conn_Publisher = new SqlConnection();
        DataTable dt_NV = new DataTable();
        public Form_HocPhanVaCTDT()
        {
            InitializeComponent();
            tB_MaCTDT.Enabled = tB_TenCTDT.Enabled = tB_loaiDT.Enabled = tB_STC.Enabled = false;
            them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
            luu_ToolStripMenuItem.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            if (KetNoiMayChu() == true)
                return;
        }

        private void Form_HocPhanVaCTDT_Load(object sender, EventArgs e)
        {
            LoadDataHocPhan();
            LoadDataCTDT();
        }

        private void them_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 1;
            tB_MaCTDT.Enabled = tB_TenCTDT.Enabled = tB_STC.Enabled = tB_loaiDT.Enabled = true;
            tB_MaCTDT.Text = tB_TenCTDT.Text = tB_loaiDT.Text = "";
            tB_STC.Text = "0";
            xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMCTDT = tB_MaCTDT.Text.Trim();
            oldTCTDT = tB_TenCTDT.Text.Trim();
            oldSTC = int.Parse(tB_STC.Text.Trim());
            oldLoaiDT = tB_loaiDT.Text.Trim();
        }

        private void xoa_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 2;
            tB_MaCTDT.Enabled = tB_STC.Enabled = tB_TenCTDT.Enabled = tB_loaiDT.Enabled = false;
            sua_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;
        }

        private void sua_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 3;
            tB_MaCTDT.Enabled = false;
            tB_TenCTDT.Enabled = tB_STC.Enabled = tB_loaiDT.Enabled = true;
            xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = false;
            luu_ToolStripMenuItem.Enabled = true;

            oldMCTDT = tB_MaCTDT.Text.Trim();
            oldTCTDT = tB_TenCTDT.Text.Trim();
            oldSTC = int.Parse(tB_STC.Text.Trim());
            oldLoaiDT = tB_loaiDT.Text.Trim();
        }

        private void luu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tB_MaCTDT, "Mã CTDT không được rỗng!")) return;
            if (!checkValidate(tB_TenCTDT, "Tên CTDT không được rỗng!")) return;
            if (!checkValidate(tB_STC, "Số tín chỉ không được rỗng!")) return;
            if (!checkValidate(tB_loaiDT, "Loại đào tạo không được rỗng!")) return;
            try
            {
                if (flag == 1)
                {
                    string strLenh = "sp_Them_ChuongTrinhDaoTao";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@mactdt", tB_MaCTDT.Text.Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@tenctdt", tB_TenCTDT.Text.Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@sotinchi", tB_STC.Text.Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@loaidaotao", tB_loaiDT.Text.Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                }
                else if (flag == 3)
                {
                    string strLenh = "sp_CapNhat_ChuongTrinhDaoTao";
                    SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 600;
                    sqlCommand.Parameters.Add(new SqlParameter("@mactdt", tB_MaCTDT.Text.Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@tenctdt", tB_TenCTDT.Text.Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@sotinchi", tB_STC.Text.Trim()));
                    sqlCommand.Parameters.Add(new SqlParameter("@loaidaotao", tB_loaiDT.Text.Trim()));
                    Program.ExecSQLCommand(sqlCommand);
                    MessageBox.Show("Cập chương trình đào tạo thành công!");
                }
                else if (flag == 2)
                {
                    if (dGV_HocPhan.Rows[0].Cells[0].Value == null)
                    {
                        string strLenh = "sp_Xoa_ChuongTrinhDaoTao";
                        SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandTimeout = 600;
                        sqlCommand.Parameters.Add(new SqlParameter("@mactdt", tB_MaCTDT.Text.Trim()));
                        Program.ExecSQLCommand(sqlCommand);
                        MessageBox.Show("Xóa chương trình đào tạo thành công!");
                    }
                    else
                        MessageBox.Show("Phải xóa học phần liên quan đến CTDT trước!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tB_MaCTDT.Enabled = tB_TenCTDT.Enabled = tB_STC.Enabled = tB_loaiDT.Enabled = false;
                them_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = sua_ToolStripMenuItem.Enabled = true;
                luu_ToolStripMenuItem.Enabled = false;
                LoadDataCTDT();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_MaCTDT.Text = oldMCTDT;
            tB_TenCTDT.Text = oldTCTDT;
            tB_STC.Text = oldSTC.ToString();
            tB_loaiDT.Text = oldLoaiDT;
        }

        private void refresh_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_CTDT.Refresh();
            dGV_HocPhan.Refresh();
            tB_MaCTDT.Enabled = tB_TenCTDT.Enabled = tB_STC.Enabled = tB_loaiDT.Enabled = false;
            luu_ToolStripMenuItem.Enabled = false;
            sua_ToolStripMenuItem.Enabled = xoa_ToolStripMenuItem.Enabled = them_ToolStripMenuItem.Enabled = true;
        }

        private void dGV_HocPhan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            int pos_xy_mouse_row = dGV_HocPhan.HitTest(e.X, e.Y).RowIndex;
            if (pos_xy_mouse_row < 0)
            {
                return;
            }

            ContextMenuStrip rightMenu = new ContextMenuStrip();
            rightMenu.Items.Add("Thêm").Name = "Thêm";
            rightMenu.Items.Add("Xóa").Name = "Xóa";
            rightMenu.Items.Add("Sửa").Name = "Sửa";
            dGV_HocPhan.ClearSelection();
            dGV_HocPhan.Rows[pos_xy_mouse_row].Selected = true;
            rightMenu.Show(dGV_HocPhan, new Point(e.X, e.Y));

            rightMenu.ItemClicked += new ToolStripItemClickedEventHandler(rightMenu_ItemClicked);
        }
        public void rightMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form_HocPhan frm = new Form_HocPhan();
            if (e.ClickedItem.Name == "Thêm")
            {
                frm.luaChon = 1;
                frm.soTC = 0;
                frm.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Sửa")
            {
                frm.luaChon = 3;
                frm.maHP = maHP;
                frm.tenHp = tenHP;
                frm.soTC = sotinchi;
                frm.phongHoc = phongHoc;
                frm.chuongTDT = chuongTDT;
                frm.khoa_BoMon = khoa_BoMon;
                frm.ShowDialog();
            }
            else if (e.ClickedItem.Name == "Xóa")
            {
                frm.luaChon = 2;
                string strLenh = "sp_Xoa_HocPhan";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@mahp", maHP.Trim()));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Xóa học phần thành công!");
            }
            LoadDataHocPhan();
        }

        private void thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGV_CTDT_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_CTDT.CurrentCell != null)
            {
                int index = dGV_CTDT.CurrentCell.RowIndex;
                DataTable dt = (DataTable)dGV_CTDT.DataSource;
                if (dt.Rows.Count > 0)
                {
                    tB_MaCTDT.Text = dGV_CTDT.Rows[index].Cells[0].Value.ToString().Trim();
                    tB_TenCTDT.Text = dGV_CTDT.Rows[index].Cells[1].Value.ToString().Trim();
                    tB_STC.Text = dGV_CTDT.Rows[index].Cells[2].Value.ToString().Trim();
                    tB_loaiDT.Text = dGV_CTDT.Rows[index].Cells[3].Value.ToString().Trim();
                }
                LoadDataHocPhan();
            }
        }
        public void LoadDataCTDT()
        {
            string strLenh = "SELECT MACTDT, TENCTDT, SOTINCHI, LOAIDAOTAO FROM CHUONGTRINHDAOTAO";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dt_NV = dt;
            dGV_CTDT.DataSource = dt;
            dGV_CTDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_CTDT.Columns[0].HeaderText = "Mã CTDT";
            dGV_CTDT.Columns[1].HeaderText = "Tên CTDT";
            dGV_CTDT.Columns[2].HeaderText = "Số tín chỉ";
            dGV_CTDT.Columns[3].HeaderText = "Loại đào tạo";
        }

        public void LoadDataHocPhan()
        {
            string strLenh = "SELECT MAHP, TENHP, P.SOTINCHI, KHOA_BOMON, H.TENPHONG, C.TENCTDT" +
                " FROM HOCPHAN P JOIN CHUONGTRINHDAOTAO C ON P.CHUONGTRINHDAOTAO = C.MACTDT " +
                "JOIN PHONGHOC H ON H.MAPHONG = P.PhongHoc " +
                "WHERE P.CHUONGTRINHDAOTAO = '" + tB_MaCTDT.Text.Trim() + "'";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            dGV_HocPhan.DataSource = dt;
            dGV_HocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_HocPhan.Columns[0].HeaderText = "Mã học phần";
            dGV_HocPhan.Columns[1].HeaderText = "Tên học phần";
            dGV_HocPhan.Columns[2].HeaderText = "Số tín chỉ";
            dGV_HocPhan.Columns[3].HeaderText = "Khoa - Bộ môn";
            dGV_HocPhan.Columns[4].HeaderText = "Phòng học";
            dGV_HocPhan.Columns[5].HeaderText = "Chương trình đào tạo";

        }

        private void dGV_HocPhan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dGV_HocPhan.CurrentCell != null)
                {
                    int index = dGV_HocPhan.CurrentCell.RowIndex;
                    DataTable dt = (DataTable)dGV_HocPhan.DataSource;
                    if (dt.Rows.Count > 0)
                    {
                        maHP = dGV_HocPhan.Rows[index].Cells[0].Value.ToString().Trim();
                        tenHP = dGV_HocPhan.Rows[index].Cells[1].Value.ToString().Trim();
                        sotinchi = int.Parse(dGV_HocPhan.Rows[index].Cells[2].Value.ToString().Trim());
                        khoa_BoMon = dGV_HocPhan.Rows[index].Cells[3].Value.ToString().Trim();
                        phongHoc = dGV_HocPhan.Rows[index].Cells[4].Value.ToString().Trim();
                        chuongTDT = dGV_HocPhan.Rows[index].Cells[5].Value.ToString().Trim();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chuột phải để thêm, xóa, sửa học phần!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
