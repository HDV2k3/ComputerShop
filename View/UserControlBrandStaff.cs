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
    public partial class UserControlBrandStaff : UserControl
    {
        public UserControlBrandStaff()
        {
            InitializeComponent();
        }

  
        private string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        #region Method
        private void LoadBrandData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Brand";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvThuongHieuStaff.DataSource = dataTable;
                    dgvThuongHieuStaff.Columns["Brand_Id"].HeaderText = "Mã Thương Hiệu";
                    dgvThuongHieuStaff.Columns["Brand_Name"].HeaderText = "Tên Thương Hiệu";
                    dgvThuongHieuStaff.Columns["Brand_Status"].HeaderText = "Trạng Thái";
                    lblTongThuongHieuStaff.Text = dgvThuongHieuStaff.Rows.Count.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
        private void SearchBrand(string searchName)
        {
            string query = "SELECT Brand_Id,Brand_Name,Brand_Status FROM Brand WHERE Brand_Name LIKE @SearchName;";

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
                        dgvThuongHieuStaff.DataSource = dataTable;

                        lblTongThuongHieuStaff.Text = dgvThuongHieuStaff.Rows.Count.ToString();
                    }
                }
            }
        }
        #endregion
        #region Event
        private void UserControlBrandStaff_Load(object sender, EventArgs e)
        {
            LoadBrandData();
        }

        private void txtTimkiemStaffBrand_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtTimkiemStaffBrand.Text;
                SearchBrand(searchName);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }
        #endregion
    }
}
