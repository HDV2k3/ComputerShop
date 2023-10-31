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
    public partial class UserControlProductStaff : UserControl
    {
        public UserControlProductStaff()
        {
            InitializeComponent();
        }

   
        private string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        #region Method
        private void LoadProductData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Product";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvSanPhamStaff.DataSource = dataTable;
                    dgvSanPhamStaff.Columns["Product_Id"].HeaderText = "Mã Sản Phẩm";
                    dgvSanPhamStaff.Columns["Product_Name"].HeaderText = "Tên Sản Phẩm";
                    dgvSanPhamStaff.Columns["Product_Image"].HeaderText = "Ảnh Sản Phẩm";
                    dgvSanPhamStaff.Columns["Product_Rate"].HeaderText = "Giá Tiền";
                    dgvSanPhamStaff.Columns["Product_Quantity"].HeaderText = "Số Lượng";
                    dgvSanPhamStaff.Columns["Product_Brand"].HeaderText = "Thương Hiệu";
                    dgvSanPhamStaff.Columns["Product_Category"].HeaderText = "Loại";
                    dgvSanPhamStaff.Columns["Product_Stastus"].HeaderText = "Trạng Thái";
                    lblTongSanPhamStaff.Text = dgvSanPhamStaff.Rows.Count.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void SearchProduct(string searchName)
        {
            string query = "SELECT Product_Id,Product_Name,Product_Image,Product_Rate,Product_Quantity,Product_Brand,Product_Category,Product_Stastus FROM Product WHERE Product_Name LIKE @SearchName;";

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
                        dgvSanPhamStaff.DataSource = dataTable;

                        lblTongSanPhamStaff.Text = dgvSanPhamStaff.Rows.Count.ToString();
                    }
                }
            }
        }
        #endregion
        #region Event
        private void UserControlProductStaff_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void txtTimKiemSanPhamStaff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchProduct(txtTimKiemSanPhamStaff.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:việt 0329615309 để update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


    }
}
