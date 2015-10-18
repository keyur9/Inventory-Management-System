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
    public partial class Material : Form
    {
        private bool nonNumberEntered = false;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd;
        string res;
        public Material()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into MaterialInfo(MaterialName,Department,Make,Model) values(@b,@c,@d,@e)", con);
                cmd.Parameters.AddWithValue("@b", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@d", txtMake.Text);
                cmd.Parameters.AddWithValue("@e", txtModel.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Select MaterialID from MaterialInfo", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            res = dr[0].ToString();
                        }
                    }
                    MessageBox.Show("Material Unique Number" + ":" + "" + "" + res, "Material Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtName.Text = "";
                    txtDepartment.Text = "";
                    txtMake.Text = "";
                    txtModel.Text = "";
                    con.Close();
                }
                Material m = new Material();
                m.Show(); 
            }
            else
            {
                MessageBox.Show("Fill Required Feilds","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into MaterialInfo(MaterialName,Department,Make,Model) values(@b,@c,@d,@e)", con);
                cmd.Parameters.AddWithValue("@b", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@d", txtMake.Text);
                cmd.Parameters.AddWithValue("@e", txtModel.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Select MaterialID from MaterialInfo", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            res = dr[0].ToString();
                        }
                    }
                    MessageBox.Show("Material Unique Number" + ":" + "" + "" + res, "Material Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    txtName.Text = "";
                    txtDepartment.Text = "";
                    txtMake.Text = "";
                    txtModel.Text = "";
                    con.Close();
                }
                this.Dispose(true);
            }

            else
            {
                MessageBox.Show("Fill Required Feilds", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void Material_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtMake_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDepartment_KeyDown(object sender, KeyEventArgs e)
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

        private void txtMake_KeyDown(object sender, KeyEventArgs e)
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
