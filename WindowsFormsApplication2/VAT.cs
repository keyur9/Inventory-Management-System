using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class VAT : Form
    {
        private bool nonNumberEntered = false;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd;
        //int flag;

        public VAT()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int flag = 1;
            if (txtState.Text == "" || mtbPercentage.Text == "")
                {
                MessageBox.Show("Enter The value","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                flag = 0;
                }
            else if (txtState.Text!="")
            {
            cmd = new SqlCommand("Select State from MasterTable", con);
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (txtState.Text == dr[0].ToString())
                    {
                        MessageBox.Show("Already exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        flag = 0;
                    }
                    //con.Close();
                }
               dr.Close();                
            }
            
            }
            if(flag!=0)
            {
                
                //con.Open();
                cmd = new SqlCommand("Insert into MasterTable values(@a,@b)", con);
                cmd.Parameters.AddWithValue("@a", txtState.Text);
                cmd.Parameters.AddWithValue("@b", mtbPercentage.Text);
                try
                {
                    //con.Open();
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    
                    txtState.Text = "";
                    mtbPercentage.Text = "";
                }

            }
            con.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtState.Text != "" && mtbPercentage.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("UPDATE MasterTable SET VAT='" + mtbPercentage.Text + "' WHERE State='" + txtState.Text + "'", con);

                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //btnSave.Enabled = false;
                        txtState.Text = "";
                        mtbPercentage.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No Record Updated", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtState.Text = "";
                        //btnUpdate.Enabled = false;
                        mtbPercentage.Text = "";
                    }
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VAT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            } 
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtState_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    nonNumberEntered = true;
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
    }
}
