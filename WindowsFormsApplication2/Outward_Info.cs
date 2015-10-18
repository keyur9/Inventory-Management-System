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
    public partial class Outward_Info : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Outward_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Outward o = new Outward();
            o.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (cbSearch.Text != "")
                {
                    if (cbSearch.Text.ToString() == "Material Name")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SqlDataAdapter("Select Outward.Date,Outward.Quantity, Unit.QuantityType FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID  where MaterialInfo.MaterialName like '" + txtSearch.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Requested Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "Quantity")
                    {
                        if (mtbFrom.Text == "" && mtbTo.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SqlDataAdapter("Select Outward.Date, MaterialInfo.MaterialName,Outward.Quantity, Unit.QuantityType FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID where Outward.Quantity > '" + mtbFrom.Text + "' AND Outward.Quantity < '" + mtbTo.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No records exist within Quantity Range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "Quantity Type")
                    {
                        if (txtSearch.Text == "")
                        {
                            MessageBox.Show("Empty Search Feild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SqlDataAdapter("Select Outward.Date, MaterialInfo.MaterialName, Outward.Quantity FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID where Unit.QuantityType like '" + txtSearch.Text + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Quantity Type does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else if (cbSearch.Text.ToString() == "Date")
                    {
                        if (dtpFrom.Value.Date > System.DateTime.Today)
                        {
                            MessageBox.Show("Invalid Selected Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            ds.Clear();
                            da = new SqlDataAdapter("Select Outward.Date, MaterialInfo.MaterialName,Outward.Quantity, Unit.QuantityType FROM Outward INNER JOIN Unit ON Outward.UnitID = Unit.UnitID INNER JOIN MaterialInfo ON Outward.MaterialID = MaterialInfo.MaterialID where Outward.Date > '" + dtpFrom.Value.Date + "' AND Outward.Date <= '" + dtpTo.Value.Date + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No records exist within Specified Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Items to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            finally
            {
                con.Close();
            }

        }

        private void Outward_Info_Load(object sender, EventArgs e)
        {
            mtbTo.Hide();
            mtbFrom.Hide();
            txtSearch.Show();
            dtpFrom.Hide();
            dtpTo.Hide();
            label3.Hide();   
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
            if (cbSearch.Text.ToString() == "Quantity")
            {
                txtSearch.Hide();
                mtbFrom.Show();
                mtbTo.Show();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Show();
            }
            else if (cbSearch.Text.ToString() == "Quantity Type")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                label3.Hide();
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT QuantityType FROM Unit WHERE QuantityType LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["QuantityType"].ToString());
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
            else if (cbSearch.Text.ToString() == "Material Name")
            {
                txtSearch.Show();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Hide();
                dtpFrom.Hide();
                dtpTo.Hide();
                txtSearch.Text = "";
                ds.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader dReader;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MaterialName FROM MaterialInfo WHERE MaterialName LIKE '" + txtSearch.Text + "%'";
                con.Open();
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["MaterialName"].ToString());
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
            else if (cbSearch.Text.ToString() == "Date")
            {
                dtpFrom.Show();
                dtpTo.Show();
                txtSearch.Hide();
                mtbFrom.Hide();
                mtbTo.Hide();
                label3.Show();
            }
        }

        private void Outward_Info_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
