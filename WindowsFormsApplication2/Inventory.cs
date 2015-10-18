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
    public partial class Inventory : Form
    {
        private bool nonNumberEntered = false;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtInvent.Text = "";
            try
            {
                if (txtSearch.Text != "")
                {
                    ds.Clear();
                    con.Open();
                    da = new SqlDataAdapter("SELECT SalesOrder.Quantity AS Sales, Inward.Quantity AS Inward FROM Inward INNER JOIN SalesOrder ON Inward.QuantityType = SalesOrder.QuantityType AND Inward.MaterialName = SalesOrder.MaterialName WHERE Inward.MaterialName like '" + txtSearch.Text + "'", con);
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
                else
                {
                    MessageBox.Show("Enter Material Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            finally
            {
                con.Close();
                txtSearch.Text = "";
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inward"].Value);
                }
                txtInward.Text = sum.ToString();
                int sum1 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum1 += Convert.ToInt32(dataGridView1.Rows[i].Cells["Sales"].Value);
                }
                txtSales.Text = sum1.ToString();
                int a = Convert.ToInt32(txtInward.Text);
                int b = Convert.ToInt32(txtSales.Text);
                int c = a - b;
                txtInvent.Text = c.ToString();
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            txtInvent.Enabled = false;
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
                //MessageBox.Show("Data not found");

            }
            dReader.Close();

            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = namesCollection;
            con.Close();

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
    }
}
