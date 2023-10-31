using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlBrand : UserControl
    {
        
        public UserControlBrand()
        {
            InitializeComponent();
        }
        #region Event
        private void dgvThuongHieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvThuongHieu.RowCount)
            {
                DataGridViewRow row = dgvThuongHieu.Rows[e.RowIndex];

                if (row.Cells.Count > 2) // Kiểm tra có đủ cột dữ liệu trong dòng hay không
                {
                    // Đảm bảo chỉ số cột hợp lệ
                    if (row.Cells[0].Value != null)
                    {
                        txtMaThuongHieu1.Text = row.Cells[0].Value.ToString();
                    }
                    if (row.Cells[1].Value != null)
                    {
                        txtTenThuongHieu1.Text = row.Cells[1].Value.ToString();
                    }
                    if (row.Cells[2].Value != null)
                    {
                        cmbTRangThai1.SelectedItem = row.Cells[2].Value.ToString();
                    }
                    tpThuongHieu.SelectedTab = tpLuaChon;
                }
            }
        }
        private void UserControlBrand_Load(object sender, EventArgs e)
        {
            txtMaThuongHieu.Text = "TH" + DateTime.Now.ToString("ddhhmmss");
            lblTotal.Text = dgvThuongHieu.Rows.Count.ToString();
            cmbTrangThai.SelectedIndex = 0;
            txtMaThuongHieu.ReadOnly = true;
            txtMaThuongHieu.Enabled = false;
            txtMaThuongHieu1.ReadOnly = true;
            txtMaThuongHieu1.Enabled = false;
        }
        private void tpThemThuongThieu_Enter(object sender, EventArgs e)
        {
            txtTimKiemThuongThieu.Clear();
            /**//*dgvThuongHieu.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
                // Đổi tên cột hiển thị trên DataGridView
                dgvThuongHieu.Columns["Brand_Id"].HeaderText = "Mã Thương Hiệu";
                dgvThuongHieu.Columns["Brand_Name"].HeaderText = "Tên Thương Hiệu";
                dgvThuongHieu.Columns["Brand_Status"].HeaderText = "Trạng Thái";
                dgvThuongHieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            }
            lblTotal.Text = dgvThuongHieu.Rows.Count.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaThuongHieu.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mã thương hiệu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtTenThuongHieu.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập tên thương hiệu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!ValidateBrandName(txtTenThuongHieu.Text.Trim()))
                {
                    MessageBox.Show("Tên thương hiệu không được chứa ký tự đặc biệt và số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cmbTrangThai.SelectedIndex == -1||cmbTrangThai.Text == "--Chọn--")
                {
                    MessageBox.Show("Vui lòng chọn trạng thái.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string brandId = txtMaThuongHieu.Text;
                    string brandName = txtTenThuongHieu.Text;
                    string brandStatus = cmbTrangThai.SelectedItem.ToString();
                    // Kiểm tra trùng lặp mã thương hiệu hoặc tên thương hiệu
                    if (IsDuplicateBrand(brandId, brandName))
                    {
                        MessageBox.Show("Mã thương hiệu hoặc tên thương hiệu đã tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Tiếp tục thêm thương hiệu mới
                    BrandController brandController = new BrandController();
                    bool result = brandController.AddBrand(brandId, brandName, brandStatus);

                    if (result)
                    {
                        MessageBox.Show("Thêm Thương Hiệu" + txtTenThuongHieu.Text + "Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvThuongHieu.DataSource = brandController;
                        dgvThuongHieu.Refresh();
                        EmptyBox();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!","Xin Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            try
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
                    Brand brand = new Brand(txtMaThuongHieu1.Text, txtTenThuongHieu1.Text.Trim(), cmbTRangThai1.SelectedItem.ToString());
                    BrandController.ChangedBrand(brand);
                    MessageBox.Show("Thay Đổi Thành Công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyBox1();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
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
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thương hiệu" + txtTenThuongHieu1.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string brandId = txtMaThuongHieu1.Text.Trim();
                        BrandController brandController = new BrandController();
                        bool result = brandController.DeleteBrand(brandId);
                        if (result)
                        {
                            MessageBox.Show("Xóa thương hiệu " + txtTenThuongHieu1.Text + " thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvThuongHieu.Refresh();
                            EmtyBox1();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void txtLoadData_Click(object sender, EventArgs e)
        {

            try
            {
                /**//*dgvThuongHieu.Columns[0].Visible = true;*/
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
            catch(Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void picTimKiem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Search");
        }
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn
        private void txtTimKiemThuongThieu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtTimKiemThuongThieu.Text;
                SearchBrand(searchName);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void tpLuaChon_Enter(object sender, EventArgs e)
        {
            if (txtMaThuongHieu.Text.Trim() == string.Empty)
            {
                tpThuongHieu.SelectedTab = tpQuanLyThuongHieu;
            }
        }
        private void tpLuaChon_Leave(object sender, EventArgs e)
        {
            EmtyBox1();
        }
        private void tpThemThuongThieu_Click(object sender, EventArgs e)
        {
            txtTimKiemThuongThieu.Clear();
            /**//*dgvThuongHieu.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
        private void dgvThuongHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvThuongHieu.RowCount)
                {
                    DataGridViewRow row = dgvThuongHieu.Rows[e.RowIndex];

                    if (row.Cells.Count > 2) // Kiểm tra có đủ cột dữ liệu trong dòng hay không
                    {
                        // Đổ dữ liệu vào các controls
                        txtMaThuongHieu1.Text = row.Cells[0].Value.ToString();
                        txtTenThuongHieu1.Text = row.Cells[1].Value.ToString();
                        cmbTRangThai1.SelectedItem = row.Cells[2].Value.ToString();
                        tpThuongHieu.SelectedTab = tpLuaChon;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion
        #region Method
        public void EmptyBox()
        {
            txtTenThuongHieu.Clear();
            cmbTrangThai.SelectedIndex = 0;
            txtMaThuongHieu.Text = "TH" + DateTime.Now.ToString("yyMMddhhmmss");

        }
        public void EmtyBox1()
        {
            txtMaThuongHieu1.Text = string.Empty;
            txtTenThuongHieu1.Clear();
            cmbTRangThai1.SelectedIndex = 0;

        }
        private void EmptyBox1()
        {
            txtMaThuongHieu1.Text = string.Empty;
            txtTenThuongHieu1.Text = string.Empty;
            cmbTRangThai1.SelectedIndex = 0;
        }
        public DataTable GetDataFromDatabase()
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay đổi chuỗi kết nối cho phù hợp

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
        #endregion
        #region constraint
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
                        dgvThuongHieu.DataSource = dataTable;

                        lblTotal.Text = dataTable.Rows.Count.ToString();
                    }
                }
            }
        }
        private bool IsDuplicateBrand(string brandId, string brandName)
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Brand WHERE Brand_Id = @BrandId OR Brand_Name = @BrandName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BrandId", brandId);
                    command.Parameters.AddWithValue("@BrandName", brandName);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true; // Trùng lặp mã thương hiệu hoặc tên thương hiệu
                    }
                }
            }

            return false; // Không có trùng lặp
        }
        private bool ValidateBrandName(string brandName)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa ký tự đặc biệt và số
            string pattern = @"^[\p{L}\s]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(brandName);
        }     
        private void txtTenThuongHieu_KeyDown(object sender, KeyEventArgs e)
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
        private void txtTenThuongHieu_KeyPress(object sender, KeyPressEventArgs e)
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
        // Phương thức kiểm tra ký tự đặc biệt
        private void txtTenThuongHieu_TextChanged(object sender, EventArgs e)
        {
            string input = txtTenThuongHieu.Text;
            string sanitizedInput = RemoveInvalidCharacters(input);
            txtTenThuongHieu.Text = sanitizedInput;
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
