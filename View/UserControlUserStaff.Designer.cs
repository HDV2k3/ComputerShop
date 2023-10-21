namespace Computer_Shop_Management_System.View
{
    partial class UserControlUserStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsersStaff = new System.Windows.Forms.DataGridView();
            this.txtTimKiemThuongHieuStaff = new System.Windows.Forms.TextBox();
            this.lblTongNhanVienStaff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersStaff
            // 
            this.dgvUsersStaff.AllowUserToAddRows = false;
            this.dgvUsersStaff.AllowUserToDeleteRows = false;
            this.dgvUsersStaff.AllowUserToResizeColumns = false;
            this.dgvUsersStaff.AllowUserToResizeRows = false;
            this.dgvUsersStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsersStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvUsersStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsersStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersStaff.ColumnHeadersHeight = 34;
            this.dgvUsersStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersStaff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsersStaff.EnableHeadersVisualStyles = false;
            this.dgvUsersStaff.Location = new System.Drawing.Point(122, 134);
            this.dgvUsersStaff.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsersStaff.Name = "dgvUsersStaff";
            this.dgvUsersStaff.ReadOnly = true;
            this.dgvUsersStaff.RowHeadersWidth = 62;
            this.dgvUsersStaff.RowTemplate.Height = 28;
            this.dgvUsersStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersStaff.Size = new System.Drawing.Size(809, 241);
            this.dgvUsersStaff.TabIndex = 2;
            // 
            // txtTimKiemThuongHieuStaff
            // 
            this.txtTimKiemThuongHieuStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemThuongHieuStaff.Location = new System.Drawing.Point(364, 86);
            this.txtTimKiemThuongHieuStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemThuongHieuStaff.Name = "txtTimKiemThuongHieuStaff";
            this.txtTimKiemThuongHieuStaff.Size = new System.Drawing.Size(246, 20);
            this.txtTimKiemThuongHieuStaff.TabIndex = 7;
            this.txtTimKiemThuongHieuStaff.TextChanged += new System.EventHandler(this.txtTimKiemThuongHieuStaff_TextChanged);
            // 
            // lblTongNhanVienStaff
            // 
            this.lblTongNhanVienStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongNhanVienStaff.AutoSize = true;
            this.lblTongNhanVienStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNhanVienStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTongNhanVienStaff.Location = new System.Drawing.Point(278, 441);
            this.lblTongNhanVienStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongNhanVienStaff.Name = "lblTongNhanVienStaff";
            this.lblTongNhanVienStaff.Size = new System.Drawing.Size(24, 17);
            this.lblTongNhanVienStaff.TabIndex = 3;
            this.lblTongNhanVienStaff.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(118, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng Nhân Viên:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(361, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tìm Kiếm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = ".../ Quản Lý Người Dùng";
            // 
            // UserControlUserStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUsersStaff);
            this.Controls.Add(this.txtTimKiemThuongHieuStaff);
            this.Controls.Add(this.lblTongNhanVienStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "UserControlUserStaff";
            this.Size = new System.Drawing.Size(1057, 559);
            this.Load += new System.EventHandler(this.UserControlUserStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersStaff;
        private System.Windows.Forms.TextBox txtTimKiemThuongHieuStaff;
        private System.Windows.Forms.Label lblTongNhanVienStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
