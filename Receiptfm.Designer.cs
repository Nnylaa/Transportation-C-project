namespace Transportation_Project
{
    partial class Receiptfm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receiptfm));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.bookingid = new Guna.UI.WinForms.GunaLabel();
            this.direction = new Guna.UI.WinForms.GunaLabel();
            this.directiontxt = new Guna.UI.WinForms.GunaLabel();
            this.Date = new Guna.UI.WinForms.GunaLabel();
            this.Departure = new Guna.UI.WinForms.GunaLabel();
            this.datetxt = new Guna.UI.WinForms.GunaLabel();
            this.timetxt = new Guna.UI.WinForms.GunaLabel();
            this.Vehicle = new Guna.UI.WinForms.GunaLabel();
            this.vehicletxt = new Guna.UI.WinForms.GunaLabel();
            this.quantity = new Guna.UI.WinForms.GunaLabel();
            this.quantitytxt = new Guna.UI.WinForms.GunaLabel();
            this.Seattxt = new Guna.UI.WinForms.GunaLabel();
            this.Seat = new Guna.UI.WinForms.GunaLabel();
            this.amounttxt = new Guna.UI.WinForms.GunaLabel();
            this.payment = new Guna.UI.WinForms.GunaLabel();
            this.contacttxt = new Guna.UI.WinForms.GunaLabel();
            this.Contact = new Guna.UI.WinForms.GunaLabel();
            this.note1 = new Guna.UI.WinForms.GunaLabel();
            this.Note = new Guna.UI.WinForms.GunaLabel();
            this.note2 = new Guna.UI.WinForms.GunaLabel();
            this.payme = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(136, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(77, 72);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // bookingid
            // 
            this.bookingid.AutoSize = true;
            this.bookingid.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingid.Location = new System.Drawing.Point(253, 97);
            this.bookingid.Name = "bookingid";
            this.bookingid.Size = new System.Drawing.Size(97, 20);
            this.bookingid.TabIndex = 1;
            this.bookingid.Text = "BookingID";
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction.Location = new System.Drawing.Point(12, 128);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(86, 20);
            this.direction.TabIndex = 2;
            this.direction.Text = "Direction";
            // 
            // directiontxt
            // 
            this.directiontxt.AutoSize = true;
            this.directiontxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directiontxt.Location = new System.Drawing.Point(227, 128);
            this.directiontxt.Name = "directiontxt";
            this.directiontxt.Size = new System.Drawing.Size(123, 20);
            this.directiontxt.TabIndex = 3;
            this.directiontxt.Text = "Direction name";
            this.directiontxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(12, 204);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 20);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            // 
            // Departure
            // 
            this.Departure.AutoSize = true;
            this.Departure.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departure.Location = new System.Drawing.Point(257, 204);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(93, 20);
            this.Departure.TabIndex = 5;
            this.Departure.Text = "Departure";
            this.Departure.Click += new System.EventHandler(this.Departure_Click);
            // 
            // datetxt
            // 
            this.datetxt.AutoSize = true;
            this.datetxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Location = new System.Drawing.Point(12, 233);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(90, 20);
            this.datetxt.TabIndex = 6;
            this.datetxt.Text = "Date name";
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetxt.Location = new System.Drawing.Point(303, 233);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(47, 20);
            this.timetxt.TabIndex = 7;
            this.timetxt.Text = "Time";
            this.timetxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Vehicle
            // 
            this.Vehicle.AutoSize = true;
            this.Vehicle.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle.Location = new System.Drawing.Point(12, 168);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(113, 20);
            this.Vehicle.TabIndex = 8;
            this.Vehicle.Text = "Vehicle type";
            this.Vehicle.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // vehicletxt
            // 
            this.vehicletxt.AutoSize = true;
            this.vehicletxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicletxt.Location = new System.Drawing.Point(261, 168);
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(89, 20);
            this.vehicletxt.TabIndex = 9;
            this.vehicletxt.Text = "VIP or Bus";
            this.vehicletxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(12, 269);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(80, 20);
            this.quantity.TabIndex = 10;
            this.quantity.Text = "Quantity";
            // 
            // quantitytxt
            // 
            this.quantitytxt.AutoSize = true;
            this.quantitytxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(213, 269);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(137, 20);
            this.quantitytxt.TabIndex = 11;
            this.quantitytxt.Text = "Quantity Number";
            this.quantitytxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Seattxt
            // 
            this.Seattxt.AutoSize = true;
            this.Seattxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seattxt.Location = new System.Drawing.Point(242, 303);
            this.Seattxt.Name = "Seattxt";
            this.Seattxt.Size = new System.Drawing.Size(108, 20);
            this.Seattxt.TabIndex = 13;
            this.Seattxt.Text = "Seat Number";
            this.Seattxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Seat
            // 
            this.Seat.AutoSize = true;
            this.Seat.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seat.Location = new System.Drawing.Point(12, 303);
            this.Seat.Name = "Seat";
            this.Seat.Size = new System.Drawing.Size(47, 20);
            this.Seat.TabIndex = 12;
            this.Seat.Text = "Seat";
            // 
            // amounttxt
            // 
            this.amounttxt.AutoSize = true;
            this.amounttxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxt.Location = new System.Drawing.Point(303, 339);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(44, 20);
            this.amounttxt.TabIndex = 15;
            this.amounttxt.Text = "total";
            this.amounttxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(12, 339);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 20);
            this.payment.TabIndex = 14;
            this.payment.Text = "Amount";
            // 
            // contacttxt
            // 
            this.contacttxt.AutoSize = true;
            this.contacttxt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacttxt.Location = new System.Drawing.Point(225, 403);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(122, 20);
            this.contacttxt.TabIndex = 17;
            this.contacttxt.Text = "Phone Number";
            this.contacttxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contacttxt.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(12, 403);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(76, 20);
            this.Contact.TabIndex = 16;
            this.Contact.Text = "Contact";
            this.Contact.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1.Location = new System.Drawing.Point(85, 471);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(190, 30);
            this.note1.TabIndex = 19;
            this.note1.Text = "1. Passenger don\'t come on time\r\n    the ticket are worthless.";
            this.note1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.note1.Click += new System.EventHandler(this.gunaLabel1_Click_2);
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(155, 441);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(61, 18);
            this.Note.TabIndex = 18;
            this.Note.Text = "Note**";
            // 
            // note2
            // 
            this.note2.AutoSize = true;
            this.note2.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note2.Location = new System.Drawing.Point(85, 511);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(184, 15);
            this.note2.TabIndex = 20;
            this.note2.Text = "2. Ticket sold is non refundable";
            this.note2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payme
            // 
            this.payme.AutoSize = true;
            this.payme.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payme.Location = new System.Drawing.Point(262, 372);
            this.payme.Name = "payme";
            this.payme.Size = new System.Drawing.Size(88, 20);
            this.payme.TabIndex = 22;
            this.payme.Text = "ABA or AC";
            this.payme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 372);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(153, 20);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "Payment method";
            // 
            // Receiptfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 555);
            this.Controls.Add(this.payme);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.Seattxt);
            this.Controls.Add(this.Seat);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.vehicletxt);
            this.Controls.Add(this.Vehicle);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.directiontxt);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.bookingid);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(362, 555);
            this.Name = "Receiptfm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel bookingid;
        private Guna.UI.WinForms.GunaLabel direction;
        private Guna.UI.WinForms.GunaLabel directiontxt;
        private Guna.UI.WinForms.GunaLabel Date;
        private Guna.UI.WinForms.GunaLabel Departure;
        private Guna.UI.WinForms.GunaLabel datetxt;
        private Guna.UI.WinForms.GunaLabel timetxt;
        private Guna.UI.WinForms.GunaLabel Vehicle;
        private Guna.UI.WinForms.GunaLabel vehicletxt;
        private Guna.UI.WinForms.GunaLabel quantity;
        private Guna.UI.WinForms.GunaLabel quantitytxt;
        private Guna.UI.WinForms.GunaLabel Seattxt;
        private Guna.UI.WinForms.GunaLabel Seat;
        private Guna.UI.WinForms.GunaLabel amounttxt;
        private Guna.UI.WinForms.GunaLabel payment;
        private Guna.UI.WinForms.GunaLabel contacttxt;
        private Guna.UI.WinForms.GunaLabel Contact;
        private Guna.UI.WinForms.GunaLabel note1;
        private Guna.UI.WinForms.GunaLabel Note;
        private Guna.UI.WinForms.GunaLabel note2;
        private Guna.UI.WinForms.GunaLabel payme;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}