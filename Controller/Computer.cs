using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using  Computer_Shop_Management_System.Model;
using Computer_Shop_Management_System.View;
using Microsoft.Web.Mvc.Controls;

namespace Computer_Shop_Management_System.Controller
{
    public class Computer
    {
       

        public static bool IsvalidNamePass(string username, string password)
        {
            using (var dbContext = new HutechDBBase())
            {
                // Kiểm tra tính hợp lệ của tên người dùng và mật khẩu
                var user = dbContext.Users.FirstOrDefault(u => u.Users_Name == username && u.Users_Password == password);
                if (user != null)
                {
                    return true; // Tên người dùng và mật khẩu hợp lệ
                }
                else
                {
                    return false; // Tên người dùng hoặc mật khẩu không hợp lệ
                }
            }
        }
     // để im đợi t chút

    }
    
}
