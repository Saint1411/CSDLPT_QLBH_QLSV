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
    public partial class FormDangNhap : Form
    {
        SqlConnection conn_Publisher = new SqlConnection();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (KetNoiMayChu() == false)
                return;
            LayDanhSachChiNhanh("SELECT * FROM v_GetSubcriber");
            cBChiNhanh.SelectedIndex = 0;
            Program.serverName = cBChiNhanh.SelectedValue.ToString();
        }
        private void LayDanhSachChiNhanh(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn_Publisher.State == ConnectionState.Closed)
                conn_Publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_Publisher);
            da.Fill(dt);
            conn_Publisher.Close();
            Program.bds_DSCN.DataSource = dt;
            cBChiNhanh.DataSource = Program.bds_DSCN;
            cBChiNhanh.DisplayMember = "TENCN";
            cBChiNhanh.ValueMember = "TENSERVER";
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
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tBTaiKhoan.Text.Trim() == null || tBMatKhau.Text.Trim() == null)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }
            Program.mLogin = tBTaiKhoan.Text.Trim();
            Program.password = tBMatKhau.Text.Trim();

            if (Program.KetNoi() == false)
                return;
            Program.mChiNhanh = cBChiNhanh.SelectedIndex;
            Program.mLoginDN = Program.mLogin;
            Program.passwordDN = Program.password;

            string strExec = "EXEC sp_LayThongTinNhanVienTu_Login '" + Program.mLogin + "'";
            Program.myReader = Program.ExecSQLDataReader(strExec);
            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.userName = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản không có quyền truy cập");
                return;
            }
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            Program.frmChinh.MANV.Text = "Mã NV = " + Program.userName;
            Program.frmChinh.HOTEN.Text = "Họ tên = " + Program.mHoTen;
            Program.frmChinh.NHOM.Text = "Tên nhóm = " + Program.mGroup;
            Program.frmChinh.HienThiMenu();
            this.Close();
        }

        private void cBChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cBChiNhanh.SelectedValue.ToString();
            }
            catch (Exception )
            {

            }
        }
    }
}
