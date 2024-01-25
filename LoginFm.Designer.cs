namespace Transportation_Project
{
    partial class FmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLogin));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Login = new Guna.UI.WinForms.GunaButton();
            this.Password = new Guna.UI.WinForms.GunaTextBox();
            this.UserName = new Guna.UI.WinForms.GunaTextBox();
            this.logo = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.AliceBlue;
            this.gunaElipsePanel1.Controls.Add(this.Login);
            this.gunaElipsePanel1.Controls.Add(this.Password);
            this.gunaElipsePanel1.Controls.Add(this.UserName);
            this.gunaElipsePanel1.Controls.Add(this.logo);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(103, 88);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 50;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(573, 378);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.AnimationHoverSpeed = 0.07F;
            this.Login.AnimationSpeed = 0.03F;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BaseColor = System.Drawing.Color.DodgerBlue;
            this.Login.BorderColor = System.Drawing.Color.Black;
            this.Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Login.FocusedColor = System.Drawing.Color.Empty;
            this.Login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Image = null;
            this.Login.ImageSize = new System.Drawing.Size(20, 20);
            this.Login.Location = new System.Drawing.Point(239, 284);
            this.Login.Name = "Login";
            this.Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Login.OnHoverForeColor = System.Drawing.Color.White;
            this.Login.OnHoverImage = null;
            this.Login.OnPressedColor = System.Drawing.Color.Black;
            this.Login.Radius = 20;
            this.Login.Size = new System.Drawing.Size(115, 51);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BaseColor = System.Drawing.Color.White;
            this.Password.BorderColor = System.Drawing.Color.SteelBlue;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FocusedBaseColor = System.Drawing.Color.White;
            this.Password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Password.Location = new System.Drawing.Point(132, 204);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.Radius = 15;
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(316, 53);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.BaseColor = System.Drawing.Color.White;
            this.UserName.BorderColor = System.Drawing.Color.SteelBlue;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.FocusedBaseColor = System.Drawing.Color.White;
            this.UserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserName.Location = new System.Drawing.Point(132, 126);
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.Radius = 15;
            this.UserName.SelectedText = "";
            this.UserName.Size = new System.Drawing.Size(316, 53);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Username";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BaseColor = System.Drawing.Color.White;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(207, -2);
            this.logo.Name = "logo";
            this.logo.Radius = 20;
            this.logo.Size = new System.Drawing.Size(164, 122);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.gunaPictureBox1_Click_1);
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox logo;
        private Guna.UI.WinForms.GunaTextBox UserName;
        private Guna.UI.WinForms.GunaButton Login;
        private Guna.UI.WinForms.GunaTextBox Password;
    }
}

