using Computer_Shop_Management_System.Controller;
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
    public partial class UserControlDashboard : UserControl
    {
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        #region Method
        private void LoadProductCount()
        {
            string query = "SELECT COUNT(*) FROM Product WHERE Product_Quantity < 10";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int productCount = (int)command.ExecuteScalar();
                    lblLowStock.Text = productCount.ToString();
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi kết nối và truy vấn
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        #endregion
        #region Event
        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            lblTongSanPham.Text = Computer.CountProducts("SELECT Count (*) FROM Product;").ToString();
            lblTongDoanhThu.Text = Computer.CountTotal_Amout().ToString();
            lblTongSoDonDH.Text = Computer.CountTotal_Order().ToString();
            LoadProductCount();
        }
        #endregion

    }
}
