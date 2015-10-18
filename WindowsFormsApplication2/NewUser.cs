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
    public partial class NewUser : Form
    {
        private bool nonNumberEntered = false;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd;
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into LogIn values(@a,@b,@c,@d)", con);
                cmd.Parameters.AddWithValue("@a", txtUserName.Text);
                cmd.Parameters.AddWithValue("@b", txtPassword.Text);
                cmd.Parameters.AddWithValue("@c", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@d", System.DateTime.Today);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show("Welcome! You are Registered");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    con.Close();
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Fill Required Feilds");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
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
