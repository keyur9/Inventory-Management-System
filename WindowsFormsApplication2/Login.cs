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
    public partial class Login : Form
    {
        private bool nonNumberEntered = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UserName,Password " +
            "FROM LogIn " +
            "WHERE UserName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'", con);
            da.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("Invalid UserID/Password", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Successful Login", "Welcome", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                //txtUserName.Text = "";
                //txtPassword.Text = "";
                this.Hide();
                if (txtUserName.Text == "admin")
                {
                    Admin_Home ah = new Admin_Home();
                    ah.Show();
                }
                else
                {
                    Executive_Home eh = new Executive_Home();
                    eh.Show();
                }
            }
            con.Close();

        }

        private void chkpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpwd.Checked == true)
            {
                txtPassword.PasswordChar = '*'; //set passwordchar to '*'
                chkpwd.Text = "Show password"; //change checkbox text to show password
            }
            else
            {
                txtPassword.PasswordChar = (char)0; //reset passwordchar to default
                chkpwd.Text = "Hide password"; //change password to hide password
            }
        }

        private void llChangePwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChngPwd cp = new ChngPwd();
            cp.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
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
