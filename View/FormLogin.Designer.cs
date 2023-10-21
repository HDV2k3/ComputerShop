namespace Computer_Shop_Management_System.PAL
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.picShowPass = new System.Windows.Forms.PictureBox();
            this.picHidePass = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer Shop Manager System | Login";
       
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
      
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
          
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(144, 309);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "VietHuynhHutech";
        
            // 
            // txtUserpassword
            // 
            this.txtUserpassword.Location = new System.Drawing.Point(144, 357);
            this.txtUserpassword.Name = "txtUserpassword";
            this.txtUserpassword.Size = new System.Drawing.Size(242, 20);
            this.txtUserpassword.TabIndex = 2;
            this.txtUserpassword.Text = "Viethuynh@#!2003";
            this.txtUserpassword.UseSystemPasswordChar = true;
  
            this.txtUserpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserpassword_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(209, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forgot Password ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(145, 445);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 38);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnLogin;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // picShowPass
            // 
            this.picShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowPass.Image = global::Computer_Shop_Management_System.Properties.Resources.eye;
            this.picShowPass.Location = new System.Drawing.Point(389, 357);
            this.picShowPass.Name = "picShowPass";
            this.picShowPass.Size = new System.Drawing.Size(24, 20);
            this.picShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPass.TabIndex = 0;
            this.picShowPass.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picShowPass, "Show Password");
            this.picShowPass.Click += new System.EventHandler(this.picShowPass_Click);
            // 
            // picHidePass
            // 
            this.picHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHidePass.Image = global::Computer_Shop_Management_System.Properties.Resources.hide;
            this.picHidePass.Location = new System.Drawing.Point(389, 357);
            this.picHidePass.Name = "picHidePass";
            this.picHidePass.Size = new System.Drawing.Size(24, 20);
            this.picHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHidePass.TabIndex = 0;
            this.picHidePass.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picHidePass, "Hide Password");
            this.picHidePass.Visible = false;
            this.picHidePass.Click += new System.EventHandler(this.picHidePass_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::Computer_Shop_Management_System.Properties.Resources.reject;
            this.picClose.Location = new System.Drawing.Point(523, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picClose, "Close");
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Computer_Shop_Management_System.Properties.Resources.laptop__1_;
            this.pictureBox3.Location = new System.Drawing.Point(186, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
        
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Shop_Management_System.Properties.Resources.laptop;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
          
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 560);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserpassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picShowPass);
            this.Controls.Add(this.picHidePass);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop Management System | Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserpassword;
        private System.Windows.Forms.PictureBox picHidePass;
        private System.Windows.Forms.PictureBox picShowPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
    }
}