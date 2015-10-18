namespace WindowsFormsApplication2
{
    partial class Inward
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMSDataSet = new WindowsFormsApplication2.IMSDataSet();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.unitTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.UnitTableAdapter();
            this.btnAddM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.VendorTableAdapter();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.materialInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialInfoTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.MaterialInfoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApplication2.Properties.Resources.remove;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(303, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 44);
            this.btnExit.TabIndex = 63;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication2.Properties.Resources.filesave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(184, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 44);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbUnit
            // 
            this.cbUnit.DataSource = this.unitBindingSource;
            this.cbUnit.DisplayMember = "QuantityType";
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(242, 217);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(85, 21);
            this.cbUnit.TabIndex = 61;
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
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(168, 217);
            this.mtbQuantity.Mask = "00000";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(67, 20);
            this.mtbQuantity.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Enter Material Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 70);
            this.label3.TabIndex = 55;
            this.label3.Text = "Inward Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddM
            // 
            this.btnAddM.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnAddM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddM.Location = new System.Drawing.Point(62, 264);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(99, 44);
            this.btnAddM.TabIndex = 65;
            this.btnAddM.Text = "New";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 66;
            this.label4.Text = "Enter Vendor Name:";
            // 
            // cbVendor
            // 
            this.cbVendor.DataSource = this.vendorBindingSource;
            this.cbVendor.DisplayMember = "VendorName";
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(167, 142);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(207, 21);
            this.cbVendor.TabIndex = 67;
            this.cbVendor.ValueMember = "VendorID";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.iMSDataSet;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // cbMaterial
            // 
            this.cbMaterial.DataSource = this.materialInfoBindingSource;
            this.cbMaterial.DisplayMember = "MaterialName";
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(168, 180);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(206, 21);
            this.cbMaterial.TabIndex = 68;
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
            this.textBox1.Location = new System.Drawing.Point(45, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.Visible = false;
            // 
            // Inward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.cbVendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Inward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inward";
            this.Load += new System.EventHandler(this.Inward_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private IMSDataSet iMSDataSet;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVendor;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.BindingSource materialInfoBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.MaterialInfoTableAdapter materialInfoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}