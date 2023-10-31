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
            this.btnXuatEcel = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbsanphambanchaynhat = new System.Windows.Forms.CheckBox();
            this.ckbSanPhamSapHetHang = new System.Windows.Forms.CheckBox();
            this.ckbDoanhThuTheoKH = new System.Windows.Forms.CheckBox();
            this.ckbDoanhThuTheoSP = new System.Windows.Forms.CheckBox();
            this.ckbSLSPDaBan = new System.Windows.Forms.CheckBox();
            this.ckbSLDonHang = new System.Windows.Forms.CheckBox();
            this.ckbSLKhachHangMoi = new System.Windows.Forms.CheckBox();
            this.ckbTongDoanhThu = new System.Windows.Forms.CheckBox();
            this.dgvAnalys = new System.Windows.Forms.DataGridView();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ckbLoiNhuan = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tpBaoCao.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1115, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBaoCao
            // 
            this.tpBaoCao.Controls.Add(this.btnXuatEcel);
            this.tpBaoCao.Controls.Add(this.panel1);
            this.tpBaoCao.Controls.Add(this.dgvAnalys);
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
            this.tpBaoCao.Size = new System.Drawing.Size(1107, 514);
            this.tpBaoCao.TabIndex = 0;
            this.tpBaoCao.Text = "Báo Cáo";
            this.tpBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnXuatEcel
            // 
            this.btnXuatEcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatEcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatEcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatEcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatEcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatEcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatEcel.Location = new System.Drawing.Point(557, 424);
            this.btnXuatEcel.Name = "btnXuatEcel";
            this.btnXuatEcel.Size = new System.Drawing.Size(137, 39);
            this.btnXuatEcel.TabIndex = 8;
            this.btnXuatEcel.Text = "Xuất Excel";
            this.btnXuatEcel.Click += new System.EventHandler(this.btnXuatEcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbLoiNhuan);
            this.panel1.Controls.Add(this.ckbsanphambanchaynhat);
            this.panel1.Controls.Add(this.ckbSanPhamSapHetHang);
            this.panel1.Controls.Add(this.ckbDoanhThuTheoKH);
            this.panel1.Controls.Add(this.ckbDoanhThuTheoSP);
            this.panel1.Controls.Add(this.ckbSLSPDaBan);
            this.panel1.Controls.Add(this.ckbSLDonHang);
            this.panel1.Controls.Add(this.ckbSLKhachHangMoi);
            this.panel1.Controls.Add(this.ckbTongDoanhThu);
            this.panel1.Location = new System.Drawing.Point(6, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 294);
            this.panel1.TabIndex = 7;
            // 
            // ckbsanphambanchaynhat
            // 
            this.ckbsanphambanchaynhat.AutoSize = true;
            this.ckbsanphambanchaynhat.Location = new System.Drawing.Point(5, 190);
            this.ckbsanphambanchaynhat.Name = "ckbsanphambanchaynhat";
            this.ckbsanphambanchaynhat.Size = new System.Drawing.Size(139, 19);
            this.ckbsanphambanchaynhat.TabIndex = 2;
            this.ckbsanphambanchaynhat.Text = "Sản Phẩm Bán Chạy ";
            this.ckbsanphambanchaynhat.UseVisualStyleBackColor = true;
            // 
            // ckbSanPhamSapHetHang
            // 
            this.ckbSanPhamSapHetHang.AutoSize = true;
            this.ckbSanPhamSapHetHang.Location = new System.Drawing.Point(5, 165);
            this.ckbSanPhamSapHetHang.Name = "ckbSanPhamSapHetHang";
            this.ckbSanPhamSapHetHang.Size = new System.Drawing.Size(159, 19);
            this.ckbSanPhamSapHetHang.TabIndex = 2;
            this.ckbSanPhamSapHetHang.Text = "Sản Phẩm Sắp Hết Hàng";
            this.ckbSanPhamSapHetHang.UseVisualStyleBackColor = true;
            // 
            // ckbDoanhThuTheoKH
            // 
            this.ckbDoanhThuTheoKH.AutoSize = true;
            this.ckbDoanhThuTheoKH.Location = new System.Drawing.Point(5, 115);
            this.ckbDoanhThuTheoKH.Name = "ckbDoanhThuTheoKH";
            this.ckbDoanhThuTheoKH.Size = new System.Drawing.Size(187, 19);
            this.ckbDoanhThuTheoKH.TabIndex = 1;
            this.ckbDoanhThuTheoKH.Text = "Doanh Thu Theo Khách Hàng";
            this.ckbDoanhThuTheoKH.UseVisualStyleBackColor = true;
            // 
            // ckbDoanhThuTheoSP
            // 
            this.ckbDoanhThuTheoSP.AutoSize = true;
            this.ckbDoanhThuTheoSP.Location = new System.Drawing.Point(5, 65);
            this.ckbDoanhThuTheoSP.Name = "ckbDoanhThuTheoSP";
            this.ckbDoanhThuTheoSP.Size = new System.Drawing.Size(175, 19);
            this.ckbDoanhThuTheoSP.TabIndex = 1;
            this.ckbDoanhThuTheoSP.Text = "Doanh Thu Theo Sản Phẩm";
            this.ckbDoanhThuTheoSP.UseVisualStyleBackColor = true;
            // 
            // ckbSLSPDaBan
            // 
            this.ckbSLSPDaBan.AutoSize = true;
            this.ckbSLSPDaBan.Location = new System.Drawing.Point(5, 40);
            this.ckbSLSPDaBan.Name = "ckbSLSPDaBan";
            this.ckbSLSPDaBan.Size = new System.Drawing.Size(177, 19);
            this.ckbSLSPDaBan.TabIndex = 1;
            this.ckbSLSPDaBan.Text = "Số Lượng Sản Phẩm Đã Bán";
            this.ckbSLSPDaBan.UseVisualStyleBackColor = true;
            // 
            // ckbSLDonHang
            // 
            this.ckbSLDonHang.AutoSize = true;
            this.ckbSLDonHang.Location = new System.Drawing.Point(5, 140);
            this.ckbSLDonHang.Name = "ckbSLDonHang";
            this.ckbSLDonHang.Size = new System.Drawing.Size(135, 19);
            this.ckbSLDonHang.TabIndex = 0;
            this.ckbSLDonHang.Text = "Số Lượng Đơn Hàng";
            this.ckbSLDonHang.UseVisualStyleBackColor = true;
            // 
            // ckbSLKhachHangMoi
            // 
            this.ckbSLKhachHangMoi.AutoSize = true;
            this.ckbSLKhachHangMoi.Location = new System.Drawing.Point(5, 90);
            this.ckbSLKhachHangMoi.Name = "ckbSLKhachHangMoi";
            this.ckbSLKhachHangMoi.Size = new System.Drawing.Size(169, 19);
            this.ckbSLKhachHangMoi.TabIndex = 1;
            this.ckbSLKhachHangMoi.Text = "Số Lượng Khách Hàng Mới";
            this.ckbSLKhachHangMoi.UseVisualStyleBackColor = true;
            // 
            // ckbTongDoanhThu
            // 
            this.ckbTongDoanhThu.AutoSize = true;
            this.ckbTongDoanhThu.Location = new System.Drawing.Point(5, 15);
            this.ckbTongDoanhThu.Name = "ckbTongDoanhThu";
            this.ckbTongDoanhThu.Size = new System.Drawing.Size(118, 19);
            this.ckbTongDoanhThu.TabIndex = 0;
            this.ckbTongDoanhThu.Text = "Tổng Doanh Thu";
            this.ckbTongDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvAnalys
            // 
            this.dgvAnalys.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnalys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalys.Location = new System.Drawing.Point(273, 88);
            this.dgvAnalys.Name = "dgvAnalys";
            this.dgvAnalys.Size = new System.Drawing.Size(832, 294);
            this.dgvAnalys.TabIndex = 6;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnTaoBaoCao.FlatAppearance.BorderSize = 0;
            this.btnTaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(323, 424);
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
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnTaoBaoCao;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnXuatEcel;
            // 
            // ckbLoiNhuan
            // 
            this.ckbLoiNhuan.AutoSize = true;
            this.ckbLoiNhuan.Location = new System.Drawing.Point(5, 215);
            this.ckbLoiNhuan.Name = "ckbLoiNhuan";
            this.ckbLoiNhuan.Size = new System.Drawing.Size(82, 19);
            this.ckbLoiNhuan.TabIndex = 3;
            this.ckbLoiNhuan.Text = "Lợi Nhuận";
            this.ckbLoiNhuan.UseVisualStyleBackColor = true;
            this.ckbLoiNhuan.CheckedChanged += new System.EventHandler(this.ckbLoiNhuan_CheckedChanged);
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(1117, 548);
            this.Load += new System.EventHandler(this.UserControlReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpBaoCao.ResumeLayout(false);
            this.tpBaoCao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvAnalys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbDoanhThuTheoKH;
        private System.Windows.Forms.CheckBox ckbDoanhThuTheoSP;
        private System.Windows.Forms.CheckBox ckbSLSPDaBan;
        private System.Windows.Forms.CheckBox ckbSLDonHang;
        private System.Windows.Forms.CheckBox ckbSLKhachHangMoi;
        private System.Windows.Forms.CheckBox ckbTongDoanhThu;
        private System.Windows.Forms.CheckBox ckbSanPhamSapHetHang;
        private System.Windows.Forms.CheckBox ckbsanphambanchaynhat;
        private Guna.UI2.WinForms.Guna2Button btnXuatEcel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.CheckBox ckbLoiNhuan;
    }
}
