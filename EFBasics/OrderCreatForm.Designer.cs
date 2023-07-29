namespace EFBasics
{
    partial class OrderCreatForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbShipper = new System.Windows.Forms.ComboBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numFreight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSendDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satıcı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taşıyıcı:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(117, 48);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(244, 28);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(117, 96);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(244, 28);
            this.cmbSupplier.TabIndex = 4;
            // 
            // cmbShipper
            // 
            this.cmbShipper.FormattingEnabled = true;
            this.cmbShipper.Location = new System.Drawing.Point(117, 144);
            this.cmbShipper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbShipper.Name = "cmbShipper";
            this.cmbShipper.Size = new System.Drawing.Size(244, 28);
            this.cmbShipper.TabIndex = 5;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(469, 260);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(255, 71);
            this.txtAdress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(469, 77);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(255, 27);
            this.txtCity.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(469, 125);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(255, 27);
            this.txtCountry.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ülke:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(630, 388);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(95, 35);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 431);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(711, 235);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numFreight
            // 
            this.numFreight.Location = new System.Drawing.Point(117, 183);
            this.numFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFreight.Name = "numFreight";
            this.numFreight.Size = new System.Drawing.Size(245, 27);
            this.numFreight.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kargo Bedeli:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bölgesi:";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(469, 173);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(255, 27);
            this.txtRegion.TabIndex = 17;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtRegion_TextChanged);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(469, 212);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(255, 27);
            this.txtPostalCode.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Posta Kodu:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(117, 221);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(244, 27);
            this.dtpOrderDate.TabIndex = 20;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(117, 260);
            this.dtpRequiredDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(244, 27);
            this.dtpRequiredDate.TabIndex = 21;
            // 
            // dtpSendDate
            // 
            this.dtpSendDate.Location = new System.Drawing.Point(117, 299);
            this.dtpSendDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSendDate.Name = "dtpSendDate";
            this.dtpSendDate.Size = new System.Drawing.Size(244, 27);
            this.dtpSendDate.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "SiparişTarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Termin Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Gönderi Tarihi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(382, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Şirket Adı:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(469, 39);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(255, 27);
            this.txtCompanyName.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(631, 678);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OrderCreatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 719);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpSendDate);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numFreight);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.cmbShipper);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderCreatForm";
            this.Text = "OrderCreatForm";
            this.Load += new System.EventHandler(this.OrderCreatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCustomer;
        private ComboBox cmbSupplier;
        private ComboBox cmbShipper;
        private TextBox txtAdress;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAddProduct;
        private DataGridView dataGridView1;
        private NumericUpDown numFreight;
        private Label label7;
        private Label label8;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private Label label9;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpSendDate;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtCompanyName;
        private Button btnSave;
    }
}