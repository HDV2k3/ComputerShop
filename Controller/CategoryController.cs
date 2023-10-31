using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.Controller
{
    public class CategoryController
    {
        // thêm
        public bool AddCategory(string CategoryId, string CategoryName, string CategoryStatus)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Category (Category_Id, Category_Name, Category_Status) VALUES (@CategoryId, @CategoryName, @CategoryStatus)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryId", CategoryId);
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@CategoryStatus", CategoryStatus);
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // tìm kiếm
       public static void SearchCategorys(string query, DataGridView dgv)
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
                
            }
        }
        // thay đổi 
        internal static void ChangedCategory(Category category)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Category SET Category_Name =@CategoryName, Category_Status =@CategoryStatus WHERE Category_Id = @CategoryId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", category.Category_Name);
                        command.Parameters.AddWithValue("@CategoryStatus", category.Category_Status);
                        command.Parameters.AddWithValue("@CategoryId", category.Category_Id);
                        command.ExecuteNonQuery();
                    }
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
        // xóa
        public bool DeleteCategory(string CategoryId)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Category WHERE Category_Id = @CategoryId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryId", CategoryId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thương hiệu để xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
