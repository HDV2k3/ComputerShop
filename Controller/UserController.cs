using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.Controller
{
    public class UserController
    {
        // thêm
        public bool AddUsers(string maloainguoidung,string loainguoidung, string tennguoidung, string matkhau,string email)
        {
            /* try
             {
                 string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();

                     string query = "INSERT INTO dbo.[User] (Users_Id,Users_Category_Id,Users_Name,Users_Password,Users_Email) VALUES ('@maloai','@tenloai','@name','@matkhau','@email')";

                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         command.Parameters.AddWithValue("@maloai", maloainguoidung);
                         command.Parameters.AddWithValue("@tenloai", loainguoidung);
                         command.Parameters.AddWithValue("@name", tennguoidung);
                         command.Parameters.AddWithValue("@matkhau", matkhau);
                         command.Parameters.AddWithValue("@email", email);
                         command.ExecuteNonQuery();
                     }
                 }

                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }*/
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra xem giá trị Users_Category_Id có tồn tại trong bảng UsersCategory không
                    string checkCategoryQuery = "SELECT COUNT(*) FROM dbo.UsersCategory WHERE Users_Category_Id = @tenloai";
                    using (SqlCommand checkCategoryCommand = new SqlCommand(checkCategoryQuery, connection))
                    {
                        checkCategoryCommand.Parameters.AddWithValue("@tenloai", loainguoidung);
                        int categoryCount = (int)checkCategoryCommand.ExecuteScalar();

                        if (categoryCount == 0)
                        {
                            MessageBox.Show("Users_Category_Id không tồn tại trong bảng UsersCategory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    string query = "INSERT INTO dbo.[User] (Users_Id, Users_Category_Id, Users_Name, Users_Password, Users_Email) VALUES (@maloai, @tenloai, @name, @matkhau, @email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maloai", maloainguoidung);
                        command.Parameters.AddWithValue("@tenloai", loainguoidung);
                        command.Parameters.AddWithValue("@name", tennguoidung);
                        command.Parameters.AddWithValue("@matkhau", matkhau);
                        command.Parameters.AddWithValue("@email", email);
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // sửa
        internal static void ChangedUser(User User)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE dbo.[User] SET Users_Id =@usersid,Users_Category_Id = @userscategoryid, Users_Name = @Username,Users_Password =@password,Users_Email =@Useremial WHERE  Users_Id =@usersid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usersid", User.Users_Id);
                        command.Parameters.AddWithValue("@userscategoryid", User.Users_Category_Id);
                        command.Parameters.AddWithValue("@Username", User.Users_Name);
                        command.Parameters.AddWithValue("@password", User.Users_Password);  
                        command.Parameters.AddWithValue("@Useremial", User.Users_Email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // xóa
        public bool DeleteUsers(string Username)
        {
            try
            {
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM dbo.[User] WHERE Users_Name = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tên người dùng để xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
