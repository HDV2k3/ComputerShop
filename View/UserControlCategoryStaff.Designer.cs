namespace Computer_Shop_Management_System.View
{
    partial class UserControlCategoryStaff
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
            this.dgvLoaiStaff = new System.Windows.Forms.DataGridView();
            this.txtTimKiemLoaiStaff = new System.Windows.Forms.TextBox();
            this.lblTongSoLoaiStaff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiStaff
            // 
            this.dgvLoaiStaff.AllowUserToAddRows = false;
            this.dgvLoaiStaff.AllowUserToDeleteRows = false;
            this.dgvLoaiStaff.AllowUserToResizeColumns = false;
            this.dgvLoaiStaff.AllowUserToResizeRows = false;
            this.dgvLoaiStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvLoaiStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiStaff.ColumnHeadersHeight = 34;
            this.dgvLoaiStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiStaff.EnableHeadersVisualStyles = false;
            this.dgvLoaiStaff.Location = new System.Drawing.Point(2, 122);
            this.dgvLoaiStaff.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLoaiStaff.Name = "dgvLoaiStaff";
            this.dgvLoaiStaff.ReadOnly = true;
            this.dgvLoaiStaff.RowHeadersWidth = 62;
            this.dgvLoaiStaff.RowTemplate.Height = 28;
            this.dgvLoaiStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiStaff.Size = new System.Drawing.Size(1053, 268);
            this.dgvLoaiStaff.TabIndex = 2;
            // 
            // txtTimKiemLoaiStaff
            // 
            this.txtTimKiemLoaiStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemLoaiStaff.Location = new System.Drawing.Point(322, 89);
            this.txtTimKiemLoaiStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemLoaiStaff.Name = "txtTimKiemLoaiStaff";
            this.txtTimKiemLoaiStaff.Size = new System.Drawing.Size(247, 20);
            this.txtTimKiemLoaiStaff.TabIndex = 7;
            this.txtTimKiemLoaiStaff.TextChanged += new System.EventHandler(this.txtTimKiemLoaiStaff_TextChanged);
            // 
            // lblTongSoLoaiStaff
            // 
            this.lblTongSoLoaiStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongSoLoaiStaff.AutoSize = true;
            this.lblTongSoLoaiStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoLoaiStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTongSoLoaiStaff.Location = new System.Drawing.Point(223, 477);
            this.lblTongSoLoaiStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoLoaiStaff.Name = "lblTongSoLoaiStaff";
            this.lblTongSoLoaiStaff.Size = new System.Drawing.Size(24, 17);
            this.lblTongSoLoaiStaff.TabIndex = 3;
            this.lblTongSoLoaiStaff.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(85, 477);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng số loại:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(318, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tìm Kiếm";
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
            this.label4.TabIndex = 6;
            this.label4.Text = ".../ Quản Lý Loại";
            // 
            // UserControlCategoryStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLoaiStaff);
            this.Controls.Add(this.txtTimKiemLoaiStaff);
            this.Controls.Add(this.lblTongSoLoaiStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "UserControlCategoryStaff";
            this.Size = new System.Drawing.Size(1057, 559);
            this.Load += new System.EventHandler(this.UserControlCategoryStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiStaff;
        private System.Windows.Forms.TextBox txtTimKiemLoaiStaff;
        private System.Windows.Forms.Label lblTongSoLoaiStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
