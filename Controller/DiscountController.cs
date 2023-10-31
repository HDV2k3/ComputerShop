using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.Controller
{
    public class DiscountController
    {
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        // thêm
        public bool AddDiscount(string brandId, string brandName, string brandStatus,string status)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DisCount (Discounts_Id, Discounts_Name, Discounts_Percent,Discounts_Status) VALUES (@BrandId, @BrandName, @BrandStatus,@status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BrandId", brandId);
                        command.Parameters.AddWithValue("@BrandName", brandName);
                        command.Parameters.AddWithValue("@BrandStatus", brandStatus);
                        command.Parameters.AddWithValue("@status", status);
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
        public static void SearchDiscount(string query, DataGridView dgv)
        {
            try
            {


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
        internal static void ChangedDiscount(DisCount dis)
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE DisCount SET Discounts_Name = @discountname, Discounts_Percent = @discountpercent, Discounts_Status =@discountstatus WHERE Discounts_Id = @discountid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@discountid", dis.Discounts_Id);
                        command.Parameters.AddWithValue("@discountname", dis.Discounts_Name);
                        command.Parameters.AddWithValue("@discountpercent", dis.Discounts_Percent);                   
                        command.Parameters.AddWithValue("@discountstatus", dis.Discounts_Status);
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
        public bool DeleteDiscount(string discountsname)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM DisCount WHERE Discounts_Id = @discountsid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@discountsid", discountsname);
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
        public static void Discount(string query, ComboBox cb)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //cb.Items.Clear(); // Xóa tất cả các mục hiện có trong ComboBox

                        while (reader.Read())
                        {
                            string value = reader.GetString(0); // Điều chỉnh chỉ số cột dựa trên câu truy vấn của bạn
                            cb.Items.Add(value); // Thêm giá trị vào ComboBox
                        }
                    }
                }
            }
        }
        public static string Gia(string DiscountName)
        {
            try
            {
                using (var dbContext = new DataBase())
                {
                    var product = dbContext.DisCount.FirstOrDefault(p => p.Discounts_Name == DiscountName);
                    if (product != null)
                    {
                        return product.Discounts_Percent.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tôi sẽ sớm quay lại!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return string.Empty;
        }
        public static string Id(string DiscountName)
        {
            try
            {
                using (var dbContext = new DataBase())
                {
                    var product = dbContext.DisCount.FirstOrDefault(p => p.Discounts_Name == DiscountName);
                    if (product != null)
                    {
                        return product.Discounts_Id.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tôi sẽ sớm quay lại!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return string.Empty;
        }
    }
}
