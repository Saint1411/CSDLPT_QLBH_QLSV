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

namespace CSDLPT_QuanLySinhVien
{
    public partial class Form_DanhSachSinhVien : Form
    {
        public Form_DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void Form_DanhSachSinhVien_Load(object sender, EventArgs e)
        {

            this.rV_DSSV.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
        }

        private void rV_DSSV_Load(object sender, EventArgs e)
        {
            string lenh = "SELECT MASV, HOTEN, NGAYSINH, " +
                "SODIENTHOAI, EMAIL, LOP FROM SINHVIEN";
            SqlDataAdapter adap = new SqlDataAdapter(lenh, Program.conn);
            adap.SelectCommand = new SqlCommand(lenh, Program.conn);

            DataSet ds = new DataSet();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                adap.Fill(ds);
                rV_DSSV.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rV_DSSV.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                rV_DSSV.ZoomPercent = 100;
                rV_DSSV.LocalReport.ReportEmbeddedResource = "CSDLPT_QuanLySinhVien.Report_DanhSachSV.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = ds.Tables[0];

                    rV_DSSV.LocalReport.DataSources.Clear();
                    rV_DSSV.LocalReport.DataSources.Add(rds);
                    rV_DSSV.RefreshReport();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
