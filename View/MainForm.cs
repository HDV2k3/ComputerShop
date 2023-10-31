using Computer_Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.View
{
    public partial class MainForm : Form
    {
        public string name = "?";

        public static User User = new User();
        public MainForm()
        {
            InitializeComponent();
        }
        #region MEthod
        private List<User> GetUserList()
        {
            List<User> users = new List<User>();

            string connectionString = @"data source=DESKTOP-3JE3S4U\SQLEXPRESS;initial catalog=ComputerShopSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            string query = "SELECT Users_Category_Id FROM dbo.[User]"; // Câu truy vấn SQL để lấy danh sách người dùng

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string userCategoryId = reader["Users_Category_Id"].ToString();

                            User user = new User
                            {

                                Users_Category_Id = userCategoryId
                            };

                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        public MainForm(User u)
        {
            User = u;
            InitializeComponent();
        }
        #endregion
        #region Event
        private void MovePanel(Control btn)
        {
           pnlDiChuyen.Top = btn.Top;
            pnlDiChuyen.Height = btn.Height;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserName .Text = name;
            NgayVaGio.Start();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn Có Muốn Đăng Xuất?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                MovePanel(btnLogOut);
                NgayVaGio.Stop();
                Close();
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
                MovePanel(btnDashboard);
                UserControlDashboard1.Visible = true;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
                UserControlBrandStaff1.Visible = false;
                userControlUserStaff1.Visible = false;
                userControlProductStaff1.Visible = false;
                userControlCategoryStaff1.Visible = false;


        }
        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
         

                    if (User.Users_Category_Id == "Admin")
                    {
                        MovePanel(btnThuongHieu);
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = true;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible = false;
                        userControlProductStaff1.Visible = false;
                        userControlCategoryStaff1.Visible = false;
                        userControlDiscount1.Visible = false;
                    }
                    else 
                    {
                        MovePanel(btnThuongHieu);
                        UserControlBrandStaff1.Visible = true;
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = false;                     
                        userControlUserStaff1.Visible = false;
                        userControlProductStaff1.Visible = false;
                        userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }
                
            

        }
        private void btnLoai_Click(object sender, EventArgs e)
        {
           
                    if (User.Users_Category_Id == "Admin")
                    {
                        MovePanel(btnLoai);
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = true;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = false;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible = false;
                        userControlProductStaff1.Visible = false;
                        userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }
                    else 
                    {
                        MovePanel(btnLoai);
                    
                        
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = false;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible= false;
                        userControlProductStaff1.Visible= false;
                        userControlCategoryStaff1.Visible = true;
                userControlDiscount1.Visible = false;
            }
           

            //jhihi
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
           
                    if (User.Users_Category_Id == "Admin")
                    {
                        MovePanel(btnSanPham);
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = true;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = false;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible = false;
                        userControlProductStaff1.Visible = false;
                        userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }
                    else 
                    {
                        MovePanel(btnSanPham);
                   

                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = false;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible = false;
                        userControlProductStaff1.Visible = true;
                        userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }
           
        }
        private void btnDatHang_Click(object sender, EventArgs e)
        {
            
                MovePanel(btnDatHang);
                UserControlDashboard1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = true;
             
                UserControlOrders1.SetUser(User);
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
                UserControlBrandStaff1.Visible = false;
                userControlUserStaff1.Visible = false;
                userControlProductStaff1.Visible = false;
                userControlCategoryStaff1.Visible = false;
            userControlDiscount1.Visible = false;

        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
                MovePanel(btnBaoCao);
                UserControlDashboard1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = true;
                UserControlUser1.Visible = false;
                UserControlBrandStaff1.Visible = false;
                userControlUserStaff1.Visible = false;
                userControlProductStaff1.Visible = false;
                userControlCategoryStaff1.Visible = false;
            userControlDiscount1.Visible = false;


        }
        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
           
                    if (User.Users_Category_Id == "Admin")
                    {
                        MovePanel(btnNguoiDung);
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = true;
                        UserControlBrand1.Visible = false;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible = false;
                        userControlProductStaff1.Visible = false;
                        userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }
                    else 
                    {
                        MovePanel(btnNguoiDung);
                      
                        UserControlDashboard1.Visible = false;
                        UserControlCategory1.Visible = false;
                        UserControlProduct1.Visible = false;
                        UserControlOrders1.Visible = false;
                        UserControlReport1.Visible = false;
                        UserControlUser1.Visible = false;
                        UserControlBrand1.Visible = false;
                        UserControlBrandStaff1.Visible = false;
                        userControlUserStaff1.Visible = true;
                        userControlProductStaff1.Visible = false;
                        userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }
           

        }
        private void NgayVaGio_Tick(object sender, EventArgs e)
        {
            lblNgayVaGio.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
        #endregion

        private void btnDiscount_Click(object sender, EventArgs e)
        {

            if (User.Users_Category_Id == "Admin")
            {
                MovePanel(btnDiscount);
                UserControlDashboard1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlBrandStaff1.Visible = false;
                userControlUserStaff1.Visible = false;
                userControlProductStaff1.Visible = false;
                userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = true;
            }
            else
            {
                MovePanel(btnDiscount);

                UserControlDashboard1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlBrandStaff1.Visible = false;
                userControlUserStaff1.Visible = true;
                userControlProductStaff1.Visible = false;
                userControlCategoryStaff1.Visible = false;
                userControlDiscount1.Visible = false;
            }

        }
    }
}
