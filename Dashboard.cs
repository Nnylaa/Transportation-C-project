using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String name, String pass)
        {
            InitializeComponent();
            if (pass == "admin") {
                btnBooking.Visible = true;
                btnPassenger.Visible = true;
                btnDriver.Visible = true;
                btnVehicle.Visible = true;
                btnReceipt.Visible = true;

            }else 
            {
                btnBooking.Visible = true;
                btnPassenger.Visible = true;
                btnDriver.Visible = true;   
                btnVehicle.Visible = true;
                btnReceipt.Visible = false;
            }
           

        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            Show.Controls.Clear();
            passengerFm passfm = new passengerFm();
            passfm.TopLevel = false;
            //form4.TopMost = true;
            Show.Controls.Add(passfm);
            passfm.Show();
        }

     

        private void Bookingbtn_Click(object sender, EventArgs e)
        {
            Show.Controls.Clear();
            FmBooking fmbooking = new FmBooking();
            fmbooking.TopLevel = false;
            //form4.TopMost = true;
            Show.Controls.Add(fmbooking);
            fmbooking.Show();
        }

       

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            Show.Controls.Clear();
            Vehicletypefm fmvehicle = new Vehicletypefm();
            fmvehicle.TopLevel = false;
            //form4.TopMost = true;
            Show.Controls.Add(fmvehicle);
            fmvehicle.Show();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            Show.Controls.Clear();
            recform fmre = new recform();
            fmre.TopLevel = false;
            //form4.TopMost = true;
            Show.Controls.Add(fmre);
            fmre.Show();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            Show.Controls.Clear();
            DriverFm drivefm = new DriverFm();
            drivefm.TopLevel = false;
            //form4.TopMost = true;
            Show.Controls.Add(drivefm);
            drivefm.Show();
        }

       
    }
}