using Microsoft.Reporting.WinForms;
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
    public partial class Form_DSPhieu_CuaNV : Form
    {
        public Form_DSPhieu_CuaNV()
        {
            InitializeComponent();
        }

        private void Form_DSPhieu_CuaNV_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.rV_HDPN_CuaNV.RefreshReport();
            cB_Loai.SelectedIndex = 0;
            cB_Nam.SelectedIndex = 0;
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            string loaiPhieu = cB_Loai.SelectedItem.ToString().Trim();
            if (loaiPhieu == "Hóa đơn (HD)")
                loaiPhieu = "H";
            else
                loaiPhieu = "N";

            string nam = cB_Nam.SelectedItem.ToString().Trim();

            string lenh = "sp_PhieuNVLapTrongNamTheoTungLoai";
            SqlDataAdapter adap = new SqlDataAdapter(lenh, Program.conn);
            adap.SelectCommand = new SqlCommand(lenh, Program.conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add(new SqlParameter("@loai", loaiPhieu));
            adap.SelectCommand.Parameters.Add(new SqlParameter("@nam", int.Parse(nam)));
            DataSet ds = new DataSet();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                adap.Fill(ds);
                // chế độ xem của report
                rV_HDPN_CuaNV.SetDisplayMode(DisplayMode.PrintLayout);
                rV_HDPN_CuaNV.ZoomMode = ZoomMode.Percent;
                rV_HDPN_CuaNV.ZoomPercent = 100;
                rV_HDPN_CuaNV.LocalReport.ReportEmbeddedResource = "CSDLPT_QuanLyBanHang.Rpt_DSPhieuCuaNV.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Tạo nguồn dữ liệu cho báo cáo
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet_HD_PN_CuaNV";
                    rds.Value = ds.Tables[0];

                    //Xóa dữ liệu báo cáo cũ
                    rV_HDPN_CuaNV.LocalReport.DataSources.Clear();
                    //Add lại dữ liệu mới
                    rV_HDPN_CuaNV.LocalReport.DataSources.Add(rds);
                    //Refresh lại báo cáo
                    rV_HDPN_CuaNV.RefreshReport();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data varchar to int"))
                    MessageBox.Show("Error");
                else
                    MessageBox.Show(ex.Message);
                Program.conn.Close();
            }
        }
    }
}
