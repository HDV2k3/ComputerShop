using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlUserStaff : UserControl
    {
        public UserControlUserStaff()
        {
            InitializeComponent();
        }
        private string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        #region Method
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Users_Id,Users_Category_Id,Users_Name,users_Email FROM dbo.[User]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvUsersStaff.DataSource = dataTable;
                    dgvUsersStaff.Columns["Users_Id"].HeaderText = "Mã Người Dùng";
                    dgvUsersStaff.Columns["Users_Category_Id"].HeaderText = "Mã Loại Người Dùng";
                    dgvUsersStaff.Columns["Users_Name"].HeaderText = "Tên Đăng Nhập";
                    dgvUsersStaff.Columns["Users_Email"].HeaderText = "Email";
                    lblTongNhanVienStaff.Text = dgvUsersStaff.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void SearchUser(string searchName)
        {
            string query = "SELECT Users_Id,Users_Category_Id,Users_Name,users_Password FROM dbo.[User] WHERE Users_Name LIKE @SearchName;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvUsersStaff.DataSource = dataTable;

                        lblTongNhanVienStaff.Text = dgvUsersStaff.Rows.Count.ToString();
                    }
                }
            }
        }
        #endregion
        #region Event
        private void UserControlUserStaff_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void txtTimKiemThuongHieuStaff_TextChanged(object sender, EventArgs e)
        {
            SearchUser(txtTimKiemThuongHieuStaff.Text.Trim());
        }
        #endregion
    }
}
