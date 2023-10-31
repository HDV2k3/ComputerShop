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
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn

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
        public DataTable GetDataFromDatabase()
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay đổi chuỗi kết nối cho phù hợp

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
        #endregion
        #region Event
        private void picTimKiem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picTimKiem, "Search");
        }    
        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            txtMaLoai.Text = "L" + DateTime.Now.ToString("ddhhmmss");
        
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Enabled = false;
            txtMaLoai1.ReadOnly = true;
            txtMaLoai1.Enabled = false;
            cmbTrangThai.SelectedIndex = 0;
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
                dgvLoai.Columns["Category_Id"].HeaderText = "Mã Loại";
                dgvLoai.Columns["Category_Name"].HeaderText = "Tên Loại";
                dgvLoai.Columns["Category_Status"].HeaderText = "Trạng Thái";


            }
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
        }
        private void tpQuanLyLoai_Click(object sender, EventArgs e)
        {
            txtTimKiemLoai.Clear();
            /**//*dgvLoai.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
                dgvLoai.Columns["Category_Id"].HeaderText = "Mã Loại";
                dgvLoai.Columns["Category_Name"].HeaderText = "Tên Loại";
                dgvLoai.Columns["Category_Status"].HeaderText = "Trạng Thái";


            }
            lblTotal.Text = dgvLoai.Rows.Count.ToString();
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
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

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
            //uguyiy

            return regex.IsMatch(CategoryName);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
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
                else if (cmbTrangThai.SelectedIndex == -1 || cmbTrangThai.Text == "--Chọn--")
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
                        MessageBox.Show("Thêm Loại " + txtTenLoai.Text + " Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        dgvLoai.DataSource = CategoryController;

                        dgvLoai.Refresh();
                        EmtyBox();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn Cần Liên Hệ bộ phận IT để Bào Trì chức năng này!", "Chúng tôi sẽ sớm quay lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            try
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
                else if (cmbTrangThai1.SelectedIndex == 0 || cmbTrangThai1.Text == "--Chọn--")
                {
                    MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Category category = new Category(txtMaLoai1.Text, txtTenLoai1.Text, cmbTrangThai1.SelectedItem.ToString());
                    CategoryController.ChangedCategory(category);
                    MessageBox.Show("Thay Đổi Thành Công");
                    EmtyBox1();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn Cần Liên Hệ bộ phận IT để Bào Trì chức năng này!", "Chúng tôi sẽ sớm quay lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
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
                else if (cmbTrangThai1.SelectedIndex == 0 || cmbTrangThai1.Text =="--Chọn--")
                {
                    MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa Loại " + txtTenLoai1.Text.Trim() + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string CategoryId = txtMaLoai1.Text.Trim();

                        CategoryController CategoryController = new CategoryController();
                        bool result = CategoryController.DeleteCategory(CategoryId);

                        if (result)
                        {
                            MessageBox.Show("Xóa Loại " + txtTenLoai1.Text.Trim() + "  thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            catch (Exception)
            {
                MessageBox.Show("Bạn Cần Liên Hệ bộ phận IT để Bào Trì chức năng này!", "Chúng tôi sẽ sớm quay lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtTimKiemLoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtTimKiemLoai.Text;
                SearchCategory(searchName);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn Cần Liên Hệ bộ phận IT để Bào Trì chức năng này!", "Chúng tôi sẽ sớm quay lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Bạn Cần Liên Hệ bộ phận IT để Bào Trì chức năng này!", "Chúng tôi sẽ sớm quay lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void tpThemLoai_Click(object sender, EventArgs e)
        {
            txtTimKiemLoai.Clear();
            /**//*dgvLoai.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
        #endregion
        #region constraint
        private void txtTenLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                e.Handled = true; // Vô hiệu hóa sự kiện Copy
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true; // Vô hiệu hóa sự kiện Paste
            }
        }
        // Phương thức kiểm tra ký tự đặc biệt
        private bool IsSpecialCharacter(char c)
        {
            return !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c);
        }
        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || IsSpecialCharacter(e.KeyChar))
            {
                if (e.KeyChar != '\b') // Kiểm tra ký tự khác với phím Backspace
                {
                    e.Handled = true; // Vô hiệu hóa ký tự không hợp lệ
                }
            }
        }
        // Phương thức loại bỏ các ký tự không hợp lệ
        private string RemoveInvalidCharacters(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {
            string input = txtTenLoai.Text;
            string sanitizedInput = RemoveInvalidCharacters(input);
            txtTenLoai.Text = sanitizedInput;
        }
        private void cmbTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Vô hiệu hóa ký tự không hợp lệ
        }
        private void cmbTrangThai_DropDown(object sender, EventArgs e)
        {
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList; // Chỉ cho phép chọn từ danh sách
        }
        private void cmbTrangThai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                e.Handled = true; // Vô hiệu hóa sự kiện Copy
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true; // Vô hiệu hóa sự kiện Paste
            }
        }
        #endregion
    }
}
