using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.IO;
using System.Data.OleDb;

namespace Computer_Shop_Management_System.Model
{
    public class DataProvider
    {
      /*  public static string GetConnectionString()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = @"ComputerShopSystem",
                DataSource = @"DESKTOP-3JE3S4U\\SQLEXPRESS",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ConnectTimeout = 0,
                MaxPoolSize = 500,
                TrustServerCertificate = true
            };
            return stringBuilder.ConnectionString;
        }*/
        public const string GetConnectionString  = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            string conn_string = GetConnectionString;
            SqlConnection sqlConnect = new SqlConnection(conn_string);
            sqlConnect.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static bool ExecuteNonQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        /*  public static bool ExecuteNonQuery(string sql)
          {
              using (SqlConnection connection = new SqlConnection(GetConnectionString()))
              {
                  try
                  {
                      connection.Open();
                      SqlCommand cmd = new SqlCommand(sql, connection);
                      cmd.ExecuteNonQuery();
                      connection.Close();
                      return true;
                  }
                  catch (Exception ex)
                  {
                      // Ghi log thông tin lỗi vào tệp tin
                      using (StreamWriter writer = new StreamWriter("error.log", true))
                      {
                          writer.WriteLine($"Exception occurred: {ex.Message}");
                          writer.WriteLine($"Stack trace: {ex.StackTrace}");
                          writer.WriteLine();
                      }
                      throw; // Ném lại ngoại lệ để nó có thể được xử lý ở nơi gọi
                  }
              }
          }*/


    }
}