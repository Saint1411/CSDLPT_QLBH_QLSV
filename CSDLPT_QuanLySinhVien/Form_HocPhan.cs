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
    public partial class Form_HocPhan : Form
    {
        public string maHP = "", tenHp = "", khoa_BoMon = "", phongHoc = "", chuongTDT = "";
        public int soTC = 0, luaChon = 0;
        public Form_HocPhan()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_HocPhan_Load(object sender, EventArgs e)
        {
            if (luaChon == 3)
            {
                tB_MaHP.Enabled = false;
            }
            tB_MaHP.Text = maHP;
            tB_MaHP.Enabled = true;
            tB_TenHP.Text = tenHp;
            tB_STC.Text = soTC.ToString();
            cB_Khoa.Text = khoa_BoMon;
            cB_Phong.Text = phongHoc;
            cB_CTDT.Text = chuongTDT;
            HienThi_CB_CTDT();
            HienThi_CB_Khoa();
            HienThi_CB_Phong();
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (luaChon == 1)
            {
                string strLenh = "sp_Them_HocPhan";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@mahp", tB_MaHP.Text.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@tenhocphan", tB_TenHP.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sotinchi", int.Parse(tB_STC.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@khoa", cB_Khoa.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@phonghoc", cB_Phong.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@chuongtrinhdaotao", cB_CTDT.SelectedValue.ToString().Trim()));

                Program.ExecSQLCommand(sqlCommand);
            }
            else if (luaChon == 3)
            {
                string strLenh = "sp_CapNhat_HocPhan";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@mahp", tB_MaHP.Text.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@tenhocphan", tB_TenHP.Text.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@sotinchi", int.Parse(tB_STC.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@khoa", cB_Khoa.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@phonghoc", cB_Phong.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@chuongtrinhdaotao", cB_CTDT.SelectedValue.ToString().Trim()));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Cập nhật học phần thành công!");
            }
            this.Close();
        }
        private void HienThi_CB_Khoa()
        {
            string lenh = "";
            lenh = "SELECT MAKHOA, TENKHOA FROM KHOA";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Khoa.DataSource = bindingSource;
            cB_Khoa.DisplayMember = "TENKHOA";
            cB_Khoa.ValueMember = "MAKHOA";
        }
        private void HienThi_CB_Phong()
        {
            string lenh = "";
            lenh = "SELECT MAPHONG, TENPHONG FROM PHONGHOC";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Phong.DataSource = bindingSource;
            cB_Phong.DisplayMember = "TENPHONG";
            cB_Phong.ValueMember = "MAPHONG";
        }
        private void HienThi_CB_CTDT()
        {
            string lenh = "";
            lenh = "SELECT MACTDT, TENCTDT FROM CHUONGTRINHDAOTAO";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_CTDT.DataSource = bindingSource;
            cB_CTDT.DisplayMember = "TENCTDT";
            cB_CTDT.ValueMember = "MACTDT";
        }
    }
}
