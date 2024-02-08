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
    public partial class Vehicletypefm : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.dbConnection);
        SqlCommand cm = new SqlCommand();
        public Vehicletypefm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (savebtn.Text == "Update" && ID.Text != "0")
            {
                UpdateProduct();
                GetProduct();
                ClearallText();
            }
            else
            {
                AddProduct();
                GetProduct();
                ClearallText();

            }
        }
        private void AddProduct()
        {
            string sql = "INSERT INTO TblVehicle (LicensePlate,Model,VehicleType,Color) VALUES (@VeType,@Model,@LiPlate,@Color)";
            cm = new SqlCommand(sql, cn);
            cm.Parameters.AddWithValue("@VeType", vehiclebox.Text);
            cm.Parameters.AddWithValue("@Model", modelboc.Text);
            cm.Parameters.AddWithValue("@LiPlate", licensebo.Text);
            cm.Parameters.AddWithValue("@Color", colorbo.Text);
      

            try
            {
                cn.Open();
                cm.ExecuteNonQuery(); // Execute the SQL command to insert data
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void UpdateProduct()
        {
            string sql = "UPDATE TblVehicle SET VehicleType=@VeType, Model=@Model, LicensePlate=@LiPlate, Color=@Color WHERE VehicleID=@id";
            cm = new SqlCommand(sql, cn);
            cm.Parameters.AddWithValue("@VeType", vehiclebox.Text);
            cm.Parameters.AddWithValue("@Model", modelboc.Text);
            cm.Parameters.AddWithValue("@LiPlate", licensebo.Text);
            cm.Parameters.AddWithValue("@Color", colorbo.Text);
            cm.Parameters.AddWithValue("@id", ID.Text); // Assuming ID is the primary key for TblVehicle
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

       private void DeleteProduct()
{
    string sql = "DELETE FROM TblVehicle WHERE VehicleID=@id";
    cm = new SqlCommand(sql, cn);
    cm.Parameters.AddWithValue("@id", ID.Text);
    cn.Open();
    cm.ExecuteNonQuery();
    cn.Close();
}


        private void GetProduct()
        {
            string sql = "SELECT * FROM TblVehicle";
            cm = new SqlCommand(sql, cn);
            var da = new SqlDataAdapter(cm);
            var dt = new DataTable();
            cn.Open();
            da.Fill(dt);
            cn.Close();
            datavehicletbl.DataSource = dt;
        }
        private void ClearallText()
        {
            vehiclebox.Text = "";
            modelboc.Text = "";
            licensebo.Text = "";
            colorbo.Text = "";
            ID.Text = "0";
            savebtn.Text = "Update";
        }

        private void modelboc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
