using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.Controller
{
    public class AnalysController
    {
        // tìm kiếm
        public static void SearchUsers(string query, DataGridView dgv)
        {
            try
            {

                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Đặt dữ liệu vào DataGridView
                            dgv.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
