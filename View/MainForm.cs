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
        public MainForm()
        {
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
            MovePanel(btnDashboard);
            userControlDashboard1.Visible = true;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrders1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            
        }
        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            MovePanel(btnThuongHieu);
            userControlDashboard1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrders1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
            userControlBrand1.Visible = true;
        }
        private void btnLoai_Click(object sender, EventArgs e)
        {
            MovePanel(btnLoai);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = true;
            userControlProduct1.Visible = false;
            userControlOrders1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            MovePanel(btnSanPham);
            userControlDashboard1.Visible = true;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = true;
            userControlOrders1.Visible = false;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MovePanel(btnDatHang);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrders1.Visible = true;
            userControlReport1.Visible = false;
            userControlUser1.Visible = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            MovePanel(btnBaoCao);
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrders1.Visible = false;
            userControlReport1.Visible = true;
            userControlUser1.Visible = false;

        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            MovePanel(btnNguoiDung);
            userControlUser1.Visible = true;
            userControlDashboard1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlProduct1.Visible = false;
            userControlOrders1.Visible = false;
            userControlReport1.Visible = false;
            
        }

        private void NgayVaGio_Tick(object sender, EventArgs e)
        {
            lblNgayVaGio.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void userControlBrand1_Load(object sender, EventArgs e)
        {

        }

        private void userControlProduct1_Load(object sender, EventArgs e)
        {

        }

        private void userControlCategory1_Load(object sender, EventArgs e)
        {

        }

        private void userControlCategory1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControlBrand1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControlCategory1_Load_2(object sender, EventArgs e)
        {

        }

        private void userControlProduct1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControlOrders1_Load(object sender, EventArgs e)
        {

        }
    }
}
