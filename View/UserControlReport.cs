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
    public partial class UserControlReport : UserControl
    {
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public UserControlReport()
        {
            InitializeComponent();
        }

       
        private void HienThiSanPhamBanChay()
        {
          
            string storedProcedure = "GetBestSellingProducts";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvAnalys.DataSource = dataTable;
                           
                           
                            dgvAnalys.Columns["Product_Name"].HeaderText = "Tên Sản Phẩm";
                          
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi kết nối và truy vấn
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void HienThiSapHetHang()
        {
            string query = "SELECT * FROM Product WHERE Product_Quantity < 10";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvAnalys.DataSource = dataTable;
                    dgvAnalys.Columns["Product_Id"].HeaderText = "Mã Sản Phẩm";
                    dgvAnalys.Columns["Product_Id"].HeaderText = "Mã Sản Phẩm";
                    dgvAnalys.Columns["Product_Name"].HeaderText = "Tên Sản Phẩm";
                    dgvAnalys.Columns["Product_Image"].HeaderText = "Ảnh Sản Phẩm";
                    dgvAnalys.Columns["Product_Rate"].HeaderText = "Giá Tiền";
                    dgvAnalys.Columns["Product_Quantity"].HeaderText = "Số Lượng";
                    dgvAnalys.Columns["Product_Brand"].HeaderText = "Thương Hiệu";
                    dgvAnalys.Columns["Product_Category"].HeaderText = "Loại";
                    dgvAnalys.Columns["Product_Stastus"].HeaderText = "Trạng Thái";
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi kết nối và truy vấn
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ckbSanPhamSapHetHang.Checked)
            {
                HienThiSapHetHang();
            }   
            if(ckbsanphambanchaynhat.Checked)
            {
                HienThiSanPhamBanChay();
            }    

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Khởi tạo danh sách tên stored procedure cần gọi
            List<string> storedProcedures = new List<string>();
            List<Color> storedProcedureColors = new List<Color>();

            if (ckbTongDoanhThu.Checked)
                storedProcedures.Add("CalculateTotalRevenue");
            storedProcedureColors.Add(Color.Red); // Đổi màu thành màu đỏ
            if (ckbSLSPDaBan.Checked)
                storedProcedures.Add("CalculateSoldProductCount1");
            storedProcedureColors.Add(Color.Blue); // Đổi màu thành màu xan
            if (ckbSLSPDaBan.Checked)
                storedProcedures.Add("CalculateRevenueByProduct");
            storedProcedureColors.Add(Color.Purple); // Đổi màu thành màu tím
            if (ckbDoanhThuTheoKH.Checked)
                storedProcedures.Add("CalculateRevenueByCustomer");
            storedProcedureColors.Add(Color.Yellow); // Đổi màu thành màu tím
            if (ckbLoiNhuan.Checked)
                storedProcedures.Add("CalculateProfit");
            storedProcedureColors.Add(Color.Green);
            if (ckbSLDonHang.Checked)
                storedProcedures.Add("CalculateOrderCount");
            storedProcedureColors.Add(Color.Orange);
            if (ckbSLKhachHangMoi.Checked)
                storedProcedures.Add("CalculateNewCustomerCount");
          

            // Kiểm tra xem có ít nhất một stored procedure được chọn hay không
            if (storedProcedures.Count > 0)
            {
                // Tạo DataTable chứa kết quả
                DataTable resultDataTable = new DataTable();

                // Tạo kết nối đến cơ sở dữ liệu
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Lặp qua danh sách stored procedure
                    for (int i = 0; i < storedProcedures.Count; i++)
                    {
                        string storedProcedure = storedProcedures[i];
                        Color storedProcedureColor = storedProcedureColors[i];

                        // Tạo và cấu hình SqlCommand để gọi stored procedure
                        using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@startDate", startDate);
                            command.Parameters.AddWithValue("@endDate", endDate);

                            // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            // Thêm kết quả vào DataTable tổng hợp
                            adapter.Fill(resultDataTable);

                            // Đặt màu cho cột tương ứng với stored procedure
                           /* dgvAnalys.Columns[i].DefaultCellStyle.ForeColor = storedProcedureColor;*/
                        }
                    }
                }

               
                // Hiển thị kết quả trên DataGridView
                dgvAnalys.DataSource = resultDataTable;


            }

        }
   
       
    }
}
