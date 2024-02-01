namespace Transportation_Project
{
    partial class passengerFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passengerFm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.passdataGridView1 = new System.Windows.Forms.DataGridView();
            this.passsearchbtn = new Guna.UI.WinForms.GunaButton();
            this.passsearchtxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passdataGridView1);
            this.panel2.Controls.Add(this.passsearchbtn);
            this.panel2.Controls.Add(this.passsearchtxtbx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.panel2.Size = new System.Drawing.Size(1217, 629);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // passdataGridView1
            // 
            this.passdataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.passdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passdataGridView1.Location = new System.Drawing.Point(29, 115);
            this.passdataGridView1.Name = "passdataGridView1";
            this.passdataGridView1.RowHeadersWidth = 51;
            this.passdataGridView1.RowTemplate.Height = 24;
            this.passdataGridView1.Size = new System.Drawing.Size(1146, 502);
            this.passdataGridView1.TabIndex = 2;
            this.passdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // passsearchbtn
            // 
            this.passsearchbtn.AnimationHoverSpeed = 0.07F;
            this.passsearchbtn.AnimationSpeed = 0.03F;
            this.passsearchbtn.BackColor = System.Drawing.Color.Transparent;
            this.passsearchbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passsearchbtn.BorderColor = System.Drawing.Color.Black;
            this.passsearchbtn.BorderSize = 1;
            this.passsearchbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.passsearchbtn.FocusedColor = System.Drawing.Color.Empty;
            this.passsearchbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passsearchbtn.ForeColor = System.Drawing.Color.White;
            this.passsearchbtn.Image = ((System.Drawing.Image)(resources.GetObject("passsearchbtn.Image")));
            this.passsearchbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.passsearchbtn.Location = new System.Drawing.Point(767, 34);
            this.passsearchbtn.Name = "passsearchbtn";
            this.passsearchbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.passsearchbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.passsearchbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.passsearchbtn.OnHoverImage = null;
            this.passsearchbtn.OnPressedColor = System.Drawing.Color.Black;
            this.passsearchbtn.Radius = 15;
            this.passsearchbtn.Size = new System.Drawing.Size(139, 49);
            this.passsearchbtn.TabIndex = 1;
            this.passsearchbtn.Text = "     Search";
            this.passsearchbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passsearchtxtbx
            // 
            this.passsearchtxtbx.BackColor = System.Drawing.Color.Transparent;
            this.passsearchtxtbx.BaseColor = System.Drawing.Color.White;
            this.passsearchtxtbx.BorderColor = System.Drawing.Color.Silver;
            this.passsearchtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passsearchtxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.passsearchtxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passsearchtxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passsearchtxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passsearchtxtbx.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.passsearchtxtbx.Location = new System.Drawing.Point(341, 33);
            this.passsearchtxtbx.Name = "passsearchtxtbx";
            this.passsearchtxtbx.PasswordChar = '\0';
            this.passsearchtxtbx.Radius = 15;
            this.passsearchtxtbx.SelectedText = "";
            this.passsearchtxtbx.Size = new System.Drawing.Size(396, 50);
            this.passsearchtxtbx.TabIndex = 0;
            this.passsearchtxtbx.Text = "   \r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 65);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger";
            // 
            // passengerFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1217, 700);
            this.Name = "passengerFm";
            this.Text = "passengerFm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox passsearchtxtbx;
        private System.Windows.Forms.DataGridView passdataGridView1;
        private Guna.UI.WinForms.GunaButton passsearchbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}