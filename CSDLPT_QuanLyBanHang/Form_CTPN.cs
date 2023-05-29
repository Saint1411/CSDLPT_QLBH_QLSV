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
    public partial class Form_CTPN : Form
    {
        public string MaPN = "", Masp = "";
        public int soLuong = 0, luaChon = 0;
        public double donGia = 0;
        public Form_CTPN()
        {
            InitializeComponent();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (luaChon == 1)
            {
                string strLenh = "sp_InsertCTPN";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@mapn", int.Parse(tB_MaPN.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@masp", tB_TenSP.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@soluong", int.Parse(tB_SL.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@dongianhap", double.Parse(tB_DonGia.Text.Trim())));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
            }
            else if (luaChon == 3)
            {
                string strLenh = "sp_UpdateCTPN";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@mapn", int.Parse(tB_MaPN.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@masp", Masp.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@soluong", int.Parse(tB_SL.Text.Trim())));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Sửa chi tiết phiếu nhập thành công!");
            }
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CTPN_Load(object sender, EventArgs e)
        {
            if (luaChon == 3)
            {
                tB_TenSP.Enabled = false;
                tB_DonGia.Enabled = false;
                tB_TenSP.Text = Masp;
            }
            tB_MaPN.Text = MaPN;
            tB_MaPN.Enabled = false;
            tB_TenSP.Text = Masp;
            tB_SL.Text = soLuong.ToString();
            tB_DonGia.Text = donGia.ToString();
            HienThi_CB_SanPham();


        }
        private void HienThi_CB_SanPham()
        {
            string lenh = "";
            if (luaChon == 3)
            {
                lenh = "SELECT MASP, TENSP FROM SANPHAM WHERE MASP = '" + Masp + "'";
            }
            else
            {
                lenh = "SELECT MASP, TENSP FROM SANPHAM";
            }
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            tB_TenSP.DataSource = bindingSource;
            tB_TenSP.DisplayMember = "TENSP";
            tB_TenSP.ValueMember = "MASP";
        }
    }
}
