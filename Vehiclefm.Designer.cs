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
            this.colorbo = new Guna.UI.WinForms.GunaTextBox();
            this.modelboc = new Guna.UI.WinForms.GunaTextBox();
            this.licensebo = new Guna.UI.WinForms.GunaTextBox();
            this.ID = new System.Windows.Forms.Label();
            this.savebtn = new Guna.UI.WinForms.GunaButton();
            this.colortxt = new System.Windows.Forms.Label();
            this.modeltxt = new System.Windows.Forms.Label();
            this.licensetxt = new System.Windows.Forms.Label();
            this.vehiclebox = new Guna.UI.WinForms.GunaComboBox();
            this.Vehicletypetxt = new System.Windows.Forms.Label();
            this.datavehicletbl = new System.Windows.Forms.DataGridView();
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
            this.Vehicletypecon.Size = new System.Drawing.Size(1217, 64);
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
            this.vehiclebutt.Controls.Add(this.colorbo);
            this.vehiclebutt.Controls.Add(this.modelboc);
            this.vehiclebutt.Controls.Add(this.licensebo);
            this.vehiclebutt.Controls.Add(this.ID);
            this.vehiclebutt.Controls.Add(this.savebtn);
            this.vehiclebutt.Controls.Add(this.colortxt);
            this.vehiclebutt.Controls.Add(this.modeltxt);
            this.vehiclebutt.Controls.Add(this.licensetxt);
            this.vehiclebutt.Controls.Add(this.vehiclebox);
            this.vehiclebutt.Controls.Add(this.Vehicletypetxt);
            this.vehiclebutt.Controls.Add(this.datavehicletbl);
            this.vehiclebutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehiclebutt.Location = new System.Drawing.Point(0, 60);
            this.vehiclebutt.Name = "vehiclebutt";
            this.vehiclebutt.Size = new System.Drawing.Size(1217, 640);
            this.vehiclebutt.TabIndex = 3;
            // 
            // colorbo
            // 
            this.colorbo.BackColor = System.Drawing.Color.Transparent;
            this.colorbo.BaseColor = System.Drawing.Color.White;
            this.colorbo.BorderColor = System.Drawing.Color.Silver;
            this.colorbo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colorbo.FocusedBaseColor = System.Drawing.Color.White;
            this.colorbo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.colorbo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.colorbo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorbo.Location = new System.Drawing.Point(734, 69);
            this.colorbo.Name = "colorbo";
            this.colorbo.PasswordChar = '\0';
            this.colorbo.Radius = 5;
            this.colorbo.SelectedText = "";
            this.colorbo.Size = new System.Drawing.Size(179, 41);
            this.colorbo.TabIndex = 22;
            // 
            // modelboc
            // 
            this.modelboc.BackColor = System.Drawing.Color.Transparent;
            this.modelboc.BaseColor = System.Drawing.Color.White;
            this.modelboc.BorderColor = System.Drawing.Color.Silver;
            this.modelboc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modelboc.FocusedBaseColor = System.Drawing.Color.White;
            this.modelboc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.modelboc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.modelboc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modelboc.Location = new System.Drawing.Point(312, 69);
            this.modelboc.Name = "modelboc";
            this.modelboc.PasswordChar = '\0';
            this.modelboc.Radius = 5;
            this.modelboc.SelectedText = "";
            this.modelboc.Size = new System.Drawing.Size(179, 41);
            this.modelboc.TabIndex = 21;
            this.modelboc.TextChanged += new System.EventHandler(this.modelboc_TextChanged);
            // 
            // licensebo
            // 
            this.licensebo.BackColor = System.Drawing.Color.Transparent;
            this.licensebo.BaseColor = System.Drawing.Color.White;
            this.licensebo.BorderColor = System.Drawing.Color.Silver;
            this.licensebo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licensebo.FocusedBaseColor = System.Drawing.Color.White;
            this.licensebo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.licensebo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.licensebo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licensebo.Location = new System.Drawing.Point(65, 69);
            this.licensebo.Name = "licensebo";
            this.licensebo.PasswordChar = '\0';
            this.licensebo.Radius = 5;
            this.licensebo.SelectedText = "";
            this.licensebo.Size = new System.Drawing.Size(179, 41);
            this.licensebo.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(969, 74);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 20);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID";
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
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // colortxt
            // 
            this.colortxt.AutoSize = true;
            this.colortxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colortxt.Location = new System.Drawing.Point(740, 44);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(52, 22);
            this.colortxt.TabIndex = 10;
            this.colortxt.Text = "Color";
            // 
            // modeltxt
            // 
            this.modeltxt.AutoSize = true;
            this.modeltxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltxt.Location = new System.Drawing.Point(320, 42);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(60, 22);
            this.modeltxt.TabIndex = 8;
            this.modeltxt.Text = "Model";
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
            this.vehiclebox.Items.AddRange(new object[] {
            "VIP",
            "BUS"});
            this.vehiclebox.Location = new System.Drawing.Point(547, 69);
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
            this.Vehicletypetxt.Location = new System.Drawing.Point(543, 44);
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
            this.datavehicletbl.Size = new System.Drawing.Size(1040, 428);
            this.datavehicletbl.TabIndex = 0;
            // 
            // Vehicletypefm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 700);
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
        private System.Windows.Forms.Label colortxt;
        private Guna.UI.WinForms.GunaButton savebtn;
        private Guna.UI.WinForms.GunaComboBox vehiclebox;
        private System.Windows.Forms.Label ID;
        private Guna.UI.WinForms.GunaTextBox licensebo;
        private Guna.UI.WinForms.GunaTextBox modelboc;
        private Guna.UI.WinForms.GunaTextBox colorbo;
    }
}