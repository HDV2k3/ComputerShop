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
        public UserControlReport()
        {
            InitializeComponent();
        }

        private void tpReport_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel28_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Tạo kết nối đến cơ sở dữ liệu
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (rdoTongDoanhThu.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateTotalRevenue", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;


                    }
                }
                else if (rdoSLSPDaBan.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateSoldProductCount1", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;

                    }
                }
                else if (rdoDoanhThuTheoSP.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateRevenueByProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;

                    }
                }
                else if (rdoDoanhThuTheoKH.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateRevenueByCustomer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;
                    }
                }
                else if (rdoLoiNhuan.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateProfit", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;
                    }
                }
                else if (rdoSLDonHang.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateOrderCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;
                    }
                }
                else if (rdoSLKHangMoi.Checked == true)
                {
                    // Tạo và cấu hình SqlCommand để gọi stored procedure
                    using (SqlCommand command = new SqlCommand("CalculateNewCustomerCount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        // Tạo SqlDataAdapter và DataTable để lấy kết quả từ stored procedure
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị kết quả trên DataGridView
                        dgvAnalys.DataSource = dataTable;
                    }
                }
               
                    
            }

        }
   
        private void UserControlReport_Load(object sender, EventArgs e)
        {

        }

        private void rdoLoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLoiNhuan.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }
        }

        private void rdoTongDoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTongDoanhThu.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }
        }

        private void dgvAnalys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void rdoSLSPDaBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSLSPDaBan.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }
        }

        private void dgvAnalys_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void rdoDoanhThuTheoSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDoanhThuTheoSP.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }

        }

        private void rdoDoanhThuTheoKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDoanhThuTheoKH.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }
        }

        private void rdoSLDonHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSLDonHang.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }
        }

        private void rdoSLKHangMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSLKHangMoi.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }
        }

      
    }
}
