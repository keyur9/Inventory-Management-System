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
    public partial class SalesOrder : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\K-Ur\\My Documents\\Visual Studio 2008\\Projects\\WindowsFormsApplication2\\WindowsFormsApplication2\\IMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmmd = new SqlCommand();
        string res;

        public SalesOrder()
        {
            InitializeComponent();
            txtAddTax.Enabled = false;
            txtVat.Enabled = false;
            txtAmount.Enabled = false;
            txtTotal.Enabled = false;
            btnGenerate.Enabled = false;
            btnCnfrm.Enabled = false;
            btnAdd.Enabled = false;
            btnPO.Enabled = false;
            btnNew.Enabled = false;
            txtAvail.Enabled = false;
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            using (Calculate calc = new Calculate())
            {
                if (calc.ShowDialog() == DialogResult.Cancel)
                {
                    txtAmount.Text = calc.TheValue.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCstName.Text == "" || mtbQuantity.Text == "" || cbMtrlName.SelectedItem == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Fill the required feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int av = Convert.ToInt32(txtAvail.Text);
                int ts = Convert.ToInt32(mtbQuantity.Text);
                if (av < ts)
                {
                    MessageBox.Show("Stock out of range", "Sale Quantity", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DataColumn dco4 = new DataColumn("Amount");
                    DataColumn dco3 = new DataColumn("Quantity");
                    DataColumn dco2 = new DataColumn("Quantity_Type");
                    DataColumn dco1 = new DataColumn("Material_Name");
                    //DataColumn dco1 = new DataColumn("Customer_Name");
                    if (dt.Columns.Count == 0)
                    {
                        dt.Columns.Add(dco1);
                        dt.Columns.Add(dco2);
                        dt.Columns.Add(dco3);
                        dt.Columns.Add(dco4);
                        //dt.Columns.Add(dco5);
                    }

                    for (int i = 1; i < 2; i++)
                    {
                        DataRow row1 = dt.NewRow();
                        row1["Amount"] = txtAmount.Text;
                        row1["Quantity"] = mtbQuantity.Text;
                        row1["Quantity_Type"] = cbUnit.Text;
                        //row1["Customer_Name"] = txtCstName.Text;
                        row1["Material_Name"] = cbMtrlName.Text;

                        //int temp=dataGridView1.NewRowIndex;
                        //MessageBox.Show(temp.ToString());

                        //dt.Rows.InsertAt(row1, i);
                        dt.Rows.Add(row1);
                        //}           
                    }
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void SalesOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iMSDataSet.MaterialInfo' table. You can move, or remove it, as needed.
            this.materialInfoTableAdapter.Fill(this.iMSDataSet.MaterialInfo);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataReader dReader;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ContactPerson FROM CustomerInfo WHERE ContactPerson LIKE '" + txtCstName.Text + "%'";
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
                //MessageBox.Show("Data not found");

            }
            dReader.Close();

            txtCstName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCstName.AutoCompleteCustomSource = namesCollection;
            con.Close();

            // TODO: This line of code loads data into the 'iMSDataSet.CustomerInfo' table. You can move, or remove it, as needed.
            //this.customerInfoTableAdapter.Fill(this.iMSDataSet.CustomerInfo);
            // TODO: This line of code loads data into the 'iMSDataSet.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.iMSDataSet.Unit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtTotal.Text);
            int b = Convert.ToInt32(txtPacking.Text);
            int c = Convert.ToInt32(txtFreight.Text);
            double f = 0, h = 0;
            if (cbVat.Checked)
            {
                //int g = Convert.ToInt32(txtTotal.Text);
                f = 0.04 * a;
                txtVat.Text = f.ToString();
            }
            if (cbAddTax.Checked)
            {
                //int i = Convert.ToInt32(txtTotal.Text);
                h = 0.01 * a;
                txtAddTax.Text = h.ToString();
            }
            double d = a + b + c + f + h;
            label12.Text = d.ToString();
            label12.Show();
            // btnGenerate.Enabled = false;
            btnCnfrm.Enabled = true;
            btnGenerate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = false;
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Amount"].Value);
            }
            txtTotal.Text = sum.ToString();
            btnGenerate.Enabled = true;
            btnPO.Enabled = false;
            btnNew.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataRow row2 = dt.NewRow();
            //dt.Rows.Add(row2);
            //int remp=e.RowIndex;
            //MessageBox.Show(remp.ToString());
            //remp++;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCstName.Enabled = false;
            cbMtrlName.Text = "";
            cbUnit.Text = "";
            txtAmount.Text = "";
            mtbQuantity.Text = "";
            txtAvail.Text = "";
            btnAdd.Enabled = false;
            btnPO.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Quantity from Outward WHERE MaterialID LIKE '" + cbMtrlName.SelectedValue + "'", con);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtAvail.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                }
                else
                {
                    MessageBox.Show("Selected Material does not exist", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            finally
            {
                con.Close();
            }
            btnAdd.Enabled = true;
            btnPO.Enabled = true;
            btnNew.Enabled = true;
        }

        private void btnCnfrm_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataReader dReader;

            con.Open();
            int count = dataGridView1.Rows.Count;
            int i=0;
            cmd = new SqlCommand("Insert into SalesOrder_Master(Date,CustomerName) values(@a,@b)", con);
            cmd.Parameters.AddWithValue("@a", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@b", txtCstName.Text);
            int k = cmd.ExecuteNonQuery();            
                    for (i=0; i < count; i++)
                    {
                    cmd = new SqlCommand("Insert into SalesOrder_Sub(MaterialID,Quantity,UnitID,Total,Packing,Freight,VAT,AddTax,GrandTotal,OrderID,Amount) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)", con);
                    cmmd = new SqlCommand("Select OrderID from SalesOrder_Master", con);
                    SqlDataReader dr = cmmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            res = dr[0].ToString();
                        }
                        dr.Close();
                    }
                    cmd.Parameters.AddWithValue("@j", Convert.ToInt32(res));
                    cmd.Parameters.AddWithValue("@a", dataGridView1.Rows[i].Cells["Material_Name"].Value);
                    cmd.Parameters.AddWithValue("@b", dataGridView1.Rows[i].Cells["Quantity"].Value);
                    cmd.Parameters.AddWithValue("@c", dataGridView1.Rows[i].Cells["Quantity_Type"].Value);
                    cmd.Parameters.AddWithValue("@k", dataGridView1.Rows[i].Cells["Amount"].Value);
                    cmd.Parameters.AddWithValue("@d", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@e", txtPacking.Text); 
                    cmd.Parameters.AddWithValue("@f", txtFreight.Text);
                    cmd.Parameters.AddWithValue("@g", txtVat.Text);
                    cmd.Parameters.AddWithValue("@h", txtAddTax.Text);
                    cmd.Parameters.AddWithValue("@i", label12.Text);
                    int r = cmd.ExecuteNonQuery();
                    }
            try
            {
                
              MessageBox.Show("Sales Entry", "Added Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txtCstName.Text = "";
                cbMtrlName.Text = "";
                cbUnit.Text = "";
                mtbQuantity.Text = "";
                txtAddTax.Text = "";
                txtAmount.Text = "";
                txtAvail.Text = "";
                txtFreight.Text = "";
                txtPacking.Text = "";
                txtTotal.Text = "";
                txtVat.Text = "";
                ((DataTable)dataGridView1.DataSource).Rows.Clear();
            }
        }

        private void SalesOrder_FormClosing(object sender, FormClosingEventArgs e)
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

