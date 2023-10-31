using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.Controller
{
    public class ProductController
    {
        // hiển thị sản phẩm theo "--Có sắn hoặc không--"
        public static void BrandCategoryProduct(string query, ComboBox cb)
        {
            string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

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
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            try
            {
                // Thay đổi chuỗi kết nối của bạn tới cơ sở dữ liệu của bạn
                string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

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
        // xóa
        public static void RemoveProduct1(string productName)
        {
            try
            {
                using (var context = new DataBase()) // Thay YourDbContext bằng tên DbContext của bạn
                {
                    // Tìm sản phẩm theo tên sản phẩm
                    var productToRemove = context.Product.FirstOrDefault(p => p.Product_Name == productName);

                    if (productToRemove != null)
                    {
                        // Xóa sản phẩm nếu tồn tại
                        context.Product.Remove(productToRemove);

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine($"Không tìm thấy sản phẩm với tên '{productName}' trong cơ sở dữ liệu.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
        public static void RemoveProduct(string id)
        {
            try
            {
                using (var context = new DataBase()) // Thay YourDbContext bằng tên DbContext của bạn
                {
                    // Tìm sản phẩm theo ID
                    var productToRemove = context.Product.FirstOrDefault(p => p.Product_Name == id);

                    if (productToRemove != null)
                    {
                        // Xóa sản phẩm nếu tồn tại
                        context.Product.Remove(productToRemove);

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine($"Không tìm thấy sản phẩm với ID '{id}' trong cơ sở dữ liệu.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        // thêm
        internal static void AddProduct(Product product)
        {
            try
            {
                using (var context = new DataBase()) // Thay YourDbContext bằng tên DbContext của bạn
                {
                    bool productExists = context.Product.Any(p => p.Product_Id == product.Product_Id);

                    if (!productExists)
                    {
                        // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào DbSet trong DbContext
                        context.Product.Add(product);

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại trong cơ sở dữ liệu.");
                        // Thực hiện các hành động khác khi sản phẩm đã tồn tại
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
