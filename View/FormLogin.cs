using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using Computer_Shop_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.PAL
{
    public partial class FormLogin : Form
    {
        DataBase db = new DataBase();
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Event
        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( txtUsername.Text.Trim() == string .Empty)
            {
                MessageBox.Show("Vui Long Nhap UserName." ,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else if(txtUserpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Long Nhap Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User check = Computer.IsvalidNamePass(txtUsername.Text.Trim() ,txtUserpassword.Text.Trim());
                if(check!=null)
                {
                    MainForm frm = new MainForm(check);
                    frm.name = txtUsername.Text;
                    frm.ShowDialog();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }     
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picShowPass_Click(object sender, EventArgs e)
        {
            if(picShowPass.Visible==true)
            {
                txtUserpassword.UseSystemPasswordChar = false;
                picShowPass.Visible = false;
                picHidePass.Visible = true;
            }
        }
        private void picHidePass_Click(object sender, EventArgs e)
        {
            if (picHidePass.Visible == true)
            {
                txtUserpassword.UseSystemPasswordChar = true;
                picShowPass.Visible = true;
                picHidePass.Visible = false;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            FormForgotPass formForgotPass = new FormForgotPass();
            this.Hide();
            formForgotPass.ShowDialog();
            this.Show();
        }
        #endregion
        #region Method
        private void Clear()
        {
            txtUsername.Clear();
            txtUserpassword.Clear();
        }
        #endregion
        #region constraint
        private void txtUserpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                // Thực hiện đăng nhập ở đây
                e.Handled = true; // Ngăn chặn ký tự Enter hiển thị trong TextBox
                btnLogin.PerformClick(); // Kích hoạt sự kiện Click của nút Button đăng nhập
            }
        }
        #endregion
    }
}
