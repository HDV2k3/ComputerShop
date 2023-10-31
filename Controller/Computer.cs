using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using  Computer_Shop_Management_System.Model;
using Computer_Shop_Management_System.View;
using Microsoft.Web.Mvc.Controls;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.Controller
{
    public class Computer
    {

        // query Users

        //public static User Users = new User();

        public static User IsvalidNamePass(string Username, string password)
        {
            try
            {
                using (var dbContext = new DataBase())
                {
                    // Kiểm tra tính hợp lệ của tên người dùng và mật khẩu
                    var User = dbContext.User.FirstOrDefault(u => u.Users_Name == Username && u.Users_Password == password);
                    if (User != null)
                    {

                        return User; // Tên người dùng và mật khẩu hợp lệ
                    }
                    else
                    {

                        return null; // Tên người dùng hoặc mật khẩu không hợp lệ
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Khởi động lại SQL");
                return null;
            }
            
        }
        // query sản phẩm

        public static void BrandCategoryProduct(string productName, System.Windows.Forms.ComboBox cb)
        {
            using (var dbContext = new DataBase())
            {
                var products = dbContext.Product
                    .Where(p => p.Product_Stastus == "Thanh Toán Thành Công")
                    .OrderBy(p => p.Product_Name)
                    .Select(p => p.Product_Name)
                    .ToList();

                Computer computer = new Computer();

                foreach (var TenSanPham in products)
                {
                    computer.AddProductToComboBox(productName, cb);  // Gọi phương thức từ đối tượng Computer
                }
            }
        }

        private void AddProductToComboBox(string productName, System.Windows.Forms.ComboBox cb)
        {
            // Thêm tên sản phẩm vào ComboBox trong ứng dụng của bạn
            cb.Items.Add(productName);
        }
        // query giá của sản phẩm
        public static string Gia(string productName)
        {
            try
            {
                using (var dbContext = new DataBase())
                {
                    var product = dbContext.Product.FirstOrDefault(p => p.Product_Name == productName);
                    if (product != null)
                    {
                        return product.Product_Rate.ToString();
                    }
                }
            }
            catch(Exception ) 
            {
                MessageBox.Show("Tôi sẽ sớm quay lại!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            return string.Empty;
        }

        // lưu vào cơ sở dữ liệu 
        public static void SaveOrder(Orders orders)
        {
            
            using (var context = new DataBase())
            {


                // Thực hiện các thao tác lưu dữ liệu vào cơ sở dữ liệu
                try
                {
                    context.Orders.Add(orders); // Sử dụng phương thức Add để thêm vào bảng Orders
                    context.SaveChanges();
                    MessageBox.Show("Lưu Hóa Đơn Thành Công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Alo coder Việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }
        }

        // query đếm sản phẩm
        public static int CountProducts(string query)
        {
            using (DataBase dbContext = new DataBase())
            {
                int count = dbContext.Product.Count();
                return count;
            }
        }
        // query tổng doanh thu
        public static int? CountTotal_Amout()
        {
            using (DataBase dbContext = new DataBase())
            {
                int? sum = dbContext.Orders.Sum(o => (int?)o.Total_Amout);
                return sum ?? 0;
            }
        }
        // query tổng hóa đơn
        public static int CountTotal_Order()
        {
            using (DataBase dbContext = new DataBase())
            {
                int count = dbContext.Orders.Count();
                return count;
            }
        }
    }

}


/*
 *  foreach (DataGridViewRow row in dtgvOrder.Rows)
                                    {
                                        if (row.Cells[0].Value != null)
                                        {
                                            string productName1 = row.Cells[0].Value.ToString();
                                            int productRate = Convert.ToInt32(row.Cells[1].Value.ToString());
                                            int amount = Convert.ToInt32(row.Cells[2].Value.ToString());
                                            int total = Convert.ToInt32(row.Cells[3].Value.ToString());

                                            // Kiểm tra tên sản phẩm đã tồn tại trong Product hay không
                                            string productQuery = "SELECT COUNT(*) FROM Product WHERE Product_Name = N'" + productName1 + "'";
                                            int productCount = 0;

                                            using (SqlConnection connection1 = new SqlConnection(connectionString))
                                            {
                                                connection.Open();

                                                SqlCommand productCmd = new SqlCommand(productQuery, connection);
                                                productCount = (int)productCmd.ExecuteScalar();

                                                connection.Close();
                                            }

                                            if (productCount > 0)
                                            {
                                                // Lấy thông tin sản phẩm
                                                string getProductQuery = "SELECT * FROM Product WHERE Product_Name = N'" + productName1 + "'";
                                                DataTable productDt = new DataTable();
                                                productDt = DataProvider.GetData(getProductQuery);
                                                string billCode = txtMaHoaDon1.Text.Trim();
                                                int productId = Convert.ToInt32(productDt.Rows[0][0].ToString());
                                                string paymentmethods = cmbptthanhtoan.SelectedItem.ToString();
                                                // Lưu chi tiết hóa đơn
                                                string orderDetailQuery = "UPDATE OrderDetails SET Product_Id =@, Amout, Product_Rate, Total,Payment_Methods) VALUES ('" + billCode + "'," + productId + "," + amount + "," + productRate + "," + total + ",N'" + cmbptthanhtoan.SelectedItem.ToString() + "')";
                                                DataProvider.ExecuteNonQuery(orderDetailQuery);
                                                // Trừ số lượng sản phẩm từ cơ sở dữ liệu
                                                string updateProductQuantityQuery = "UPDATE Product SET Product_Quantity = Product_Quantity - " + amount + " WHERE Product_Id = " + productId;
                                                DataProvider.ExecuteNonQuery(updateProductQuantityQuery);

                                            }
                                        }
                                    }
 */