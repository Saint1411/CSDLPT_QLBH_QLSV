using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QuanLyBanHang
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static string conString;

        public static string conString_Publisher = "Data Source=DESKTOP-KKGPLKT;initial catalog=QLBH;integrated security=True";

        public static SqlDataReader myReader;
        public static string serverName = "";
        public static string userName = "";
        public static string mLogin = "";
        public static string password = "";

        public static string database = "QLBH";
        public static string remoteLogin = "HoTroKetNoi";
        public static string remotePassword = "123456";
        public static string mLoginDN = "";
        public static string passwordDN = "";
        public static string mGroup = "";
        public static string mHoTen = "";
        public static int mChiNhanh = 0;

        public static MainForm frmChinh;
        public static BindingSource bds_DSCN = new BindingSource();
        public static bool KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.conString = "Data Source=" + Program.serverName.ToString() + "; Initial Catalog=" +
                    Program.database + "; User ID=" + Program.mLogin + "; password=" + Program.password;
                Program.conn.ConnectionString = Program.conString;
                Program.conn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                return false;
            }
        }
        public static SqlDataReader ExecSQLDataReader(string strExec)
        {
            SqlDataReader sqlReader;
            SqlCommand sqlCmd = new SqlCommand(strExec, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                sqlReader = sqlCmd.ExecuteReader();
                return sqlReader;
            }
            catch (Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static DataTable ExecSQLDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void ExecSQLCommand(SqlCommand sqlCommand)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
                Program.conn.Close();
            }
            catch(SqlException e)
            {
                if (e.Message.Contains("Error converting data varchar to int"))
                    MessageBox.Show("Error");
                else
                    MessageBox.Show(e.Message);
                Program.conn.Close();
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new MainForm();
            Application.Run(frmChinh);
        }
    }
}
