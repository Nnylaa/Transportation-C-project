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
            this.lblDriverID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modeltxt = new System.Windows.Forms.Label();
            this.btnsave = new Guna.UI.WinForms.GunaButton();
            this.txtDriverPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtDriverName = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewDriver = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDriverID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.modeltxt);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtDriverPhone);
            this.panel2.Controls.Add(this.txtDriverName);
            this.panel2.Controls.Add(this.dataGridViewDriver);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 647);
            this.panel2.TabIndex = 1;
            // 
            // lblDriverID
            // 
            this.lblDriverID.AutoSize = true;
            this.lblDriverID.Location = new System.Drawing.Point(72, 68);
            this.lblDriverID.Name = "lblDriverID";
            this.lblDriverID.Size = new System.Drawing.Size(56, 16);
            this.lblDriverID.TabIndex = 11;
            this.lblDriverID.Text = "DriverID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone Number";
            // 
            // modeltxt
            // 
            this.modeltxt.AutoSize = true;
            this.modeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltxt.Location = new System.Drawing.Point(218, 31);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(110, 22);
            this.modeltxt.TabIndex = 9;
            this.modeltxt.Text = "Driver Name";
            // 
            // btnsave
            // 
            this.btnsave.AnimationHoverSpeed = 0.07F;
            this.btnsave.AnimationSpeed = 0.03F;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnsave.BorderColor = System.Drawing.Color.Black;
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsave.FocusedColor = System.Drawing.Color.Empty;
            this.btnsave.Font = new System.Drawing.Font("Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = null;
            this.btnsave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsave.Location = new System.Drawing.Point(860, 57);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Radius = 10;
            this.btnsave.Size = new System.Drawing.Size(133, 50);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtDriverPhone.BaseColor = System.Drawing.Color.White;
            this.txtDriverPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtDriverPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDriverPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDriverPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDriverPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverPhone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDriverPhone.Location = new System.Drawing.Point(548, 57);
            this.txtDriverPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.PasswordChar = '\0';
            this.txtDriverPhone.Radius = 10;
            this.txtDriverPhone.SelectedText = "";
            this.txtDriverPhone.Size = new System.Drawing.Size(251, 50);
            this.txtDriverPhone.TabIndex = 2;
            // 
            // txtDriverName
            // 
            this.txtDriverName.BackColor = System.Drawing.Color.Transparent;
            this.txtDriverName.BaseColor = System.Drawing.Color.White;
            this.txtDriverName.BorderColor = System.Drawing.Color.Silver;
            this.txtDriverName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDriverName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDriverName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDriverName.Location = new System.Drawing.Point(210, 57);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.PasswordChar = '\0';
            this.txtDriverName.Radius = 10;
            this.txtDriverName.SelectedText = "";
            this.txtDriverName.Size = new System.Drawing.Size(251, 50);
            this.txtDriverName.TabIndex = 1;
            // 
            // dataGridViewDriver
            // 
            this.dataGridViewDriver.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriver.Location = new System.Drawing.Point(29, 138);
            this.dataGridViewDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDriver.Name = "dataGridViewDriver";
            this.dataGridViewDriver.RowHeadersWidth = 51;
            this.dataGridViewDriver.RowTemplate.Height = 24;
            this.dataGridViewDriver.Size = new System.Drawing.Size(1140, 482);
            this.dataGridViewDriver.TabIndex = 0;
            this.dataGridViewDriver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriver_CellClick);
            this.dataGridViewDriver.DoubleClick += new System.EventHandler(this.dataGridViewDriver_DoubleClick);
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
            this.Load += new System.EventHandler(this.DriverFm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDriver;
        private Guna.UI.WinForms.GunaTextBox txtDriverPhone;
        private Guna.UI.WinForms.GunaTextBox txtDriverName;
        private Guna.UI.WinForms.GunaButton btnsave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label modeltxt;
        private System.Windows.Forms.Label lblDriverID;
    }
}