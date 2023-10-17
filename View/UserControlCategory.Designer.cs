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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpThemLoai = new System.Windows.Forms.TabControl();
            this.tcThemLoai = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpQuanLyLoai = new System.Windows.Forms.TabPage();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
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
            this.txtTenLoai1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnResetData = new Guna.UI2.WinForms.Guna2Button();
            this.tpThemLoai.SuspendLayout();
            this.tcThemLoai.SuspendLayout();
            this.tpQuanLyLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.tpLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpThemLoai
            // 
            this.tpThemLoai.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tpThemLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpThemLoai.Controls.Add(this.tcThemLoai);
            this.tpThemLoai.Controls.Add(this.tpQuanLyLoai);
            this.tpThemLoai.Controls.Add(this.tpLuaChon);
            this.tpThemLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpThemLoai.Location = new System.Drawing.Point(2, -1);
            this.tpThemLoai.Margin = new System.Windows.Forms.Padding(2);
            this.tpThemLoai.Name = "tpThemLoai";
            this.tpThemLoai.SelectedIndex = 0;
            this.tpThemLoai.Size = new System.Drawing.Size(1059, 533);
            this.tpThemLoai.TabIndex = 0;
            this.tpThemLoai.Click += new System.EventHandler(this.tpThemLoai_Click);
            // 
            // tcThemLoai
            // 
            this.tcThemLoai.Controls.Add(this.btnThem);
            this.tcThemLoai.Controls.Add(this.cmbTrangThai);
            this.tcThemLoai.Controls.Add(this.txtMaLoai);
            this.tcThemLoai.Controls.Add(this.txtTenLoai);
            this.tcThemLoai.Controls.Add(this.label3);
            this.tcThemLoai.Controls.Add(this.label7);
            this.tcThemLoai.Controls.Add(this.label2);
            this.tcThemLoai.Controls.Add(this.label1);
            this.tcThemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcThemLoai.Location = new System.Drawing.Point(4, 4);
            this.tcThemLoai.Margin = new System.Windows.Forms.Padding(2);
            this.tcThemLoai.Name = "tcThemLoai";
            this.tcThemLoai.Padding = new System.Windows.Forms.Padding(2);
            this.tcThemLoai.Size = new System.Drawing.Size(1051, 503);
            this.tcThemLoai.TabIndex = 0;
            this.tcThemLoai.Text = "Thêm Loại";
            this.tcThemLoai.UseVisualStyleBackColor = true;
            this.tcThemLoai.Click += new System.EventHandler(this.tcCategory_Click);
            this.tcThemLoai.Enter += new System.EventHandler(this.tcThemLoai_Enter);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(93, 294);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 34);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.cmbTrangThai.Location = new System.Drawing.Point(583, 145);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(288, 21);
            this.cmbTrangThai.TabIndex = 2;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaLoai.Location = new System.Drawing.Point(21, 146);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(244, 20);
            this.txtMaLoai.TabIndex = 1;
            this.txtMaLoai.TextChanged += new System.EventHandler(this.txtTenLoai_TextChanged);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenLoai.Location = new System.Drawing.Point(278, 146);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(244, 20);
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
            this.label3.Location = new System.Drawing.Point(579, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(17, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Loại:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(274, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(4, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = ".../Thêm Loại";
            // 
            // tpQuanLyLoai
            // 
            this.tpQuanLyLoai.Controls.Add(this.btnResetData);
            this.tpQuanLyLoai.Controls.Add(this.picTimKiem);
            this.tpQuanLyLoai.Controls.Add(this.dgvLoai);
            this.tpQuanLyLoai.Controls.Add(this.txtTimKiemLoai);
            this.tpQuanLyLoai.Controls.Add(this.lblTotal);
            this.tpQuanLyLoai.Controls.Add(this.label6);
            this.tpQuanLyLoai.Controls.Add(this.label5);
            this.tpQuanLyLoai.Controls.Add(this.label4);
            this.tpQuanLyLoai.Location = new System.Drawing.Point(4, 4);
            this.tpQuanLyLoai.Margin = new System.Windows.Forms.Padding(2);
            this.tpQuanLyLoai.Name = "tpQuanLyLoai";
            this.tpQuanLyLoai.Padding = new System.Windows.Forms.Padding(2);
            this.tpQuanLyLoai.Size = new System.Drawing.Size(1051, 503);
            this.tpQuanLyLoai.TabIndex = 1;
            this.tpQuanLyLoai.Text = "Quản Lý Loại";
            this.tpQuanLyLoai.UseVisualStyleBackColor = true;
            this.tpQuanLyLoai.Click += new System.EventHandler(this.tpQuanLyLoai_Click);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTimKiem.Image = global::Computer_Shop_Management_System.Properties.Resources.Search1;
            this.picTimKiem.Location = new System.Drawing.Point(507, 83);
            this.picTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(26, 25);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 9;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.MouseHover += new System.EventHandler(this.picTimKiem_MouseHover);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoai.ColumnHeadersHeight = 34;
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoai.EnableHeadersVisualStyles = false;
            this.dgvLoai.Location = new System.Drawing.Point(64, 122);
            this.dgvLoai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersWidth = 62;
            this.dgvLoai.RowTemplate.Height = 28;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(877, 268);
            this.dgvLoai.TabIndex = 0;
            this.dgvLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellClick);
            this.dgvLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellContentClick);
            // 
            // txtTimKiemLoai
            // 
            this.txtTimKiemLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemLoai.Location = new System.Drawing.Point(256, 83);
            this.txtTimKiemLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemLoai.Name = "txtTimKiemLoai";
            this.txtTimKiemLoai.Size = new System.Drawing.Size(247, 25);
            this.txtTimKiemLoai.TabIndex = 1;
            this.txtTimKiemLoai.TextChanged += new System.EventHandler(this.txtTimKiemLoai_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(150, 422);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(97, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(253, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = ".../ Quản Lý Loại";
            // 
            // tpLuaChon
            // 
            this.tpLuaChon.Controls.Add(this.cmbTRangThai1);
            this.tpLuaChon.Controls.Add(this.label10);
            this.tpLuaChon.Controls.Add(this.btnXoa);
            this.tpLuaChon.Controls.Add(this.btnThayDoi);
            this.tpLuaChon.Controls.Add(this.txtTenLoai1);
            this.tpLuaChon.Controls.Add(this.label9);
            this.tpLuaChon.Controls.Add(this.label8);
            this.tpLuaChon.Location = new System.Drawing.Point(4, 4);
            this.tpLuaChon.Margin = new System.Windows.Forms.Padding(2);
            this.tpLuaChon.Name = "tpLuaChon";
            this.tpLuaChon.Padding = new System.Windows.Forms.Padding(2);
            this.tpLuaChon.Size = new System.Drawing.Size(1051, 503);
            this.tpLuaChon.TabIndex = 2;
            this.tpLuaChon.Text = "Lựa chọn";
            this.tpLuaChon.UseVisualStyleBackColor = true;
            this.tpLuaChon.Enter += new System.EventHandler(this.tpLuaChon_Enter);
            this.tpLuaChon.Leave += new System.EventHandler(this.tpLuaChon_Leave);
            // 
            // cmbTRangThai1
            // 
            this.cmbTRangThai1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTRangThai1.FormattingEnabled = true;
            this.cmbTRangThai1.Items.AddRange(new object[] {
            "--SELECT--",
            "Có sẵn",
            "Không có sẵn"});
            this.cmbTRangThai1.Location = new System.Drawing.Point(420, 135);
            this.cmbTRangThai1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTRangThai1.Name = "cmbTRangThai1";
            this.cmbTRangThai1.Size = new System.Drawing.Size(288, 25);
            this.cmbTRangThai1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(417, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
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
            this.btnXoa.Location = new System.Drawing.Point(184, 223);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 34);
            this.btnXoa.TabIndex = 4;
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
            this.btnThayDoi.Location = new System.Drawing.Point(53, 223);
            this.btnThayDoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(107, 34);
            this.btnThayDoi.TabIndex = 3;
            this.btnThayDoi.Text = "Thay Đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // txtTenLoai1
            // 
            this.txtTenLoai1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenLoai1.Location = new System.Drawing.Point(53, 135);
            this.txtTenLoai1.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoai1.Name = "txtTenLoai1";
            this.txtTenLoai1.Size = new System.Drawing.Size(239, 25);
            this.txtTenLoai1.TabIndex = 1;
            this.txtTenLoai1.TextChanged += new System.EventHandler(this.txtLoai1_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(50, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Loại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(2, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
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
            // btnResetData
            // 
            this.btnResetData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetData.ForeColor = System.Drawing.Color.White;
            this.btnResetData.Location = new System.Drawing.Point(698, 51);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(180, 45);
            this.btnResetData.TabIndex = 10;
            this.btnResetData.Text = "Tải Lại :";
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tpThemLoai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(1063, 532);
            this.Load += new System.EventHandler(this.UserControlCategory_Load);
            this.tpThemLoai.ResumeLayout(false);
            this.tcThemLoai.ResumeLayout(false);
            this.tcThemLoai.PerformLayout();
            this.tpQuanLyLoai.ResumeLayout(false);
            this.tpQuanLyLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.tpLuaChon.ResumeLayout(false);
            this.tpLuaChon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tpThemLoai;
        private System.Windows.Forms.TabPage tcThemLoai;
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbTRangThai1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.TextBox txtTenLoai1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnResetData;
    }
}
