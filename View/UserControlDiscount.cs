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
    public partial class UserControlDiscount : UserControl
    {
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public UserControlDiscount()
        {
            InitializeComponent();
        }
        private bool IsDuplicateDiscount(string discountid ,string discountname)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Discount WHERE Discounts_Id = @discountid OR Discounts_Name = @discountname";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@discountid", discountid);
                    command.Parameters.AddWithValue("@discountname", discountname);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        return true; // Trùng lặp mã thương hiệu hoặc tên thương hiệu
                    }
                }
            }

            return false; // Không có trùng lặp
        }
        private void EmptyBox()
        {
            txtmagiamgia.Text = "GG" + DateTime.Now.ToString("ddhhmmss");
            txtmota.Text = string.Empty;
            txtsotiengiamgia.Text = string.Empty;
            cmbTrangThai.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmagiamgia.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mã Giảm Giá.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtmota.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập Mô tả chương trình giảm giá.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                else if (txtsotiengiamgia.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập số tiền cần giảm cho chương trình này.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(cmbTrangThai.Text == "--Chọn--")
                {
                    MessageBox.Show("Vui lòng chọn trạng thái cần giảm cho chương trình này.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                else
                {
                    string discountid = txtmagiamgia.Text;
                    string discountname = txtmota.Text;
                    string discountpercent = Convert.ToInt32(txtsotiengiamgia.Text).ToString();
                    string status = cmbTrangThai.Text;
                    // Kiểm tra trùng lặp mã thương hiệu hoặc tên thương hiệu
                    if (IsDuplicateDiscount(discountid, discountname))
                    {
                        MessageBox.Show("Mã Giảm Giá hoặc Mô Tả đã tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Tiếp tục thêm thương hiệu mới
                    DiscountController discountController = new DiscountController();
                    bool result = discountController.AddDiscount(discountid, discountname, discountpercent, status);

                    if (result)
                    {
                        MessageBox.Show("Thêm Mã Giảm Giá  "  + txtmagiamgia.Text +  " Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGiamGia.DataSource = discountController;
                        dgvGiamGia.Refresh();
                        EmptyBox();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TpThemGiamGia_Click(object sender, EventArgs e)
        {
            LoadDisCountData();
        }
      
        private void UserControlDiscount_Load(object sender, EventArgs e)
        {
  
         
            cmbTrangThai.SelectedIndex = 0;
        
            cmbTrangThaiLC.SelectedIndex = 0;
            LoadDisCountData();
            txtmagiamgia.Text = "GG" + DateTime.Now.ToString("ddhhmmss");

        }
        private void LoadDisCountData()
        {
            try
            {
              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM DisCount";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvGiamGia.DataSource = dataTable;
                    dgvGiamGia.Columns["Discounts_Id"].HeaderText = "Mã Giảm Giá";
                    dgvGiamGia.Columns["Discounts_Name"].HeaderText = "Mô Tả";
                    dgvGiamGia.Columns["Discounts_Percent"].HeaderText = "Số Tiền";
                    dgvGiamGia.Columns["Discounts_Status"].HeaderText = "Trạng Thái";
                   
                   
                    lblGiamGia.Text = dgvGiamGia.Rows.Count.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
        private void SearchDiscount(string searchName)
        {
            try
            {
                string query = "SELECT Discounts_Id,Discounts_Name,Discounts_Percent,Discounts_Status FROM DisCount WHERE Discounts_Name LIKE @SearchName;";

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
                            dgvGiamGia.DataSource = dataTable;
                            lblGiamGia.Text = dataTable.Rows.Count.ToString();
                        }
                    }
                }
            }
           catch(Exception) 
            { return; }
        }
   
        private void dgvGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvGiamGia.RowCount)
                {
                    DataGridViewRow row = dgvGiamGia.Rows[e.RowIndex];

                    if (row.Cells.Count > 2) // Kiểm tra có đủ cột dữ liệu trong dòng hay không
                    {
                        TcDiscount.SelectedTab = TpLuaChon;
                        // Đổ dữ liệu vào các controls
                        txtMaGiamGiaLC.Text = row.Cells[0].Value?.ToString();
                        txtMoTaLC.Text = row.Cells[1].Value?.ToString();
                        txtSoTienGiamGiaLC.Text = row.Cells[2].Value?.ToString();
                        cmbTrangThaiLC.Text = row.Cells[3].Value?.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmptyBox1()
        {
            txtMaGiamGiaLC.Text = string.Empty;
            txtMoTaLC.Text = string.Empty;
            txtSoTienGiamGiaLC.Text = string.Empty;
            cmbTrangThaiLC.SelectedIndex = 0;
            LoadDisCountData();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaGiamGiaLC.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Mã Giảm Giá gần đây.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtMoTaLC.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui Lòng Nhập Mô tả chương trình .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtSoTienGiamGiaLC.Text == string.Empty)
                {
                    MessageBox.Show(" Vui lòng nhập số tiền giảm giá .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (cmbTrangThaiLC.Text == "--Chọn--") 
                {
                    MessageBox.Show(" Vui lòng chọn trạng thái .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DisCount disCount = new DisCount(txtMaGiamGiaLC.Text, txtMoTaLC.Text.Trim(), Convert.ToInt32(txtSoTienGiamGiaLC.Text.Trim()), cmbTrangThaiLC.Text);
                    DiscountController.ChangedDiscount(disCount);
                    MessageBox.Show("Thay Đổi Thành Công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGiamGia.DataSource = disCount;
                    dgvGiamGia.Refresh();
                    EmptyBox1();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaGiamGiaLC.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" gần đây.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtMoTaLC.Text.Trim() == string.Empty || txtMoTaLC.Text.Trim() == "No Discount")
                {
                    MessageBox.Show("Mã Mặc Định không thể xóa  .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtSoTienGiamGiaLC.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(" Vui lòng số tiền giảm giá .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa Mã Giảm Giá Này " + txtMaGiamGiaLC.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string discountid = txtMaGiamGiaLC.Text.Trim();
                        DiscountController discountController = new DiscountController();
                        bool result = discountController.DeleteDiscount(discountid);
                        if (result)
                        {
                            MessageBox.Show("Xóa Mã Giảm Giá " + txtMaGiamGiaLC.Text + " thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvGiamGia.DataSource = discountController;
                            dgvGiamGia.Refresh();
                            EmptyBox1();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TpQuanLyGiamGia_Click(object sender, EventArgs e)
        {
            LoadDisCountData();
        }

        private void dgvGiamGia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvGiamGia.RowCount)
            {
                DataGridViewRow row = dgvGiamGia.Rows[e.RowIndex];

                // Check if the row is not an uncommitted new row
                if (!row.IsNewRow)
                {
                    bool hasData = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                        {
                            hasData = true;
                            break;
                        }
                    }

                    // Hide the row if it doesn't have any data
                    row.Visible = hasData;
                }
            }
        }

        private void TpLuaChon_Click(object sender, EventArgs e)
        {

        }

        private void txtMaGiamGiaLC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTaLC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTienGiamGiaLC_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtTimKiem.Text;
                SearchDiscount(searchName);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTimKiem_Validated(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtmota.Text;
                SearchDiscount(searchName);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Hệ Thống Cần Được Bảo Dưỡng Sửa Chữa Để Tiếp Tục Thực Hiện Chứ Năng Này!", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
