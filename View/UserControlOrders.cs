using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlOrders : UserControl
    {
        public static List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn
        DataBase db = new DataBase();
        int otong = 0;
        decimal tongSoTien = 0;
        public static User User = new User();

        public UserControlOrders()
        {
            InitializeComponent();
        }
        public UserControlOrders(User u)
        {
            User = u;
            InitializeComponent();
        }

        public void SetUser(User u)
        {
            User = u;
            if (User != null)
            {
                txtMaNhanVien.Text = User.Users_Id;
            }
        }

        #region Method
        private void LoadOrdersData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Orders";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dtgvQL.DataSource = dataTable;
                    dtgvQL.Columns["Orders_Id"].HeaderText = "Mã Hóa Đơn";
                    dtgvQL.Columns["Users_Id"].HeaderText = "Mã Nhân Viên";
                    dtgvQL.Columns["Order_Date"].HeaderText = "Ngày Lập";
                    dtgvQL.Columns["Customer_Name"].HeaderText = "Khách Hàng";
                    dtgvQL.Columns["Customer_Number"].HeaderText = "Mã Khách Hàng";
                    dtgvQL.Columns["Total_Amout"].HeaderText = "Tổng Tiền";
                    dtgvQL.Columns["Paid_Amout"].HeaderText = "Tiền Nhận Từ Khách";
                    dtgvQL.Columns["Due_Amout"].HeaderText = "Tiền Thừa";
                    dtgvQL.Columns["Discount"].HeaderText = "Chiết Khấu";
                    dtgvQL.Columns["Grand_Total"].HeaderText = "Tổng Tiền Sau Khi Chiết Khấu";
                    dtgvQL.Columns["StatusPayment"].HeaderText = "Trạng Thái Thanh Toán";

                    lbltongsotien.Text = dtgvQL.Rows.Count.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
        private void LoadProductsToComboBox()
        {
            cmbsanpham.Items.Clear();
            cmbsanpham.Items.Add("-- Chọn --");
            ProductController.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Stastus = N'Có Sẵn' ORDER BY Product_Name;", cmbsanpham);
            cmbsanpham.SelectedIndex = 0;
        }

        private void ClearData()
        {
            dtgvOrder.Rows.Clear();
            Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status =N'Có Sẵn' ORDER BY Product_Name;", cmbsanpham);
            txtMaHoaDon.Text = "BILL" + DateTime.Now.ToString("yyMMddhhmmss");
            txtmakhachhang.Text = "KH" + DateTime.Now.ToString("yyMMddhhmmss");
            dtgvOrder.DataSource = null;
            txtSoDienThoai.Text = "";
            txttenkhachhang.Text = "";
            dtpDate.Value = DateTime.Now;
            cmbsanpham.SelectedItem = "--Chọn--";
            cmbtttt.SelectedItem = "--Chọn--";
            cmbptthanhtoan.SelectedItem = "--Chọn--";
            txtGiaTien.Text = "";
            nudsoluong.Value = 0;
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            txttienphaitra.Text = "";
            txtGiamGia.Text = "";
            txttongcong.Text = "";
            txtTienThua.Text = "";


        }
        private void AddClear()
        {


            Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status ='Thanh Toán Thành Công' ORDER BY Product_Name;", cmbsanpham);

            // Lấy danh sách các dòng được chọn




            txtSoDienThoai.Text = string.Empty;
            txttenkhachhang.Text = string.Empty;
            dtpDate.Value = DateTime.Now;

            cmbsanpham.SelectedItem = 0;
            cmbtttt.SelectedItem = "--Chọn--";
            txtGiaTien.Text = "";
            nudsoluong.Value = 0;
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            txttienphaitra.Text = "";
            txtGiamGia.Text = "";
            txttongcong.Text = "";
            txtTienThua.Text = "";
            txtMaHoaDon.Text = "BILL" + DateTime.Now.ToString("yyMMddhhmmss");
            txtmakhachhang.Text = "KH " + DateTime.Now.ToString("yyMMddhhmmss");

        }
        private int GetAvailableQuantityFromDatabase(string productName)
        {
            int availableQuantity = 0;

            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Product_Quantity FROM Product WHERE Product_Name = @ProductName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        availableQuantity = (int)result;
                    }
                }
            }

            return availableQuantity;
        }
        private decimal CalculateTotal()
        {
            int Total = 0;
            foreach (DataGridViewRow rows in dtgvOrder.Rows)
            {
                Total += Convert.ToInt32(rows.Cells[3].Value);
            }
            txttongtien.Text = Total.ToString();

            return Total;
        }
        private void TinhTienThua()
        {
            decimal tongTien = 0; // Tổng tiền hóa đơn (ví dụ)
            decimal tienGiamGia = 0; // Số tiền giảm giá (ví dụ)

            if (string.IsNullOrEmpty(txttienphaitra.Text))
            {
                txtTienThua.Text = string.Empty;
                return;
            }

            if (!decimal.TryParse(txttienphaitra.Text, out decimal tienKhachTra) || tienKhachTra < 0 || tienKhachTra < tongTien)
            {
                MessageBox.Show("Số tiền nhập vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttienphaitra.Text = string.Empty; // Xóa giá trị nhập vào
                txtTienThua.Text = string.Empty;
                return;
            }

            // Tính toán số tiền thừa
            decimal tienThua = tienKhachTra - tongTien + tienGiamGia;
            txtTienThua.Text = tienThua.ToString();
        }
        private bool ValidateCategoryName(string CategoryName)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa ký tự đặc biệt và số
            string pattern = @"^[\p{L}\s]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(CategoryName);
        }
        public void EmtyBox()
        {
            dtpDate.Value = DateTime.Now;
            txttenkhachhang.Clear();
            txtmakhachhang.Clear();
            AddClear();
            dtgvOrder.Rows.Clear();
            txttongtien.Text = "0";
            txttienphaitra.Text = "0";
            txtTienThua.Text = "0";
            txtGiamGia.Text = "0";
            txttongcong.Text = "0";
            cmbtttt.SelectedIndex = 0;
            txtMaNhanVien.Text = string.Empty;

        }
        // trả về các box rỗng bên Quản Lý
        public void EmtyBox1()
        {
            dtp2.Value = DateTime.Now;
            txttenkhachhangop.Clear();
            txttenkhachhangop.Clear();
            txttongtienop.Text = "0";
            txtTienThuaLC.Text = "0";
            txttiennhankhachhang.Text = "0";
            txtGiamGiaLC.Text = "0";
            txttongcongop.Text = "0";
            txtMaHoaDon1.Text = "";
            txtMaKH.Text = "0";
            cmbtrangthaiop.SelectedIndex = 0;
            txtMaNhanVien1.Text = string.Empty;
        }
        RichTextBox richTextBox = new RichTextBox();
        // Chức năng xuất hóa đơn
        private void Receipt()
        {
            richTextBox.Clear();
            richTextBox.Text += "\t                                         Computer Shop Management System\n";
            richTextBox.Text += "************************************************************************************************************************************************\n\n";
            richTextBox.Text += "   Ngày Mua:" + dtpDate.Text + "\n";
            richTextBox.Text += "   Mã Hóa Đơn:" + txtMaHoaDon.Text.Trim() + "\n";
            richTextBox.Text += "   Tên Khách Hàng:" + txttenkhachhang.Text.Trim() + "\n";
            richTextBox.Text += "   Mã Nhân Viên:" + txtMaNhanVien.Text.Trim() + "\n";
            richTextBox.Text += "   Mã Khách Hàng:" + txtmakhachhang.Text.Trim() + "\n\n";
            richTextBox.Text += "************************************************************************************************************************************************\n\n";
            richTextBox.Text += "Tên Sản Phẩm\t\t               \tGiá\t                             \tSố Lượng\t\t     \tTổng Tiền\t\n";
            for (int i = 0; i < dtgvOrder.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvOrder.Columns.Count; j++)
                {
                    var cellValue = dtgvOrder.Rows[i].Cells[j].Value;
                    if (cellValue != null)
                    {
                        richTextBox.Text += cellValue.ToString() + "    \t\t\t\t";
                    }
                    else
                    {
                        richTextBox.Text += "\t\t"; // Ô trống
                    }

                }
                richTextBox.Text += "\n";
            }

            richTextBox.Text += "************************************************************************************************************************************************\n\n ";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTổng Cộng: $ " + txttongtien.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tSố Tiền Đã Nhận: $" + txttienphaitra.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tGiảm Giá: $ " + txtGiamGia.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTiền Thừa: $ " + txtTienThua.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\t********************************\n\n ";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTổng Cộng: $ " + txttongcong.Text + "\n\n";

        }
        private void CompareTextBoxValues()
        {
            int value1, value2;
            bool isValidValue1 = int.TryParse(txttongtien.Text, out value1);
            bool isValidValue2 = int.TryParse(txttienphaitra.Text, out value2);

            if (isValidValue1 && isValidValue2)
            {
                if (value2 < value1)
                {
                    MessageBox.Show("số tiền khách trả không hợp lệ.","kiểm tra",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    // Kiểm tra nếu TextBox rỗng hoặc không thể chuyển đổi sang số thực, thoát khỏi phương thức
                    if (!string.IsNullOrEmpty(txttienphaitra.Text))
                    {
                        txtTienThua.Text = string.Empty;
                        return;
                    }

                    if (!int.TryParse(txttienphaitra.Text, out int tienKhachTra) && tienKhachTra < 0)
                    {
                        MessageBox.Show("số tiền nhập vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txttienphaitra.Text = string.Empty; // Xóa giá trị nhập vào
                        txtTienThua.Text = string.Empty;
                        return;
                    }

                    // Tính toán số tiền thừa
                    int tienThua = tienKhachTra - tongTien + tienGiamGia;
                    txtTienThua.Text = tienThua.ToString();
                }
            }
            else
            {
                MessageBox.Show("Hãy Nhập số tiền hợp lệ!.");
            }
        }

        /*public void XoaHoaDon(string maHoaDon)
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string trangthai = cmbtrangthaiop.SelectedItem.ToString();
                //check trạng thái 
                string checktrangthai = "SELECT PaymentStatus FROM Orders WHERE PaymentStatus =  ";


                // Xóa các bản ghi liên quan trong bảng OrderDetails trước
                string deleteOrderDetailsQuery = "DELETE FROM OrderDetails WHERE Orders_Id = @MaHoaDon";
                using (SqlCommand deleteOrderDetailsCommand = new SqlCommand(deleteOrderDetailsQuery, connection))
                {
                    deleteOrderDetailsCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    deleteOrderDetailsCommand.ExecuteNonQuery();
                }

                // Tiếp tục xóa hóa đơn
                string deleteOrderQuery = "DELETE FROM Orders WHERE Orders_Id = @MaHoaDon";
                using (SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection))
                {
                    deleteOrderCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    int rowsAffected = deleteOrderCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hóa đơn " + txtMaHoaDon1.Text + " đã được xóa thành công.");

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn có mã: " + maHoaDon);
                    }
                    EmtyBox1();
                }
            }
        }*/
        public void XoaHoaDon(string maHoaDon)
        {
            string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectedTrangThai = cmbtrangthaiop.SelectedItem.ToString();

                // Kiểm tra nếu trạng thái được chọn là "--Thanh Toán Thất Bại--" thì mới xóa hóa đơn
                if (selectedTrangThai == "Thanh Toán Thất Bại")
                {
                    // Xóa các bản ghi liên quan trong bảng OrderDetails trước
                    string deleteOrderDetailsQuery = "DELETE FROM OrderDetails WHERE Orders_Id = @MaHoaDon";
                    using (SqlCommand deleteOrderDetailsCommand = new SqlCommand(deleteOrderDetailsQuery, connection))
                    {
                        deleteOrderDetailsCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        deleteOrderDetailsCommand.ExecuteNonQuery();
                    }

                    // Tiếp tục xóa hóa đơn
                    string deleteOrderQuery = "DELETE FROM Orders WHERE Orders_Id = @MaHoaDon";
                    using (SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection))
                    {
                        deleteOrderCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        int rowsAffected = deleteOrderCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hóa đơn " + txtMaHoaDon1.Text + " đã được xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn có mã: " + maHoaDon);
                        }
                        EmtyBox1();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa hóa đơn vì trạng thái không phải là '--Thanh Toán Thất Bại--'.");
                }
            }
        }

        private void SearchCustomer(string searchName)
        {
            string query = "SELECT Orders_Id,Users_Id, Order_Date, Customer_Name, Customer_Number, Total_Amout, Paid_Amout, Due_Amout, Discount, Grand_Total, StatusPayment FROM Orders WHERE Customer_Name LIKE @SearchName;";

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
                        dtgvQL.DataSource = dataTable;

                        lbltongsotien.Text = dataTable.Rows.Count.ToString();
                    }
                }
            }
        }
        #endregion
        #region Event
        private void tpthemhoadon_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
        }

      
        private void tpluachon_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
        }
       

        private void UserControlOrders_Load(object sender, EventArgs e)
        {
            txtmakhachhang.Text = "KH" + DateTime.Now.ToString("yyMMddhhmmss");
            txtMaHoaDon.Text = "BILL" + DateTime.Now.ToString("yyMMddhhmmss");
            dtpDate.Value = DateTime.Now;
            cmbsanpham.Items.Clear();
            cmbsanpham.Items.Add("---Chọn---");
            cmbsanpham.SelectedIndex = 0;
            LoadProductsToComboBox();
            cmbtttt.Items.Clear();
            cmbtttt.Items.Add("--Chọn--");
            cmbtttt.SelectedIndex = 0;
         
            cmbptthanhtoan.Items.Add("--Chọn--");
            cmbptthanhtoan.SelectedIndex = 0;

            LoadOrdersData();
          
           




        }
             
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbsanpham.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn Sản Phẩm!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (nudsoluong.Value == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra số lượng sản phẩm có sẵn trong cơ sở dữ liệu
                string productName = cmbsanpham.SelectedItem.ToString();
                int availableQuantity = GetAvailableQuantityFromDatabase(productName);
                int requestedQuantity = Convert.ToInt32(nudsoluong.Value);

                if (requestedQuantity > availableQuantity)
                {
                    MessageBox.Show("Số lượng sản phẩm mua vượt quá số lượng có sẵn. Số lượng có sẵn: " + availableQuantity, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmtyBox();
                }

                int gia, tongtien;
                Int32.TryParse(txtGiaTien.Text, out gia);
                Int32.TryParse(txttongtien.Text, out tongtien);

                foreach (DataGridViewRow rows in dtgvOrder.Rows)
                {
                    if (rows.Cells[0].Value != null && rows.Cells[0].Value.ToString() == productName)
                    {
                        int quantity = Convert.ToInt32(rows.Cells[2].Value);
                        int total1 = Convert.ToInt32(rows.Cells[3].Value);
                        quantity += requestedQuantity;
                        total1 += tongtien;
                        rows.Cells[2].Value = quantity;
                        rows.Cells[3].Value = total1;
                        return;
                    }
                }

              
                string[] row = { productName, txtGiaTien.Text, requestedQuantity.ToString(), txttongtien.Text };
                dtgvOrder.Rows.Add(row);              
                txtGiaTien.Text = string.Empty;
                nudsoluong.Value = 0;
                txtthanhtien.Text = string.Empty;
                txttongtien.Text = "";
                cmbsanpham.Items.Add("--Chọn--");
                cmbsanpham.SelectedItem = 0;
                CalculateTotal();
                TinhTienThua();
            }
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
     
      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Receipt();
                printPreviewDialog1.Document = printDocument1;
                printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                printPreviewDialog1.ShowDialog(); 

                CompareTextBoxValues();
             
                    // Kiểm tra các điều kiện nhập liệu trước khi lưu
                    if (!ValidateCategoryName(txttenkhachhang.Text.Trim()))
                    {
                        MessageBox.Show("Tên Không phù hợp", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (txtmakhachhang.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập mã khách hàng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (txttongtien.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập số tiền hóa đơn của khách hàng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (txttienphaitra.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập số tiền nhận được từ khách hàng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    else
                    {
                        string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

                        string phoneNumber = txtSoDienThoai.Text.Trim();
                        string checkCustomerQuery = "SELECT COUNT(*) FROM Customer WHERE Phone_Number = '" + phoneNumber + "'";
                        int? customerCount = null;

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            SqlCommand checkCustomerCmd = new SqlCommand(checkCustomerQuery, connection);
                            object result = checkCustomerCmd.ExecuteScalar();
                            if (result != null)
                            {
                                customerCount = (int)result;
                            }

                            connection.Close();
                        }

                        if (customerCount == null || customerCount == 0)
                        {
                            // Khách hàng chưa tồn tại, thêm vào bảng "Customer"
                            string customerNumber = txtmakhachhang.Text.Trim();
                            string customerName = txttenkhachhang.Text.Trim();


                            string insertCustomerQuery = "INSERT INTO Customer(Customer_Number, Customer_Name, Phone_Number) VALUES ('" + customerNumber + "', N'" + customerName + "', '" + phoneNumber + "')";
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                SqlCommand insertCustomerCmd = new SqlCommand(insertCustomerQuery, connection);
                                insertCustomerCmd.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                        // Kiểm tra số lượng sản phẩm có sẵn trong cơ sở dữ liệu
                        string productName = cmbsanpham.SelectedItem.ToString();
                        int availableQuantity = GetAvailableQuantityFromDatabase(productName);
                        int requestedQuantity = Convert.ToInt32(nudsoluong.Value);

                        if (requestedQuantity > availableQuantity)
                        {
                            MessageBox.Show("Số lượng sản phẩm mua vượt quá số lượng có sẵn. Số lượng có sẵn: " + availableQuantity, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string billCode = txtMaHoaDon.Text.Trim();
                        // Kiểm tra mã hóa đơn đã tồn tại trong Orders hay chưa
                        string checkQuery = "SELECT COUNT(*) FROM Orders WHERE Orders_Id = '" + billCode + "'";
                        int count = 0;
                        string connectionString1 = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                        using (SqlConnection connection = new SqlConnection(connectionString1))
                        {
                            connection.Open();

                            SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                            count = (int)checkCmd.ExecuteScalar();

                            connection.Close();
                        }

                        if (count > 0)
                        {
                            MessageBox.Show("Mã hóa đơn " + txtMaHoaDon.Text + " đã tồn tại. Vui lòng chọn mã hóa đơn khác.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                        // Tiếp tục lưu hóa đơn và chi tiết hóa đơn 
                        string orderQuery = "INSERT INTO Orders(Orders_Id,Users_Id, Order_Date, Customer_Name, Customer_Number, Total_Amout, Paid_Amout,Discount, Due_Amout, Grand_Total, StatusPayment)  VALUES ('" + billCode + "','" + txtMaNhanVien.Text + "','" + dtpDate.Value.ToString("yyyy/MM/dd") + "',N'" + txttenkhachhang.Text + "','" + txtmakhachhang.Text + "'," + Convert.ToInt32(txttongtien.Text.Trim()) + "," + Convert.ToInt32(txttienphaitra.Text.Trim()) + "," + Convert.ToInt32(txtGiamGia.Text.Trim()) + "," + Convert.ToInt32(txtTienThua.Text.Trim()) + "," + Convert.ToInt32(txttongcong.Text.Trim()) + ",N'" + cmbtttt.SelectedItem.ToString() + "')";
                        DataProvider.ExecuteNonQuery(orderQuery);

                        foreach (DataGridViewRow row in dtgvOrder.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                string productName1 = row.Cells[0].Value.ToString();
                                int productRate = Convert.ToInt32(row.Cells[1].Value.ToString());
                                int amount = Convert.ToInt32(row.Cells[2].Value.ToString());
                                int total = Convert.ToInt32(row.Cells[3].Value.ToString());

                                // Kiểm tra tên sản phẩm đã tồn tại trong Product hay không
                                string productQuery = "SELECT COUNT(*) FROM Product WHERE Product_Name = N'" + productName1 + "'";
                                int productCount = 0;

                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();

                                    SqlCommand productCmd = new SqlCommand(productQuery, connection);
                                    productCount = (int)productCmd.ExecuteScalar();

                                    connection.Close();
                                }

                                if (productCount > 0)
                                {
                                    // Lấy thông tin sản phẩm
                                    string getProductQuery = "SELECT * FROM Product WHERE Product_Name = N'" + productName1 + "'";
                                    DataTable productDt = new DataTable();
                                    productDt = DataProvider.GetData(getProductQuery);

                                    int productId = Convert.ToInt32(productDt.Rows[0][0].ToString());
                                    string paymentmethods = cmbptthanhtoan.SelectedItem.ToString();
                                    // Lưu chi tiết hóa đơn
                                    string orderDetailQuery = "INSERT INTO OrderDetails(Orders_Id, Product_Id, Amout, Product_Rate, Total,Payment_Methods) VALUES ('" + billCode + "'," + productId + "," + amount + "," + productRate + "," + total + ",N'" + cmbptthanhtoan.SelectedItem.ToString() + "')";
                                    DataProvider.ExecuteNonQuery(orderDetailQuery);
                                    // Trừ số lượng sản phẩm từ cơ sở dữ liệu
                                    string updateProductQuantityQuery = "UPDATE Product SET Product_Quantity = Product_Quantity - " + amount + " WHERE Product_Id = " + productId;
                                    DataProvider.ExecuteNonQuery(updateProductQuantityQuery);

                                }
                                else
                                {
                                    MessageBox.Show("Sản phẩm không tồn tại trong cơ sở dữ liệu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                        MessageBox.Show("Thanh Toán và Lưu Hóa Đơn " + txtMaHoaDon.Text + " Thành Công");
                        ClearData();
                        txtSoDienThoai.Text = string.Empty;
                       
                    }
             
            }
             
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
        private void txtTienThua_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chặn ký tự nhập vào
            e.Handled = true;
        }

        private void txttongcong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chặn ký tự nhập vào
            e.Handled = true;
        }
        private int tongTien = 0;
        private int tienGiamGia = 0;
        private void txttienphaitra_TextChanged(object sender, EventArgs e)
        {

            // Kiểm tra nếu TextBox rỗng hoặc không thể chuyển đổi sang số thực, thoát khỏi phương thức
            if (!string.IsNullOrEmpty(txttienphaitra.Text))
            {
                txtTienThua.Text = string.Empty;
                return;
            }

            if (!int.TryParse(txttienphaitra.Text, out int tienKhachTra) && tienKhachTra < 0)
            {
                MessageBox.Show("số tiền nhập vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttienphaitra.Text = string.Empty; // Xóa giá trị nhập vào
                txtTienThua.Text = string.Empty;
                return;
            }

            // Tính toán số tiền thừa
            int tienThua = tienKhachTra - tongTien + tienGiamGia;
            txtTienThua.Text = tienThua.ToString();
          

        }

        private void cmbsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* 
               LoadProductsToComboBox();*/
        
                string gia = Computer.Gia(cmbsanpham.SelectedItem.ToString());
                if (gia != string.Empty)
                {
                    txtGiaTien.Text = gia;
                    nudsoluong.Value = 0;
                }
         
           
         
        }

        private void nudsoluong_ValueChanged(object sender, EventArgs e)
        {

            if (cmbsanpham.SelectedIndex != -1)
            {

                int gia, soluong;
                Int32.TryParse(txtGiaTien.Text, out gia);
                Int32.TryParse(nudsoluong.Value.ToString(), out soluong);
                int tongtien = gia * soluong;
                txttongtien.Text = tongtien.ToString();
                txtthanhtien.Text = tongtien.ToString();
            }
        }

        private void txtthanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

            // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
            if ((!string.IsNullOrEmpty(txttongtien.Text) && int.TryParse(txttongtien.Text, out int total)) &&
                (!string.IsNullOrEmpty(txttienphaitra.Text) && int.TryParse(txttienphaitra.Text, out int customerPayment)))
            {
                // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
                if (!string.IsNullOrEmpty(txtGiamGia.Text) && int.TryParse(txtGiamGia.Text, out int discountAmount))
                {

                    // Tính toán tổng cộng
                    int subtotal = total - discountAmount;

                    // Tính toán tiền thừa
                    int change = customerPayment - subtotal;

                    // Hiển thị tổng cộng và tiền thừa lên các textbox tương ứng
                    txttongcong.Text = subtotal.ToString();
                    txtTienThua.Text = change.ToString();
                }
                else if (int.TryParse(txtGiamGia.Text, out int discountAmount1) && discountAmount1 < 0)
                {
                    MessageBox.Show("Số tiền nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiamGia.Text = ""; // Xóa giá trị nhập vào
                    txttongcong.Text = "";
                    txtTienThua.Text = "";
                }
            }
            else
            {
                // Xử lý trường hợp giá trị nhập vào không hợp lệ
                //MessageBox.Show("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại giá trị số.");

                // Xóa nội dung trong các textbox
                txttongtien.Text = "";
                txttienphaitra.Text = "";
                txtGiamGia.Text = "";
                txttongcong.Text = "";
                txtTienThua.Text = "";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = richTextBox.Text;
            text = text.Replace("System.Drawing.Bitmap", ""); // Loại bỏ cụm từ "System.Drawing.Bitmap"

            e.Graphics.DrawString(text, new Font("Segoe UI", 6, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mess = MessageBox.Show("Bạn muốn xóa hóa đơn này ", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mess == DialogResult.Yes)
                {
                    XoaHoaDon(txtMaHoaDon1.Text.Trim());
                }
                else
                {
                    return;
                }    
            }
              catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tpOders.SelectedTab = tpluachon;
                if (e.RowIndex >= 0 && e.RowIndex < dtgvQL.Rows.Count)
                {
                    DataGridViewRow row = dtgvQL.Rows[e.RowIndex];

                    // Kiểm tra chỉ số cột hợp lệ trước khi truy cập vào Cells
                    if (e.ColumnIndex >= 0 && e.ColumnIndex < row.Cells.Count)
                    {
                        for (int columnIndex = 0; columnIndex < row.Cells.Count; columnIndex++)
                        {
                            object cellValue = row.Cells[columnIndex].Value;

                            if (cellValue != null)
                            {
                                if (columnIndex == 0)
                                    txtMaHoaDon1.Text = cellValue.ToString();
                                else if (columnIndex == 1)
                                    txtMaNhanVien1.Text = cellValue.ToString();
                                else if (columnIndex == 2)
                                    dtp2.Value = Convert.ToDateTime(cellValue);
                                else if (columnIndex == 3)
                                    txttenkhachhangop.Text = cellValue.ToString();
                                else if (columnIndex == 4)
                                    txtMaKH.Text = cellValue.ToString();
                                else if (columnIndex == 5)
                                    txttongtienop.Text = cellValue.ToString();
                                else if (columnIndex == 6)
                                    txttiennhankhachhang.Text = cellValue.ToString();
                                else if (columnIndex == 7)
                                    txtGiamGiaLC.Text = cellValue.ToString();
                                else if (columnIndex == 8)
                                    txtTienThuaLC.Text = cellValue.ToString();
                                else if (columnIndex == 9)
                                    txttongcongop.Text = cellValue.ToString();
                                else if (columnIndex == 10)
                                    cmbtrangthaiop.Text = cellValue.ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            LoadOrdersData();


        }

        private void tpquanlyhoadon_Click(object sender, EventArgs e)
        {
            LoadOrdersData();

        }
      

        private void txtTienThua_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // chặn ký tự nhập vào
            e.Handled = true;
        }

        private void txttimtenkhachhang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = txttimtenkhachhang.Text;
                SearchCustomer(searchName);
            }
            
              catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimtenkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled |= true;
        }

       

        private void dtgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dtgvOrder.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value is Image)
                {
                    // Xử lý việc xóa dòng dữ liệu tại e.RowIndex

                    // Ví dụ: Xóa dòng dữ liệu
                    if (!dtgvOrder.Rows[e.RowIndex].IsNewRow)
                    {
                        dtgvOrder.Rows.RemoveAt(e.RowIndex);
                        CalculateTotal();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để xóa");
                    }

                }
            }
        }

        private void txtMaHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtmakhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            /*try
            {

                // Lấy dữ liệu từ các TextBox
                string orderId = txtMaHoaDon1.Text; // Giá trị Orders_Id không thay đổi
                string orderDateText = dtp2.Text;
                DateTime orderDate;
                if (DateTime.TryParseExact(orderDateText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out orderDate))
                {
                    // Giá trị ngày tháng hợp lệ, tiếp tục xử lý
                    string customerName = txttenkhachhangop.Text;
                    string customerNumber = txtMaKH.Text;
                    string usersid = txtMaNhanVien1.Text;
                    decimal totalAmount = decimal.Parse(txttongtienop.Text);
                    decimal paidAmount = decimal.Parse(txttiennhankhachhang.Text);
                    decimal dueAmount = decimal.Parse(txtTienThuaLC.Text);
                    decimal discount = decimal.Parse(txtGiamGiaLC.Text);
                    decimal grandTotal = decimal.Parse(txttongcongop.Text);
                    string statusPayment = cmbtrangthaiop.SelectedItem.ToString();
                    string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Tạo câu lệnh SQL để cập nhật thông tin hóa đơn
                        string sqlQuery = "UPDATE Orders SET Order_Date = @OrderDate,Users_Id =@usersid, Customer_Name = @CustomerName, Customer_Number = @CustomerNumber, " +
                            "Total_Amout = @TotalAmount, Paid_Amout = @PaidAmount, Due_Amout = @DueAmount, Discount = @Discount, " +
                            "Grand_Total = @GrandTotal, StatusPayment = @StatusPayment WHERE Orders_Id = @OrderId";

                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            // Thiết lập giá trị cho các tham số
                            command.Parameters.AddWithValue("@OrderDate", orderDate);
                            command.Parameters.AddWithValue("@usersid", usersid);
                            command.Parameters.AddWithValue("@CustomerName", customerName);
                            command.Parameters.AddWithValue("@CustomerNumber", customerNumber);
                            command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                            command.Parameters.AddWithValue("@PaidAmount", paidAmount);
                            command.Parameters.AddWithValue("@DueAmount", dueAmount);
                            command.Parameters.AddWithValue("@Discount", discount);
                            command.Parameters.AddWithValue("@GrandTotal", grandTotal);
                            command.Parameters.AddWithValue("@StatusPayment", statusPayment);
                            command.Parameters.AddWithValue("@OrderId", orderId); // orderId là giá trị Orders_Id của hóa đơn cần cập nhật

                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thông tin hóa đơn đã được cập nhật thành công.");
                                EmtyBox1();
                                LoadOrdersData();

                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin hóa đơn không thành công.");
                                EmtyBox1();
                            }
                        }
                    }
                }
                else
                {
                    // Giá trị ngày tháng không hợp lệ, hiển thị thông báo lỗi
                    MessageBox.Show("Giá trị ngày tháng không hợp lệ.");
                    EmtyBox1();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            try
            {
                // Lấy mã hóa đơn từ DataGridView hoặc TextBox (tùy vào cách bạn truyền dữ liệu)
                string orderId = txtMaHoaDon1.Text;

                // Kiểm tra trạng thái thanh toán của hóa đơn trong cơ sở dữ liệu
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL để lấy trạng thái thanh toán từ cơ sở dữ liệu
                    string checkStatusQuery = "SELECT StatusPayment FROM Orders WHERE Orders_Id = @OrderId";

                    using (SqlCommand checkStatusCommand = new SqlCommand(checkStatusQuery, connection))
                    {
                        checkStatusCommand.Parameters.AddWithValue("@OrderId", orderId);
                        string currentStatus = checkStatusCommand.ExecuteScalar() as string;

                        if (currentStatus == "--Thanh Toán Thất Bại--")
                        {
                            // Lấy dữ liệu từ các TextBox và ComboBox
                            string orderDateText = dtp2.Text;
                            DateTime orderDate;
                            if (DateTime.TryParseExact(orderDateText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out orderDate))
                            {
                                // Giá trị ngày tháng hợp lệ, tiếp tục xử lý
                                string customerName = txttenkhachhangop.Text;
                                string customerNumber = txtMaKH.Text;
                                string usersid = txtMaNhanVien1.Text;
                                decimal totalAmount = decimal.Parse(txttongtienop.Text);
                                decimal paidAmount = decimal.Parse(txttiennhankhachhang.Text);
                                decimal dueAmount = decimal.Parse(txtTienThuaLC.Text);
                                decimal discount = decimal.Parse(txtGiamGiaLC.Text);
                                decimal grandTotal = decimal.Parse(txttongcongop.Text);
                                string statusPayment = cmbtrangthaiop.SelectedItem.ToString();
                                // Tạo câu lệnh SQL để cập nhật thông tin hóa đơn
                                string updateQuery = "UPDATE Orders SET Order_Date = @OrderDate, Users_Id = @usersid, Customer_Name = @CustomerName, Customer_Number = @CustomerNumber, " +
                                    "Total_Amout = @TotalAmount, Paid_Amout = @PaidAmount, Due_Amout = @DueAmount, Discount = @Discount, " +
                                    "Grand_Total = @GrandTotal, StatusPayment = @StatusPayment WHERE Orders_Id = @OrderId";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    // Thiết lập giá trị cho các tham số
                                    updateCommand.Parameters.AddWithValue("@OrderDate", orderDate);
                                    updateCommand.Parameters.AddWithValue("@usersid", usersid);
                                    updateCommand.Parameters.AddWithValue("@CustomerName", customerName);
                                    updateCommand.Parameters.AddWithValue("@CustomerNumber", customerNumber);
                                    updateCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                                    updateCommand.Parameters.AddWithValue("@PaidAmount", paidAmount);
                                    updateCommand.Parameters.AddWithValue("@DueAmount", dueAmount);
                                    updateCommand.Parameters.AddWithValue("@Discount", discount);
                                    updateCommand.Parameters.AddWithValue("@GrandTotal", grandTotal);
                                    updateCommand.Parameters.AddWithValue("@StatusPayment", statusPayment);
                                    updateCommand.Parameters.AddWithValue("@OrderId", orderId);

                                    // Thực thi câu lệnh SQL
                                    int rowsAffected = updateCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Thông tin hóa đơn đã được cập nhật thành công.");
                                        EmtyBox1();
                                        LoadOrdersData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cập nhật thông tin hóa đơn không thành công.");
                                        EmtyBox1();
                                    }
                                }
                            }
                            else
                            {
                                // Giá trị ngày tháng không hợp lệ, hiển thị thông báo lỗi
                                MessageBox.Show("Giá trị ngày tháng không hợp lệ.");
                                EmtyBox1();
                            }
                        }
                        else
                        {
                            // Trạng thái không phải "--Thanh Toán Thất Bại--", hiển thị thông báo lỗi
                            MessageBox.Show("Không thể cập nhật hóa đơn vì trạng thái không phải là '--Thanh Toán Thất Bại--'.");
                            EmtyBox1();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alo Coder:0329615309 để được update", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        #endregion
        #region constraint
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text.Length == 10)
            {
                string sodienthoai = txtSoDienThoai.Text.Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkphonenumberquery = "SELECT * FROM Customer WHERE Phone_Number = @phonenumber";
                    using (SqlCommand command = new SqlCommand(checkphonenumberquery, connection))
                    {
                        command.Parameters.AddWithValue("@phonenumber", sodienthoai);
                        // Thực thi câu lệnh SQL
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Số điện thoại đã tồn tại trong cơ sở dữ liệu
                                string sodienthoaikh = reader["Phone_Number"].ToString();
                                string tenkhachhang = reader["Customer_Name"].ToString();
                                string makhachhang = reader["Customer_Number"].ToString();

                                // Hiển thị thông tin khách hàng vào các TextBox tương ứng
                                txtSoDienThoai.Text = sodienthoaikh;
                                txttenkhachhang.Text = tenkhachhang;
                                txtmakhachhang.Text = makhachhang;
                            }
                            else
                            {
                                // Số điện thoại chưa tồn tại trong cơ sở dữ liệu
                                txttenkhachhang.Text = string.Empty;
                                txtmakhachhang.Text = "KH" + DateTime.Now.ToString("yyMMddhhmmss");
                            }
                        }
                    }
                }
            }
            else
            {
                // Xóa thông tin khách hàng khi số điện thoại không hợp lệ
                txttenkhachhang.Text = string.Empty;
                txtmakhachhang.Text = "KH" + DateTime.Now.ToString("yyMMddhhmmss");
            }
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {

           
                    e.Handled = true; // Vô hiệu hóa ký tự không hợp lệ
                
            
        }
   

        private void txtMaNhanVien_KeyDown(object sender, KeyEventArgs e)
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

        private void txtmakhachhang_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbsanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Vô hiệu hóa ký tự không hợp lệ
        }

        private void cmbsanpham_DropDown(object sender, EventArgs e)
        {
            cmbsanpham.DropDownStyle = ComboBoxStyle.DropDownList; // Chỉ cho phép chọn từ danh sách
        }

        private void cmbsanpham_KeyDown(object sender, KeyEventArgs e)
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
  
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                // Kiểm tra nếu có ký tự không phải số hoặc độ dài vượt quá 10
                if (!IsNumeric(txtSoDienThoai.Text) || txtSoDienThoai.Text.Length > 10)
                {
                    // Xóa ký tự cuối cùng
                    txtSoDienThoai.Text = txtSoDienThoai.Text.Remove(txtSoDienThoai.Text.Length - 1);
                    // Di chuyển con trỏ về cuối TextBox
                    txtSoDienThoai.SelectionStart = txtSoDienThoai.Text.Length;
                }
            }
        }
        // Kiểm tra xem một chuỗi có phải là số hay không
        private bool IsNumeric(string text)
        {
            return long.TryParse(text, out _);
        }
        private void txtSoDienThoai_KeyDown(object sender, KeyEventArgs e)
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

        private void txttenkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b' && e.KeyChar != '̣' && e.KeyChar != '́' && e.KeyChar != '̀')
            {
                e.Handled = true; // Vô hiệu hóa ký tự số và ký tự đặc biệt không cho phép
            }
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbtttt_Click(object sender, EventArgs e)
        {
            string successItem = "Thanh Toán Thành Công";
            string failureItem = "Thanh Toán Thất Bại";
            if (!cmbtttt.Items.Contains(successItem))
            {
                cmbtttt.Items.Add(successItem);
            }

            if (!cmbtttt.Items.Contains(failureItem))
            {
                cmbtttt.Items.Add(failureItem);
            }

            cmbtttt.SelectedIndex = 0;
        }
        #endregion

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaNhanVien1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttenkhachhangop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMaHoaDon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttongtienop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttenkhachhangop_TextChanged(object sender, EventArgs e)
        {

        }
        private void txttongcongop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
       
        private void txttiennhankhachhang_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txttiennhankhachhang.Text, out int result))
            {
                txttiennhankhachhang.Text = ""; // Xóa nội dung TextBox nếu không phải số
            }
            // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
            if ((!string.IsNullOrEmpty(txttongtienop.Text) && int.TryParse(txttongtienop.Text, out int total)) &&
                (!string.IsNullOrEmpty(txtGiamGiaLC.Text) && int.TryParse(txtGiamGiaLC.Text, out int discountAmount)))
            {
                // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
                if (!string.IsNullOrEmpty(txttiennhankhachhang.Text) && int.TryParse(txttiennhankhachhang.Text, out int customerPayment))
                {
                    
                    // Tính toán tổng cộng
                    int subtotal = total - discountAmount;

                    // Tính toán tiền thừa
                    int change = customerPayment  - subtotal;

                    // Hiển thị tổng cộng và tiền thừa lên các textbox tương ứng
                    txttongcongop.Text = subtotal.ToString();
                    txtTienThuaLC.Text = change.ToString();
                }
                else if (int.TryParse(txtGiamGiaLC.Text, out int discountAmount1) && discountAmount1 < 0)
                {
                    MessageBox.Show("Số tiền nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }
           

        }

        private void cmbtrangthaiop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGiamGiaLC_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGiamGiaLC.Text, out int result))
            {
                txtGiamGiaLC.Text = ""; // Xóa nội dung TextBox nếu không phải số
            }
            // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
            if ((!string.IsNullOrEmpty(txttongtienop.Text) && int.TryParse(txttongtienop.Text, out int total)) &&
                (!string.IsNullOrEmpty(txttiennhankhachhang.Text) && int.TryParse(txttiennhankhachhang.Text, out int customerPayment)))
            {
                // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
                if (!string.IsNullOrEmpty(txtGiamGiaLC.Text) && int.TryParse(txtGiamGiaLC.Text, out int discountAmount))
                {

                    // Tính toán tổng cộng
                    int subtotal = total - discountAmount;

                    // Tính toán tiền thừa
                    int change = customerPayment - subtotal;

                    // Hiển thị tổng cộng và tiền thừa lên các textbox tương ứng
                    txttongcongop.Text = subtotal.ToString();
                    txtTienThuaLC.Text = change.ToString();
                }
                else if (int.TryParse(txtGiamGiaLC.Text, out int discountAmount1) && discountAmount1 < 0)
                {
                    MessageBox.Show("Số tiền nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiamGiaLC.Text = ""; // Xóa giá trị nhập vào
                    txttongcongop.Text = "";
                    txtTienThuaLC.Text = "";
                }
            }
            else
            {
                // Xử lý trường hợp giá trị nhập vào không hợp lệ
                //MessageBox.Show("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại giá trị số.");

                // Xóa nội dung trong các textbox
                txttongtienop.Text = "";
                txttiennhankhachhang.Text = "";
                txtGiamGiaLC.Text = "";
                txttongcongop.Text = "";
                txtTienThuaLC.Text = "";
            }
        }

        private void txtTienThuaLC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void guna2HtmlLabel23_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbtttt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGiamGiaLC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
