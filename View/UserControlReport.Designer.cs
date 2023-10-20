namespace Computer_Shop_Management_System.View
{
    partial class UserControlReport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBaoCao = new System.Windows.Forms.TabPage();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.rdoSLKHangMoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoSLDonHang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoLoiNhuan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoDoanhThuTheoKH = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoDoanhThuTheoSP = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoSLSPDaBan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoTongDoanhThu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvAnalys = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpBaoCao.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalys)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tpBaoCao);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBaoCao
            // 
            this.tpBaoCao.Controls.Add(this.dgvAnalys);
            this.tpBaoCao.Controls.Add(this.guna2CustomGradientPanel1);
            this.tpBaoCao.Controls.Add(this.btnTaoBaoCao);
            this.tpBaoCao.Controls.Add(this.label1);
            this.tpBaoCao.Controls.Add(this.dtpEndDate);
            this.tpBaoCao.Controls.Add(this.dtpStartDate);
            this.tpBaoCao.Controls.Add(this.guna2HtmlLabel1);
            this.tpBaoCao.Controls.Add(this.guna2HtmlLabel28);
            this.tpBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBaoCao.Location = new System.Drawing.Point(4, 4);
            this.tpBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.tpBaoCao.Name = "tpBaoCao";
            this.tpBaoCao.Padding = new System.Windows.Forms.Padding(2);
            this.tpBaoCao.Size = new System.Drawing.Size(990, 493);
            this.tpBaoCao.TabIndex = 0;
            this.tpBaoCao.Text = "Báo Cáo";
            this.tpBaoCao.UseVisualStyleBackColor = true;
            this.tpBaoCao.Click += new System.EventHandler(this.tpReport_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoSLKHangMoi);
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoSLDonHang);
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoLoiNhuan);
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoDoanhThuTheoKH);
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoDoanhThuTheoSP);
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoSLSPDaBan);
            this.guna2CustomGradientPanel1.Controls.Add(this.rdoTongDoanhThu);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(6, 88);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(265, 294);
            this.guna2CustomGradientPanel1.TabIndex = 5;
            // 
            // rdoSLKHangMoi
            // 
            this.rdoSLKHangMoi.AutoSize = true;
            this.rdoSLKHangMoi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSLKHangMoi.CheckedState.BorderThickness = 0;
            this.rdoSLKHangMoi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSLKHangMoi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoSLKHangMoi.CheckedState.InnerOffset = -4;
            this.rdoSLKHangMoi.Location = new System.Drawing.Point(4, 233);
            this.rdoSLKHangMoi.Name = "rdoSLKHangMoi";
            this.rdoSLKHangMoi.Size = new System.Drawing.Size(168, 19);
            this.rdoSLKHangMoi.TabIndex = 2;
            this.rdoSLKHangMoi.Text = "Số Lượng Khách Hàng Mới";
            this.rdoSLKHangMoi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoSLKHangMoi.UncheckedState.BorderThickness = 2;
            this.rdoSLKHangMoi.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoSLKHangMoi.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoSLKHangMoi.CheckedChanged += new System.EventHandler(this.rdoSLKHangMoi_CheckedChanged);
            // 
            // rdoSLDonHang
            // 
            this.rdoSLDonHang.AutoSize = true;
            this.rdoSLDonHang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSLDonHang.CheckedState.BorderThickness = 0;
            this.rdoSLDonHang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSLDonHang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoSLDonHang.CheckedState.InnerOffset = -4;
            this.rdoSLDonHang.Location = new System.Drawing.Point(3, 190);
            this.rdoSLDonHang.Name = "rdoSLDonHang";
            this.rdoSLDonHang.Size = new System.Drawing.Size(134, 19);
            this.rdoSLDonHang.TabIndex = 2;
            this.rdoSLDonHang.Text = "Số Lượng Đơn Hàng";
            this.rdoSLDonHang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoSLDonHang.UncheckedState.BorderThickness = 2;
            this.rdoSLDonHang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoSLDonHang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoSLDonHang.CheckedChanged += new System.EventHandler(this.rdoSLDonHang_CheckedChanged);
            // 
            // rdoLoiNhuan
            // 
            this.rdoLoiNhuan.AutoSize = true;
            this.rdoLoiNhuan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoLoiNhuan.CheckedState.BorderThickness = 0;
            this.rdoLoiNhuan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoLoiNhuan.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoLoiNhuan.CheckedState.InnerOffset = -4;
            this.rdoLoiNhuan.Location = new System.Drawing.Point(0, 154);
            this.rdoLoiNhuan.Name = "rdoLoiNhuan";
            this.rdoLoiNhuan.Size = new System.Drawing.Size(81, 19);
            this.rdoLoiNhuan.TabIndex = 2;
            this.rdoLoiNhuan.Text = "Lợi Nhuận";
            this.rdoLoiNhuan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoLoiNhuan.UncheckedState.BorderThickness = 2;
            this.rdoLoiNhuan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoLoiNhuan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoLoiNhuan.CheckedChanged += new System.EventHandler(this.rdoLoiNhuan_CheckedChanged);
            // 
            // rdoDoanhThuTheoKH
            // 
            this.rdoDoanhThuTheoKH.AutoSize = true;
            this.rdoDoanhThuTheoKH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDoanhThuTheoKH.CheckedState.BorderThickness = 0;
            this.rdoDoanhThuTheoKH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDoanhThuTheoKH.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDoanhThuTheoKH.CheckedState.InnerOffset = -4;
            this.rdoDoanhThuTheoKH.Location = new System.Drawing.Point(4, 114);
            this.rdoDoanhThuTheoKH.Name = "rdoDoanhThuTheoKH";
            this.rdoDoanhThuTheoKH.Size = new System.Drawing.Size(186, 19);
            this.rdoDoanhThuTheoKH.TabIndex = 2;
            this.rdoDoanhThuTheoKH.Text = "Doanh Thu Theo Khách Hàng";
            this.rdoDoanhThuTheoKH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDoanhThuTheoKH.UncheckedState.BorderThickness = 2;
            this.rdoDoanhThuTheoKH.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDoanhThuTheoKH.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDoanhThuTheoKH.CheckedChanged += new System.EventHandler(this.rdoDoanhThuTheoKH_CheckedChanged);
            // 
            // rdoDoanhThuTheoSP
            // 
            this.rdoDoanhThuTheoSP.AutoSize = true;
            this.rdoDoanhThuTheoSP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDoanhThuTheoSP.CheckedState.BorderThickness = 0;
            this.rdoDoanhThuTheoSP.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDoanhThuTheoSP.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDoanhThuTheoSP.CheckedState.InnerOffset = -4;
            this.rdoDoanhThuTheoSP.Location = new System.Drawing.Point(3, 73);
            this.rdoDoanhThuTheoSP.Name = "rdoDoanhThuTheoSP";
            this.rdoDoanhThuTheoSP.Size = new System.Drawing.Size(174, 19);
            this.rdoDoanhThuTheoSP.TabIndex = 2;
            this.rdoDoanhThuTheoSP.Text = "Doanh Thu Theo Sản Phẩm";
            this.rdoDoanhThuTheoSP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDoanhThuTheoSP.UncheckedState.BorderThickness = 2;
            this.rdoDoanhThuTheoSP.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDoanhThuTheoSP.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDoanhThuTheoSP.CheckedChanged += new System.EventHandler(this.rdoDoanhThuTheoSP_CheckedChanged);
            // 
            // rdoSLSPDaBan
            // 
            this.rdoSLSPDaBan.AutoSize = true;
            this.rdoSLSPDaBan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSLSPDaBan.CheckedState.BorderThickness = 0;
            this.rdoSLSPDaBan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSLSPDaBan.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoSLSPDaBan.CheckedState.InnerOffset = -4;
            this.rdoSLSPDaBan.Location = new System.Drawing.Point(3, 35);
            this.rdoSLSPDaBan.Name = "rdoSLSPDaBan";
            this.rdoSLSPDaBan.Size = new System.Drawing.Size(172, 19);
            this.rdoSLSPDaBan.TabIndex = 2;
            this.rdoSLSPDaBan.Text = "Số Lượng Sản Phẩn Đã Bán";
            this.rdoSLSPDaBan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoSLSPDaBan.UncheckedState.BorderThickness = 2;
            this.rdoSLSPDaBan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoSLSPDaBan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoSLSPDaBan.CheckedChanged += new System.EventHandler(this.rdoSLSPDaBan_CheckedChanged);
            // 
            // rdoTongDoanhThu
            // 
            this.rdoTongDoanhThu.AutoSize = true;
            this.rdoTongDoanhThu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoTongDoanhThu.CheckedState.BorderThickness = 0;
            this.rdoTongDoanhThu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoTongDoanhThu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoTongDoanhThu.CheckedState.InnerOffset = -4;
            this.rdoTongDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.rdoTongDoanhThu.Name = "rdoTongDoanhThu";
            this.rdoTongDoanhThu.Size = new System.Drawing.Size(117, 19);
            this.rdoTongDoanhThu.TabIndex = 2;
            this.rdoTongDoanhThu.Text = "Tổng Doanh Thu";
            this.rdoTongDoanhThu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoTongDoanhThu.UncheckedState.BorderThickness = 2;
            this.rdoTongDoanhThu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoTongDoanhThu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoTongDoanhThu.CheckedChanged += new System.EventHandler(this.rdoTongDoanhThu_CheckedChanged);
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnTaoBaoCao.FlatAppearance.BorderSize = 0;
            this.btnTaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(398, 412);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(143, 39);
            this.btnTaoBaoCao.TabIndex = 3;
            this.btnTaoBaoCao.Text = "Tạo Báo Cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = ".../Báo Cáo";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(268, 56);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(222, 26);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.Value = new System.DateTime(2023, 10, 11, 16, 38, 26, 746);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(6, 56);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(226, 24);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.Value = new System.DateTime(2023, 10, 11, 16, 38, 26, 746);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(268, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 19);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Ngày Kết Thúc:";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel28_Click);
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel28.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(6, 31);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(90, 19);
            this.guna2HtmlLabel28.TabIndex = 0;
            this.guna2HtmlLabel28.Text = "Ngày bắt đầu:";
            this.guna2HtmlLabel28.Click += new System.EventHandler(this.guna2HtmlLabel28_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnTaoBaoCao;
            // 
            // dgvAnalys
            // 
            this.dgvAnalys.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnalys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalys.Location = new System.Drawing.Point(268, 88);
            this.dgvAnalys.Name = "dgvAnalys";
            this.dgvAnalys.Size = new System.Drawing.Size(726, 294);
            this.dgvAnalys.TabIndex = 6;
            this.dgvAnalys.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAnalys_CellFormatting);
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(1013, 527);
            this.Load += new System.EventHandler(this.UserControlReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpBaoCao.ResumeLayout(false);
            this.tpBaoCao.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBaoCao;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel28;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2RadioButton rdoSLKHangMoi;
        private Guna.UI2.WinForms.Guna2RadioButton rdoSLDonHang;
        private Guna.UI2.WinForms.Guna2RadioButton rdoLoiNhuan;
        private Guna.UI2.WinForms.Guna2RadioButton rdoDoanhThuTheoKH;
        private Guna.UI2.WinForms.Guna2RadioButton rdoDoanhThuTheoSP;
        private Guna.UI2.WinForms.Guna2RadioButton rdoSLSPDaBan;
        private Guna.UI2.WinForms.Guna2RadioButton rdoTongDoanhThu;
        private System.Windows.Forms.DataGridView dgvAnalys;
    }
}
