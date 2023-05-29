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
    public partial class Form_TimKiemSinhVien : Form
    {
        public Form_TimKiemSinhVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_TimKiemSinhVien_Load(object sender, EventArgs e)
        {
            HienThi_CB_Lop();
        }
        void HienThi_CB_Lop()
        {
            string lenh = "SELECT MALOP, TENLOP FROM LOP";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Lop.DataSource = bindingSource;
            cB_Lop.DisplayMember = "TENLOP";
            cB_Lop.ValueMember = "MALOP";
        }

        void HienThiSinhVienTheoLop(string type)
        {
            string proc = "";
            SqlCommand cmd = new SqlCommand(proc, Program.conn);
            if (type == "Lop")
            {
                proc = "sp_DSSinhVienTheo_Lop";
                cmd = new SqlCommand(proc, Program.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@malop", cB_Lop.SelectedValue.ToString().Trim()));
                dGV_TimKiem.Refresh();
            }
            if(type == "Diem")
            {
                proc = "sp_DSSinhVienTheoKhoangDiem";
                cmd = new SqlCommand(proc, Program.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DiemMin", tB_DiemTu.Text.ToString().Trim()));
                cmd.Parameters.Add(new SqlParameter("@DiemMax", tB_DiemDen.Text.ToString().Trim()));
                dGV_TimKiem.Refresh();
            }
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                try
                {
                    da.Fill(dt);
                    dGV_TimKiem.DataSource = dt;
                    dGV_TimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dGV_TimKiem.Columns[0].HeaderText = "Mã SV";
                    dGV_TimKiem.Columns[1].HeaderText = "Họ tên";
                    dGV_TimKiem.Columns[2].HeaderText = "Ngày sinh";
                    dGV_TimKiem.Columns[3].HeaderText = "Giới tính";
                    dGV_TimKiem.Columns[4].HeaderText = "Địa chỉ";
                    dGV_TimKiem.Columns[5].HeaderText = "Số điện thoại";
                    dGV_TimKiem.Columns[6].HeaderText = "Email";
                    dGV_TimKiem.Columns[7].HeaderText = "Lớp";
                    dGV_TimKiem.Columns[7].HeaderText = "Điểm TB";
                }
                catch
                {
                    dGV_TimKiem.DataSource = null;
                    MessageBox.Show("Lớp không có sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btn_TraCuu1_Click(object sender, EventArgs e)
        {
            HienThiSinhVienTheoLop("Lop");
        }

        private void btn_TraCuu2_Click(object sender, EventArgs e)
        {
            HienThiSinhVienTheoLop("Diem");
        }
    }
}
