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
    public partial class Form_DSNV : Form
    {
        public Form_DSNV()
        {
            InitializeComponent();
        }

        private void Form_DSNV_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.rV_DSNV.RefreshReport();
            this.rV_DSNV.RefreshReport();
        }

        private void rV_DSNV_Load(object sender, EventArgs e)
        {
            string lenh = "sp_DSNV";
            SqlDataAdapter adap = new SqlDataAdapter(lenh, Program.conn);
            adap.SelectCommand = new SqlCommand(lenh, Program.conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                adap.Fill(ds);
                // chế độ xem của report
                rV_DSNV.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rV_DSNV.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                rV_DSNV.ZoomPercent = 100;
                rV_DSNV.LocalReport.ReportEmbeddedResource = "CSDLPT_QuanLyBanHang.Rpt_DSNV.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Tạo nguồn dữ liệu cho báo cáo
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet_DSNV";
                    rds.Value = ds.Tables[0];

                    //Xóa dữ liệu báo cáo cũ
                    rV_DSNV.LocalReport.DataSources.Clear();
                    //Add lại dữ liệu mới
                    rV_DSNV.LocalReport.DataSources.Add(rds);
                    //Refresh lại báo cáo
                    rV_DSNV.RefreshReport();
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
