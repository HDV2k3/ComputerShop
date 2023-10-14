using Computer_Shop_Management_System.Controller;
using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class UserControlOrders : UserControl
    {
        int TotalMoney = 0;
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

        private void UserControlOrders_Load(object sender, EventArgs e)
        {
            txtmakhachhang.Text = "BILL" + DateTime.Now.ToString("yyMMddhhmmss");
            LoadProductsToComboBox();
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

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                int rowIndex = dtgvOrder.CurrentCell.RowIndex;

                // Kiểm tra xem dòng hiện tại có phải là dòng mới chưa được commit hay không
                if (rowIndex >= 0 && rowIndex < dtgvOrder.Rows.Count && !dtgvOrder.Rows[rowIndex].IsNewRow)
                {
                    dtgvOrder.Rows.RemoveAt(rowIndex);

                    if (dtgvOrder.Rows.Count != 0)
                    {
                        int TotalMoney = 0;
                        foreach (DataGridViewRow row in dtgvOrder.Rows)
                        {
                            if (row.Cells[3].Value != null)
                            {
                                TotalMoney += Convert.ToInt32(row.Cells[3].Value.ToString());
                            }
                        }
                        txttongtien.Text = TotalMoney.ToString();
                    }
                    else
                    {
                        txttongtien.Text = "0";
                        TotalMoney = 0;
                    }
                }
            }
        }
        private void AddClear()
        {
            /*cmbsanpham.Items.Clear();
            cmbsanpham.Items.Add("--SELECT--");
            Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status ='Thanh Toán Thành Công' ORDER BY Product_Name;", cmbsanpham);
            cmbsanpham.SelectedIndex = 0;
            txtgia.Clear();
            nudsoluong.Value = 0;
            txttongtien.Clear();*/
            /*cmbsanpham.Items.Clear();*/
            /*   cmbsanpham.SelectedIndex = 0;*/
            /*cmbsanpham.Items.Add("--SELECT--");*/

            Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status ='Thanh Toán Thành Công' ORDER BY Product_Name;", cmbsanpham);

            txtgia.Clear();
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
            Int32.TryParse(txtgia.Text, out gia);
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
            cmbsanpham.SelectedItem.ToString(), txtgia.Text, nudsoluong.Value.ToString(), txttongtien.Text
        };
                dtgvOrder.Rows.Add(row);
                /* AddClear();*/
            }

            CalculateTotal();
        }
        private void CalculateTotal()
        {
            int Total = 0;
            foreach (DataGridViewRow rows in dtgvOrder.Rows)
            {
                Total += Convert.ToInt32(rows.Cells[3].Value);
            }
            txttongtien.Text = Total.ToString();
        }

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
            else if (txttiennhankhachhang.Text.Trim() == string.Empty)
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
                //Orders orders = new Orders
                //(
                //    dtpDate.Value.Date,
                //    Convert.ToInt32(nudsoluong.Value),
                //    txttenkhachhang.Text.Trim(),
                //    txtmakhachhang.Text.Trim(),
                //    Convert.ToInt32(txttongtien.Text.Trim()),
                //    Convert.ToInt32(txttiennhantukhach.Text.Trim()),
                //    Convert.ToInt32(txtgiamgia.Text.Trim()),
                //    Convert.ToInt32(txttienthua.Text.Trim()),
                //    Convert.ToInt32(txttongcong.Text.Trim()),
                //    cmbtttt.SelectedItem.ToString()
                //);
                //Computer.SaveOrder(orders);
                //// Cập nhật lại nguồn dữ liệu cho DataGridView
                //dtgvProductList.DataSource = Computer.GetOrders();
                string str = "INSERT INTO Orders(Orders_Id,Order_Date,Customer_Name,Customer_Number,Total_Amout,Paid_Amout,Due_Amout,Discount,Grand_Total,StatusPayment)  VALUES ( '" + txtOrders_Id.Text + "','" + dtpDate.Value.ToString("yyyy/MM/dd") + "',N'" + txttenkhachhang.Text + "','" + txtmakhachhang.Text + "'," + Convert.ToInt32(txttongtien.Text.Trim()) + "," + Convert.ToInt32(txttiennhantukhach.Text.Trim()) + "," + Convert.ToInt32(txtgiamgia.Text.Trim()) + "," + Convert.ToInt32(txttienthua.Text.Trim()) + "," + Convert.ToInt32(txttongcong.Text.Trim()) + ",'" + cmbtttt.SelectedItem.ToString() + "')";
                DataProvider.ExecuteNonQuery(str);

                foreach (DataGridViewRow rows in dtgvOrder.Rows)
                {
                    string a = "SELECT * FROM Product WHERE Product_Name = N'" + rows.Cells[0].Value.ToString() + "' ";
                    DataTable dt = new DataTable();
                    dt = DataProvider.GetData(a);


                    int Product_Id = Convert.ToInt32(dt.Rows[0][0].ToString());

                    int Amout = Convert.ToInt32(rows.Cells[2].Value.ToString());
                    int Product_Rate = Convert.ToInt32(rows.Cells[1].Value.ToString());
                    int Total = Convert.ToInt32(rows.Cells[3].Value.ToString());
                    string str2 = "INSERT INTO OrderDetails(Orders_Id,Product_Id,Amout,Product_Rate,Total)  VALUES ( '" + txtOrders_Id.Text + "'," + Product_Id + "," + Amout + "," + Product_Rate + "," + Total + ")";
                    DataProvider.ExecuteNonQuery(str2);
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
            txtti.Text = "0";
            txttiennhantukhach.Text = "0";
            txtgiamgia.Text = "0";
            txttongcong.Text = "0";
            cmbtttt.SelectedIndex = 0;

        }
    }
}
