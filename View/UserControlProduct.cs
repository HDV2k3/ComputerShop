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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlProduct : UserControl
    {
        private string id = "";
        byte[] image;
        ImageConverter imageConverter;
        MemoryStream memoryStream;

        public UserControlProduct()
        {
            InitializeComponent();
            imageConverter = new ImageConverter();

        }

        private void ImageUpLoad(PictureBox picture)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Image upload error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EmptyBox()
        {
            txtTenSanPham.Clear();
            picPhoto.Image = null;
            txtGiaTien.Text = "0";
            nudSoLuong.Text = "0";
            cmbThuongHieu.Items.Clear();
            cmbThuongHieu.Items.Add("-- SELECT --");
            ProductController.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = N'Có Sẵn' ORDER BY Brand_Name;", cmbThuongHieu);
            cmbThuongHieu.SelectedIndex = 0;
            cmbLoai.Items.Clear();
            cmbLoai.Items.Add("-- SELECT --");
            ProductController.BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = N'Có Sẵn' ORDER BY Category_Name;", cmbLoai);
            cmbLoai.SelectedIndex = 0;
            cmbTrangThai.SelectedIndex = 0;
        }

        private void EmptyBox1()
        {
            txtTenSanPham1.Clear();
            picPhoto1.Image = null;
            txtGiaTien1.Text = "0";
            nudSoLuong1.Text = "0";
            ComboBoxAutoFill();
            cmbTrangThai1.SelectedIndex = 0;
            id = "";
        }
        private void ComboBoxAutoFill()
        {
            cmbThuongHieu1.Items.Clear();
            cmbThuongHieu1.Items.Add("-- SELECT --");
            ProductController.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = N'Có Sẵn' ORDER BY Brand_Name;", cmbThuongHieu1);
            cmbThuongHieu1.SelectedIndex = 0;
            cmbLoai1.Items.Clear();
            cmbLoai1.Items.Add("-- SELECT --");
            ProductController.BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = N'Có Sẵn' ORDER BY Category_Name;", cmbLoai1);
            cmbLoai1.SelectedIndex = 0;
        }

        private void btnDuyetSanPham_Click(object sender, EventArgs e)
        {
            ImageUpLoad(picPhoto);
        }

        private void btnDuyetSanPham1_Click(object sender, EventArgs e)
        {
            ImageUpLoad(picPhoto1);
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ComboBoxAutoFill();
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                txtTenSanPham1.Text = row.Cells[1].Value.ToString();
                image = (byte[])row.Cells[2].Value;
                memoryStream = new MemoryStream();
                picPhoto1.Image = Image.FromStream(memoryStream);
                txtGiaTien1.Text = row.Cells[3].Value.ToString();
                nudSoLuong1.Text = row.Cells[4].Value.ToString();
                cmbThuongHieu1.SelectedItem = row.Cells[5].Value.ToString();
                cmbLoai1.SelectedItem = row.Cells[6].Value.ToString();
                cmbTrangThai1.SelectedItem = row.Cells[7].Value.ToString();
                tpProduct.SelectedTab = tpLuaChon;
            }
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            txtTenSanPham.Clear();
            picPhoto.Image = null;
            txtGiaTien.Text = "0";
            nudSoLuong.Text = "0";
            cmbThuongHieu.Items.Clear();
            cmbThuongHieu.Items.Add("-- SELECT --");
            ProductController.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = N'Có Sẵn' ORDER BY Brand_Name;", cmbThuongHieu);
            cmbThuongHieu.SelectedIndex = 0;
            cmbLoai.Items.Clear();
            cmbLoai.Items.Add("-- SELECT --");
            ProductController.BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = N'Có Sẵn' ORDER BY Category_Name;", cmbLoai);
            cmbLoai.SelectedIndex = 0;
            cmbTrangThai.SelectedIndex = 0;
        }

        private void tpThemSanPham_Click(object sender, EventArgs e)
        {

        }

        private void tpProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null)
            {
                MessageBox.Show("Please select Image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGiaTien.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter rate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudSoLuong.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbThuongHieu.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbLoai.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtTenSanPham.Text.Trim(), (byte[])imageConverter.ConvertTo(picPhoto.Image, typeof(byte[])), Convert.ToInt32(txtGiaTien.Text), Convert.ToInt32(nudSoLuong.Text), cmbThuongHieu.SelectedItem.ToString(), cmbLoai.SelectedItem.ToString(), cmbTrangThai.SelectedItem.ToString());
                ProductController.AddProduct(product);
                EmptyBox();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tpQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picTimKiem, "Tim Kiem");
        }

        private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
        {
            ProductController.DisplayAndSearch("SELECT Product_Name FROM WHERE Product LIKE '%" + txtTimKiemSanPham.Text + "%';", dgvSanPham);
            lblTotal.Text = dgvSanPham.Rows.Count.ToString();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tpLuaChon_Click(object sender, EventArgs e)
        {

        }

        private void nudSoLuong1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaTien1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTrangThai1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoai1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbThuongHieu1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null)
            {
                MessageBox.Show("Please select Image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGiaTien1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter rate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudSoLuong1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbThuongHieu1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbLoai1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this product", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductController.RemoveProduct(id);
                    EmptyBox1();
                    tpProduct.SelectedTab = tpQuanLySanPham;
                }

            }
        }

        private void picPhoto1_Click(object sender, EventArgs e)
        {

        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSanPham1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tpProduct_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void tpProduct_Enter(object sender, EventArgs e)
        {
            if (id == "")
            {
                tpProduct.SelectedTab = tpQuanLySanPham;
            }
        }

        private void tpQuanLySanPham_Enter(object sender, EventArgs e)
        {
            txtTenSanPham.Clear();
          
            ProductController.DisplayAndSearch("SELECT * FROM Product;", dgvSanPham);
            lblTotal.Text = dgvSanPham.Rows.Count.ToString();
        }

        private void tpThemSanPham_Enter(object sender, EventArgs e)
        {
            EmptyBox();
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
        private void tpProduct_Click(object sender, EventArgs e)
        {
            txtTimKiemSanPham.Clear();
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

                dgvSanPham.DataSource = dataTable;

            }
            lblTotal.Text = dgvSanPham.Rows.Count.ToString();
        }
    }
}
