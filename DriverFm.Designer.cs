namespace Transportation_Project
{
    partial class DriverFm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.modeltxt = new System.Windows.Forms.Label();
            this.driversavebtn = new Guna.UI.WinForms.GunaButton();
            this.driverphonebox = new Guna.UI.WinForms.GunaTextBox();
            this.driverbox = new Guna.UI.WinForms.GunaTextBox();
            this.driverdataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.modeltxt);
            this.panel2.Controls.Add(this.driversavebtn);
            this.panel2.Controls.Add(this.driverphonebox);
            this.panel2.Controls.Add(this.driverbox);
            this.panel2.Controls.Add(this.driverdataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 647);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone Number";
            // 
            // modeltxt
            // 
            this.modeltxt.AutoSize = true;
            this.modeltxt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltxt.Location = new System.Drawing.Point(218, 31);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(110, 22);
            this.modeltxt.TabIndex = 9;
            this.modeltxt.Text = "Driver Name";
            // 
            // driversavebtn
            // 
            this.driversavebtn.AnimationHoverSpeed = 0.07F;
            this.driversavebtn.AnimationSpeed = 0.03F;
            this.driversavebtn.BackColor = System.Drawing.Color.Transparent;
            this.driversavebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.driversavebtn.BorderColor = System.Drawing.Color.Black;
            this.driversavebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.driversavebtn.FocusedColor = System.Drawing.Color.Empty;
            this.driversavebtn.Font = new System.Drawing.Font("Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversavebtn.ForeColor = System.Drawing.Color.White;
            this.driversavebtn.Image = null;
            this.driversavebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.driversavebtn.Location = new System.Drawing.Point(860, 57);
            this.driversavebtn.Name = "driversavebtn";
            this.driversavebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.driversavebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.driversavebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.driversavebtn.OnHoverImage = null;
            this.driversavebtn.OnPressedColor = System.Drawing.Color.Black;
            this.driversavebtn.Radius = 10;
            this.driversavebtn.Size = new System.Drawing.Size(133, 50);
            this.driversavebtn.TabIndex = 5;
            this.driversavebtn.Text = "Save";
            this.driversavebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driverphonebox
            // 
            this.driverphonebox.BackColor = System.Drawing.Color.Transparent;
            this.driverphonebox.BaseColor = System.Drawing.Color.White;
            this.driverphonebox.BorderColor = System.Drawing.Color.Silver;
            this.driverphonebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.driverphonebox.FocusedBaseColor = System.Drawing.Color.White;
            this.driverphonebox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.driverphonebox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.driverphonebox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverphonebox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.driverphonebox.Location = new System.Drawing.Point(548, 57);
            this.driverphonebox.Margin = new System.Windows.Forms.Padding(4);
            this.driverphonebox.Name = "driverphonebox";
            this.driverphonebox.PasswordChar = '\0';
            this.driverphonebox.Radius = 10;
            this.driverphonebox.SelectedText = "";
            this.driverphonebox.Size = new System.Drawing.Size(251, 50);
            this.driverphonebox.TabIndex = 2;
            // 
            // driverbox
            // 
            this.driverbox.BackColor = System.Drawing.Color.Transparent;
            this.driverbox.BaseColor = System.Drawing.Color.White;
            this.driverbox.BorderColor = System.Drawing.Color.Silver;
            this.driverbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.driverbox.FocusedBaseColor = System.Drawing.Color.White;
            this.driverbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.driverbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.driverbox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.driverbox.Location = new System.Drawing.Point(210, 57);
            this.driverbox.Margin = new System.Windows.Forms.Padding(4);
            this.driverbox.Name = "driverbox";
            this.driverbox.PasswordChar = '\0';
            this.driverbox.Radius = 10;
            this.driverbox.SelectedText = "";
            this.driverbox.Size = new System.Drawing.Size(251, 50);
            this.driverbox.TabIndex = 1;
            // 
            // driverdataGridView1
            // 
            this.driverdataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.driverdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverdataGridView1.Location = new System.Drawing.Point(29, 138);
            this.driverdataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driverdataGridView1.Name = "driverdataGridView1";
            this.driverdataGridView1.RowHeadersWidth = 51;
            this.driverdataGridView1.RowTemplate.Height = 24;
            this.driverdataGridView1.Size = new System.Drawing.Size(1140, 482);
            this.driverdataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 56);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver";
            // 
            // DriverFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1217, 700);
            this.Name = "DriverFm";
            this.Text = "DriverFm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView driverdataGridView1;
        private Guna.UI.WinForms.GunaTextBox driverphonebox;
        private Guna.UI.WinForms.GunaTextBox driverbox;
        private Guna.UI.WinForms.GunaButton driversavebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label modeltxt;
    }
}