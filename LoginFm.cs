using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Transportation_Project
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }
        

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.dbConnection);
            String sql = "select * from TblUser where Username = @username and Password =@password ";
            var cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@username", txtUser.Text);
            cm.Parameters.AddWithValue("@password", txtPassword.Text);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            String name = null;
            String pass = null; 
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    name = dr.GetValue(1).ToString();
                    pass = dr.GetValue(2).ToString();
                }
                Dashboard fm = new Dashboard(name,pass);
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","Information",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                
            }
            txtUser.Text = "";
            txtPassword.Text = "";

            con.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            txtPassword.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            txtPassword.PasswordChar = '\0';
        }
    }
}
