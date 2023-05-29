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
    public partial class Form_HoatDongNV : Form
    {
        public string maNV = "", loaiPhieu = "";
        public DateTime tuNgay, denNgay;

        private void rV_HoatDongNV_Load(object sender, EventArgs e)
        {
            if (loaiPhieu == "Hóa đơn")
                loaiPhieu = "H";
            else
                loaiPhieu = "N";


            string lenh = "sp_CacHoatDongCuaNV";
            SqlDataAdapter adap = new SqlDataAdapter(lenh, Program.conn);
            adap.SelectCommand = new SqlCommand(lenh, Program.conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add(new SqlParameter("@manv", maNV));
            adap.SelectCommand.Parameters.Add(new SqlParameter("@loai", loaiPhieu));
            adap.SelectCommand.Parameters.Add(new SqlParameter("@fromDate", Convert.ToDateTime(tuNgay)));
            adap.SelectCommand.Parameters.Add(new SqlParameter("@toDate", Convert.ToDateTime(denNgay)));
            DataSet ds = new DataSet();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                adap.Fill(ds);
                // chế độ xem của report
                rV_HoatDongNV.SetDisplayMode(DisplayMode.PrintLayout);
                rV_HoatDongNV.ZoomMode = ZoomMode.Percent;
                rV_HoatDongNV.ZoomPercent = 100;
                rV_HoatDongNV.LocalReport.ReportEmbeddedResource = "CSDLPT_QuanLyBanHang.Rpt_HoatDongCuaNV.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Tạo nguồn dữ liệu cho báo cáo
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet_HoatDongCuaNV";
                    rds.Value = ds.Tables[0];

                    //Xóa dữ liệu báo cáo cũ
                    rV_HoatDongNV.LocalReport.DataSources.Clear();
                    //Add lại dữ liệu mới
                    rV_HoatDongNV.LocalReport.DataSources.Add(rds);
                    //Refresh lại báo cáo
                    rV_HoatDongNV.RefreshReport();
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

        public Form_HoatDongNV()
        {
            InitializeComponent();
        }

        private void Form_HoatDongNV_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;   
            this.rV_HoatDongNV.RefreshReport();
        }
    }
}
