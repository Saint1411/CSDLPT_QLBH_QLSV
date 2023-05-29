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
    public partial class Form_DS_TheoKhoa : Form
    {
        public Form_DS_TheoKhoa()
        {
            InitializeComponent();
        }

        private void Form_DS_TheoKhoa_Load(object sender, EventArgs e)
        {

            this.rV_DS_TheoKhoa.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
            cB_DoiTuong.SelectedIndex = 0;
            HienThi_CB_Khoa();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            string doituong = cB_DoiTuong.Text.ToString().Trim();
            if (doituong == "Sinh viên")
                doituong = "SV";
            else
                doituong = "GV";

            string lenh = "sp_DS_TheoKhoa";
            SqlDataAdapter adap = new SqlDataAdapter(lenh, Program.conn);
            adap.SelectCommand = new SqlCommand(lenh, Program.conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add(new SqlParameter("@makhoa", cB_Khoa.SelectedValue));
            adap.SelectCommand.Parameters.Add(new SqlParameter("@loai", doituong));
            DataSet ds = new DataSet();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                adap.Fill(ds);
                rV_DS_TheoKhoa.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rV_DS_TheoKhoa.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                rV_DS_TheoKhoa.ZoomPercent = 100;
                rV_DS_TheoKhoa.LocalReport.ReportEmbeddedResource = "CSDLPT_QuanLySinhVien.Report_DS_TheoKhoa.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = ds.Tables[0];

                    rV_DS_TheoKhoa.LocalReport.DataSources.Clear();
                    rV_DS_TheoKhoa.LocalReport.DataSources.Add(rds);
                    rV_DS_TheoKhoa.RefreshReport();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void HienThi_CB_Khoa()
        {
            string lenh = "SELECT Makhoa, TenKhoa FROM Khoa";
            DataTable dt = Program.ExecSQLDataTable(lenh);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            cB_Khoa.DataSource = bindingSource;
            cB_Khoa.DisplayMember = "TenKhoa";
            cB_Khoa.ValueMember = "Makhoa";
        }

    }
}
