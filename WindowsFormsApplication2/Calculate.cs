using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Calculate : Form
    {
        int a, b;
        double c;
        public Calculate()
        {
            InitializeComponent();
            Amount.Enabled = false;
        }
        public double TheValue
        {
            get
            {
                return c;
            }
            set
            {
                Amount.Text = c.ToString();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (mtbPrice.Text == "" && mtbTotal.Text == "")
            {
                MessageBox.Show("Enter the value", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                a = Convert.ToInt32(mtbPrice.Text);
                b = Convert.ToInt32(mtbTotal.Text);
                c = a * b;
                Amount.Text = c.ToString();
                btnCalc.Enabled = false;
                this.Dispose(true);
            }
        }
    }
}
