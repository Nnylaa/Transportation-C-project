namespace Transportation_Project
{
    partial class Vehicletypefm
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
            this.Vehicletypecon = new System.Windows.Forms.Panel();
            this.vehiclecontxt = new Guna.UI.WinForms.GunaLabel();
            this.vehiclebutt = new System.Windows.Forms.Panel();
            this.licensetxt = new System.Windows.Forms.Label();
            this.vehiclebox = new Guna.UI.WinForms.GunaComboBox();
            this.Vehicletypetxt = new System.Windows.Forms.Label();
            this.datavehicletbl = new System.Windows.Forms.DataGridView();
            this.modeltxt = new System.Windows.Forms.Label();
            this.colortxt = new System.Windows.Forms.Label();
            this.driveridtxt = new System.Windows.Forms.Label();
            this.savebtn = new Guna.UI.WinForms.GunaButton();
            this.licensebox = new Guna.UI.WinForms.GunaButton();
            this.modelboc = new Guna.UI.WinForms.GunaButton();
            this.colorbox = new Guna.UI.WinForms.GunaButton();
            this.driveridbox = new Guna.UI.WinForms.GunaButton();
            this.Vehicletypecon.SuspendLayout();
            this.vehiclebutt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datavehicletbl)).BeginInit();
            this.SuspendLayout();
            // 
            // Vehicletypecon
            // 
            this.Vehicletypecon.BackColor = System.Drawing.Color.SteelBlue;
            this.Vehicletypecon.Controls.Add(this.vehiclecontxt);
            this.Vehicletypecon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vehicletypecon.Location = new System.Drawing.Point(0, 0);
            this.Vehicletypecon.Name = "Vehicletypecon";
            this.Vehicletypecon.Size = new System.Drawing.Size(1199, 64);
            this.Vehicletypecon.TabIndex = 2;
            // 
            // vehiclecontxt
            // 
            this.vehiclecontxt.AutoSize = true;
            this.vehiclecontxt.Font = new System.Drawing.Font("Battambang", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclecontxt.ForeColor = System.Drawing.Color.White;
            this.vehiclecontxt.Location = new System.Drawing.Point(25, 16);
            this.vehiclecontxt.Name = "vehiclecontxt";
            this.vehiclecontxt.Size = new System.Drawing.Size(126, 41);
            this.vehiclecontxt.TabIndex = 0;
            this.vehiclecontxt.Text = "Vehicle ";
            // 
            // vehiclebutt
            // 
            this.vehiclebutt.Controls.Add(this.driveridbox);
            this.vehiclebutt.Controls.Add(this.colorbox);
            this.vehiclebutt.Controls.Add(this.modelboc);
            this.vehiclebutt.Controls.Add(this.licensebox);
            this.vehiclebutt.Controls.Add(this.savebtn);
            this.vehiclebutt.Controls.Add(this.driveridtxt);
            this.vehiclebutt.Controls.Add(this.colortxt);
            this.vehiclebutt.Controls.Add(this.modeltxt);
            this.vehiclebutt.Controls.Add(this.licensetxt);
            this.vehiclebutt.Controls.Add(this.vehiclebox);
            this.vehiclebutt.Controls.Add(this.Vehicletypetxt);
            this.vehiclebutt.Controls.Add(this.datavehicletbl);
            this.vehiclebutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehiclebutt.Location = new System.Drawing.Point(0, 60);
            this.vehiclebutt.Name = "vehiclebutt";
            this.vehiclebutt.Size = new System.Drawing.Size(1199, 593);
            this.vehiclebutt.TabIndex = 3;
            // 
            // licensetxt
            // 
            this.licensetxt.AutoSize = true;
            this.licensetxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensetxt.Location = new System.Drawing.Point(76, 42);
            this.licensetxt.Name = "licensetxt";
            this.licensetxt.Size = new System.Drawing.Size(117, 22);
            this.licensetxt.TabIndex = 6;
            this.licensetxt.Text = "License Plate";
            this.licensetxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // vehiclebox
            // 
            this.vehiclebox.BackColor = System.Drawing.Color.Transparent;
            this.vehiclebox.BaseColor = System.Drawing.Color.White;
            this.vehiclebox.BorderColor = System.Drawing.Color.DimGray;
            this.vehiclebox.BorderSize = 1;
            this.vehiclebox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vehiclebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiclebox.FocusedColor = System.Drawing.Color.Empty;
            this.vehiclebox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vehiclebox.ForeColor = System.Drawing.Color.Black;
            this.vehiclebox.FormattingEnabled = true;
            this.vehiclebox.ItemHeight = 33;
            this.vehiclebox.Location = new System.Drawing.Point(533, 69);
            this.vehiclebox.Name = "vehiclebox";
            this.vehiclebox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.vehiclebox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.vehiclebox.Radius = 5;
            this.vehiclebox.Size = new System.Drawing.Size(121, 39);
            this.vehiclebox.TabIndex = 5;
            // 
            // Vehicletypetxt
            // 
            this.Vehicletypetxt.AutoSize = true;
            this.Vehicletypetxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicletypetxt.Location = new System.Drawing.Point(529, 44);
            this.Vehicletypetxt.Name = "Vehicletypetxt";
            this.Vehicletypetxt.Size = new System.Drawing.Size(111, 22);
            this.Vehicletypetxt.TabIndex = 3;
            this.Vehicletypetxt.Text = "Vehicle Type";
            // 
            // datavehicletbl
            // 
            this.datavehicletbl.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.datavehicletbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datavehicletbl.Location = new System.Drawing.Point(74, 200);
            this.datavehicletbl.Name = "datavehicletbl";
            this.datavehicletbl.RowHeadersWidth = 51;
            this.datavehicletbl.RowTemplate.Height = 24;
            this.datavehicletbl.Size = new System.Drawing.Size(1040, 369);
            this.datavehicletbl.TabIndex = 0;
            // 
            // modeltxt
            // 
            this.modeltxt.AutoSize = true;
            this.modeltxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltxt.Location = new System.Drawing.Point(306, 42);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(60, 22);
            this.modeltxt.TabIndex = 8;
            this.modeltxt.Text = "Model";
            // 
            // colortxt
            // 
            this.colortxt.AutoSize = true;
            this.colortxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colortxt.Location = new System.Drawing.Point(748, 43);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(52, 22);
            this.colortxt.TabIndex = 10;
            this.colortxt.Text = "Color";
            // 
            // driveridtxt
            // 
            this.driveridtxt.AutoSize = true;
            this.driveridtxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveridtxt.Location = new System.Drawing.Point(964, 42);
            this.driveridtxt.Name = "driveridtxt";
            this.driveridtxt.Size = new System.Drawing.Size(74, 22);
            this.driveridtxt.TabIndex = 12;
            this.driveridtxt.Text = "DriverID";
            // 
            // savebtn
            // 
            this.savebtn.AnimationHoverSpeed = 0.07F;
            this.savebtn.AnimationSpeed = 0.03F;
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.savebtn.BorderColor = System.Drawing.Color.Blue;
            this.savebtn.BorderSize = 1;
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.savebtn.FocusedColor = System.Drawing.Color.Empty;
            this.savebtn.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Image = null;
            this.savebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.savebtn.Location = new System.Drawing.Point(999, 129);
            this.savebtn.Name = "savebtn";
            this.savebtn.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.savebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.savebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.savebtn.OnHoverImage = null;
            this.savebtn.OnPressedColor = System.Drawing.Color.Black;
            this.savebtn.Radius = 5;
            this.savebtn.Size = new System.Drawing.Size(115, 42);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "SAVE";
            this.savebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // licensebox
            // 
            this.licensebox.AnimationHoverSpeed = 0.07F;
            this.licensebox.AnimationSpeed = 0.03F;
            this.licensebox.BackColor = System.Drawing.Color.Transparent;
            this.licensebox.BaseColor = System.Drawing.Color.White;
            this.licensebox.BorderColor = System.Drawing.Color.DimGray;
            this.licensebox.BorderSize = 1;
            this.licensebox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.licensebox.FocusedColor = System.Drawing.Color.Empty;
            this.licensebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licensebox.ForeColor = System.Drawing.Color.White;
            this.licensebox.Image = null;
            this.licensebox.ImageSize = new System.Drawing.Size(20, 20);
            this.licensebox.Location = new System.Drawing.Point(74, 69);
            this.licensebox.Name = "licensebox";
            this.licensebox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.licensebox.OnHoverBorderColor = System.Drawing.Color.Black;
            this.licensebox.OnHoverForeColor = System.Drawing.Color.White;
            this.licensebox.OnHoverImage = null;
            this.licensebox.OnPressedColor = System.Drawing.Color.Black;
            this.licensebox.Radius = 5;
            this.licensebox.Size = new System.Drawing.Size(149, 37);
            this.licensebox.TabIndex = 15;
            // 
            // modelboc
            // 
            this.modelboc.AnimationHoverSpeed = 0.07F;
            this.modelboc.AnimationSpeed = 0.03F;
            this.modelboc.BackColor = System.Drawing.Color.Transparent;
            this.modelboc.BaseColor = System.Drawing.Color.White;
            this.modelboc.BorderColor = System.Drawing.Color.DimGray;
            this.modelboc.BorderSize = 1;
            this.modelboc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.modelboc.FocusedColor = System.Drawing.Color.Empty;
            this.modelboc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modelboc.ForeColor = System.Drawing.Color.White;
            this.modelboc.Image = null;
            this.modelboc.ImageSize = new System.Drawing.Size(20, 20);
            this.modelboc.Location = new System.Drawing.Point(301, 69);
            this.modelboc.Name = "modelboc";
            this.modelboc.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.modelboc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.modelboc.OnHoverForeColor = System.Drawing.Color.White;
            this.modelboc.OnHoverImage = null;
            this.modelboc.OnPressedColor = System.Drawing.Color.Black;
            this.modelboc.Radius = 5;
            this.modelboc.Size = new System.Drawing.Size(149, 37);
            this.modelboc.TabIndex = 16;
            // 
            // colorbox
            // 
            this.colorbox.AnimationHoverSpeed = 0.07F;
            this.colorbox.AnimationSpeed = 0.03F;
            this.colorbox.BackColor = System.Drawing.Color.Transparent;
            this.colorbox.BaseColor = System.Drawing.Color.White;
            this.colorbox.BorderColor = System.Drawing.Color.DimGray;
            this.colorbox.BorderSize = 1;
            this.colorbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.colorbox.FocusedColor = System.Drawing.Color.Empty;
            this.colorbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorbox.ForeColor = System.Drawing.Color.White;
            this.colorbox.Image = null;
            this.colorbox.ImageSize = new System.Drawing.Size(20, 20);
            this.colorbox.Location = new System.Drawing.Point(744, 69);
            this.colorbox.Name = "colorbox";
            this.colorbox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.colorbox.OnHoverBorderColor = System.Drawing.Color.Black;
            this.colorbox.OnHoverForeColor = System.Drawing.Color.White;
            this.colorbox.OnHoverImage = null;
            this.colorbox.OnPressedColor = System.Drawing.Color.Black;
            this.colorbox.Radius = 5;
            this.colorbox.Size = new System.Drawing.Size(149, 37);
            this.colorbox.TabIndex = 17;
            // 
            // driveridbox
            // 
            this.driveridbox.AnimationHoverSpeed = 0.07F;
            this.driveridbox.AnimationSpeed = 0.03F;
            this.driveridbox.BackColor = System.Drawing.Color.Transparent;
            this.driveridbox.BaseColor = System.Drawing.Color.White;
            this.driveridbox.BorderColor = System.Drawing.Color.DimGray;
            this.driveridbox.BorderSize = 1;
            this.driveridbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.driveridbox.FocusedColor = System.Drawing.Color.Empty;
            this.driveridbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.driveridbox.ForeColor = System.Drawing.Color.White;
            this.driveridbox.Image = null;
            this.driveridbox.ImageSize = new System.Drawing.Size(20, 20);
            this.driveridbox.Location = new System.Drawing.Point(965, 67);
            this.driveridbox.Name = "driveridbox";
            this.driveridbox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.driveridbox.OnHoverBorderColor = System.Drawing.Color.Black;
            this.driveridbox.OnHoverForeColor = System.Drawing.Color.White;
            this.driveridbox.OnHoverImage = null;
            this.driveridbox.OnPressedColor = System.Drawing.Color.Black;
            this.driveridbox.Radius = 5;
            this.driveridbox.Size = new System.Drawing.Size(149, 37);
            this.driveridbox.TabIndex = 18;
            // 
            // Vehicletypefm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 653);
            this.Controls.Add(this.vehiclebutt);
            this.Controls.Add(this.Vehicletypecon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1217, 700);
            this.Name = "Vehicletypefm";
            this.Text = "Form1";
            this.Vehicletypecon.ResumeLayout(false);
            this.Vehicletypecon.PerformLayout();
            this.vehiclebutt.ResumeLayout(false);
            this.vehiclebutt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datavehicletbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Vehicletypecon;
        private Guna.UI.WinForms.GunaLabel vehiclecontxt;
        private System.Windows.Forms.Panel vehiclebutt;
        private System.Windows.Forms.DataGridView datavehicletbl;
        private System.Windows.Forms.Label Vehicletypetxt;
        private System.Windows.Forms.Label licensetxt;
        private System.Windows.Forms.Label modeltxt;
        private System.Windows.Forms.Label driveridtxt;
        private System.Windows.Forms.Label colortxt;
        private Guna.UI.WinForms.GunaButton savebtn;
        private Guna.UI.WinForms.GunaButton driveridbox;
        private Guna.UI.WinForms.GunaButton colorbox;
        private Guna.UI.WinForms.GunaButton modelboc;
        private Guna.UI.WinForms.GunaButton licensebox;
        private Guna.UI.WinForms.GunaComboBox vehiclebox;
    }
}