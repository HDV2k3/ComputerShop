using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
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
    public partial class UserControlBrand : UserControl
    {
        
        public UserControlBrand()
        {
            InitializeComponent();
        }

        /*  public void EmptyBox()
        {
            txtbrandname.Clear();
            cmbstatus.SelectedIndex = 0;

        }*/
        public void EmtyBox1()
        {
            txtTenThuongHieu.Clear();
            cmbTrangThai.SelectedIndex = 0;

        }
            

        private void UserControlBrand_Load(object sender, EventArgs e)
        {
            txtMaThuongHieu.Text = "TH" + DateTime.Now.ToString("yyMMddhhmmss");
        }

    

        private void picTimKiem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picTimKiem, "Search");
        }

      

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenThuongHieu.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter brand name. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string brandId = txtMaThuongHieu.Text;
                string brandName = txtTenThuongHieu.Text;
                string brandStatus = cmbTrangThai.SelectedItem.ToString();

                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Brand (Brand_Id, Brand_Name, Brand_Status) VALUES (@BrandId, @BrandName, @BrandStatus)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BrandId", brandId);
                        command.Parameters.AddWithValue("@BrandName", brandName);
                        command.Parameters.AddWithValue("@BrandStatus", brandStatus);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm Thương Hiệu Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    

        private void tpThemThuongThieu_Enter(object sender, EventArgs e)
        {
            txtTimKiemThuongHieu.Clear();
            dgvThuongHieu.Columns[0].Visible = false;
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection("data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Brand
                string query = "SELECT * FROM Brand";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào datatable
                DataTable dataTable = GetDataFromDatabase();

                // Gán datatable làm nguồn dữ liệu cho DataGridView
                dgvThuongHieu.DataSource = dataTable;
            }
            lblTotal.Text = dgvThuongHieu.Rows.Count.ToString();
        }
        public DataTable GetDataFromDatabase()
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay đổi chuỗi kết nối cho phù hợp

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Brand";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void txtTimKiemThuongThieu_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtTimKiemThuongHieu.Text;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection("data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy các brand thỏa mãn điều kiện
                string query = "SELECT * FROM Brand WHERE Brand_Name LIKE @SearchKeyword";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");
                SqlDataReader reader = command.ExecuteReader();

                // Tạo DataTable để lưu dữ liệu từ truy vấn
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dgvThuongHieu.DataSource = dataTable;
            }
            lblTotal.Text = dgvThuongHieu.Rows.Count.ToString();
        }

        private void dgvThuongHieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvThuongHieu.Rows[e.RowIndex];
                txtMaThuongHieu.Text = row.Cells[0].Value.ToString();
                txtTenThuongHieu.Text = row.Cells[1].Value.ToString();
                cmbTrangThai.SelectedItem = row.Cells[2].Value.ToString();

                tpThemThuongThieu.SelectedTab = tpLuaChon;
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMaThuongHieu.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Thương hiệu gần đây.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenThuongHieu1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập Tên Thương Hiệu .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTRangThai1.SelectedIndex == 0)
            {
                MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string str = "INSERT INTO Brand(Brand_Id,Brand_Name,Brand_Status)  VALUES ( '" + txtMaThuongHieu.Text + "','" + txtTenThuongHieu1.Text + "','" + cmbTRangThai1.Text + "')";
                DataProvider.ExecuteNonQuery(str);

                foreach (DataGridViewRow rows in dgvThuongHieu.Rows)
                {
                    string a = "SELECT * FROM Product WHERE Product_Name = N'" + rows.Cells[0].Value.ToString() + "' ";
                    DataTable dt = new DataTable();
                    dt = DataProvider.GetData(a);


                    /* int Product_Id = Convert.ToInt32(dt.Rows[0][0].ToString());

                     int Amout = Convert.ToInt32(rows.Cells[2].Value.ToString());
                     int Product_Rate = Convert.ToInt32(rows.Cells[1].Value.ToString());
                     int Total = Convert.ToInt32(rows.Cells[3].Value.ToString());
                     string str2 = "INSERT INTO OrderDetails(Orders_Id,Product_Id,Amout,Product_Rate,Total)  VALUES ( '" + txtOrders_Id.Text + "'," + Product_Id + "," + Amout + "," + Product_Rate + "," + Total + ")";
                     DataProvider.ExecuteNonQuery(str2);*/
                }
                tpThemThuongThieu.SelectedTab = tpQuanLyThuongHieu;
                EmtyBox1();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThuongHieu.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Thương hiệu gần đây.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenThuongHieu1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập Tên Thương Hiệu .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTRangThai1.SelectedIndex == 0)
            {
                MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thương hiệu này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string brandName = txtTenThuongHieu1.Text;

                    // Kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection("data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                    {
                        // Mở kết nối
                        connection.Open();

                        // Câu truy vấn DELETE để xóa thương hiệu
                        string query = "DELETE FROM Brand WHERE Brand_Name = @BrandName";

                        // Thực hiện truy vấn
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@BrandName", brandName);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thương hiệu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Thực hiện làm mới DataGridView hoặc các hoạt động cần thiết khác
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thương hiệu để xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void tpLuaChon_Enter(object sender, EventArgs e)
        {
            if (txtMaThuongHieu.Text.Trim() == string.Empty)
            {
                tpThemThuongThieu.SelectedTab = tpQuanLyThuongHieu;
            }
        }

        private void tpLuaChon_Leave(object sender, EventArgs e)
        {
            EmtyBox1();
        }
    }
}
