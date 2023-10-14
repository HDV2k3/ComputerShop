namespace Computer_Shop_Management_System.View
{
    partial class UserControlCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpThemLoai = new System.Windows.Forms.TabControl();
            this.tcCategory = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpQuanLyLoai = new System.Windows.Forms.TabPage();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.Category_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemLoai = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpLuaChon = new System.Windows.Forms.TabPage();
            this.cmbTRangThai1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.txtTenThuongHieu1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.tpThemLoai.SuspendLayout();
            this.tcCategory.SuspendLayout();
            this.tpQuanLyLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.tpLuaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tpThemLoai
            // 
            this.tpThemLoai.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tpThemLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpThemLoai.Controls.Add(this.tcCategory);
            this.tpThemLoai.Controls.Add(this.tpQuanLyLoai);
            this.tpThemLoai.Controls.Add(this.tpLuaChon);
            this.tpThemLoai.Location = new System.Drawing.Point(3, -2);
            this.tpThemLoai.Name = "tpThemLoai";
            this.tpThemLoai.SelectedIndex = 0;
            this.tpThemLoai.Size = new System.Drawing.Size(1378, 826);
            this.tpThemLoai.TabIndex = 0;
            // 
            // tcCategory
            // 
            this.tcCategory.Controls.Add(this.btnThem);
            this.tcCategory.Controls.Add(this.cmbTrangThai);
            this.tcCategory.Controls.Add(this.txtTenLoai);
            this.tcCategory.Controls.Add(this.label3);
            this.tcCategory.Controls.Add(this.label2);
            this.tcCategory.Controls.Add(this.label1);
            this.tcCategory.Location = new System.Drawing.Point(4, 4);
            this.tcCategory.Name = "tcCategory";
            this.tcCategory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tcCategory.Size = new System.Drawing.Size(1370, 793);
            this.tcCategory.TabIndex = 0;
            this.tcCategory.Text = "Thêm Loại";
            this.tcCategory.UseVisualStyleBackColor = true;
            this.tcCategory.Click += new System.EventHandler(this.tcCategory_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(100, 324);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 52);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "--SELECT--",
            "Có sẵn",
            "Không có sẵn"});
            this.cmbTrangThai.Location = new System.Drawing.Point(666, 223);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(430, 28);
            this.cmbTrangThai.TabIndex = 2;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenLoai.Location = new System.Drawing.Point(100, 225);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(364, 26);
            this.txtTenLoai.TabIndex = 1;
            this.txtTenLoai.TextChanged += new System.EventHandler(this.txtTenLoai_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(661, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(95, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(6, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = ".../Thêm Loại";
            // 
            // tpQuanLyLoai
            // 
            this.tpQuanLyLoai.Controls.Add(this.picTimKiem);
            this.tpQuanLyLoai.Controls.Add(this.dgvLoai);
            this.tpQuanLyLoai.Controls.Add(this.txtTimKiemLoai);
            this.tpQuanLyLoai.Controls.Add(this.lblTotal);
            this.tpQuanLyLoai.Controls.Add(this.label6);
            this.tpQuanLyLoai.Controls.Add(this.label5);
            this.tpQuanLyLoai.Controls.Add(this.label4);
            this.tpQuanLyLoai.Location = new System.Drawing.Point(4, 4);
            this.tpQuanLyLoai.Name = "tpQuanLyLoai";
            this.tpQuanLyLoai.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpQuanLyLoai.Size = new System.Drawing.Size(1370, 793);
            this.tpQuanLyLoai.TabIndex = 1;
            this.tpQuanLyLoai.Text = "Quản Lý Loại";
            this.tpQuanLyLoai.UseVisualStyleBackColor = true;
            this.tpQuanLyLoai.Click += new System.EventHandler(this.tpQuanLyLoai_Click);
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.AllowUserToResizeColumns = false;
            this.dgvLoai.AllowUserToResizeRows = false;
            this.dgvLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoai.ColumnHeadersHeight = 34;
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_Id,
            this.Category_Name,
            this.Category_Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoai.EnableHeadersVisualStyles = false;
            this.dgvLoai.Location = new System.Drawing.Point(40, 191);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersWidth = 62;
            this.dgvLoai.RowTemplate.Height = 28;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(1211, 413);
            this.dgvLoai.TabIndex = 0;
            // 
            // Category_Id
            // 
            this.Category_Id.HeaderText = "Loại #";
            this.Category_Id.MinimumWidth = 8;
            this.Category_Id.Name = "Category_Id";
            this.Category_Id.ReadOnly = true;
            // 
            // Category_Name
            // 
            this.Category_Name.HeaderText = "Tên Loại";
            this.Category_Name.MinimumWidth = 8;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            // 
            // Category_Status
            // 
            this.Category_Status.HeaderText = "Trạng Thái";
            this.Category_Status.MinimumWidth = 8;
            this.Category_Status.Name = "Category_Status";
            this.Category_Status.ReadOnly = true;
            // 
            // txtTimKiemLoai
            // 
            this.txtTimKiemLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemLoai.Location = new System.Drawing.Point(279, 131);
            this.txtTimKiemLoai.Name = "txtTimKiemLoai";
            this.txtTimKiemLoai.Size = new System.Drawing.Size(368, 26);
            this.txtTimKiemLoai.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(120, 652);
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
            this.label6.Location = new System.Drawing.Point(41, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(274, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = ".../ Quản Lý Loại";
            // 
            // tpLuaChon
            // 
            this.tpLuaChon.Controls.Add(this.cmbTRangThai1);
            this.tpLuaChon.Controls.Add(this.label10);
            this.tpLuaChon.Controls.Add(this.btnXoa);
            this.tpLuaChon.Controls.Add(this.btnThayDoi);
            this.tpLuaChon.Controls.Add(this.txtTenThuongHieu1);
            this.tpLuaChon.Controls.Add(this.label9);
            this.tpLuaChon.Controls.Add(this.label8);
            this.tpLuaChon.Location = new System.Drawing.Point(4, 4);
            this.tpLuaChon.Name = "tpLuaChon";
            this.tpLuaChon.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpLuaChon.Size = new System.Drawing.Size(1370, 793);
            this.tpLuaChon.TabIndex = 2;
            this.tpLuaChon.Text = "Lựa chọn";
            this.tpLuaChon.UseVisualStyleBackColor = true;
            // 
            // cmbTRangThai1
            // 
            this.cmbTRangThai1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTRangThai1.FormattingEnabled = true;
            this.cmbTRangThai1.Items.AddRange(new object[] {
            "--SELECT--",
            "Có sẵn",
            "Không có sẵn"});
            this.cmbTRangThai1.Location = new System.Drawing.Point(630, 208);
            this.cmbTRangThai1.Name = "cmbTRangThai1";
            this.cmbTRangThai1.Size = new System.Drawing.Size(430, 28);
            this.cmbTRangThai1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(625, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng Thái:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(276, 343);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 52);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThayDoi.FlatAppearance.BorderSize = 0;
            this.btnThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.Location = new System.Drawing.Point(80, 343);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(160, 52);
            this.btnThayDoi.TabIndex = 3;
            this.btnThayDoi.Text = "Thay Đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            // 
            // txtTenThuongHieu1
            // 
            this.txtTenThuongHieu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenThuongHieu1.Location = new System.Drawing.Point(80, 208);
            this.txtTenThuongHieu1.Name = "txtTenThuongHieu1";
            this.txtTenThuongHieu1.Size = new System.Drawing.Size(356, 26);
            this.txtTenThuongHieu1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(75, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Thương Hiệu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = ".../Lựa Chọn";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            // picTimKiem
            // 
            this.picTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTimKiem.Image = global::Computer_Shop_Management_System.Properties.Resources.Search1;
            this.picTimKiem.Location = new System.Drawing.Point(643, 131);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(30, 27);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 9;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.MouseHover += new System.EventHandler(this.picTimKiem_MouseHover);
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tpThemLoai);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(1382, 829);
            this.Load += new System.EventHandler(this.UserControlCategory_Load);
            this.tpThemLoai.ResumeLayout(false);
            this.tcCategory.ResumeLayout(false);
            this.tcCategory.PerformLayout();
            this.tpQuanLyLoai.ResumeLayout(false);
            this.tpQuanLyLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.tpLuaChon.ResumeLayout(false);
            this.tpLuaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tpThemLoai;
        private System.Windows.Forms.TabPage tcCategory;
        private System.Windows.Forms.TabPage tpQuanLyLoai;
        private System.Windows.Forms.TabPage tpLuaChon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.TextBox txtTimKiemLoai;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Status;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbTRangThai1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.TextBox txtTenThuongHieu1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}
