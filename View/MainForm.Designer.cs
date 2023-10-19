namespace Computer_Shop_Management_System.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDiChuyen = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnLoai = new System.Windows.Forms.Button();
            this.btnThuongHieu = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgayVaGio = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NgayVaGio = new System.Windows.Forms.Timer(this.components);
            this.userControlUser1 = new Computer_Shop_Management_System.View.UserControlUser();
            this.userControlReport1 = new Computer_Shop_Management_System.View.UserControlReport();
            this.userControlOrders1 = new Computer_Shop_Management_System.View.UserControlOrders();
            this.userControlProduct1 = new Computer_Shop_Management_System.View.UserControlProduct();
            this.userControlCategory1 = new Computer_Shop_Management_System.View.UserControlCategory();
            this.userControlBrand1 = new Computer_Shop_Management_System.View.UserControlBrand();
            this.userControlDashboard1 = new Computer_Shop_Management_System.View.UserControlDashboard();
            this.userControlBrandStaff1 = new Computer_Shop_Management_System.View.UserControlBrandStaff();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.pnlDiChuyen);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnNguoiDung);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnDatHang);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnLoai);
            this.panel1.Controls.Add(this.btnThuongHieu);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 612);
            this.panel1.TabIndex = 0;
            // 
            // pnlDiChuyen
            // 
            this.pnlDiChuyen.BackColor = System.Drawing.Color.White;
            this.pnlDiChuyen.Location = new System.Drawing.Point(3, 110);
            this.pnlDiChuyen.Name = "pnlDiChuyen";
            this.pnlDiChuyen.Size = new System.Drawing.Size(6, 45);
            this.pnlDiChuyen.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_logout_50;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(8, 512);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(234, 46);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "       Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnNguoiDung.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_user_50;
            this.btnNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguoiDung.Location = new System.Drawing.Point(8, 447);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(234, 46);
            this.btnNguoiDung.TabIndex = 3;
            this.btnNguoiDung.Text = "           Người Dùng";
            this.btnNguoiDung.UseVisualStyleBackColor = true;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_report_50;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(8, 392);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(234, 49);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "    Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.FlatAppearance.BorderSize = 0;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_order_50;
            this.btnDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatHang.Location = new System.Drawing.Point(8, 325);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(234, 49);
            this.btnDatHang.TabIndex = 3;
            this.btnDatHang.Text = "   Orders";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_product_50;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(8, 270);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(234, 49);
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.Text = "        Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnLoai
            // 
            this.btnLoai.FlatAppearance.BorderSize = 0;
            this.btnLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoai.ForeColor = System.Drawing.Color.White;
            this.btnLoai.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_category_50;
            this.btnLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoai.Location = new System.Drawing.Point(8, 215);
            this.btnLoai.Name = "btnLoai";
            this.btnLoai.Size = new System.Drawing.Size(234, 49);
            this.btnLoai.TabIndex = 3;
            this.btnLoai.Text = "Loại";
            this.btnLoai.UseVisualStyleBackColor = true;
            this.btnLoai.Click += new System.EventHandler(this.btnLoai_Click);
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.FlatAppearance.BorderSize = 0;
            this.btnThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuongHieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuongHieu.ForeColor = System.Drawing.Color.White;
            this.btnThuongHieu.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_brand_50;
            this.btnThuongHieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuongHieu.Location = new System.Drawing.Point(8, 161);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(234, 49);
            this.btnThuongHieu.TabIndex = 3;
            this.btnThuongHieu.Text = "             Thương Hiệu";
            this.btnThuongHieu.UseVisualStyleBackColor = true;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_dashboard_50__1_;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(8, 106);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(234, 49);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "            Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Shop_Management_System.Properties.Resources.icons8_laptop_64;
            this.pictureBox1.Location = new System.Drawing.Point(83, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblNgayVaGio);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(242, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 53);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "WellCome:";
            // 
            // lblNgayVaGio
            // 
            this.lblNgayVaGio.AutoSize = true;
            this.lblNgayVaGio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVaGio.ForeColor = System.Drawing.Color.White;
            this.lblNgayVaGio.Location = new System.Drawing.Point(665, 9);
            this.lblNgayVaGio.Name = "lblNgayVaGio";
            this.lblNgayVaGio.Size = new System.Drawing.Size(20, 25);
            this.lblNgayVaGio.TabIndex = 2;
            this.lblNgayVaGio.Text = "?";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(140, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(20, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(242, 581);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 31);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đồ Án C# SV Hutech";
            // 
            // NgayVaGio
            // 
            this.NgayVaGio.Tick += new System.EventHandler(this.NgayVaGio_Tick);
            // 
            // userControlUser1
            // 
            this.userControlUser1.BackColor = System.Drawing.Color.White;
            this.userControlUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlUser1.Location = new System.Drawing.Point(242, 53);
            this.userControlUser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlUser1.Name = "userControlUser1";
            this.userControlUser1.Size = new System.Drawing.Size(1029, 528);
            this.userControlUser1.TabIndex = 7;
            this.userControlUser1.Visible = false;
            // 
            // userControlReport1
            // 
            this.userControlReport1.BackColor = System.Drawing.Color.White;
            this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReport1.Location = new System.Drawing.Point(242, 53);
            this.userControlReport1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlReport1.Name = "userControlReport1";
            this.userControlReport1.Size = new System.Drawing.Size(1029, 528);
            this.userControlReport1.TabIndex = 6;
            this.userControlReport1.Visible = false;
            // 
            // userControlOrders1
            // 
            this.userControlOrders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlOrders1.Location = new System.Drawing.Point(242, 53);
            this.userControlOrders1.Name = "userControlOrders1";
            this.userControlOrders1.Size = new System.Drawing.Size(1029, 528);
            this.userControlOrders1.TabIndex = 5;
            this.userControlOrders1.Visible = false;
            this.userControlOrders1.Load += new System.EventHandler(this.userControlOrders1_Load);
            // 
            // userControlProduct1
            // 
            this.userControlProduct1.BackColor = System.Drawing.Color.White;
            this.userControlProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProduct1.Location = new System.Drawing.Point(242, 53);
            this.userControlProduct1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlProduct1.Name = "userControlProduct1";
            this.userControlProduct1.Size = new System.Drawing.Size(1029, 528);
            this.userControlProduct1.TabIndex = 4;
            this.userControlProduct1.Visible = false;
            // 
            // userControlCategory1
            // 
            this.userControlCategory1.AutoSize = true;
            this.userControlCategory1.BackColor = System.Drawing.Color.White;
            this.userControlCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCategory1.Location = new System.Drawing.Point(242, 53);
            this.userControlCategory1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlCategory1.Name = "userControlCategory1";
            this.userControlCategory1.Size = new System.Drawing.Size(1029, 528);
            this.userControlCategory1.TabIndex = 3;
            this.userControlCategory1.Visible = false;
            // 
            // userControlBrand1
            // 
            this.userControlBrand1.BackColor = System.Drawing.Color.White;
            this.userControlBrand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBrand1.Location = new System.Drawing.Point(242, 53);
            this.userControlBrand1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlBrand1.Name = "userControlBrand1";
            this.userControlBrand1.Size = new System.Drawing.Size(1029, 528);
            this.userControlBrand1.TabIndex = 2;
            this.userControlBrand1.Visible = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.AutoScroll = true;
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Location = new System.Drawing.Point(242, 53);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1029, 528);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlBrandStaff1
            // 
            this.userControlBrandStaff1.BackColor = System.Drawing.Color.White;
            this.userControlBrandStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBrandStaff1.Location = new System.Drawing.Point(242, 53);
            this.userControlBrandStaff1.Name = "userControlBrandStaff1";
            this.userControlBrandStaff1.Size = new System.Drawing.Size(1029, 528);
            this.userControlBrandStaff1.TabIndex = 8;
            this.userControlBrandStaff1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 612);
            this.Controls.Add(this.userControlBrandStaff1);
            this.Controls.Add(this.userControlUser1);
            this.Controls.Add(this.userControlReport1);
            this.Controls.Add(this.userControlOrders1);
            this.Controls.Add(this.userControlProduct1);
            this.Controls.Add(this.userControlCategory1);
            this.Controls.Add(this.userControlBrand1);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop Manager System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnLoai;
        private System.Windows.Forms.Button btnThuongHieu;
      //  private System.Windows.Forms.Panel MovePanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNgayVaGio;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDiChuyen;
        private System.Windows.Forms.Timer NgayVaGio;
        private UserControlDashboard userControlDashboard1;
        private UserControlBrand userControlBrand1;
        private UserControlCategory userControlCategory1;
        private UserControlProduct userControlProduct1;
        private UserControlOrders userControlOrders1;
        private UserControlReport userControlReport1;
        private UserControlUser userControlUser1;
        private UserControlBrandStaff userControlBrandStaff1;
    }
}