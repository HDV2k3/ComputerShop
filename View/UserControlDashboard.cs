using Computer_Shop_Management_System.Controller;
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
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void count()
        {
          //. lblTongSanPham.Text= Computer.


        }

       
        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            lblTongSanPham.Text = Computer.CountProducts("SELECT Count (*) FROM Product;").ToString();
            lblTongDoanhThu.Text = Computer.CountTotal_Amout().ToString();
            lblTongSoDonDH.Text = Computer.CountTotal_Order().ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
