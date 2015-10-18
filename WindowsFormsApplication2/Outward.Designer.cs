namespace WindowsFormsApplication2
{
    partial class Outward
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMSDataSet = new WindowsFormsApplication2.IMSDataSet();
            this.unitTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.UnitTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnAddM = new System.Windows.Forms.Button();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.materialInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialInfoTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.MaterialInfoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 70);
            this.label3.TabIndex = 7;
            this.label3.Text = "Outward Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Material Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity";
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(169, 182);
            this.mtbQuantity.Mask = "00000";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(67, 20);
            this.mtbQuantity.TabIndex = 12;
            // 
            // cbUnit
            // 
            this.cbUnit.DataSource = this.unitBindingSource;
            this.cbUnit.DisplayMember = "QuantityType";
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(243, 182);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(85, 21);
            this.cbUnit.TabIndex = 13;
            this.cbUnit.ValueMember = "UnitID";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.iMSDataSet;
            // 
            // iMSDataSet
            // 
            this.iMSDataSet.DataSetName = "IMSDataSet";
            this.iMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApplication2.Properties.Resources.remove;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(304, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 44);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication2.Properties.Resources.filesave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(199, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 44);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 19);
            this.label13.TabIndex = 63;
            this.label13.Text = "Available Quantity";
            // 
            // txtAvail
            // 
            this.txtAvail.Location = new System.Drawing.Point(168, 218);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(100, 20);
            this.txtAvail.TabIndex = 61;
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(284, 213);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(115, 23);
            this.btnAvailable.TabIndex = 62;
            this.btnAvailable.Text = "Check Avalibility";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnAddM
            // 
            this.btnAddM.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnAddM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddM.Location = new System.Drawing.Point(83, 263);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(99, 44);
            this.btnAddM.TabIndex = 66;
            this.btnAddM.Text = "New";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // cbMaterial
            // 
            this.cbMaterial.DataSource = this.materialInfoBindingSource;
            this.cbMaterial.DisplayMember = "MaterialName";
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(169, 145);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(228, 21);
            this.cbMaterial.TabIndex = 67;
            this.cbMaterial.ValueMember = "MaterialID";
            // 
            // materialInfoBindingSource
            // 
            this.materialInfoBindingSource.DataMember = "MaterialInfo";
            this.materialInfoBindingSource.DataSource = this.iMSDataSet;
            // 
            // materialInfoTableAdapter
            // 
            this.materialInfoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 68;
            this.textBox1.Visible = false;
            // 
            // Outward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 328);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAvail);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Outward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outward";
            this.Load += new System.EventHandler(this.Outward_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.ComboBox cbUnit;
        private IMSDataSet iMSDataSet;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.BindingSource materialInfoBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.MaterialInfoTableAdapter materialInfoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}