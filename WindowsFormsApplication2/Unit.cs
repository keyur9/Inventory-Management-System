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
    public partial class Unit : Form
    {
        private bool nonNumberEntered = false;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd;
        public Unit()
        {
            InitializeComponent();
        }

        private void Unit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtUnit.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Unit(QuantityType) values(@b)", con);
                cmd.Parameters.AddWithValue("@b", txtUnit.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("Material Unit Added Succesfully", "Unit Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtUnit.Text = "";
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            Unit u = new Unit();
            u.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (txtUnit.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Unit(QuantityType) values(@b)", con);
                cmd.Parameters.AddWithValue("@b", txtUnit.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("Material Unit Added Succesfully", "Unit Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtUnit.Text = "";
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            this.Dispose(true);
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtUnit_KeyDown(object sender, KeyEventArgs e)
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
