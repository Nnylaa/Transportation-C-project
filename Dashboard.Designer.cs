namespace Transportation_Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Show = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.welcometxt = new Guna.UI.WinForms.GunaLabel();
            this.Exit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.btnDriver = new Guna.UI.WinForms.GunaButton();
            this.btnReceipt = new Guna.UI.WinForms.GunaButton();
            this.btnVehicle = new Guna.UI.WinForms.GunaButton();
            this.btnPassenger = new Guna.UI.WinForms.GunaButton();
            this.btnBooking = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.gunaPanel1.Controls.Add(this.Show);
            this.gunaPanel1.Controls.Add(this.gunaPanel5);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(255, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1245, 800);
            this.gunaPanel1.TabIndex = 0;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(16, 88);
            this.Show.MaximumSize = new System.Drawing.Size(1217, 700);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(1217, 700);
            this.Show.TabIndex = 1;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.SteelBlue;
            this.gunaPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPanel5.Controls.Add(this.welcometxt);
            this.gunaPanel5.Controls.Add(this.Exit);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(1245, 85);
            this.gunaPanel5.TabIndex = 0;
            // 
            // welcometxt
            // 
            this.welcometxt.AutoSize = true;
            this.welcometxt.BackColor = System.Drawing.Color.Transparent;
            this.welcometxt.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometxt.ForeColor = System.Drawing.Color.AliceBlue;
            this.welcometxt.Location = new System.Drawing.Point(41, 25);
            this.welcometxt.Name = "welcometxt";
            this.welcometxt.Size = new System.Drawing.Size(384, 36);
            this.welcometxt.TabIndex = 1;
            this.welcometxt.Text = "Welcome to, LARANA TRAVEL";
        
            // 
            // Exit
            // 
            this.Exit.BaseColor = System.Drawing.Color.White;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1169, 16);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 57);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPanel2.Controls.Add(this.gunaPanel4);
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(247, 800);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.btnDriver);
            this.gunaPanel4.Controls.Add(this.btnReceipt);
            this.gunaPanel4.Controls.Add(this.btnVehicle);
            this.gunaPanel4.Controls.Add(this.btnPassenger);
            this.gunaPanel4.Controls.Add(this.btnBooking);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 202);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(243, 594);
            this.gunaPanel4.TabIndex = 1;
            // 
            // btnDriver
            // 
            this.btnDriver.AnimationHoverSpeed = 0.07F;
            this.btnDriver.AnimationSpeed = 0.03F;
            this.btnDriver.BackColor = System.Drawing.Color.Transparent;
            this.btnDriver.BaseColor = System.Drawing.Color.Transparent;
            this.btnDriver.BorderColor = System.Drawing.Color.Black;
            this.btnDriver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDriver.FocusedColor = System.Drawing.Color.Empty;
            this.btnDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDriver.Image = ((System.Drawing.Image)(resources.GetObject("btnDriver.Image")));
            this.btnDriver.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDriver.Location = new System.Drawing.Point(-1, 275);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.OnHoverBaseColor = System.Drawing.Color.PowderBlue;
            this.btnDriver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDriver.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDriver.OnHoverImage = null;
            this.btnDriver.OnPressedColor = System.Drawing.Color.Black;
            this.btnDriver.Radius = 5;
            this.btnDriver.Size = new System.Drawing.Size(244, 85);
            this.btnDriver.TabIndex = 7;
            this.btnDriver.Text = "Driver";
            this.btnDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.AnimationHoverSpeed = 0.07F;
            this.btnReceipt.AnimationSpeed = 0.03F;
            this.btnReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnReceipt.BaseColor = System.Drawing.Color.Transparent;
            this.btnReceipt.BorderColor = System.Drawing.Color.Black;
            this.btnReceipt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReceipt.FocusedColor = System.Drawing.Color.Empty;
            this.btnReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnReceipt.Image")));
            this.btnReceipt.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReceipt.Location = new System.Drawing.Point(-1, 366);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.OnHoverBaseColor = System.Drawing.Color.PowderBlue;
            this.btnReceipt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReceipt.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReceipt.OnHoverImage = null;
            this.btnReceipt.OnPressedColor = System.Drawing.Color.Black;
            this.btnReceipt.Radius = 5;
            this.btnReceipt.Size = new System.Drawing.Size(244, 85);
            this.btnReceipt.TabIndex = 6;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.AnimationHoverSpeed = 0.07F;
            this.btnVehicle.AnimationSpeed = 0.03F;
            this.btnVehicle.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicle.BaseColor = System.Drawing.Color.Transparent;
            this.btnVehicle.BorderColor = System.Drawing.Color.Black;
            this.btnVehicle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVehicle.FocusedColor = System.Drawing.Color.Empty;
            this.btnVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicle.Image")));
            this.btnVehicle.ImageSize = new System.Drawing.Size(35, 35);
            this.btnVehicle.Location = new System.Drawing.Point(1, 184);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.OnHoverBaseColor = System.Drawing.Color.PowderBlue;
            this.btnVehicle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVehicle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVehicle.OnHoverImage = null;
            this.btnVehicle.OnPressedColor = System.Drawing.Color.Black;
            this.btnVehicle.Radius = 5;
            this.btnVehicle.Size = new System.Drawing.Size(244, 85);
            this.btnVehicle.TabIndex = 5;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.AnimationHoverSpeed = 0.07F;
            this.btnPassenger.AnimationSpeed = 0.03F;
            this.btnPassenger.BackColor = System.Drawing.Color.Transparent;
            this.btnPassenger.BaseColor = System.Drawing.Color.Transparent;
            this.btnPassenger.BorderColor = System.Drawing.Color.Black;
            this.btnPassenger.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPassenger.FocusedColor = System.Drawing.Color.Empty;
            this.btnPassenger.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassenger.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPassenger.Image = ((System.Drawing.Image)(resources.GetObject("btnPassenger.Image")));
            this.btnPassenger.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPassenger.Location = new System.Drawing.Point(6, 87);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.OnHoverBaseColor = System.Drawing.Color.PowderBlue;
            this.btnPassenger.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPassenger.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPassenger.OnHoverImage = null;
            this.btnPassenger.OnPressedColor = System.Drawing.Color.Black;
            this.btnPassenger.Radius = 5;
            this.btnPassenger.Size = new System.Drawing.Size(244, 85);
            this.btnPassenger.TabIndex = 1;
            this.btnPassenger.Text = "Passenger";
            this.btnPassenger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.AnimationHoverSpeed = 0.07F;
            this.btnBooking.AnimationSpeed = 0.03F;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BaseColor = System.Drawing.Color.Transparent;
            this.btnBooking.BorderColor = System.Drawing.Color.Black;
            this.btnBooking.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBooking.FocusedColor = System.Drawing.Color.Empty;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBooking.Location = new System.Drawing.Point(6, 1);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.OnHoverBaseColor = System.Drawing.Color.PowderBlue;
            this.btnBooking.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBooking.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBooking.OnHoverImage = null;
            this.btnBooking.OnPressedColor = System.Drawing.Color.Black;
            this.btnBooking.Radius = 5;
            this.btnBooking.Size = new System.Drawing.Size(244, 85);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking";
            this.btnBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBooking.Click += new System.EventHandler(this.Bookingbtn_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Azure;
            this.gunaPanel3.Controls.Add(this.pictureBox1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(243, 200);
            this.gunaPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Dashboard";
            this.Text = "  ";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnBooking;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaPictureBox Exit;
        private Guna.UI.WinForms.GunaLabel welcometxt;
        private Guna.UI.WinForms.GunaButton btnPassenger;
        private Guna.UI.WinForms.GunaButton btnVehicle;
        private Guna.UI.WinForms.GunaButton btnDriver;
        private Guna.UI.WinForms.GunaButton btnReceipt;
        private Guna.UI.WinForms.GunaPanel Show;
    }
}