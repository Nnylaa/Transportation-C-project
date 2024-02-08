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
    public partial class FmBooking : Form
    {
        public FmBooking()
        {
            InitializeComponent();
        }

        private void cfmbtn_Click(object sender, EventArgs e)
        {
            recieptshow.Controls.Clear();
            Receiptfm Recfm = new Receiptfm();
            Recfm.TopLevel = false;
            //form4.TopMost = true;
            recieptshow.Controls.Add(Recfm);
            Recfm.Show();
        }

        private void VIPbtn_Click(object sender, EventArgs e)
        {
            seatshow.Controls.Clear();
            VIPfm vipfm = new VIPfm();
            vipfm.TopLevel = false;
            //form4.TopMost = true;
            seatshow.Controls.Add(vipfm);
            vipfm.Show();
        }

        private void BUSbtn_Click(object sender, EventArgs e)
        {
            seatshow.Controls.Clear();
            Busfm busfm = new Busfm();
            busfm.TopLevel = false;
            //form4.TopMost = true;
            seatshow.Controls.Add(busfm);
            busfm.Show();
        }
    }
}
