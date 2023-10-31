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
    public class OderController
    {
        // xóa
        public bool DeleteOrder(string orderid)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Orders WHERE Orders_Id = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", orderid);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy Hóa Đơn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // tìm kiếm
        public static void SearchOrders(string query, DataGridView dgv)
        {
            try
            {
                // Thay đổi chuỗi kết nối của bạn tới cơ sở dữ liệu của bạn
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

       }    }        

    }
}
