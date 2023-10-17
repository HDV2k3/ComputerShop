namespace Computer_Shop_Management_System.View
{
    partial class UserControlUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.tpThemNguoiDung = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.txtTenNguoiDung1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tpQuanLyNguoiDung = new System.Windows.Forms.TabPage();
            this.ptbTimKiem = new System.Windows.Forms.PictureBox();
            this.dgvThuongHieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemThuongHieu = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tcUser.SuspendLayout();
            this.tpThemNguoiDung.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpQuanLyNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUser
            // 
            this.tcUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcUser.Controls.Add(this.tpThemNguoiDung);
            this.tcUser.Controls.Add(this.tabPage1);
            this.tcUser.Controls.Add(this.tpQuanLyNguoiDung);
            this.tcUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUser.Location = new System.Drawing.Point(14, 13);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(1006, 685);
            this.tcUser.TabIndex = 0;
            // 
            // tpThemNguoiDung
            // 
            this.tpThemNguoiDung.Controls.Add(this.btnThem);
            this.tpThemNguoiDung.Controls.Add(this.txtEmail);
            this.tpThemNguoiDung.Controls.Add(this.textMatKhau);
            this.tpThemNguoiDung.Controls.Add(this.txtTenNguoiDung);
            this.tpThemNguoiDung.Controls.Add(this.label3);
            this.tpThemNguoiDung.Controls.Add(this.label1);
            this.tpThemNguoiDung.Controls.Add(this.label2);
            this.tpThemNguoiDung.Controls.Add(this.label8);
            this.tpThemNguoiDung.Location = new System.Drawing.Point(4, 4);
            this.tpThemNguoiDung.Name = "tpThemNguoiDung";
            this.tpThemNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tpThemNguoiDung.Size = new System.Drawing.Size(998, 647);
            this.tpThemNguoiDung.TabIndex = 0;
            this.tpThemNguoiDung.Text = "Thêm Người Dùng";
            this.tpThemNguoiDung.UseVisualStyleBackColor = true;
            this.tpThemNguoiDung.Click += new System.EventHandler(this.tpThemNguoiDung_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(57, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(161, 52);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Location = new System.Drawing.Point(492, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 34);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtTenNguoiDung_TextChanged);
            // 
            // textMatKhau
            // 
            this.textMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textMatKhau.Location = new System.Drawing.Point(57, 294);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(356, 34);
            this.textMatKhau.TabIndex = 3;
            this.textMatKhau.UseSystemPasswordChar = true;
            this.textMatKhau.TextChanged += new System.EventHandler(this.txtTenNguoiDung_TextChanged);
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenNguoiDung.Location = new System.Drawing.Point(57, 155);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(356, 34);
            this.txtTenNguoiDung.TabIndex = 1;
            this.txtTenNguoiDung.TextChanged += new System.EventHandler(this.txtTenNguoiDung_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(52, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(487, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Người dùng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = ".../Thêm Người Dùng";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnThayDoi);
            this.tabPage1.Controls.Add(this.txtEmail1);
            this.tabPage1.Controls.Add(this.txtMatKhau1);
            this.tabPage1.Controls.Add(this.txtTenNguoiDung1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 644);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Lựa Chọn";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = ".../Lựa Chọn";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThayDoi.FlatAppearance.BorderSize = 0;
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.Location = new System.Drawing.Point(82, 389);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(161, 52);
            this.btnThayDoi.TabIndex = 4;
            this.btnThayDoi.Text = "Thay Đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail1.Location = new System.Drawing.Point(526, 179);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(404, 34);
            this.txtEmail1.TabIndex = 2;
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatKhau1.Location = new System.Drawing.Point(82, 318);
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.Size = new System.Drawing.Size(356, 34);
            this.txtMatKhau1.TabIndex = 3;
            this.txtMatKhau1.UseSystemPasswordChar = true;
            // 
            // txtTenNguoiDung1
            // 
            this.txtTenNguoiDung1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenNguoiDung1.Location = new System.Drawing.Point(82, 179);
            this.txtTenNguoiDung1.Name = "txtTenNguoiDung1";
            this.txtTenNguoiDung1.Size = new System.Drawing.Size(356, 34);
            this.txtTenNguoiDung1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(77, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mật Khẩu:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(521, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(77, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Người dùng:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(278, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 52);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // tpQuanLyNguoiDung
            // 
            this.tpQuanLyNguoiDung.Controls.Add(this.ptbTimKiem);
            this.tpQuanLyNguoiDung.Controls.Add(this.dgvThuongHieu);
            this.tpQuanLyNguoiDung.Controls.Add(this.txtTimKiemThuongHieu);
            this.tpQuanLyNguoiDung.Controls.Add(this.lblTotal);
            this.tpQuanLyNguoiDung.Controls.Add(this.label6);
            this.tpQuanLyNguoiDung.Controls.Add(this.label5);
            this.tpQuanLyNguoiDung.Controls.Add(this.label4);
            this.tpQuanLyNguoiDung.Location = new System.Drawing.Point(4, 4);
            this.tpQuanLyNguoiDung.Name = "tpQuanLyNguoiDung";
            this.tpQuanLyNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyNguoiDung.Size = new System.Drawing.Size(998, 647);
            this.tpQuanLyNguoiDung.TabIndex = 1;
            this.tpQuanLyNguoiDung.Text = "Quản Lý Người Dùng";
            this.tpQuanLyNguoiDung.UseVisualStyleBackColor = true;
            this.tpQuanLyNguoiDung.Click += new System.EventHandler(this.tpQuanLyNguoiDung_Click);
            // 
            // ptbTimKiem
            // 
            this.ptbTimKiem.Image = global::Computer_Shop_Management_System.Properties.Resources.Search12;
            this.ptbTimKiem.Location = new System.Drawing.Point(575, 106);
            this.ptbTimKiem.Name = "ptbTimKiem";
            this.ptbTimKiem.Size = new System.Drawing.Size(62, 31);
            this.ptbTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTimKiem.TabIndex = 8;
            this.ptbTimKiem.TabStop = false;
            this.ptbTimKiem.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // dgvThuongHieu
            // 
            this.dgvThuongHieu.AllowUserToAddRows = false;
            this.dgvThuongHieu.AllowUserToDeleteRows = false;
            this.dgvThuongHieu.AllowUserToResizeColumns = false;
            this.dgvThuongHieu.AllowUserToResizeRows = false;
            this.dgvThuongHieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuongHieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuongHieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThuongHieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuongHieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThuongHieu.ColumnHeadersHeight = 34;
            this.dgvThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThuongHieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuongHieu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThuongHieu.EnableHeadersVisualStyles = false;
            this.dgvThuongHieu.Location = new System.Drawing.Point(36, 158);
            this.dgvThuongHieu.Name = "dgvThuongHieu";
            this.dgvThuongHieu.ReadOnly = true;
            this.dgvThuongHieu.RowHeadersWidth = 62;
            this.dgvThuongHieu.RowTemplate.Height = 28;
            this.dgvThuongHieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuongHieu.Size = new System.Drawing.Size(932, 371);
            this.dgvThuongHieu.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Users_Id";
            this.Column1.HeaderText = "Mã Người Dùng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Users_Name";
            this.Column2.HeaderText = "Tên Người Dùng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Users_Email";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Users_Password";
            this.Column4.HeaderText = "Mật Khẩu";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtTimKiemThuongHieu
            // 
            this.txtTimKiemThuongHieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemThuongHieu.Location = new System.Drawing.Point(215, 106);
            this.txtTimKiemThuongHieu.Name = "txtTimKiemThuongHieu";
            this.txtTimKiemThuongHieu.Size = new System.Drawing.Size(367, 34);
            this.txtTimKiemThuongHieu.TabIndex = 1;
            this.txtTimKiemThuongHieu.TextChanged += new System.EventHandler(this.txtTimKiemThuongHieu_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(101, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 28);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(31, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(210, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Người Dùng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = ".../ Quản Lý Người Dùng";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnThem;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnThayDoi;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnXoa;
            // 
            // UserControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcUser);
            this.Name = "UserControlUser";
            this.Size = new System.Drawing.Size(1035, 710);
            this.tcUser.ResumeLayout(false);
            this.tpThemNguoiDung.ResumeLayout(false);
            this.tpThemNguoiDung.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpQuanLyNguoiDung.ResumeLayout(false);
            this.tpQuanLyNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage tpThemNguoiDung;
        private System.Windows.Forms.TabPage tpQuanLyNguoiDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvThuongHieu;
        private System.Windows.Forms.TextBox txtTimKiemThuongHieu;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbTimKiem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtMatKhau1;
        private System.Windows.Forms.TextBox txtTenNguoiDung1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}
