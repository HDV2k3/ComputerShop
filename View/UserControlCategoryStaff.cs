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
    public partial class UserControlCategoryStaff : UserControl
    {
        public UserControlCategoryStaff()
        {
            InitializeComponent();
        }
        #region Method
        private string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private void LoadCategoryData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Category";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLoaiStaff.DataSource = dataTable;
                    dgvLoaiStaff.Columns["Category_Id"].HeaderText = "Mã Loại";
                    dgvLoaiStaff.Columns["Category_Name"].HeaderText = "Tên loại";
                    dgvLoaiStaff.Columns["Category_Status"].HeaderText = "Trạng Thái";
                    lblTongSoLoaiStaff.Text = dgvLoaiStaff.Rows.Count.ToString();

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Alo Coder:0329615309 để được update hệ thống","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void SearchCategory(string searchName)
        {
            try
            {
                string query = "SELECT Category_Id,Category_Name,Category_Status FROM Category WHERE Category_Name LIKE @SearchName;";

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
                            dgvLoaiStaff.DataSource = dataTable;
                            dgvLoaiStaff.Columns["Category_Id"].HeaderText = "Mã Loại";
                            dgvLoaiStaff.Columns["Category_Name"].HeaderText = "Tên Loại";
                            dgvLoaiStaff.Columns["Category_Status"].HeaderText = "Trạng Thái";

                            lblTongSoLoaiStaff.Text = dgvLoaiStaff.Rows.Count.ToString();
                        }
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Alo Coder:0329615309 để được update hệ thống", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
        #region Event
        private void UserControlCategoryStaff_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
        }
        private void txtTimKiemLoaiStaff_TextChanged(object sender, EventArgs e)
        {
            SearchCategory(txtTimKiemLoaiStaff.Text.Trim());
        }
        #endregion

        
    }
}
