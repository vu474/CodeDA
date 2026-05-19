using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCuaHangDoAnNhanh
{
    internal class KetNoiCSDL
    {
        private static string connectionString =
            @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;" +
            @"Initial Catalog=QuanLyCuaHangDoAnNhanh;" +
            @"Integrated Security=True;" +
            @"TrustServerCertificate=True;";

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, con);
            if (parameters?.Length > 0)
                cmd.Parameters.AddRange(parameters);

            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public static DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand(query, con)
                {
                    CommandType = CommandType.Text   
                };

                if (parameters?.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

       
        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, con);
            if (parameters?.Length > 0)
                cmd.Parameters.AddRange(parameters);
            con.Open();
            return cmd.ExecuteScalar();
        }
    }
}