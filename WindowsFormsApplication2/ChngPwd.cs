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
    public partial class ChngPwd : Form
    {
        private bool nonNumberEntered = false;
        public ChngPwd()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UserName,Password " +
            "FROM LogIn " +
            "WHERE UserName = '" + txtPassword.Text + "' AND Password = '" + txtUserName.Text + "'", con);
            da.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("Invalid UserID/Password", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                txtNewPwd.Text = "";
                txtCnfrm.Text = "";
                txtUserName.Text = "";

            }
            else
            {
                if (txtNewPwd.Text == "" && txtCnfrm.Text == "")
                {
                    MessageBox.Show("Please Enter New Password", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

                }
                else
                {
                    string a, b;
                    a = txtNewPwd.Text.ToString();
                    b = txtCnfrm.Text.ToString();
                    if (a != b)
                    {
                        MessageBox.Show("New Password are Different", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Stop);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("UPDATE LogIn SET Password='" + txtCnfrm.Text + "' WHERE UserName='" + txtPassword.Text + "'", con);

                        int r = cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed Succesfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
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

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }
    }
}
       
