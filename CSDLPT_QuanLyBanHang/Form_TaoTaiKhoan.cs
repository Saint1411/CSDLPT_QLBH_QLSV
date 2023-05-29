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
    public partial class Form_TaoTaiKhoan : Form
    {
        public Form_TaoTaiKhoan()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDataNHANVIEN();
            rB_ChiNhanh.Enabled = rB_BanHang.Enabled = rB_CongTy.Enabled = rB_Kho.Enabled = rB_SanPham.Enabled = rB_User.Enabled = false;
            if(Program.mGroup == "CONGTY")
            {
                rB_CongTy.Enabled = true;
            }
            else if(Program.mGroup == "CHINHANH")
            {
                rB_ChiNhanh.Enabled = rB_BanHang.Enabled = rB_Kho.Enabled = rB_SanPham.Enabled = rB_User.Enabled = true;
            }
            else if (Program.mGroup == "USER" || Program.mGroup =="BANHANG" || Program.mGroup == "KHO" || Program.mGroup == "SANPHAM")
            {
                rB_ChiNhanh.Enabled = rB_BanHang.Enabled = rB_CongTy.Enabled = rB_Kho.Enabled = rB_SanPham.Enabled = rB_User.Enabled = false;
            }
        }
        void LoadDataNHANVIEN()
        {
            string strLenh = "SELECT MANV, HOTEN FROM NHANVIEN";
            DataTable dt = Program.ExecSQLDataTable(strLenh);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            cB_UserName.DataSource = bds;
            cB_UserName.DisplayMember = "HOTEN";
            cB_UserName.ValueMember = "MANV";
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
        private void btn_TaoLogin_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tB_LoginName, "Login name không được trống!"))
                return;
            if (!checkValidate(tB_Pass, "Password không được trống!"))
                return;            
            if (!(rB_CongTy.Checked || rB_ChiNhanh.Checked || rB_Kho.Checked || rB_SanPham.Checked || rB_User.Checked || rB_BanHang.Checked))
            {
                MessageBox.Show("Chưa chọn Role!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tB_LoginName.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Login name  không được chứa khoảng trắng", "Cảnh báo mã kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string role = "";
            if (rB_CongTy.Checked)
                role = "CONGTY";
            else if (rB_ChiNhanh.Checked)
                role = "CHINHANH";
            else if (rB_User.Checked)
                role = "USER";
            else if (rB_BanHang.Checked)
                role = "BANHANG";
            else if (rB_Kho.Checked)
                role = "KHO";
            else if (rB_SanPham.Checked)
                role = "SANPHAM";

            // Lưu login
            try
            {
                string strLenh = "sp_TaoLogin";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@loginName", tB_LoginName.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@password", tB_Pass.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@userName", cB_UserName.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@role", role));

                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Tạo login thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tạo login thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
