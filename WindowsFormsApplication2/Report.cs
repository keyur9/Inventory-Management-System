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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IMSDataSet.SalesOrder' table. You can move, or remove it, as needed.
            this.SalesOrderTableAdapter.Fill(this.IMSDataSet.SalesOrder);

            this.reportViewer1.RefreshReport();
        }
    }
}
