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
    public partial class Vendor_Info : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Vendor_Info()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendor v = new Vendor();
            v.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text != "")
            {
                if (cbSearch.Text.ToString() == "VendorName")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select Address,City,State,ContactNo,OfficeNo,EmailID FROM Vendor where VendorName like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested Person not found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "Address")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select VendorName,City,State,ContactNo,OfficeNo,EmailID FROM Vendor where Address like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested Address cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "City")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select VendorName,Address,State,ContactNo,OfficeNo,EmailID FROM Vendor where City like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested City cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "State")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select VendorName,Address,City,ContactNo,OfficeNo,EmailID FROM Vendor where State like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested State cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }

                if (cbSearch.Text.ToString() == "ContactNo")
                {
                    if (mtbSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select VendorName,Address,City,State,OfficeNo,EmailID FROM Vendor where ContactNo like '" + mtbSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested ContactNo cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "OfficeNo")
                {
                    if (mtbSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select VendorName,ContactPerson,Address,City,State,ContactNo,EmailID FROM Vendor where OfficeNo like '" + mtbSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested OfficeNo cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                if (cbSearch.Text.ToString() == "EmailID")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select VendorName,Address,City,State,ContactNo,OfficeNo FROM Vendor where EmailID like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested EmailID cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Items to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            //try
            //{
            //    if (txtSearch.Text != "")
            //    {
            //        ds.Clear();
            //        con.Open();
            //        da = new SqlDataAdapter("Select VendorName,Address,City,State,ContactNo,OfficeNo,EmailID from Vendor where VendorName like '" + txtSearch.Text + "'", con);
            //        da.Fill(ds);
            //        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //        {
            //            dataGridView1.DataSource = ds.Tables[0]; 
            //        }
            //        else
            //        {
            //            MessageBox.Show("Requested Vendor does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Enter VendorName", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            //    }
            //}
            //finally
            //{
            //    con.Close();
            //    txtSearch.Text = "";
            //}
        }

        private void Vendor_Info_Load(object sender, EventArgs e)
        {
            mtbSearch.Hide();
            txtSearch.Show();
        }

        private void Vendor_Info_FormClosing(object sender, FormClosingEventArgs e)
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
            updelvendor udv = new updelvendor();
            udv.Show();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
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

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.ToString() == "VendorName")
            {
                txtSearch.Show();
                mtbSearch.Hide();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT VendorName FROM Vendor WHERE VendorName LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["VendorName"].ToString());
                }
                else
                {
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "City")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT City FROM Vendor WHERE City LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["City"].ToString());
                }
                else
                {
                    namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "State")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT State FROM Vendor WHERE State LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["State"].ToString());
                }
                else
                {
                    namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "Address")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Address FROM Vendor WHERE Address LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["Address"].ToString());
                }
                else
                {
                    namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "EmailID")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT EmailID FROM Vendor WHERE EmailID LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["EmailID"].ToString());
                }
                else
                {
                    namesCollection.Add(dReader["No record found"].ToString());
                }
                dReader.Close();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = namesCollection;
                con.Close();
            }
            else if (cbSearch.Text.ToString() == "ContactNo")
            {
                mtbSearch.Show();
                txtSearch.Hide();
                txtSearch.Text = "";
                ds.Clear();
                mtbSearch.Text = "";
            }
            else if (cbSearch.Text.ToString() == "OfficeNo")
            {
                mtbSearch.Show();
                txtSearch.Hide();
                txtSearch.Text = "";
                ds.Clear();
                mtbSearch.Text = "";
            }
        }
    }
}
