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
    public partial class Customer_Info : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Customer_Info()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text != "")
            {
                if (cbSearch.Text.ToString() == "ContactPerson")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select CompanyName,Address,City,State,ContactNo,OfficeNo,EmailID FROM CustomerInfo where ContactPerson like '" + txtSearch.Text + "'", con);
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
                if (cbSearch.Text.ToString() == "CompanyName")
                {
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ds.Clear();
                        da = new SqlDataAdapter("Select ContactPerson,Address,City,State,ContactNo,OfficeNo,EmailID FROM CustomerInfo where CompanyName like '" + txtSearch.Text + "'", con);
                        da.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Requested Company Name cannot be found", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                        da = new SqlDataAdapter("Select CompanyName,ContactPerson,City,State,ContactNo,OfficeNo,EmailID FROM CustomerInfo where Address like '" + txtSearch.Text + "'", con);
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
                        da = new SqlDataAdapter("Select CompanyName,ContactPerson,Address,State,ContactNo,OfficeNo,EmailID FROM CustomerInfo where City like '" + txtSearch.Text + "'", con);
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
                        da = new SqlDataAdapter("Select CompanyName,ContactPerson,Address,City,ContactNo,OfficeNo,EmailID FROM CustomerInfo where State like '" + txtSearch.Text + "'", con);
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
                        da = new SqlDataAdapter("Select CompanyName,ContactPerson,Address,City,State,OfficeNo,EmailID FROM CustomerInfo where ContactNo like '" + mtbSearch.Text + "'", con);
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
                        da = new SqlDataAdapter("Select CompanyName,ContactPerson,Address,City,State,ContactNo,EmailID FROM CustomerInfo where OfficeNo like '" + mtbSearch.Text + "'", con);
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
                        da = new SqlDataAdapter("Select CompanyName,ContactPerson,Address,City,State,ContactNo,OfficeNo FROM CustomerInfo where EmailID like '" + txtSearch.Text + "'", con);
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
       
        private void Customer_Info_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Customer_Info_Load(object sender, EventArgs e)
        {
            mtbSearch.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updel ud = new updel();
            ud.Show();
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

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.ToString() == "CompanyName")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT CompanyName FROM CustomerInfo WHERE CompanyName LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["CompanyName"].ToString());
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
            else if (cbSearch.Text.ToString() == "ContactPerson")
            {
                mtbSearch.Hide();
                txtSearch.Show();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ContactPerson FROM CustomerInfo WHERE ContactPerson LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["ContactPerson"].ToString());
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
                cmd.CommandText = "SELECT City FROM CustomerInfo WHERE City LIKE '" + txtSearch.Text + "%'";
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
                cmd.CommandText = "SELECT State FROM CustomerInfo WHERE State LIKE '" + txtSearch.Text + "%'";
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
                cmd.CommandText = "SELECT Address FROM CustomerInfo WHERE Address LIKE '" + txtSearch.Text + "%'";
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
                cmd.CommandText = "SELECT EmailID FROM CustomerInfo WHERE EmailID LIKE '" + txtSearch.Text + "%'";
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
