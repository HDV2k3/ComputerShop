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
    /*    void GetFile()
        {
            System.Windows.Forms.OpenFileDialog openImage = new OpenFileDialog();
            openImage.Title = "Select your image";
            openImage.InitialDirectory = "C:";
            openImage.Filter = "Image Only(.jpg; *.jpeg; *.gif; *.bmp; *.png)|.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openImage.AutoUpgradeEnabled = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                String Chosen_File = openImage.FileName;

                string filename = System.IO.Path.GetFileName(Chosen_File);
                String inputExt = (Path.GetExtension(filename).ToLower());
                try
                {
                    System.IO.File.Copy(Chosen_File, @"..\..Computer Shop Management System\Images" + filename);
                }
                catch
                {
                }
                Invoke((MethodInvoker)delegate
                {

                    picPhoto.Image = new Bitmap(Chosen_File);
                    picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                });
            }
        }*/
        private void ImageUpLoad(PictureBox picture)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openImage = new OpenFileDialog();
                openImage.Filter = "Image Only(.jpg; *.jpeg; *.gif; *.bmp; *.png)|.jpg; *.jpeg; *.gif; *.bmp; *.png";
                openImage.AutoUpgradeEnabled = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String Chosen_File = openImage.FileName;

                    string filename = System.IO.Path.GetFileName(Chosen_File);
                    String inputExt = (Path.GetExtension(filename).ToLower());
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
           /* GetFile();*/
        }

        private void btnDuyetSanPham1_Click(object sender, EventArgs e)
        {
            ImageUpLoad(picPhoto1);
      /*      GetFile();*/
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           /* if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                // Đổ dữ liệu vào các controls
                txtTenSanPham1.Text = row.Cells[1].Value.ToString();
                txtGiaTien1.Text = row.Cells[3].Value.ToString();
                nudSoLuong1.Value = Convert.ToDecimal(row.Cells[4].Value);

                // ComboBox "cmbThuongHieu1" và "cmbLoai1" cần phải có Item với giá trị phù hợp
                cmbThuongHieu1.SelectedItem = row.Cells[5].Value.ToString();
                cmbLoai1.SelectedItem = row.Cells[6].Value.ToString();
                cmbTrangThai1.SelectedItem = row.Cells[7].Value.ToString();

                // Hiển thị hình ảnh từ dữ liệu byte[] trong cột "2"
                byte[] imageData = (byte[])row.Cells[2].Value;
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    picPhoto1.Image = Image.FromStream(memoryStream);
                }

                tpProduct.SelectedTab = tpLuaChon;
            }*/
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
        public bool CheckTen(string Ten)
        {
            using (DataBase db = new DataBase())
            {
                var result = db.Product.Where(p => p.Product_Name == Ten).FirstOrDefault();
                if (result != null)
                {
                    return true;
                }
                return false;
            }
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
        private void LoadProductsToComboBoxThuongHieu()
        {
            using (var context = new DataBase())
            {
                var products = context.Product.ToList();

                // Lấy danh sách tên sản phẩm
                var productNames = products.Select(product => product.Product_Name).ToArray();

                // Thêm danh sách sản phẩm vào combobox
                
                cmbThuongHieu1.Items.AddRange(productNames);
            }
        }
        private void LoadProductsToComboBoxLoai()
        {
            using (var context = new DataBase())
            {
                var products = context.Product.ToList();

                // Lấy danh sách tên sản phẩm
                var productNames = products.Select(product => product.Product_Name).ToArray();

                // Thêm danh sách sản phẩm vào combobox
                cmbLoai1.Items.AddRange(productNames);

              
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hãy nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null) // Kiểm tra hình ảnh
            {
                MessageBox.Show("Hãy chọn hình ảnh sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGiaTien.Text.Trim() == string.Empty || Convert.ToInt32(txtGiaTien.Text) == 0)
            {
                MessageBox.Show("Hãy nhập giá sản phẩm(Giá sản phẩm không thể bằng 0!).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudSoLuong.Text.Trim() == string.Empty || nudSoLuong.Value == 0)
            {
                MessageBox.Show("Hãy nhập số lượng sản phẩm(Số lượng sản phẩm không thể bằng 0!).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbThuongHieu.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy nhập thương hiệu sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbLoai.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy nhập loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy nhập trạng thái sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (CheckTen(txtTenSanPham.Text))
                {
                    MessageBox.Show("Tên đã trùng, vui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenSanPham.Text = string.Empty;
                    return;
                }
                else
                {
                    Product product = new Product(txtTenSanPham.Text.Trim(), (byte[])imageConverter.ConvertTo(picPhoto.Image, typeof(byte[])), Convert.ToInt32(txtGiaTien.Text), Convert.ToInt32(nudSoLuong.Text), cmbThuongHieu.SelectedItem.ToString(), cmbLoai.SelectedItem.ToString(), cmbTrangThai.SelectedItem.ToString());
                    ProductController.AddProduct(product);
                    EmptyBox();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    LoadDgvSanPham();
                }
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
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn
        private void SearchProduct(string searchName)
        {
            string query = "SELECT Product_Name,Product_Image,Product_Rate,Product_Quantity,Product_Brand,Product_Category,Product_Status FROM WHERE Product_Name LIKE  LIKE @SearchName;";

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
                        dgvSanPham.DataSource = dataTable;

                        lblTotal.Text = dataTable.Rows.Count.ToString();
                    }
                }
            }
        }
        private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtTimKiemSanPham.Text;
            SearchProduct(searchName);
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
            if (string.IsNullOrWhiteSpace(txtTenSanPham1.Text))
            {
                MessageBox.Show("Hãy nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtGiaTien1.Text))
            {
                MessageBox.Show("Hãy nhập giá tiền sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(nudSoLuong1.Text))
            {
                MessageBox.Show("Hãy nhập số lượng sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbThuongHieu1.SelectedIndex <= 0)
            {
                MessageBox.Show("Hãy nhập thương hiệu sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbLoai1.SelectedIndex <= 0)
            {
                MessageBox.Show("Hãy nhập loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbTrangThai1.SelectedIndex <= 0)
            {
                MessageBox.Show("Hãy nhập trạng thái sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chứ!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductController.RemoveProduct1(txtTenSanPham1.Text);
                    EmptyBox1(); // Đặt các controls về giá trị mặc định
                    tpProduct.SelectedTab = tpQuanLySanPham;
                    LoadDgvSanPham();

                }
            }
        }

        private void picPhoto1_Click(object sender, EventArgs e)
        {

        }
        public void LoadDgvSanPham()
        {
            txtTimKiemSanPham.Clear();
            /**//*dgvLoai.Columns[0].Visible = true;*/
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Category
                string query = "SELECT * FROM Product";

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
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hãy nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGiaTien.Text.Trim() == string.Empty || Convert.ToInt32(txtGiaTien1.Text) == 0)
            {
                MessageBox.Show("Hãy nhập giá sản phẩm(Giá sản phẩm không thể bằng 0!).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudSoLuong.Text.Trim() == string.Empty || nudSoLuong1.Value == 0)
            {
                MessageBox.Show("Hãy nhập số lượng sản phẩm(Số lượng sản phẩm không thể bằng 0!).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbThuongHieu1.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy nhập thương hiệu sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbLoai1.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy nhập loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbTrangThai1.SelectedIndex == 0)
            {
                MessageBox.Show("Hãy nhập trạng thái sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (var context = new DataBase())
                {
                    var productToUpdate = context.Product.FirstOrDefault(p => p.Product_Name.Equals(txtTenSanPham1.Text)); // Thay id bằng giá trị tương ứng


                    if (CheckTen(productToUpdate.Product_Name) == true)
                    {
                        // Cập nhật các thuộc tính của đối tượng với giá trị từ controls
                        productToUpdate.Product_Name = txtTenSanPham1.Text;
                        productToUpdate.Product_Rate = int.Parse(txtGiaTien1.Text);
                        productToUpdate.Product_Quantity = int.Parse(nudSoLuong1.Value.ToString());
                        productToUpdate.Product_Brand = cmbThuongHieu1.SelectedItem.ToString();
                        productToUpdate.Product_Category = cmbLoai1.SelectedItem.ToString();
                        productToUpdate.Product_Stastus = cmbTrangThai1.SelectedItem.ToString();

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                        txtTenSanPham1.Enabled = true;
                        EmptyBox1();
                        MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDgvSanPham();
                        tpProduct.SelectedTab = tpQuanLySanPham;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm trong dữ liệu .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
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
            LoadProductsToComboBoxLoai();
            LoadProductsToComboBoxThuongHieu();
            if (txtTenSanPham1.Text.Trim() != null)
            {
                string tensanpham = txtTenSanPham1.Text.Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkcmbquery = "SELECT * FROM Product WHERE Product_Name = @name";
                    using (SqlCommand command = new SqlCommand(checkcmbquery, connection))
                    {
                        command.Parameters.AddWithValue("@name", tensanpham);
                        // Thực thi câu lệnh SQL
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                

                                string cmbloai = reader["Product_Category"].ToString();
                                string cmbthuonghieu = reader["Product_Brand"].ToString();

                                cmbLoai1.Text = cmbloai;
                                cmbThuongHieu1.Text = cmbthuonghieu;
                            }
                            else
                            {
                                
                            }
                        }
                    }
                }
            }    
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
           /* if (id == "")
            {
                tpProduct.SelectedTab = tpQuanLySanPham;
            }*/
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

                string query = "SELECT * FROM Product";

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
                string query = "SELECT * FROM Product";

                // Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                // Lấy dữ liệu từ cơ sở dữ liệu và lưu vào datatable
                DataTable dataTable = GetDataFromDatabase();

                // Gán datatable làm nguồn dữ liệu cho DataGridView
               
                dgvSanPham.DataSource = dataTable;
                dgvSanPham.Columns["Product_Id"].HeaderText = "Mã Sản Phẩm";
                dgvSanPham.Columns["Product_Name"].HeaderText = "Tên Sản Phẩm";
                dgvSanPham.Columns["Product_Image"].HeaderText = "Ảnh Sản Phẩm";
                dgvSanPham.Columns["Product_Rate"].HeaderText = "Giá Tiền";
                dgvSanPham.Columns["Product_Quantity"].HeaderText = "Số Lượng";
                dgvSanPham.Columns["Product_Brand"].HeaderText = "Thương Hiệu";
                dgvSanPham.Columns["Product_Category"].HeaderText = "Loại";
                dgvSanPham.Columns["Product_Stastus"].HeaderText = "Trạng Thái";

            }
            lblTotal.Text = dgvSanPham.Rows.Count.ToString();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*   tpProduct.SelectedTab = tpLuaChon;
               DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

               // Đổ dữ liệu vào các controls
               txtTenSanPham1.Text = row.Cells[1].Value.ToString();
               txtGiaTien1.Text = row.Cells[3].Value.ToString();
               nudSoLuong1.Value = Convert.ToDecimal(row.Cells[4].Value);
               cmbThuongHieu1.SelectedItem = row.Cells[5].Value.ToString();
               cmbLoai1.SelectedItem = row.Cells[6].Value.ToString();
               cmbTrangThai1.SelectedItem = row.Cells[7].Value.ToString();

               // Kiểm tra và hiển thị hình ảnh từ cột "2"
               if (row.Cells.Count > 2 && row.Cells[2].Value != DBNull.Value)
               {
                   byte[] imageData = (byte[])row.Cells[2].Value;
                   using (MemoryStream memoryStream = new MemoryStream(imageData))
                   {
                       picPhoto1.Image = Image.FromStream(memoryStream);
                   }
               }
               else
               {
                   // Nếu cột 2 không có giá trị, hiển thị hình ảnh mặc định
                   picPhoto1.Image = Properties.Resources.plus;
               }
*/
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                tpProduct.SelectedTab = tpLuaChon;
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                // Đảm bảo chỉ số cột hợp lệ
                if (row.Cells.Count > 1)
                {
                    // Đổ dữ liệu vào các controls
                    txtTenSanPham1.Text = row.Cells[1].Value?.ToString();
                }
                if (row.Cells.Count > 3)
                {
                    txtGiaTien1.Text = row.Cells[3].Value?.ToString();
                }
                if (row.Cells.Count > 4)
                {
                    nudSoLuong1.Value = Convert.ToDecimal(row.Cells[4].Value);
                }
                if (row.Cells.Count > 5)
                {
                    cmbThuongHieu1.SelectedItem = row.Cells[5].Value?.ToString();
                }
                if (row.Cells.Count > 6)
                {
                    cmbLoai1.SelectedItem = row.Cells[6].Value?.ToString();
                }
                if (row.Cells.Count > 7)
                {
                    cmbTrangThai1.SelectedItem = row.Cells[7].Value?.ToString();
                }

                // Kiểm tra và hiển thị hình ảnh từ cột "2"
                if (row.Cells.Count > 2 && row.Cells[2].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells[2].Value;
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {
                        picPhoto1.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    // Nếu cột 2 không có giá trị, hiển thị hình ảnh mặc định
                    picPhoto1.Image = Properties.Resources.plus;
                }
            }

        }

        private void cmbThuongHieu1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cmbLoai1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }
    }
}
