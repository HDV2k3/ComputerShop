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
    public partial class MainForm : Form
    {
        public string name = "?";

        public static User User = new User();
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User u)
        {
            User = u;
            InitializeComponent();
        }
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
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnDashboard);
                UserControlDashboard1.Visible = true;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
            }   
            else
            {
                MessageBox.Show("Bạn Cần Cấp Quyền Cao Hơn Để Truy Cập");
            }    
           
            
        }
        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnThuongHieu);
                UserControlDashboard1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
                UserControlBrand1.Visible = true;
            }
            else
            {
                MovePanel(btnThuongHieu);
                MessageBox.Show("Bạn Cần Cấp Quyền Cao Hơn Để Truy Cập Các Chức Năng Cao Hơn");
                UserControlBrandStaff1.Visible = true;
                UserControlDashboard1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
                UserControlBrand1.Visible = false;
            }    
           
        }
        private void btnLoai_Click(object sender, EventArgs e)
        {
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnLoai);
                UserControlDashboard1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = true;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
            }    
            else
            {
                MessageBox.Show("Bạn Cần Cấp Quyền Cao Hơn Để Truy Cập");
            }    
           //jhihi
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnSanPham);
                UserControlDashboard1.Visible = true;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = true;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
            }  
            else
            {
                MessageBox.Show("Bạn Cần Cấp Quyền Cao Hơn Để Truy Cập");
            }    
           
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnDatHang);
                UserControlDashboard1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = true;
                UserControlReport1.Visible = false;
                UserControlUser1.Visible = false;
            }    
            else
            {
                UserControlOrders1.Visible = true;
               
            }    
           
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnBaoCao);
                UserControlDashboard1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = true;
                UserControlUser1.Visible = false;
            }  
            else
            {
                UserControlReport1.Visible = true;
                
            }    
         

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            if(User.Users_Category_Id == "Admin")
            {
                MovePanel(btnNguoiDung);
                UserControlUser1.Visible = true;
                UserControlDashboard1.Visible = false;
                UserControlBrand1.Visible = false;
                UserControlCategory1.Visible = false;
                UserControlProduct1.Visible = false;
                UserControlOrders1.Visible = false;
                UserControlReport1.Visible = false;
            }   
            else
            {
                MessageBox.Show("Bạn Cần Cấp Quyền Cao Hơn Để Truy Cập");
            }    
          
            
        }

        private void NgayVaGio_Tick(object sender, EventArgs e)
        {
            lblNgayVaGio.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void UserControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void UserControlBrand1_Load(object sender, EventArgs e)
        {

        }

        private void UserControlProduct1_Load(object sender, EventArgs e)
        {

        }

        private void UserControlCategory1_Load(object sender, EventArgs e)
        {

        }

        private void UserControlCategory1_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControlBrand1_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControlCategory1_Load_2(object sender, EventArgs e)
        {

        }

        private void UserControlProduct1_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControlOrders1_Load(object sender, EventArgs e)
        {

        }
    }
}
