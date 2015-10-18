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
    public partial class Inward : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        public Inward()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbMaterial.Text == "" || mtbQuantity.Text == ""||cbVendor.Text=="")
            {
                MessageBox.Show("Enter The Value in Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (dateTimePicker1.Value.Date != System.DateTime.Today)
                {
                    MessageBox.Show("Wrong data Selected", "InAppropriate Date", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    SqlDataReader dReader;

                    con.Open();
                        cmd = new SqlCommand("Insert into Inward(Date,MaterialID,Quantity,UnitID,VendorID) values(@a,@b,@c,@d,@e)", con);
                        cmd.Parameters.AddWithValue("@a", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@b", cbMaterial.SelectedValue);
                        cmd.Parameters.AddWithValue("@c", mtbQuantity.Text);
                        cmd.Parameters.AddWithValue("@d", cbUnit.SelectedValue);
                        cmd.Parameters.AddWithValue("@e", cbVendor.SelectedValue);

                        try
                        {
                            int r = cmd.ExecuteNonQuery();
                            MessageBox.Show("Inward Entry", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataSet ds = new DataSet();
                            SqlDataAdapter da = new SqlDataAdapter("Select MaterialID from Temp where MaterialID like '" + cbMaterial.SelectedValue + "'", con);
                            da.Fill(ds);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                ds.Clear();
                                SqlDataAdapter sda = new SqlDataAdapter("Select Quantity from Temp where MaterialID like '" + cbMaterial.SelectedValue + "' ", con);
                                DataSet ds1 = new DataSet();
                                sda.Fill(ds1);
                                textBox1.Text = ds1.Tables[0].Rows[0][0].ToString();
                                int a = Convert.ToInt32(textBox1.Text);
                                int b = Convert.ToInt32(mtbQuantity.Text);
                                int c = a + b;
                                textBox1.Text = c.ToString();
                                cmd = new SqlCommand("UPDATE Temp SET Quantity='" + textBox1.Text + "' WHERE MaterialID='" + cbMaterial.SelectedValue + "'", con);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd = new SqlCommand("Insert into Temp(MaterialID,Quantity) values(@a,@b)", con);
                                cmd.Parameters.AddWithValue("@a", cbMaterial.SelectedValue);
                                cmd.Parameters.AddWithValue("@b", mtbQuantity.Text);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                        finally
                        {
                            cbMaterial.Text = "";
                            mtbQuantity.Text = "";
                            cbVendor.Text = "";
                            cbUnit.Text = "";
                        }
                    }
                        con.Close();
            }
        }

        private void Inward_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iMSDataSet.MaterialInfo' table. You can move, or remove it, as needed.
            this.materialInfoTableAdapter.Fill(this.iMSDataSet.MaterialInfo);
            // TODO: This line of code loads data into the 'iMSDataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.iMSDataSet.Vendor);
            // TODO: This line of code loads data into the 'iMSDataSet.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.iMSDataSet.Unit);
        }
        private void txtMaterial_KeyDown(object sender, KeyEventArgs e)
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

        private void txtMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }
    }
}
