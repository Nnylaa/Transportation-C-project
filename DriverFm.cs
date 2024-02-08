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
    public partial class DriverFm : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.dbConnection);
        SqlCommand com = new SqlCommand();
        public DriverFm()
        {
            InitializeComponent();
        }
      

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(btnsave.Text =="Update" && lblDriverID.Text != "0")
            {
                UpdateDriver();
                GetRecord();
                ClearText();

            }
            else
            {
                AddDriver();
                GetRecord();
                ClearText();
            }
        }

        //Function Add data
        private void AddDriver()
        {
            String sql = "Insert into TblDriver (DriverName,DriverNumber) Values(@D_Name,@D_Number )";
            com = new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@D_Name", txtDriverName.Text);
            com.Parameters.AddWithValue("@D_Number", txtDriverPhone.Text);
            con.Open();
            com.ExecuteNonQuery();  
            con.Close();
        }

        //Function Update
        private void UpdateDriver()
        {
            String sql = "Update TblDriver set DriverName = @D_Name , DriverPhone = @D_Number where DriverID = @id";
            com = new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@D_Name",txtDriverName.Text);
            com.Parameters.AddWithValue("@D_Number",txtDriverPhone.Text);
            com.Parameters.AddWithValue("@id",lblDriverID.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        
        //Function Delete

        private void DeleteDriver()
        {
            String sql = "Delete TblDriver where DriverID = @id";
            com = new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@id",lblDriverID.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        private void GetRecord()
        {
            String sql = "select * from TblDriver";
            com = new SqlCommand(sql,con);
            var da = new SqlDataAdapter(com);
            var dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close() ;
            dataGridViewDriver.DataSource = dt;
        }
        private void ClearText()
        {
            txtDriverName.Text = "";
            txtDriverPhone.Text = "";
            lblDriverID.Text = "0";
            txtDriverName.Focus();
            btnsave.Text = "AddDriver";
        
        }

        private void DriverFm_Load(object sender, EventArgs e)
        {
            GetRecord();
           
        }

        private void dataGridViewDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                {
                if (dataGridViewDriver.Columns[e.ColumnIndex].Index == 0)
                {

                    var msg = MessageBox.Show("Do you wanna delete the record !", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        DeleteDriver();
                        ClearText();
                        GetRecord();
                    }

                }
                else
                {
                    lblDriverID.Text = dataGridViewDriver.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtDriverName.Text = dataGridViewDriver.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtDriverPhone.Text = dataGridViewDriver.Rows[e.RowIndex].Cells[2].Value.ToString();
                    btnsave.Text = "UpdateDriver";
                }
            }



        }

        //private void dataGridViewDriver_DoubleClick(object sender, EventArgs e)
        //{
        //    //if (e.RowIndex >= 0)
        //    //{
        //    //    if (dataGridViewDriver.Columns[e.ColumnIndex].Index)
        //    //    {
        //    //        var msg = MessageBox.Show("Do you wanna delete the record !", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    //        if (msg == DialogResult.Yes)
        //    //        {
        //    //            DeleteDriver();
        //    //            ClearText();
        //    //            GetRecord();
        //    //        }

        //    //    }
        //    //    else
        //    //    {
        //    //        lblDriverID.Text = dataGridViewDriver.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    //        txtDriverName.Text = dataGridViewDriver.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    //        txtDriverPhone.Text = dataGridViewDriver.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    //        btnsave.Text = "Update";

        //    //    }
        //    //}

        
  
        //        //DataGridView grid = (DataGridView)sender;

        //        //if (grid.CurrentRow != null)
        //        //{
        //        //    int rowIndex = grid.CurrentRow.Index;

        //        //    if (grid.Columns[grid.CurrentCell.ColumnIndex].Index  == 0 ) // Replace "YourColumnName" with the actual column name
        //        //    {
        //        //        var msg = MessageBox.Show("Do you want to delete the record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        //        if (msg == DialogResult.Yes)
        //        //        {
        //        //            DeleteDriver();
        //        //            ClearText();
        //        //            GetRecord();
        //        //        }
        //        //    }
                    
        //        //}
            }

        }
    