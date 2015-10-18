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
    public partial class Executive_Home : Form
    {
        private int childFormNumber = 0;

        public Executive_Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Executive_Home_Load(object sender, EventArgs e)
        {
            toolStrip.Hide();
            statusStrip.Show();
        }

        private void viewInfoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            VAT_Info vi = new VAT_Info();
            vi.Show();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to LogOff?", "Log-Off", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose(true);
                Home h = new Home();
                h.Show();
            }
            else
            {
                //e.Cancel = false;
            } 

        }

        private void newEntryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void viewInfoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Customer_Info ci = new Customer_Info();
            ci.Show();
        }

        private void newEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }

        private void viewInfoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Material_Info mi = new Material_Info();
            mi.Show();
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inward i = new Inward();
            i.Show();
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inward_Info ii = new Inward_Info();
            ii.Show();
        }

        private void newEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Outward o = new Outward();
            o.Show();
        }

        private void viewInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Outward_Info oi = new Outward_Info();
            oi.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrder so = new SalesOrder();
            so.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }
    }
}
