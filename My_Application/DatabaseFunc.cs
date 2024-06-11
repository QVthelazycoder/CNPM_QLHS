using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace My_Application
{
    internal class DatabaseFunc
    {
        // Tạo các đối tượng cần thiết trong Database
        private static string con = "Data Source=LAPTOP-0L6FPOI1\\SQLEXPRESS;Initial Catalog=My_Application;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private static SqlConnection sqlCon = new SqlConnection(con);
        private static SqlCommand sqlCmd;
        private static DataTable dt;
        private static DataRow dr;
        private static SqlDataAdapter adpt;

        public static void SetCommand(SqlCommand cmd)
        {
            sqlCmd = cmd;
        }


        public static SqlCommand GetCommand()
        {
            return sqlCmd;
        }

        public static string GetStringCon()
        {
            return con;
        }

        public static void Connect()
        {
            try
            {
                sqlCon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối !", "Lỗi");
                return;
            }
        }

        public static void Disconnect()
        {
            sqlCon.Close();
        }
        //
        // Lệnh SELECT
        //
        public static DataTable Select(string table_name, List<CustomParam> list)
        {
            try
            {
                Connect();
                sqlCmd = new SqlCommand("SELECT_" + table_name, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                foreach (CustomParam o in list)
                {
                    sqlCmd.Parameters.AddWithValue(o.Key, (o.Value) ?? (object)DBNull.Value);
                }
                adpt = new SqlDataAdapter(sqlCmd);
                dt = new DataTable();
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                /*MessageBox.Show("Lỗi không tải được dữ liệu: " + e.Message, "Lỗi");*/
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        //
        // Lệnh INSERT
        //
        public static int Insert(string table_name, List<CustomParam> list)
        {
            try
            {
                Connect();
                sqlCmd = new SqlCommand("INSERT_" + table_name, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                foreach (CustomParam o in list)
                {
                    sqlCmd.Parameters.AddWithValue(o.Key, o.Value);
                }
                return (int) sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
/*                MessageBox.Show("Đã xảy ra lỗi: " + e.Message, "Lỗi");*/
                return 0;
            }
            finally 
            { 
                Disconnect(); 
            }
        }
        //
        // Lệnh DELETE
        //
        public static int Delete(string table_name, List<CustomParam> list)
        {
            try
            {
                Connect();
                sqlCmd = new SqlCommand("DELETE_" + table_name, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                foreach (CustomParam o in list)
                {
                    sqlCmd.Parameters.AddWithValue(o.Key, o.Value);
                }
                return (int)sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
/*              MessageBox.Show("Đã xảy ra lỗi: " + e.Message, "Lỗi");*/
                return 0;
            }
            finally
            {
                Disconnect();
            }
        }
        //
        // Lệnh UPDATE
        //
        public static int Update(string table_name, List<CustomParam> list)
        {
            try
            {
                Connect();
                sqlCmd = new SqlCommand("UPDATE_" + table_name, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                foreach (CustomParam o in list)
                {
                    sqlCmd.Parameters.AddWithValue(o.Key, o.Value);
                }
                return (int)sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
/*                MessageBox.Show("Đã xảy ra lỗi: " + e.Message, "Lỗi");*/
                return 0;
            }
            finally
            {
                Disconnect();
            }
        }
        //
        // Lệnh SELECT khi double click 1 cell trong DataGridView, hoặc chọn 1 row từ table của CSDL
        //
        public static DataRow SelectRows(string table_name, List<CustomParam> list)
        {
            try
            {
                Connect();
                string cmd = "SELECT_" + table_name + "_DBCLICK";
                sqlCmd = new SqlCommand(cmd, sqlCon);
                sqlCmd.CommandType= CommandType.StoredProcedure;
                foreach (CustomParam o in list)
                {
                    sqlCmd.Parameters.AddWithValue(o.Key, o.Value);
                }
                dt = new DataTable();
                dt.Load(sqlCmd.ExecuteReader());
                dr = dt.Rows[0];
                return dr;
            }
            catch (Exception e)
            {
/*                MessageBox.Show("Lỗi không tải được dữ liệu: " + e.Message, "Lỗi");*/
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        //
        //
        //
        public static int Exec(string cmd, List<CustomParam> list)
        {
            try
            {
                Connect();
                sqlCmd = new SqlCommand(cmd, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                foreach (CustomParam o in list)
                {
                    sqlCmd.Parameters.AddWithValue(o.Key, (o.Value) ?? (object) DBNull.Value);
                }
                return (int)sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
/*                MessageBox.Show("Đã xảy ra lỗi: " + e.Message, "Lỗi");*/
                return 0;
            }
            finally
            {
                Disconnect();
            }
        }
        //
        // Lấy giá trị thực từ 1 bảng bất kỳ trong CSDL
        //
        public static decimal Select_Value(string cmd)
        {
            try
            {
                Connect();
                sqlCmd = new SqlCommand(cmd, sqlCon);
                object result = sqlCmd.ExecuteScalar();
                if (result == (object) DBNull.Value || result == null) {
                    return -1;
                }
                else 
                    return Convert.ToDecimal(result);
            }
            catch (Exception e)
            {
/*                MessageBox.Show("Đã xảy ra lỗi: " + e.Message, "Lỗi");*/
                return -2;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
