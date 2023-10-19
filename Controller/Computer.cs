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

        // query users

        //public static User users = new User();

        public static User IsvalidNamePass(string username, string password)
        {
            using (var dbContext = new DataBase())
            {
                // Kiểm tra tính hợp lệ của tên người dùng và mật khẩu
                var user = dbContext.User.FirstOrDefault(u => u.Users_Name == username && u.users_Password == password);
                if (user != null)
                {
                   
                    return user; // Tên người dùng và mật khẩu hợp lệ
                }
                else
                {
                    
                    return null; // Tên người dùng hoặc mật khẩu không hợp lệ
                }
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
            using (var dbContext = new DataBase())
            {
                var product = dbContext.Product.FirstOrDefault(p => p.Product_Name == productName);
                if (product != null)
                {
                    return product.Product_Rate.ToString();
                }
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
                    throw;
                    // Xử lý ngoại lệ hoặc ghi nhật ký lỗi tùy theo yêu cầu của bạn
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
        public static int CountTotal_Amout()
        {
            using (DataBase dbContext = new DataBase())
            {
                int sum = dbContext.Orders.Sum(o => o.Total_Amout);
                return sum;
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
    

