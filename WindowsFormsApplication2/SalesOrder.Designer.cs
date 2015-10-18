namespace WindowsFormsApplication2
{
    partial class SalesOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMSDataSet = new WindowsFormsApplication2.IMSDataSet();
            this.cbMtrlName = new System.Windows.Forms.ComboBox();
            this.materialInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPacking = new System.Windows.Forms.TextBox();
            this.txtAddTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCnfrm = new System.Windows.Forms.Button();
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.unitTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.UnitTableAdapter();
            this.cbVat = new System.Windows.Forms.CheckBox();
            this.cbAddTax = new System.Windows.Forms.CheckBox();
            this.customerInfoTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.CustomerInfoTableAdapter();
            this.txtCstName = new System.Windows.Forms.TextBox();
            this.materialInfoTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.MaterialInfoTableAdapter();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Image = global::WindowsFormsApplication2.Properties.Resources.order_icon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-3, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(861, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sales Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Customer Name";
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "CustomerInfo";
            this.customerInfoBindingSource.DataSource = this.iMSDataSet;
            // 
            // iMSDataSet
            // 
            this.iMSDataSet.DataSetName = "IMSDataSet";
            this.iMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMtrlName
            // 
            this.cbMtrlName.DataSource = this.materialInfoBindingSource;
            this.cbMtrlName.DisplayMember = "MaterialName";
            this.cbMtrlName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMtrlName.FormattingEnabled = true;
            this.cbMtrlName.Location = new System.Drawing.Point(307, 134);
            this.cbMtrlName.Name = "cbMtrlName";
            this.cbMtrlName.Size = new System.Drawing.Size(233, 21);
            this.cbMtrlName.TabIndex = 33;
            this.cbMtrlName.ValueMember = "MaterialID";
            // 
            // materialInfoBindingSource
            // 
            this.materialInfoBindingSource.DataMember = "MaterialInfo";
            this.materialInfoBindingSource.DataSource = this.iMSDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Material Name";
            // 
            // cbUnit
            // 
            this.cbUnit.DataSource = this.unitBindingSource;
            this.cbUnit.DisplayMember = "QuantityType";
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(397, 167);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(89, 21);
            this.cbUnit.TabIndex = 37;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.iMSDataSet;
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(309, 168);
            this.mtbQuantity.Mask = "00000";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(74, 20);
            this.mtbQuantity.TabIndex = 36;
            this.mtbQuantity.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Quantity";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(425, 202);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(99, 23);
            this.btnCalc.TabIndex = 38;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(309, 202);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(92, 20);
            this.txtAmount.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnPO);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(11, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 147);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 102);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(275, 10);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(75, 23);
            this.btnPO.TabIndex = 3;
            this.btnPO.Text = "Place Order";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(183, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAvail
            // 
            this.txtAvail.Location = new System.Drawing.Point(309, 240);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(100, 20);
            this.txtAvail.TabIndex = 6;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(440, 469);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(100, 20);
            this.txtFreight.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "VAT %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Additional Tax";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(440, 495);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 20);
            this.txtVat.TabIndex = 45;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(440, 419);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 46;
            // 
            // txtPacking
            // 
            this.txtPacking.Location = new System.Drawing.Point(440, 443);
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.Size = new System.Drawing.Size(100, 20);
            this.txtPacking.TabIndex = 47;
            // 
            // txtAddTax
            // 
            this.txtAddTax.Location = new System.Drawing.Point(440, 521);
            this.txtAddTax.Name = "txtAddTax";
            this.txtAddTax.Size = new System.Drawing.Size(100, 20);
            this.txtAddTax.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Packing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(321, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 51;
            this.label10.Text = "Freight";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(642, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(56, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Grand Total:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(370, 544);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(143, 23);
            this.btnGenerate.TabIndex = 55;
            this.btnGenerate.Text = "Generate Total";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::WindowsFormsApplication2.Properties.Resources.remove;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(749, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCnfrm
            // 
            this.btnCnfrm.Image = global::WindowsFormsApplication2.Properties.Resources.filesave;
            this.btnCnfrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCnfrm.Location = new System.Drawing.Point(662, 526);
            this.btnCnfrm.Name = "btnCnfrm";
            this.btnCnfrm.Size = new System.Drawing.Size(75, 33);
            this.btnCnfrm.TabIndex = 53;
            this.btnCnfrm.Text = "Confirm";
            this.btnCnfrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCnfrm.UseVisualStyleBackColor = true;
            this.btnCnfrm.Click += new System.EventHandler(this.btnCnfrm_Click);
            // 
            // btnAddM
            // 
            this.btnAddM.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnAddM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddM.Location = new System.Drawing.Point(558, 131);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(99, 36);
            this.btnAddM.TabIndex = 34;
            this.btnAddM.Text = "New";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnAddC
            // 
            this.btnAddC.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnAddC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddC.Location = new System.Drawing.Point(558, 93);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(99, 36);
            this.btnAddC.TabIndex = 31;
            this.btnAddC.Text = "New";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // cbVat
            // 
            this.cbVat.AutoSize = true;
            this.cbVat.Location = new System.Drawing.Point(300, 500);
            this.cbVat.Name = "cbVat";
            this.cbVat.Size = new System.Drawing.Size(15, 14);
            this.cbVat.TabIndex = 56;
            this.cbVat.UseVisualStyleBackColor = true;
            // 
            // cbAddTax
            // 
            this.cbAddTax.AutoSize = true;
            this.cbAddTax.Location = new System.Drawing.Point(300, 524);
            this.cbAddTax.Name = "cbAddTax";
            this.cbAddTax.Size = new System.Drawing.Size(15, 14);
            this.cbAddTax.TabIndex = 57;
            this.cbAddTax.UseVisualStyleBackColor = true;
            // 
            // customerInfoTableAdapter
            // 
            this.customerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // txtCstName
            // 
            this.txtCstName.Location = new System.Drawing.Point(307, 101);
            this.txtCstName.Name = "txtCstName";
            this.txtCstName.Size = new System.Drawing.Size(233, 20);
            this.txtCstName.TabIndex = 58;
            // 
            // materialInfoTableAdapter
            // 
            this.materialInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(425, 240);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(115, 23);
            this.btnAvailable.TabIndex = 59;
            this.btnAvailable.Text = "Check Avalibility";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(180, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 19);
            this.label13.TabIndex = 60;
            this.label13.Text = "Available Quantity";
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 572);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAvail);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.txtCstName);
            this.Controls.Add(this.cbAddTax);
            this.Controls.Add(this.cbVat);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCnfrm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddTax);
            this.Controls.Add(this.txtPacking);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.cbMtrlName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "SalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesOrder_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.ComboBox cbMtrlName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPacking;
        private System.Windows.Forms.TextBox txtAddTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCnfrm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IMSDataSet iMSDataSet;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.CheckBox cbVat;
        private System.Windows.Forms.CheckBox cbAddTax;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.CustomerInfoTableAdapter customerInfoTableAdapter;
        private System.Windows.Forms.TextBox txtCstName;
        private System.Windows.Forms.BindingSource materialInfoBindingSource;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.MaterialInfoTableAdapter materialInfoTableAdapter;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Label label13;
    }
}