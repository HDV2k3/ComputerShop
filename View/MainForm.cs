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
            userControlOrders1.Visible = true;
            
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            MovePanel(btnThuongHieu);
            userControlOrders1.Visible = false;
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            MovePanel(btnLoai);
            userControlOrders1.Visible = false;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            MovePanel(btnSanPham);
            userControlOrders1.Visible = false;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MovePanel(btnDatHang);
            userControlOrders1.Visible = true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            MovePanel(btnBaoCao);
            userControlOrders1.Visible = false;
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            MovePanel(btnNguoiDung);
            userControlOrders1.Visible = false;
        }

        private void NgayVaGio_Tick(object sender, EventArgs e)
        {
            lblNgayVaGio.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
