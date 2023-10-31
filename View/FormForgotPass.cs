using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class FormForgotPass : Form
    {
        public FormForgotPass()
        {
            InitializeComponent();
        }
        #region Event
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetpw_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Long Nhap UserName.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Long Nhap Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string password = ForgotPassword(txtUsername.Text.Trim(), txtEmail.Text.Trim());
                if (!string.IsNullOrEmpty(password))
                {
                    MessageBox.Show($"Mật khẩu của bạn là: {password}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sai Tên Người Dùng hoặc Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private string ForgotPassword(string Username, string email)
        {
            // Tạo đối tượng DbContext từ kết nối Code First của bạn
            DataBase dbContext = new DataBase();

            // Tìm người dùng trong cơ sở dữ liệu
            User User = dbContext.User.FirstOrDefault(u => u.Users_Name == Username && u.Users_Email == email);

            if (User != null)
            {
                return User.Users_Password; 
            }

            return null;
        }

        private void FormForgotPass_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
