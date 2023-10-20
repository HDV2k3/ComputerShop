﻿using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlUser : UserControl
    {
        private static string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public UserControlUser()
        {
            InitializeComponent();
        }

        private void txtTenNguoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpThemNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tpQuanLyNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtTimKiemThuongHieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxLoaiTK()
        {
         
            using(var context = new DataBase())
            {
                var Usercategory = context.User.ToList();

                // Lấy danh sách tên sản phẩm
                var productNames = Usercategory.Select(u => u.Users_Category_Id).ToArray();

                // Thêm danh sách sản phẩm vào combobox
                cmbLoaiTK.Items.AddRange(productNames);
            }
        }
        private void LoadComboBoxLoaiTKLC()
        {

            using (var context = new DataBase())
            {
                var Usercategory = context.User.ToList();

                // Lấy danh sách tên sản phẩm
                var productNames = Usercategory.Select(u => u.Users_Category_Id).ToArray();

                // Thêm danh sách sản phẩm vào combobox
                cmbLoaiTKlc.Items.AddRange(productNames);
            }
        }
        private void LoadDataUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.[User]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvUsers.DataSource = dataTable;
                    dgvUsers.Columns["Users_Id"].HeaderText = "Mã Người Dùng";
                    dgvUsers.Columns["Users_Category_Id"].HeaderText = "Mã Loại Người Dùng";
                    dgvUsers.Columns["Users_Name"].HeaderText = "Tên Đăng Nhập";
                    dgvUsers.Columns["Users_Password"].HeaderText = "Mật Khẩu";
                    dgvUsers.Columns["Users_Email"].HeaderText = "Email";
                    lblTotal.Text = dgvUsers.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
        private bool IsDuplicateUsers( string UserName)
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM dbo.[User] WHERE Users_Name = @Username ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", UserName);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true; 
                       
                    }
                }
            }

            return false; 
        }
        private bool ValidateUserName(string brandName)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa ký tự đặc biệt và số
            string pattern = @"^[a-zA-Z]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(brandName);
        }
        private void EmptyBox()
        {
            txtTenNguoiDung.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbLoaiTK.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateUserName(txtTenNguoiDung.Text.Trim()))
            {
                MessageBox.Show("tên người dùng không được phép.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtMatKhau.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            else if (cmbLoaiTK.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoảng.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string tennguoidung = txtTenNguoiDung.Text;
                string matkhau = txtMatKhau.Text;
                string email = txtEmail.Text;
                string loaitk = cmbLoaiTK.SelectedIndex.ToString();

                // Kiểm tra trùng lặp mã thương hiệu hoặc tên thương hiệu
                if (IsDuplicateUsers(tennguoidung))
                {
                    MessageBox.Show("tên người dùng đã tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tiếp tục thêm thương hiệu mới
                UserController UserController = new UserController();
                bool result = UserController.AddUsers(tennguoidung, matkhau, email, loaitk);

                if (result)
                {
                    MessageBox.Show("Thêm Thương Hiệu Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dgvUsers.DataSource = UserController;

                    dgvUsers.Refresh();
                    EmptyBox();
                }
            }
        }
        private void EmptyBox1()
        {
            txtMatKhau1.Text = string.Empty;
            txtEmail1.Text = string.Empty;
            txtTenNguoiDung1.Text = string.Empty;
            cmbLoaiTKlc.SelectedIndex = 0;
        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên người dùng.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtMatKhau1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbLoaiTKlc.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoảng.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(txtEmail1.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Vui lòng nhập email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            else
            {
                User User = new User(txtTenNguoiDung1.Text, txtMatKhau1.Text.Trim(),txtEmail1.Text.Trim(), cmbLoaiTKlc.SelectedItem.ToString());
                UserController.ChangedUser(User);
                MessageBox.Show("Thay Đổi Thành Công");
                EmptyBox1();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtTenNguoiDung1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên người dùng.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtMatKhau1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbLoaiTKlc.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoảng.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa tài khoảng này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string Username = txtTenNguoiDung1.Text;

                    UserController UserController = new UserController();
                    bool result = UserController.DeleteUsers(Username);

                    if (result)
                    {
                        MessageBox.Show("Xóa thương hiệu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvUsers.Refresh();
                        EmptyBox1();
                    }
                }
            }
        }

        private void tcUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoaiTKlc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNguoiDung1_TextChanged(object sender, EventArgs e)
        {
           
            if (txtTenNguoiDung1.Text.Trim() != null)
            {
                string tendangnhap = txtTenNguoiDung1.Text.Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkcmbquery = "SELECT * FROM dbo.[User] WHERE Users_Name = @name";
                    using (SqlCommand command = new SqlCommand(checkcmbquery, connection))
                    {
                        command.Parameters.AddWithValue("@name", tendangnhap);
                        // Thực thi câu lệnh SQL
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {


                                string cmbloai = reader["Users_Category_Id"].ToString();
                               

                                cmbLoaiTKlc.Text = cmbloai;
                               
                            }
                            else
                            {
                                
                            }
                        }
                    }
                }
            }
            LoadComboBoxLoaiTKLC();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ptbTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void UserControlUser_Load(object sender, EventArgs e)
        {
            lblTotal.Text =dgvUsers.Rows.Count.ToString();
            LoadDataUser();
            LoadComboBoxLoaiTK();
           
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUsers.RowCount)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                if (row.Cells.Count > 2) // Kiểm tra có đủ cột dữ liệu trong dòng hay không
                {
                    cmbLoaiTKlc.SelectedItem = row.Cells[1].Value.ToString();
                    txtTenNguoiDung1.Text = row.Cells[2].Value.ToString();
                    txtMatKhau1.Text = row.Cells[3].Value.ToString();
                    txtEmail1.Text = row.Cells[4].Value.ToString();
                    tcUser.SelectedTab = tpLuaChon;
                }
            }
        }
    }
}
