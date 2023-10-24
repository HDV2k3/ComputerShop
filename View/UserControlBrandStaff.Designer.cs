namespace Computer_Shop_Management_System.View
{
    partial class UserControlBrandStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimkiemStaffBrand = new System.Windows.Forms.TextBox();
            this.lblTongThuongHieuStaff = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvThuongHieuStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieuStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimkiemStaffBrand
            // 
            this.txtTimkiemStaffBrand.Location = new System.Drawing.Point(321, 99);
            this.txtTimkiemStaffBrand.Name = "txtTimkiemStaffBrand";
            this.txtTimkiemStaffBrand.Size = new System.Drawing.Size(318, 20);
            this.txtTimkiemStaffBrand.TabIndex = 0;
            this.txtTimkiemStaffBrand.TextChanged += new System.EventHandler(this.txtTimkiemStaffBrand_TextChanged);
            // 
            // lblTongThuongHieuStaff
            // 
            this.lblTongThuongHieuStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblTongThuongHieuStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThuongHieuStaff.Location = new System.Drawing.Point(271, 476);
            this.lblTongThuongHieuStaff.Name = "lblTongThuongHieuStaff";
            this.lblTongThuongHieuStaff.Size = new System.Drawing.Size(9, 19);
            this.lblTongThuongHieuStaff.TabIndex = 2;
            this.lblTongThuongHieuStaff.Text = "?";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(321, 37);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(85, 27);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Tìm Kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = ".../ Quản Lý Thương Hiệu";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(100, 476);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(125, 19);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Tổng Thương Hiệu:";
            // 
            // dgvThuongHieuStaff
            // 
            this.dgvThuongHieuStaff.AllowUserToAddRows = false;
            this.dgvThuongHieuStaff.AllowUserToDeleteRows = false;
            this.dgvThuongHieuStaff.AllowUserToResizeColumns = false;
            this.dgvThuongHieuStaff.AllowUserToResizeRows = false;
            this.dgvThuongHieuStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuongHieuStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuongHieuStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvThuongHieuStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThuongHieuStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuongHieuStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuongHieuStaff.ColumnHeadersHeight = 34;
            this.dgvThuongHieuStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuongHieuStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuongHieuStaff.EnableHeadersVisualStyles = false;
            this.dgvThuongHieuStaff.Location = new System.Drawing.Point(2, 148);
            this.dgvThuongHieuStaff.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThuongHieuStaff.Name = "dgvThuongHieuStaff";
            this.dgvThuongHieuStaff.ReadOnly = true;
            this.dgvThuongHieuStaff.RowHeadersWidth = 62;
            this.dgvThuongHieuStaff.RowTemplate.Height = 28;
            this.dgvThuongHieuStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuongHieuStaff.Size = new System.Drawing.Size(1053, 268);
            this.dgvThuongHieuStaff.TabIndex = 6;
            // 
            // UserControlBrandStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvThuongHieuStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblTongThuongHieuStaff);
            this.Controls.Add(this.txtTimkiemStaffBrand);
            this.Name = "UserControlBrandStaff";
            this.Size = new System.Drawing.Size(1057, 559);
            this.Load += new System.EventHandler(this.UserControlBrandStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieuStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimkiemStaffBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongThuongHieuStaff;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridView dgvThuongHieuStaff;
    }
}
