using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Shop_Management_System.Model;

namespace Computer_Shop_Management_System.Controller
{
    public class BrandController
    {
        // thêm
        public bool AddBrand(string brandId, string brandName, string brandStatus)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Brand (Brand_Id, Brand_Name, Brand_Status) VALUES (@BrandId, @BrandName, @BrandStatus)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BrandId", brandId);
                        command.Parameters.AddWithValue("@BrandName", brandName);
                        command.Parameters.AddWithValue("@BrandStatus", brandStatus);
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
        public static void SearchBrands(string query, DataGridView dgv)
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
        // thay đổi 
        internal static void ChangedBrand(Brand brand)
        {

            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Brand SET Brand_Name = @BrandName, Brand_Status = @BrandStatus WHERE Brand_Id = @brandId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BrandName", brand.Brand_Name);
                        command.Parameters.AddWithValue("@BrandStatus", brand.Brand_Status);
                        command.Parameters.AddWithValue("@brandId", brand.Brand_Id);
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
        public bool DeleteBrand(string brandName)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Brand WHERE Brand_Id = @BrandId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BrandId", brandName);
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


