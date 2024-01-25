namespace Transportation_Project
{
    partial class recform
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
            this.receiptcon = new System.Windows.Forms.Panel();
            this.recontxt = new Guna.UI.WinForms.GunaLabel();
            this.recbutt = new System.Windows.Forms.Panel();
            this.datarectbl = new System.Windows.Forms.DataGridView();
            this.recsearchbox = new Guna.UI.WinForms.GunaTextBox();
            this.searchbtn = new Guna.UI.WinForms.GunaButton();
            this.receiptcon.SuspendLayout();
            this.recbutt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datarectbl)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptcon
            // 
            this.receiptcon.BackColor = System.Drawing.Color.SteelBlue;
            this.receiptcon.Controls.Add(this.recontxt);
            this.receiptcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.receiptcon.Location = new System.Drawing.Point(0, 0);
            this.receiptcon.Name = "receiptcon";
            this.receiptcon.Size = new System.Drawing.Size(1217, 64);
            this.receiptcon.TabIndex = 3;
            // 
            // recontxt
            // 
            this.recontxt.AutoSize = true;
            this.recontxt.Font = new System.Drawing.Font("Battambang", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recontxt.ForeColor = System.Drawing.Color.White;
            this.recontxt.Location = new System.Drawing.Point(25, 16);
            this.recontxt.Name = "recontxt";
            this.recontxt.Size = new System.Drawing.Size(122, 41);
            this.recontxt.TabIndex = 0;
            this.recontxt.Text = "Receipt";
            // 
            // recbutt
            // 
            this.recbutt.Controls.Add(this.searchbtn);
            this.recbutt.Controls.Add(this.recsearchbox);
            this.recbutt.Controls.Add(this.datarectbl);
            this.recbutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recbutt.Location = new System.Drawing.Point(0, 70);
            this.recbutt.Name = "recbutt";
            this.recbutt.Size = new System.Drawing.Size(1217, 630);
            this.recbutt.TabIndex = 4;
            // 
            // datarectbl
            // 
            this.datarectbl.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.datarectbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datarectbl.Location = new System.Drawing.Point(68, 85);
            this.datarectbl.Name = "datarectbl";
            this.datarectbl.RowHeadersWidth = 51;
            this.datarectbl.RowTemplate.Height = 24;
            this.datarectbl.Size = new System.Drawing.Size(1080, 519);
            this.datarectbl.TabIndex = 0;
            // 
            // recsearchbox
            // 
            this.recsearchbox.BackColor = System.Drawing.Color.Transparent;
            this.recsearchbox.BaseColor = System.Drawing.Color.White;
            this.recsearchbox.BorderColor = System.Drawing.Color.Silver;
            this.recsearchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recsearchbox.FocusedBaseColor = System.Drawing.Color.White;
            this.recsearchbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.recsearchbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.recsearchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recsearchbox.Location = new System.Drawing.Point(429, 25);
            this.recsearchbox.Name = "recsearchbox";
            this.recsearchbox.PasswordChar = '\0';
            this.recsearchbox.Radius = 5;
            this.recsearchbox.SelectedText = "";
            this.recsearchbox.Size = new System.Drawing.Size(325, 43);
            this.recsearchbox.TabIndex = 1;
            // 
            // searchbtn
            // 
            this.searchbtn.AnimationHoverSpeed = 0.07F;
            this.searchbtn.AnimationSpeed = 0.03F;
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchbtn.BorderColor = System.Drawing.Color.Blue;
            this.searchbtn.BorderSize = 1;
            this.searchbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchbtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchbtn.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Image = null;
            this.searchbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchbtn.Location = new System.Drawing.Point(778, 25);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.searchbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchbtn.OnHoverImage = null;
            this.searchbtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchbtn.Radius = 5;
            this.searchbtn.Size = new System.Drawing.Size(115, 42);
            this.searchbtn.TabIndex = 15;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 700);
            this.Controls.Add(this.recbutt);
            this.Controls.Add(this.receiptcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1217, 700);
            this.Name = "recform";
            this.Text = "recform";
            this.receiptcon.ResumeLayout(false);
            this.receiptcon.PerformLayout();
            this.recbutt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datarectbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel receiptcon;
        private Guna.UI.WinForms.GunaLabel recontxt;
        private System.Windows.Forms.Panel recbutt;
        private System.Windows.Forms.DataGridView datarectbl;
        private Guna.UI.WinForms.GunaTextBox recsearchbox;
        private Guna.UI.WinForms.GunaButton searchbtn;
    }
}