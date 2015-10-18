using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    
    public partial class Customer : Form
    {
        private bool nonNumberEntered = false;
         
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd;
        string res;
        public Customer()
        {
            InitializeComponent();
            
        }
        Validate_textbox vt = new Validate_textbox();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCntctPerson.Text == ""  || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill the data correctly", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbOffice.Text != "" || mtbContact.Text != "")
                {
                    if (mtbOffice.Text.Length < 10 && mtbContact.Text.Length < 10)
                    {
                        MessageBox.Show("Incorrect No.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {

                        string valid;
                        Regex strregex = new Regex("([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})");

                        valid = txtEmail.Text;

                        if (strregex.IsMatch(valid))
                        {
                            con.Open();
                            cmd = new SqlCommand("Insert into CustomerInfo(CompanyName,ContactPerson,Address,City,State,ContactNo,OfficeNo,EmailID) values(@b,@c,@d,@e,@f,@g,@h,@i)", con);
                            cmd.Parameters.AddWithValue("@b", txtCmpnyName.Text);
                            cmd.Parameters.AddWithValue("@c", txtCntctPerson.Text);
                            cmd.Parameters.AddWithValue("@d", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@e", txtCity.Text);
                            cmd.Parameters.AddWithValue("@f", txtState.Text);
                            cmd.Parameters.AddWithValue("@g", mtbContact.Text);
                            cmd.Parameters.AddWithValue("@h", mtbOffice.Text);
                            cmd.Parameters.AddWithValue("@i", txtEmail.Text);

                            try
                            {
                                int r = cmd.ExecuteNonQuery();
                                cmd = new SqlCommand("Select CustomerID from CustomerInfo", con);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        res = dr[0].ToString();
                                    }
                                }
                                dr.Close();
                             MessageBox.Show("Customer Unique Number" + ":" + "" + "" + res, "Contact Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }

                            finally
                            {
                                txtCmpnyName.Text = "";
                                txtCntctPerson.Text = "";
                                txtAddress.Text = "";
                                txtCity.Text = "";
                                txtState.Text = "";
                                txtEmail.Text = "";
                                mtbContact.Text = "";
                                mtbOffice.Text = "";
                                con.Close();
                            }

                        }
                        else if (!strregex.IsMatch(valid))
                        {
                            MessageBox.Show("Incorrect Email", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    Customer c = new Customer();
                    c.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCntctPerson.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbOffice.Text != "" || mtbContact.Text != "")
                {
                    if (mtbOffice.Text.Length < 10 && mtbContact.Text.Length < 10)
                    {
                        MessageBox.Show("Incorrect No.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {

                        string valid;
                        Regex strregex = new Regex("([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})");

                        valid = txtEmail.Text;

                        if (strregex.IsMatch(valid))
                        {
                            con.Open();
                            cmd = new SqlCommand("Insert into CustomerInfo(CompanyName,ContactPerson,Address,City,State,ContactNo,OfficeNo,EmailID) values(@b,@c,@d,@e,@f,@g,@h,@i)", con);
                            cmd.Parameters.AddWithValue("@b", txtCmpnyName.Text);
                            cmd.Parameters.AddWithValue("@c", txtCntctPerson.Text);
                            cmd.Parameters.AddWithValue("@d", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@e", txtCity.Text);
                            cmd.Parameters.AddWithValue("@f", txtState.Text);
                            cmd.Parameters.AddWithValue("@g", mtbContact.Text);
                            cmd.Parameters.AddWithValue("@h", mtbOffice.Text);
                            cmd.Parameters.AddWithValue("@i", txtEmail.Text);

                            try
                            {
                                int r = cmd.ExecuteNonQuery();
                                cmd = new SqlCommand("Select CustomerID from CustomerInfo", con);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        res = dr[0].ToString();
                                    }
                                }

                                MessageBox.Show("Customer Unique Number" + ":" + "" +""+ res, "Contact Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }

                            finally
                            {
                                txtCmpnyName.Text = "";
                                txtCntctPerson.Text = "";
                                txtAddress.Text = "";
                                txtCity.Text = "";
                                txtState.Text = "";
                                txtEmail.Text = "";
                                mtbContact.Text = "";
                                mtbOffice.Text = "";
                                con.Close();
                            }

                        }
                        else if (!strregex.IsMatch(valid))
                        {
                            MessageBox.Show("Incorrect Email", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    this.Dispose(true);
                }
            }            
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updel ud = new updel();
            ud.Show();
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
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
       

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {               
                e.Handled = true;
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

        private void txtCntctPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtCntctPerson_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCmpnyName_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCmpnyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }
        }
    }

