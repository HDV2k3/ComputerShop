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
   
        private void UserControlReport_Load(object sender, EventArgs e)
        {

        }

        private void rdoLoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
           /* if (rdoLoiNhuan.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/
        }

        private void rdoTongDoanhThu_CheckedChanged(object sender, EventArgs e)
        {
           /* if (rdoTongDoanhThu.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/
        }

        private void dgvAnalys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void rdoSLSPDaBan_CheckedChanged(object sender, EventArgs e)
        {
         /*   if (rdoSLSPDaBan.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/
        }

        private void dgvAnalys_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void rdoDoanhThuTheoSP_CheckedChanged(object sender, EventArgs e)
        {
           /* if (rdoDoanhThuTheoSP.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/

        }

        private void rdoDoanhThuTheoKH_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (rdoDoanhThuTheoKH.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/
        }

        private void rdoSLDonHang_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rdoSLDonHang.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/
        }

        private void rdoSLKHangMoi_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rdoSLKHangMoi.Checked)
            {
                // Kích hoạt nút tìm kiếm
                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                // Vô hiệu hóa nút tìm kiếm
                btnTaoBaoCao.Enabled = false;
            }*/
        }

      
    }
}
