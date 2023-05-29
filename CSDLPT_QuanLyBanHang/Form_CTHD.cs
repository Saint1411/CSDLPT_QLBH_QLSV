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
    public partial class Form_CTHD : Form
    {
        public string soHD = "", Masp = "";
        public int soLuong = 0, luaChon = 0;
        public double donGia = 0;
        
        public Form_CTHD()
        {
            InitializeComponent();
        }
        private void Form_CTHD_Load(object sender, EventArgs e)
        {
            if (luaChon == 3)
            {
                cB_MaSP.Enabled = false;
                tB_DonGia.Enabled = false;
                cB_MaSP.Text = Masp;
            }
            tB_SoHD.Text = soHD;
            tB_SoHD.Enabled = false;
            cB_MaSP.Text = Masp;
            tB_SoLuong.Text = soLuong.ToString();
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
            cB_MaSP.DataSource = bindingSource;
            cB_MaSP.DisplayMember = "TENSP";
            cB_MaSP.ValueMember = "MASP";
        }

     
        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if(luaChon == 1)
            {
                string strLenh = "sp_InsertCTHD";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@sohd", int.Parse(tB_SoHD.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@masp", cB_MaSP.SelectedValue.ToString().Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@dongia", double.Parse(tB_DonGia.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@soluong", int.Parse(tB_SoLuong.Text.Trim())));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
            }
            else if (luaChon == 3)
            {
                string strLenh = "sp_UpdateCTHD";
                SqlCommand sqlCommand = new SqlCommand(strLenh, Program.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 600;
                sqlCommand.Parameters.Add(new SqlParameter("@sohd", int.Parse(tB_SoHD.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@masp", Masp.Trim()));
                sqlCommand.Parameters.Add(new SqlParameter("@dongia", double.Parse(tB_DonGia.Text.Trim())));
                sqlCommand.Parameters.Add(new SqlParameter("@soluong", int.Parse(tB_SoLuong.Text.Trim())));
                Program.ExecSQLCommand(sqlCommand);
                MessageBox.Show("Cập nhật chi tiết hóa đơn thành công!");
            }
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
