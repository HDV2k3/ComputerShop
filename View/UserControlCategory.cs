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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlCategory : UserControl
    {
        public UserControlCategory()
        {
            InitializeComponent();
        }

        #region Method
        public void EmtyBox()
        {
            txtMaLoai.Text = "L" + DateTime.Now.ToString("yyMMddhhmmss");
            txtTenLoai.Clear();
            cmbTrangThai.SelectedIndex = 0;

        }
        public void EmtyBox1()
        {
            txtMaLoai1.Text = string.Empty;
            txtTenLoai1.Clear();
            cmbTrangThai1.SelectedIndex = 0;
            
        }
        #endregion

        private void picTimKiem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picTimKiem, "Search");
        }

        private void tcCategory_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            txtMaLoai.Text = "L" + DateTime.Now.ToString("yyMMddhhmmss");
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Enabled = false;
            txtMaLoai1.ReadOnly = true;
            txtMaLoai1.Enabled = false;
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpQuanLyLoai_Click(object sender, EventArgs e)
        {
            txtTimKiemLoai.Clear();
            /**//*dgvLoai.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Category
                string query = "SELECT * FROM Category";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào datatable
                DataTable dataTable = GetDataFromDatabase();

                // Gán datatable làm nguồn dữ liệu cho DataGridView

                dgvLoai.DataSource = dataTable;

            }
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
        }

        private void txtLoai1_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable GetDataFromDatabase()
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay đổi chuỗi kết nối cho phù hợp

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Category";

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
        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoai.RowCount)
            {
                DataGridViewRow row = dgvLoai.Rows[e.RowIndex];

                if (row.Cells.Count > 2) // Kiểm tra có đủ cột dữ liệu trong dòng hay không
                {
                    // Đổ dữ liệu vào các controls
                    txtMaLoai1.Text = row.Cells[0].Value.ToString();
                    txtTenLoai1.Text = row.Cells[1].Value.ToString();
                    cmbTrangThai1.SelectedItem = row.Cells[2].Value.ToString();
                    tpThemLoai.SelectedTab = tpLuaChon;
                }
            }
        }
        private void tcThemLoai_Enter(object sender, EventArgs e)
        {
            txtTimKiemLoai.Clear();
            /**//*dgvLoai.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Category
                string query = "SELECT * FROM Category";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào datatable
                DataTable dataTable = GetDataFromDatabase();

                // Gán datatable làm nguồn dữ liệu cho DataGridView

                dgvLoai.DataSource = dataTable;

            }
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
        }
        private bool IsDuplicateCategory(string CategoryId, string CategoryName)
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Category WHERE Category_Id = @CategoryId OR Category_Name = @CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", CategoryId);
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true; // Trùng lặp mã Loại hoặc tên Loại
                    }
                }
            }

            return false; // Không có trùng lặp
        }
        private bool ValidateCategoryName(string CategoryName)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa ký tự đặc biệt và số
            string pattern = @"^[\p{L}\s]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(CategoryName);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã Loại.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenLoai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên Loại.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!ValidateCategoryName(txtTenLoai.Text.Trim()))
            {
                MessageBox.Show("Tên Loại không được chứa ký tự đặc biệt và số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string CategoryId = txtMaLoai.Text;
                string CategoryName = txtTenLoai.Text;
                string CategoryStatus = cmbTrangThai.SelectedItem.ToString();

                // Kiểm tra trùng lặp mã Loại hoặc tên Loại
                if (IsDuplicateCategory(CategoryId, CategoryName))
                {
                    MessageBox.Show("Mã Loại hoặc tên Loại đã tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tiếp tục thêm Loại mới
                CategoryController CategoryController = new CategoryController();
                bool result = CategoryController.AddCategory(CategoryId, CategoryName, CategoryStatus);

                if (result)
                {
                    MessageBox.Show("Thêm Loại Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dgvLoai.DataSource = CategoryController;

                    dgvLoai.Refresh();
                    EmtyBox();
                }
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Loại gần đây.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenLoai1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập Tên Loại .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai1.SelectedIndex == 0)
            {
                MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Category category = new Category(txtMaLoai1.Text,txtTenLoai1.Text, cmbTrangThai1.SelectedItem.ToString());
                CategoryController.ChangedCategory(category);
                MessageBox.Show("Thay Đổi Thành Công");
                EmtyBox1();
            }
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Loai gần đây.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtTenLoai1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập Tên Loại .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai1.SelectedIndex == 0)
            {
                MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa Loại này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string CategoryName = txtTenLoai1.Text;

                    CategoryController CategoryController = new CategoryController();
                    bool result = CategoryController.DeleteCategory(CategoryName);

                    if (result)
                    {
                        MessageBox.Show("Xóa Loại thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvLoai.Refresh();
                        EmtyBox1();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }    
                }
            }
        }
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn
        private void SearchCategory(string searchName)
        {
            string query = "SELECT Category_Name,Category_Id,Category_Status FROM Category WHERE Category_Name LIKE @SearchName;";

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
                        dgvLoai.DataSource = dataTable;

                        lblTotal.Text = dataTable.Rows.Count.ToString();
                    }
                }
            }
        }
        private void txtTimKiemLoai_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtTimKiemLoai.Text;
            SearchCategory(searchName);
        }

        private void tpLuaChon_Enter(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == string.Empty)
            {
                tpThemLoai.SelectedTab = tpQuanLyLoai;
            }
        }

        private void tpLuaChon_Leave(object sender, EventArgs e)
        {
            EmtyBox1();
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {

          
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Brand
                string query = "SELECT * FROM Category";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào datatable
                DataTable dataTable = GetDataFromDatabase();

                // Gán datatable làm nguồn dữ liệu cho DataGridView

                dgvLoai.DataSource = dataTable;

            }
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoai.RowCount)
            {
                DataGridViewRow row = dgvLoai.Rows[e.RowIndex];

                if (row.Cells.Count > 2) // Kiểm tra có đủ cột dữ liệu trong dòng hay không
                {
                    // Đổ dữ liệu vào các controls
                    txtMaLoai1.Text = row.Cells[0].Value.ToString();
                    txtTenLoai1.Text = row.Cells[1].Value.ToString();
                    cmbTrangThai1.SelectedItem = row.Cells[2].Value.ToString();
                    tpThemLoai.SelectedTab = tpLuaChon;
                }
            }
        }

        private void tpThemLoai_Click(object sender, EventArgs e)
        {
            txtTimKiemLoai.Clear();
            /**//*dgvLoai.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Category
                string query = "SELECT * FROM Category";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào datatable
                DataTable dataTable = GetDataFromDatabase();

                // Gán datatable làm nguồn dữ liệu cho DataGridView

                dgvLoai.DataSource = dataTable;

            }
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
        }
    }
}
