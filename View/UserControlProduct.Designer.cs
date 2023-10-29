namespace Computer_Shop_Management_System.View
{
    partial class UserControlProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpProduct = new System.Windows.Forms.TabControl();
            this.tpThemSanPham = new System.Windows.Forms.TabPage();
            this.txttProductName = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.cmbThuongHieu = new System.Windows.Forms.ComboBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnDuyetSanPham = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpQuanLySanPham = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.txtTimKiemSanPham = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpLuaChon = new System.Windows.Forms.TabPage();
            this.cmbLoai1 = new System.Windows.Forms.ComboBox();
            this.cmbThuongHieu1 = new System.Windows.Forms.ComboBox();
            this.nudSoLuong1 = new System.Windows.Forms.NumericUpDown();
            this.txtGiaTien1 = new System.Windows.Forms.TextBox();
            this.cmbTrangThai1 = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenSanPham1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.picPhoto1 = new System.Windows.Forms.PictureBox();
            this.btnDuyetSanPham1 = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.tpProduct.SuspendLayout();
            this.tpThemSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.tpQuanLySanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.tpLuaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpProduct
            // 
            this.tpProduct.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpProduct.Controls.Add(this.tpThemSanPham);
            this.tpProduct.Controls.Add(this.tpQuanLySanPham);
            this.tpProduct.Controls.Add(this.tpLuaChon);
            this.tpProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpProduct.Location = new System.Drawing.Point(0, 2);
            this.tpProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.SelectedIndex = 0;
            this.tpProduct.Size = new System.Drawing.Size(983, 554);
            this.tpProduct.TabIndex = 0;
            this.tpProduct.Click += new System.EventHandler(this.tpProduct_Click);
            this.tpProduct.Enter += new System.EventHandler(this.tpProduct_Enter);
            this.tpProduct.Leave += new System.EventHandler(this.tpProduct_Leave);
            // 
            // tpThemSanPham
            // 
            this.tpThemSanPham.Controls.Add(this.txttProductName);
            this.tpThemSanPham.Controls.Add(this.nudSoLuong);
            this.tpThemSanPham.Controls.Add(this.txtGiaTien);
            this.tpThemSanPham.Controls.Add(this.cmbTrangThai);
            this.tpThemSanPham.Controls.Add(this.cmbLoai);
            this.tpThemSanPham.Controls.Add(this.cmbThuongHieu);
            this.tpThemSanPham.Controls.Add(this.picPhoto);
            this.tpThemSanPham.Controls.Add(this.btnDuyetSanPham);
            this.tpThemSanPham.Controls.Add(this.btnThem);
            this.tpThemSanPham.Controls.Add(this.label7);
            this.tpThemSanPham.Controls.Add(this.label2);
            this.tpThemSanPham.Controls.Add(this.label3);
            this.tpThemSanPham.Controls.Add(this.label1);
            this.tpThemSanPham.Controls.Add(this.label4);
            this.tpThemSanPham.Controls.Add(this.label5);
            this.tpThemSanPham.Controls.Add(this.label6);
            this.tpThemSanPham.Location = new System.Drawing.Point(4, 4);
            this.tpThemSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.tpThemSanPham.Name = "tpThemSanPham";
            this.tpThemSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.tpThemSanPham.Size = new System.Drawing.Size(975, 524);
            this.tpThemSanPham.TabIndex = 0;
            this.tpThemSanPham.Text = "Thêm Sản Phẩm";
            this.tpThemSanPham.UseVisualStyleBackColor = true;
            this.tpThemSanPham.Enter += new System.EventHandler(this.tpThemSanPham_Enter);
            // 
            // txttProductName
            // 
            this.txttProductName.Location = new System.Drawing.Point(53, 58);
            this.txttProductName.Name = "txttProductName";
            this.txttProductName.Size = new System.Drawing.Size(151, 25);
            this.txttProductName.TabIndex = 18;
            this.txttProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttProductName_KeyDown);
            this.txttProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttProductName_KeyPress);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(241, 117);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(155, 25);
            this.nudSoLuong.TabIndex = 17;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(53, 117);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(151, 25);
            this.txtGiaTien.TabIndex = 16;
            this.txtGiaTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiaTien_KeyDown);
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "--Chọn--",
            "Có sẵn",
            "Không có sẵn"});
            this.cmbTrangThai.Location = new System.Drawing.Point(53, 339);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(279, 25);
            this.cmbTrangThai.TabIndex = 6;
            this.cmbTrangThai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTrangThai_KeyPress);
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(53, 248);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(279, 25);
            this.cmbLoai.TabIndex = 5;
            this.cmbLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLoai_KeyPress);
            // 
            // cmbThuongHieu
            // 
            this.cmbThuongHieu.FormattingEnabled = true;
            this.cmbThuongHieu.Location = new System.Drawing.Point(53, 181);
            this.cmbThuongHieu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbThuongHieu.Name = "cmbThuongHieu";
            this.cmbThuongHieu.Size = new System.Drawing.Size(279, 25);
            this.cmbThuongHieu.TabIndex = 4;
            this.cmbThuongHieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbThuongHieu_KeyPress);
            // 
            // picPhoto
            // 
            this.picPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(508, 48);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(222, 231);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 14;
            this.picPhoto.TabStop = false;
            // 
            // btnDuyetSanPham
            // 
            this.btnDuyetSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDuyetSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnDuyetSanPham.FlatAppearance.BorderSize = 0;
            this.btnDuyetSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetSanPham.ForeColor = System.Drawing.Color.White;
            this.btnDuyetSanPham.Image = global::Computer_Shop_Management_System.Properties.Resources.floder;
            this.btnDuyetSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuyetSanPham.Location = new System.Drawing.Point(508, 297);
            this.btnDuyetSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnDuyetSanPham.Name = "btnDuyetSanPham";
            this.btnDuyetSanPham.Size = new System.Drawing.Size(221, 57);
            this.btnDuyetSanPham.TabIndex = 8;
            this.btnDuyetSanPham.Text = "Duyệt Sản Phẩm";
            this.btnDuyetSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuyetSanPham.UseVisualStyleBackColor = false;
            this.btnDuyetSanPham.Click += new System.EventHandler(this.btnDuyetSanPham_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(53, 383);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(49, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(51, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thương Hiệu:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(237, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(49, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(49, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Sản Phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = ".../Thêm Sản Phẩm";
            // 
            // tpQuanLySanPham
            // 
            this.tpQuanLySanPham.Controls.Add(this.dgvSanPham);
            this.tpQuanLySanPham.Controls.Add(this.picTimKiem);
            this.tpQuanLySanPham.Controls.Add(this.txtTimKiemSanPham);
            this.tpQuanLySanPham.Controls.Add(this.lblTotal);
            this.tpQuanLySanPham.Controls.Add(this.label8);
            this.tpQuanLySanPham.Controls.Add(this.label9);
            this.tpQuanLySanPham.Controls.Add(this.label10);
            this.tpQuanLySanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpQuanLySanPham.Location = new System.Drawing.Point(4, 4);
            this.tpQuanLySanPham.Margin = new System.Windows.Forms.Padding(2);
            this.tpQuanLySanPham.Name = "tpQuanLySanPham";
            this.tpQuanLySanPham.Padding = new System.Windows.Forms.Padding(2);
            this.tpQuanLySanPham.Size = new System.Drawing.Size(975, 524);
            this.tpQuanLySanPham.TabIndex = 1;
            this.tpQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.tpQuanLySanPham.UseVisualStyleBackColor = true;
            this.tpQuanLySanPham.Enter += new System.EventHandler(this.tpQuanLySanPham_Enter);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 95);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(969, 378);
            this.dgvSanPham.TabIndex = 11;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick_1);
            this.dgvSanPham.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvSanPham_RowPrePaint);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTimKiem.Image = global::Computer_Shop_Management_System.Properties.Resources.Search1;
            this.picTimKiem.Location = new System.Drawing.Point(499, 67);
            this.picTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(27, 23);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 10;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // txtTimKiemSanPham
            // 
            this.txtTimKiemSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemSanPham.Location = new System.Drawing.Point(232, 65);
            this.txtTimKiemSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            this.txtTimKiemSanPham.Size = new System.Drawing.Size(247, 25);
            this.txtTimKiemSanPham.TabIndex = 1;
            this.txtTimKiemSanPham.TextChanged += new System.EventHandler(this.txtTimKiemSanPham_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(160, 476);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(18, 476);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng Sản Phẩm:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(228, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Sản Phẩm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label10.Location = new System.Drawing.Point(4, -3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = ".../ Quản Lý Sản Phẩm";
            // 
            // tpLuaChon
            // 
            this.tpLuaChon.Controls.Add(this.cmbLoai1);
            this.tpLuaChon.Controls.Add(this.cmbThuongHieu1);
            this.tpLuaChon.Controls.Add(this.nudSoLuong1);
            this.tpLuaChon.Controls.Add(this.txtGiaTien1);
            this.tpLuaChon.Controls.Add(this.cmbTrangThai1);
            this.tpLuaChon.Controls.Add(this.btnXoa);
            this.tpLuaChon.Controls.Add(this.btnThayDoi);
            this.tpLuaChon.Controls.Add(this.label11);
            this.tpLuaChon.Controls.Add(this.label12);
            this.tpLuaChon.Controls.Add(this.label13);
            this.tpLuaChon.Controls.Add(this.txtTenSanPham1);
            this.tpLuaChon.Controls.Add(this.label14);
            this.tpLuaChon.Controls.Add(this.label15);
            this.tpLuaChon.Controls.Add(this.label16);
            this.tpLuaChon.Controls.Add(this.label17);
            this.tpLuaChon.Controls.Add(this.picPhoto1);
            this.tpLuaChon.Controls.Add(this.btnDuyetSanPham1);
            this.tpLuaChon.Location = new System.Drawing.Point(4, 4);
            this.tpLuaChon.Margin = new System.Windows.Forms.Padding(2);
            this.tpLuaChon.Name = "tpLuaChon";
            this.tpLuaChon.Padding = new System.Windows.Forms.Padding(2);
            this.tpLuaChon.Size = new System.Drawing.Size(975, 524);
            this.tpLuaChon.TabIndex = 2;
            this.tpLuaChon.Text = "Lựa Chọn";
            this.tpLuaChon.UseVisualStyleBackColor = true;
            // 
            // cmbLoai1
            // 
            this.cmbLoai1.FormattingEnabled = true;
            this.cmbLoai1.Location = new System.Drawing.Point(43, 252);
            this.cmbLoai1.Name = "cmbLoai1";
            this.cmbLoai1.Size = new System.Drawing.Size(146, 25);
            this.cmbLoai1.TabIndex = 34;
            // 
            // cmbThuongHieu1
            // 
            this.cmbThuongHieu1.FormattingEnabled = true;
            this.cmbThuongHieu1.Location = new System.Drawing.Point(43, 193);
            this.cmbThuongHieu1.Name = "cmbThuongHieu1";
            this.cmbThuongHieu1.Size = new System.Drawing.Size(147, 25);
            this.cmbThuongHieu1.TabIndex = 33;
            // 
            // nudSoLuong1
            // 
            this.nudSoLuong1.Location = new System.Drawing.Point(241, 135);
            this.nudSoLuong1.Margin = new System.Windows.Forms.Padding(2);
            this.nudSoLuong1.Name = "nudSoLuong1";
            this.nudSoLuong1.Size = new System.Drawing.Size(141, 25);
            this.nudSoLuong1.TabIndex = 32;
            // 
            // txtGiaTien1
            // 
            this.txtGiaTien1.Location = new System.Drawing.Point(42, 135);
            this.txtGiaTien1.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaTien1.Name = "txtGiaTien1";
            this.txtGiaTien1.Size = new System.Drawing.Size(147, 25);
            this.txtGiaTien1.TabIndex = 31;
            // 
            // cmbTrangThai1
            // 
            this.cmbTrangThai1.FormattingEnabled = true;
            this.cmbTrangThai1.Items.AddRange(new object[] {
            "--SELECT--",
            "Có sẵn",
            "Không có sẵn"});
            this.cmbTrangThai1.Location = new System.Drawing.Point(42, 323);
            this.cmbTrangThai1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrangThai1.Name = "cmbTrangThai1";
            this.cmbTrangThai1.Size = new System.Drawing.Size(148, 25);
            this.cmbTrangThai1.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(185, 356);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThayDoi.FlatAppearance.BorderSize = 0;
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.Location = new System.Drawing.Point(41, 356);
            this.btnThayDoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(107, 34);
            this.btnThayDoi.TabIndex = 7;
            this.btnThayDoi.Text = "Thay Đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(39, 287);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trạng Thái:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(39, 221);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Loại:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(39, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Thương Hiệu:";
            // 
            // txtTenSanPham1
            // 
            this.txtTenSanPham1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenSanPham1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham1.Location = new System.Drawing.Point(43, 66);
            this.txtTenSanPham1.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSanPham1.Name = "txtTenSanPham1";
            this.txtTenSanPham1.Size = new System.Drawing.Size(359, 25);
            this.txtTenSanPham1.TabIndex = 1;
            this.txtTenSanPham1.TextChanged += new System.EventHandler(this.txtTenSanPham1_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(237, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Số Lượng:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(39, 99);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Giá Tiền:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(39, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tên Sản Phẩm:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label17.Location = new System.Drawing.Point(2, 2);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 30);
            this.label17.TabIndex = 0;
            this.label17.Text = ".../Lựa Chọn";
            // 
            // picPhoto1
            // 
            this.picPhoto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto1.Location = new System.Drawing.Point(474, 41);
            this.picPhoto1.Margin = new System.Windows.Forms.Padding(2);
            this.picPhoto1.Name = "picPhoto1";
            this.picPhoto1.Size = new System.Drawing.Size(187, 190);
            this.picPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto1.TabIndex = 30;
            this.picPhoto1.TabStop = false;
            // 
            // btnDuyetSanPham1
            // 
            this.btnDuyetSanPham1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDuyetSanPham1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnDuyetSanPham1.FlatAppearance.BorderSize = 0;
            this.btnDuyetSanPham1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetSanPham1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetSanPham1.ForeColor = System.Drawing.Color.White;
            this.btnDuyetSanPham1.Image = global::Computer_Shop_Management_System.Properties.Resources.floder;
            this.btnDuyetSanPham1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuyetSanPham1.Location = new System.Drawing.Point(474, 252);
            this.btnDuyetSanPham1.Margin = new System.Windows.Forms.Padding(2);
            this.btnDuyetSanPham1.Name = "btnDuyetSanPham1";
            this.btnDuyetSanPham1.Size = new System.Drawing.Size(186, 54);
            this.btnDuyetSanPham1.TabIndex = 9;
            this.btnDuyetSanPham1.Text = "Duyệt Sản Phẩm";
            this.btnDuyetSanPham1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuyetSanPham1.UseVisualStyleBackColor = false;
            this.btnDuyetSanPham1.Click += new System.EventHandler(this.btnDuyetSanPham1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnThem;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnDuyetSanPham;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnThayDoi;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.btnXoa;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.btnDuyetSanPham1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Upload Image";
            this.openFileDialog.Filter = "JPG|*.ipg|JPEG|*.jpeg|PNG|*.png";
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tpProduct);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(985, 558);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            this.tpProduct.ResumeLayout(false);
            this.tpThemSanPham.ResumeLayout(false);
            this.tpThemSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.tpQuanLySanPham.ResumeLayout(false);
            this.tpQuanLySanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.tpLuaChon.ResumeLayout(false);
            this.tpLuaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpProduct;
        private System.Windows.Forms.TabPage tpThemSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpLuaChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnThem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Button btnDuyetSanPham;
        private System.Windows.Forms.TabPage tpQuanLySanPham;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSanPham;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picPhoto1;
        private System.Windows.Forms.Button btnDuyetSanPham1;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenSanPham1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.ComboBox cmbThuongHieu;
        private System.Windows.Forms.ComboBox cmbTrangThai1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtGiaTien1;
        private System.Windows.Forms.NumericUpDown nudSoLuong1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.ComboBox cmbThuongHieu1;
        private System.Windows.Forms.ComboBox cmbLoai1;
        private System.Windows.Forms.TextBox txttProductName;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}
