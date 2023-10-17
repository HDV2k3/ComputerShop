using Computer_Shop_Management_System.Controller;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlOrders : UserControl
    {
        private const string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=HutechDBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"; // Thay thế bằng chuỗi kết nối của bạn
        DataBase db = new DataBase();
        int otong = 0;
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
            LoadOrdersData();
        }

        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void tpluachon_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    
    private void UserControlOrders_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "BILL" + DateTime.Now.ToString("yyMMddhhmmss");
            LoadProductsToComboBox();
            /*  // Kết nối và truy vấn cơ sở dữ liệu để lấy danh sách sản phẩm
              string connectionString = "your_connection_string_here";
              string query = "SELECT ProductName FROM Products";
              using (SqlConnection connection = new SqlConnection(connectionString))
              {
                  connection.Open();
                  using (SqlCommand command = new SqlCommand(query, connection))
                  {
                      using (SqlDataReader reader = command.ExecuteReader())
                      {
                          while (reader.Read())
                          {
                              cmbsanpham.Items.Add(reader["ProductName"].ToString());
                          }
                      }
                  }
              }*/
            LoadOrdersData();
        }

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

            /*if (e.ColumnIndex == 4)
            {
                int rowIndex = dtgvOrder.CurrentCell.RowIndex;

                // Kiểm tra xem dòng hiện tại có phải là dòng mới chưa được commit hay không
                if (rowIndex >= 0 && rowIndex < dtgvOrder.Rows.Count && !dtgvOrder.Rows[rowIndex].IsNewRow)
                {
                    dtgvOrder.Rows.RemoveAt(rowIndex);

                    if (dtgvOrder.Rows.Count != 0)
                    {
                        int otong = 0;
                        foreach (DataGridViewRow row in dtgvOrder.Rows)
                        {
                            if (row.Cells[3].Value != null)
                            {
                                otong += Convert.ToInt32(row.Cells[3].Value.ToString());
                            }
                        }
                        txttongtien.Text = otong.ToString();
                    }
                    else
                    {
                        txttongtien.Text = "0";
                        otong = 0;
                    }
                }
            }*/
            
        }
        private void AddClear()
        {
            

            Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status ='Thanh Toán Thành Công' ORDER BY Product_Name;", cmbsanpham);

            txtGiaTien.Clear();
            nudsoluong.Value = 0;
            txttongtien.Clear();


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

            int gia, tongtien;
            Int32.TryParse(txtGiaTien.Text, out gia);
            Int32.TryParse(txttongtien.Text, out tongtien);

            foreach (DataGridViewRow rows in dtgvOrder.Rows)
            {
                if (rows.Cells[0].Value != null && rows.Cells[0].Value.ToString() == cmbsanpham.SelectedItem.ToString())
                {
                    int quantity = Convert.ToInt32(rows.Cells[2].Value);
                    int total1 = Convert.ToInt32(rows.Cells[3].Value);
                    quantity += Convert.ToInt32(nudsoluong.Value);
                    total1 += tongtien;
                    rows.Cells[2].Value = quantity;
                    rows.Cells[3].Value = total1;
                    AddClear();
                    return;
                }
            }

            if (cmbsanpham.SelectedIndex != -1)
            {
                txttongtien.Text = (gia * Convert.ToInt32(nudsoluong.Value)).ToString();
                string[] row =
                {
            cmbsanpham.SelectedItem.ToString(), txtGiaTien.Text, nudsoluong.Value.ToString(), txttongtien.Text
        };
                dtgvOrder.Rows.Add(row);
                /* AddClear();*/
            }

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
     
        private void btnLuu_Click(object sender, EventArgs e)
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
                string orderQuery = "INSERT INTO Orders(Orders_Id, Order_Date, Customer_Name, Customer_Number, Total_Amout, Paid_Amout, Due_Amout, Discount, Grand_Total, StatusPayment)  VALUES ('" + billCode + "','" + dtpDate.Value.ToString("yyyy/MM/dd") + "',N'" + txttenkhachhang.Text + "','" + txtmakhachhang.Text + "'," + Convert.ToInt32(txttongtien.Text.Trim()) + "," + Convert.ToInt32(txttienphaitra.Text.Trim()) + "," + Convert.ToInt32(txtGiamGia.Text.Trim()) + "," + Convert.ToInt32(txtTienThua.Text.Trim()) + "," + Convert.ToInt32(txttongcong.Text.Trim()) + ",'" + cmbtttt.SelectedItem.ToString() + "')";
                DataProvider.ExecuteNonQuery(orderQuery);

                foreach (DataGridViewRow rows in dtgvOrder.Rows)
                {
                    if (rows.Cells[0].Value != null)
                    {
                        string productName = rows.Cells[0].Value.ToString();

                        // Kiểm tra tên sản phẩm đã tồn tại trong Product hay không
                        string productQuery = "SELECT COUNT(*) FROM Product WHERE Product_Name = N'" + productName + "'";
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
                            string getProductQuery = "SELECT * FROM Product WHERE Product_Name = N'" + productName + "'";
                            DataTable productDt = new DataTable();
                            productDt = DataProvider.GetData(getProductQuery);

                            int productId = Convert.ToInt32(productDt.Rows[0][0].ToString());
                            int amount = Convert.ToInt32(rows.Cells[2].Value.ToString());
                            int productRate = Convert.ToInt32(rows.Cells[1].Value.ToString());
                            int total = Convert.ToInt32(rows.Cells[3].Value.ToString());

                            // Lưu chi tiết hóa đơn
                            string orderDetailQuery = "INSERT INTO OrderDetails(Orders_Id, Product_Id, Amout, Product_Rate, Total) VALUES ('" + billCode + "'," + productId + "," + amount + "," + productRate + "," + total + ")";
                            DataProvider.ExecuteNonQuery(orderDetailQuery);
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm không tồn tại trong cơ sở dữ liệu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lưu Hóa Đơn Thành Công");
                        return;
                    }
                }

                EmtyBox();
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
       /*     txtti.Text = "0";
            txttiennhantukhach.Text = "0";
            txtgiamgia.Text = "0";*/
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
                   /* richTextBox.Text += "";*/
                }
            }

            richTextBox.Text += "*********************\n\n ";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTổng Tiền: $ " + txttongtien.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tSố Tiền Đã Nhận: $" + txttienphaitra.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tGiảm Giá: $ " + txtGiamGia.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTiền Thừa: $ " + txtTienThua.Text + "\n\n";
            richTextBox.Text += "\t\t\t\t\t\t\t\t*********************\n\n ";
            richTextBox.Text += "\t\t\t\t\t\t\t\tTổng Cộng: $ " + txttongcong.Text + "\n\n";
        }
        private void CalculateChange()
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
            if (string.IsNullOrEmpty(txttienphaitra.Text))
            {
                txtTienThua.Text = string.Empty;
                return;
            }

            if (!int.TryParse(txttienphaitra.Text, out int tienKhachTra))
            {
                // Xử lý khi tiền khách trả không hợp lệ
                // Ví dụ: Hiển thị thông báo lỗi, gán giá trị mặc định, ...
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
            /*// Kiểm tra nếu TextBox rỗng hoặc không thể chuyển đổi sang số thực, thoát khỏi phương thức
            if (string.IsNullOrEmpty(txtGiamGia.Text))
            {
                tienGiamGia = 0;
                txttongtien.Text = tongTien.ToString();
                return;
            }

            if (!int.TryParse(txtGiamGia.Text, out tienGiamGia))
            {
                // Xử lý khi tiền giảm giá không hợp lệ
                // Ví dụ: Hiển thị thông báo lỗi, gán giá trị mặc định, ...
                tienGiamGia = 0;
                txttongtien.Text = tongTien.ToString();
                return;
            }

            // Cập nhật lại tổng tiền
            int tongTienSauGiamGia = tongTien - tienGiamGia ;
            txttongcong.Text = tongTienSauGiamGia.ToString();

            // Tính toán số tiền thừa
            if (!string.IsNullOrEmpty(txttienphaitra.Text))
            {
                if (int.TryParse(txttienphaitra.Text, out int tienKhachTra))
                {
                    int tienThua = tienKhachTra - tongTienSauGiamGia;
                    txtTienThua.Text = tienThua.ToString();
                }
            }*/
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
                else
                {
                    // Xử lý trường hợp giá trị nhập vào không hợp lệ
                    //MessageBox.Show("Giá trị giảm giá không hợp lệ. Vui lòng nhập lại giá trị số.");

                    // Xóa nội dung trong các textbox
                    txtGiamGia.Text = "";
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
                    string orderid = txtMaHoaDon.Text;

                    OderController oderController = new OderController();
                    bool result = oderController.DeleteOrder(orderid);

                    if (result)
                    {
                        MessageBox.Show("Xóa thương hiệu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgvOrder.Refresh();
                        EmtyBox1();
                    }
                }
            }
        }

        private void dtgvQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvOrder.Rows[e.RowIndex];

                // Đổ dữ liệu từ DataGridViewRow vào các điều khiển tương ứng
                dtpDate.Value = GetDateTimeValue(row.Cells["Order_Date"].Value);
                txttenkhachhang.Text = GetStringCellValue(row.Cells["Customer_Name"].Value);
                txtmakhachhang.Text = GetStringCellValue(row.Cells["Customer_Number"].Value);
                txtMaHoaDon.Text = GetStringCellValue(row.Cells["Orders_Id"].Value);
                txttongtien.Text = GetIntValue(row.Cells["Total_Amout"].Value).ToString();
                txtTienThua.Text = GetIntValue(row.Cells["Paid_Amout"].Value).ToString();
                txttienphaitra.Text = GetIntValue(row.Cells["Due_Amout"].Value).ToString();
                txtGiamGia.Text = GetIntValue(row.Cells["Discount"].Value).ToString();
                txttongcong.Text = GetIntValue(row.Cells["Grand_Total"].Value).ToString();
                cmbtttt.SelectedItem = GetStringCellValue(row.Cells["StatusPayment"].Value);
                tabControl1.SelectedTab = tpluachon;
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

        private void dtgvQL_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
        }
    }
}
