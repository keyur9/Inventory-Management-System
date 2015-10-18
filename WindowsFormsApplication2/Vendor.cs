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
    public partial class Vendor : Form
    {
        private bool nonNumberEntered = false;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd;
        int r;
        string res;

        public Vendor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbMobile.Text != "" || mtbContact.Text != "")
                {
                    if (mtbMobile.Text.Length < 10 && mtbContact.Text.Length < 10)
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
                            cmd = new SqlCommand("Insert into Vendor(VendorName,Address,City,State,ContactNo,MobileNo,EmailID) values(@b,@c,@d,@e,@f,@g,@h)", con);
                            cmd.Parameters.AddWithValue("@b", txtName.Text);
                            cmd.Parameters.AddWithValue("@c", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@d", txtCity.Text);
                            cmd.Parameters.AddWithValue("@e", txtState.Text);
                            cmd.Parameters.AddWithValue("@f", mtbContact.Text);
                            cmd.Parameters.AddWithValue("@g", mtbMobile.Text);
                            cmd.Parameters.AddWithValue("@h", txtEmail.Text);


                            try
                            {
                                r = cmd.ExecuteNonQuery();
                                cmd = new SqlCommand("Select VendorID from Vendor", con);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        res = dr[0].ToString();
                                    }
                                }
                                MessageBox.Show("Vendor Unique Number"+":"+""+""+res, "Succesfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }
                            finally
                            {
                                txtAddress.Text = "";
                                txtCity.Text = "";
                                txtEmail.Text = "";
                                txtName.Text = "";
                                txtState.Text = "";
                                mtbMobile.Text = "";
                                mtbContact.Text = "";
                                con.Close();
                            }
                        }
                        else if (!strregex.IsMatch(valid))
                        {
                            MessageBox.Show("Incorrect Email", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    } 
                    Vendor v = new Vendor();
                    v.Show();
                }
            }            
        }

        private void Vendor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                MessageBox.Show("Fill All the Required Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (mtbMobile.Text != "" || mtbContact.Text != "")
                {
                    if (mtbMobile.Text.Length < 10 && mtbContact.Text.Length < 10)
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
                            cmd = new SqlCommand("Insert into Vendor(VendorName,Address,City,State,ContactNo,MobileNo,EmailID) values(@b,@c,@d,@e,@f,@g,@h)", con);
                            cmd.Parameters.AddWithValue("@b", txtName.Text);
                            cmd.Parameters.AddWithValue("@c", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@d", txtCity.Text);
                            cmd.Parameters.AddWithValue("@e", txtState.Text);
                            cmd.Parameters.AddWithValue("@f", mtbContact.Text);
                            cmd.Parameters.AddWithValue("@g", mtbMobile.Text);
                            cmd.Parameters.AddWithValue("@h", txtEmail.Text);


                            try
                            {
                                r = cmd.ExecuteNonQuery();
                                cmd = new SqlCommand("Select VendorID from Vendor", con);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        res = dr[0].ToString();
                                    }
                                }
                                MessageBox.Show("Vendor Unique Number"+":"+""+""+res, "Succesfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }
                            finally
                            {
                                txtAddress.Text = "";
                                txtCity.Text = "";
                                txtEmail.Text = "";
                                txtName.Text = "";
                                txtState.Text = "";
                                mtbMobile.Text = "";
                                mtbContact.Text = "";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updelvendor udv = new updelvendor();
            udv.Show();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
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
    }
}
