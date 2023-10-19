﻿using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlOrders : UserControl
    {
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn
        DataBase db = new DataBase();
        int otong = 0;
        decimal tongSoTien = 0;
        public UserControlOrders()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbtttt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            Receipt();
            printPreviewDialog1.Document = printDocument1;
            printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printPreviewDialog1.ShowDialog();
        }

        private void tpthemhoadon_Click(object sender, EventArgs e)
        {
           
        }

        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void tpluachon_Click(object sender, EventArgs e)
        {
           
        }
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
                   lbltongsotien.Text = dtgvQL.Rows.Count.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
          
        }
    
    private void UserControlOrders_Load(object sender, EventArgs e)
        {
            txtmakhachhang.Text = "KH " + DateTime.Now.ToString("yyMMddhhmmss");
            txtMaHoaDon.Text = "BILL" + DateTime.Now.ToString("yyMMddhhmmss");
            dtpDate.Value = DateTime.Now;
            LoadProductsToComboBox();
            LoadOrdersData();
         



        }
  /*      private string TinhTongTienTrenMotHoaDon()
        {
            int tongsotien = 0;
            if(dtgvQL.Rows.Count < 0)
            {
                lbltongsotien.Text = string.Empty;
            }
            int tien = dtgvQL.Rows.Count;
            int thanhtien = 0;
            for(int i = 0;i<tien; i++)
            {
                thanhtien += int.Parse(dtgvQL.Rows[i].Cells["Grand_Total"].Value.ToString());
            }
            tongsotien = thanhtien;
            return tongsotien.ToString();

        }*/
        private void LoadProductsToComboBox()
        {
            using (var context = new DataBase())
            {
                var products = context.Product.ToList();

                // Lấy danh sách tên sản phẩm
                var productNames = products.Select(product => product.Product_Name).ToArray();

                // Thêm danh sách sản phẩm vào combobox
                cmbsanpham.Items.AddRange(productNames);
            }
        }

        private void dtgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DateTime GetDateTimeValue(object value)
        {
            if (value != null && value != DBNull.Value)
            {
                return Convert.ToDateTime(value);
            }
            else
            {
                return DateTime.MinValue; // Giá trị mặc định khi giá trị là DBNull hoặc null
            }
        }

        private string GetStringCellValue(object value)
        {
            if (value != null && value != DBNull.Value)
            {
                return value.ToString();
            }
            else
            {
                return string.Empty; // Giá trị mặc định khi giá trị là DBNull hoặc null
            }
        }

        private int GetIntValue(object value)
        {
            if (value != null && value != DBNull.Value)
            {
                return Convert.ToInt32(value);
            }
            else
            {
                return 0; // Giá trị mặc định khi giá trị là DBNull hoặc null
            }
        }
        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }
        private void AddClear()
        {
            

            Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status ='Thanh Toán Thành Công' ORDER BY Product_Name;", cmbsanpham);

            // Lấy danh sách các dòng được chọn
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dtgvOrder.SelectedRows)
            {
                selectedRows.Add(row);
            }

            foreach (DataGridViewRow row in selectedRows)
            {
                // Kiểm tra nếu hàng đó không phải là hàng mới (đã được commit)
                if (!row.IsNewRow)
                {
                    dtgvOrder.Rows.Remove(row);
                }
            }
            txttenkhachhang.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            cmbsanpham.SelectedItem = "--SELECT--";
            cmbtttt.SelectedItem = "--SELECT--";
            txtGiaTien.Text = string.Empty;
            nudsoluong.Value = 0;
            txtthanhtien.Text = string.Empty;
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
                    if (result != DBNull.Value)
                    {
                        availableQuantity = (int)result;
                    }
                }
            }

            return availableQuantity;
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                return;
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

                    AddClear();
                    return;
                }
            }

            // Thêm thông tin ngày lập, tên khách hàng và mã khách hàng vào dòng đó
            string[] row = { productName, txtGiaTien.Text, requestedQuantity.ToString(), txttongtien.Text };
            dtgvOrder.Rows.Add(row);

            cmbsanpham.SelectedItem = "--SELECT--";
            txtGiaTien.Text = string.Empty;
            nudsoluong.Value = 0;
            txtthanhtien.Text = string.Empty;
            txttongtien.Text = "";
            CalculateTotal();
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

        /* private void btnLuu_Click(object sender, EventArgs e)
         {
             if (txttenkhachhang.Text.Trim() == string.Empty)
             {
                 MessageBox.Show("Vui lòng nhập tên", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
             else if (nudsoluong.Value == 0)
             {
                 MessageBox.Show("Vui lòng nhập số lượng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }
             else
             {


                 string str = "INSERT INTO Orders(Orders_Id,Order_Date,Customer_Name,Customer_Number,Total_Amout,Paid_Amout,Due_Amout,Discount,Grand_Total,StatusPayment)  VALUES ( '" + txtMaHoaDon.Text + "','" + dtpDate.Value.ToString("yyyy/MM/dd") + "',N'" + txttenkhachhang.Text + "','" + txtmakhachhang.Text + "'," + Convert.ToInt32(txttongtien.Text.Trim()) + "," + Convert.ToInt32(txttienphaitra.Text.Trim()) + "," + Convert.ToInt32(txtGiamGia.Text.Trim()) + "," + Convert.ToInt32(txtTienThua.Text.Trim()) + "," + Convert.ToInt32(txttongcong.Text.Trim()) + ",'" + cmbtttt.SelectedItem.ToString() + "')";
                 DataProvider.ExecuteNonQuery(str);

                 foreach (DataGridViewRow rows in dtgvOrder.Rows)
                 {
                     if (rows.Cells[0].Value != null)
                     {
                         string productName = rows.Cells[0].Value.ToString();

                         string a = "SELECT * FROM Product WHERE Product_Name = N'" + productName + "'";
                         DataTable dt = new DataTable();
                         dt = DataProvider.GetData(a);

                         string checkQuery = "SELECT COUNT(*) FROM Orders WHERE BillCode = '" + billCode + "'";
                         int count = 0;

                         // Tiếp tục xử lý dữ liệu
                         int Product_Id = Convert.ToInt32(dt.Rows[0][0].ToString());

                         int Amout = Convert.ToInt32(rows.Cells[2].Value.ToString());
                         int Product_Rate = Convert.ToInt32(rows.Cells[1].Value.ToString());
                         int Total = Convert.ToInt32(rows.Cells[3].Value.ToString());
                         string str2 = "INSERT INTO OrderDetails(Orders_Id,Product_Id,Amout,Product_Rate,Total)  VALUES ( '" + txtMaHoaDon.Text + "'," + Product_Id + "," + Amout + "," + Product_Rate + "," + Total + ")";
                         DataProvider.ExecuteNonQuery(str2);
                     }

                     else
                     {
                         MessageBox.Show("Lỗi");  
                     }    



                 }

                 EmtyBox();
             }

         }*/
        private bool ValidateCategoryName(string CategoryName)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa ký tự đặc biệt và số
            string pattern = @"^[\p{L}\s]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(CategoryName);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
                string connectionString = "data source=DESKTOP-3JE3S4U\\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    count = (int)checkCmd.ExecuteScalar();

                    connection.Close();
                }

                if (count > 0)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng chọn mã hóa đơn khác.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tiếp tục lưu hóa đơn và chi tiết hóa đơn 
                string orderQuery = "INSERT INTO Orders(Orders_Id, Order_Date, Customer_Name, Customer_Number, Total_Amout, Paid_Amout,Discount, Due_Amout, Grand_Total, StatusPayment)  VALUES ('" + billCode + "','" + dtpDate.Value.ToString("yyyy/MM/dd") + "',N'" + txttenkhachhang.Text + "','" + txtmakhachhang.Text + "'," + Convert.ToInt32(txttongtien.Text.Trim()) + "," + Convert.ToInt32(txttienphaitra.Text.Trim()) + "," + Convert.ToInt32(txtGiamGia.Text.Trim()) + "," + Convert.ToInt32(txtTienThua.Text.Trim()) + "," + Convert.ToInt32(txttongcong.Text.Trim()) + ",'" + cmbtttt.SelectedItem.ToString() + "')";
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
                            // Lưu chi tiết hóa đơn
                            string orderDetailQuery = "INSERT INTO OrderDetails(Orders_Id, Product_Id, Amout, Product_Rate, Total) VALUES ('" + billCode + "'," + productId + "," + amount + "," + productRate + "," + total + ")";
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
                MessageBox.Show("Lưu Hóa Đơn Thành Công");

                AddClear();
            }
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

        }
        // trả về các box rỗng bên Quản Lý
        public void EmtyBox1()
        {
            dtp2.Value = DateTime.Now;
            txttenkhachhangop.Clear();
            txttenkhachhangop.Clear();
            AddClear();
            dtgvOrder.Rows.Clear();
            txttongtienop.Text = "0";
            txtTienThuaLC.Text = "0";
            txttiennhankhachhang.Text = "0";
            txtGiamGiaLC.Text = "0";
            txttongcongop.Text = "0";
            cmbtrangthaiop.SelectedIndex = 0;

        }
        RichTextBox richTextBox = new RichTextBox();
        // Chức năng xuất hóa đơn
        private void Receipt()
        {
            richTextBox.Clear();
            richTextBox.Text += "\t              Computer Shop Management System\n";
            richTextBox.Text += "**********************************************************************************************\n\n";
            richTextBox.Text += "   Ngày Mua:" + dtpDate.Text + "\n";
            richTextBox.Text += "   Mã Hóa Đơn:" + txtMaHoaDon.Text.Trim() + "\n";
            richTextBox.Text += "   Tên Khách Hàng:" + txttenkhachhang.Text.Trim() + "\n";
            richTextBox.Text += "   Mã Khách Hàng:" + txtmakhachhang.Text.Trim() + "\n\n";
            richTextBox.Text += "***********************************************************************************************\n\n";
            richTextBox.Text += "Tên Sản Phẩm\t\tGiá\t\t      Số Lượng\t\t\tTổng Tiền\n";
            for (int i = 0; i < dtgvOrder.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvOrder.Columns.Count; j++)
                {
                    var cellValue = dtgvOrder.Rows[i].Cells[j].Value;
                    if (cellValue != null)
                    {
                        richTextBox.Text += cellValue.ToString() + "    \t\t\t";
                    }
                    else
                    {
                        richTextBox.Text += "\t\t"; // Ô trống
                    }
                   
                }
                richTextBox.Text += "\n";
            }

            richTextBox.Text += "***********************************************************************************************\n\n ";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTổng Cộng: $ " + txttongtien.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tSố Tiền Đã Nhận: $" + txttienphaitra.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tGiảm Giá: $ " + txtGiamGia.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTiền Thừa: $ " + txtTienThua.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\t*********************\n\n ";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTổng Cộng: $ " + txttongcong.Text + "\n\n";
        }
      /*  private void CalculateChange()
        {
            // Kiểm tra và chuyển đổi giá trị từ textbox thành kiểu int
            if ((!string.IsNullOrEmpty(txttongtien.Text) && int.TryParse(txttongtien.Text, out int total)) &&
                (!string.IsNullOrEmpty(txttiennhankhachhang.Text) && int.TryParse(txttiennhankhachhang.Text, out int customerPayment)))
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
                else
                {
                    // Xử lý trường hợp giá trị nhập vào không hợp lệ
                    MessageBox.Show("Giá trị giảm giá không hợp lệ. Vui lòng nhập lại giá trị số.");

                    // Xóa nội dung trong các textbox
                    txtGiamGia.Text = "";
                    txttongcong.Text = "";
                    txtTienThua.Text = "";
                }
            }
            else
            {
                // Xử lý trường hợp giá trị nhập vào không hợp lệ
                MessageBox.Show("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại giá trị số.");

                // Xóa nội dung trong các textbox
                txttongtien.Text = "";
                txttiennhankhachhang.Text = "";
                txtGiamGia.Text = "";
                txttongcong.Text = "";
                txtTienThua.Text = "";
            }
        }*/

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

            if (!int.TryParse(txttienphaitra.Text, out int tienKhachTra) && tienKhachTra <0)
            {
                MessageBox.Show("Số âm không được phép!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string gia = Computer.Gia(cmbsanpham.SelectedItem.ToString());
            if (gia != string.Empty)
            {
                txtGiaTien.Text = gia;
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
                else if(int.TryParse(txtGiamGia.Text, out int discountAmount1) && discountAmount1<0)
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
            e.Graphics.DrawString(richTextBox.Text, new Font("Segoe UI", 6, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hóa Đơn này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string customerid = txtMaKH.Text;

                    OderController oderController = new OderController();
                    bool result = oderController.DeleteOrder(customerid);

                    if (result)
                    {
                        MessageBox.Show("Xóa Hóa đơn thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgvOrder.Refresh();
                        EmtyBox1();
                    }
                }
            }
        }

        private void dtgvQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvQL.Rows[e.RowIndex];

            tpOders.SelectedTab = tpluachon;
            txtMaHoaDon1.Text = row.Cells[0].Value.ToString();
            dtp2.Value = Convert.ToDateTime(row.Cells[1].Value);
            txttenkhachhangop.Text = row.Cells[2].Value.ToString();
            txtMaKH.Text = row.Cells[3].Value.ToString();
            txttongtienop.Text = row.Cells[4].Value.ToString();
            txttiennhankhachhang.Text = row.Cells[5].Value.ToString();
            txtGiamGiaLC.Text = row.Cells[7].Value.ToString();
            txtTienThuaLC.Text = row.Cells[6].Value.ToString();
            txttongcongop.Text = row.Cells[8].Value.ToString();
            cmbtrangthaiop.Text = row.Cells[9].Value.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           
          
         
        }

        private void tpquanlyhoadon_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
           
        }
        private void dtgvQL_Click(object sender, EventArgs e)
        {
      
        
        }

        private void txtTienThua_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // chặn ký tự nhập vào
            e.Handled = true;
        }
        private void SearchCustomer(string searchName)
        {
            string query = "SELECT Orders_Id, Order_Date, Customer_Name, Customer_Number, Total_Amout, Paid_Amout, Due_Amout, Discount, Grand_Total, StatusPayment FROM Orders WHERE Customer_Name LIKE @SearchName;";

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

      

        private void txttimtenkhachhang_TextChanged(object sender, EventArgs e)
        {
            string searchName = txttimtenkhachhang.Text;
             SearchCustomer(searchName);
        }

        private void btntimtenkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled |= true;
        }

        private void dtgvQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0 && e.RowIndex < dtgvQL.RowCount)
            {

                DataGridViewRow row = dtgvQL.Rows[e.RowIndex];

                if (row.Cells.Count >0)
                {

                    txttenkhachhangop.Text = row.Cells[2].Value.ToString();
                    txtMaKH.Text = row.Cells[3].Value.ToString();
                    txttongtienop.Text = row.Cells[4].Value.ToString();
                    txttiennhankhachhang.Text = row.Cells[5].Value.ToString();
                    txtGiamGiaLC.Text = row.Cells[7].Value.ToString();
                    txtTienThuaLC.Text = row.Cells[6].Value.ToString();
                    txttongcongop.Text = row.Cells[8].Value.ToString();
                    cmbtrangthaiop.SelectedItem = row.Cells[9].Value.ToString();
                    tpOders.SelectedTab = tpluachon;
                }

            }*/
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
                    dtgvOrder.Rows.RemoveAt(e.RowIndex);
                    CalculateTotal();
                }
            }
        }

        private void txtMaHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled   = true;
        }

        private void txtmakhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled  = true;
        }

        private void cmbtrangthaiop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
