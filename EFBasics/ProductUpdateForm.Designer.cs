namespace EFBasics
{
    partial class ProductUpdateForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.numReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.numUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.numUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(214, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(117, 382);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(80, 19);
            this.chkDiscontinued.TabIndex = 55;
            this.chkDiscontinued.Text = "Pasif Ürün";
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // numReorderLevel
            // 
            this.numReorderLevel.Location = new System.Drawing.Point(117, 335);
            this.numReorderLevel.Name = "numReorderLevel";
            this.numReorderLevel.Size = new System.Drawing.Size(172, 23);
            this.numReorderLevel.TabIndex = 54;
            // 
            // numUnitsOnOrder
            // 
            this.numUnitsOnOrder.Location = new System.Drawing.Point(117, 291);
            this.numUnitsOnOrder.Name = "numUnitsOnOrder";
            this.numUnitsOnOrder.Size = new System.Drawing.Size(172, 23);
            this.numUnitsOnOrder.TabIndex = 53;
            // 
            // numUnitInStock
            // 
            this.numUnitInStock.Location = new System.Drawing.Point(117, 243);
            this.numUnitInStock.Name = "numUnitInStock";
            this.numUnitInStock.Size = new System.Drawing.Size(172, 23);
            this.numUnitInStock.TabIndex = 52;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.Location = new System.Drawing.Point(117, 197);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(172, 23);
            this.numUnitPrice.TabIndex = 51;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(117, 150);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(172, 23);
            this.txtQuantityPerUnit.TabIndex = 50;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(117, 104);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(172, 23);
            this.cmbSupplier.TabIndex = 49;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(117, 61);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(172, 23);
            this.cmbCategory.TabIndex = 48;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 23);
            this.txtName.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Ürün Durumu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Kirtik Stok Eşiği:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Gelecek Stok:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Stok Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Birim Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Paket İçeriği:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tedarikçi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kategorisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ürün Adı:";
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.numReorderLevel);
            this.Controls.Add(this.numUnitsOnOrder);
            this.Controls.Add(this.numUnitInStock);
            this.Controls.Add(this.numUnitPrice);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductUpdateForm";
            this.Text = "ProductUpdateForm";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private CheckBox chkDiscontinued;
        private NumericUpDown numReorderLevel;
        private NumericUpDown numUnitsOnOrder;
        private NumericUpDown numUnitInStock;
        private NumericUpDown numUnitPrice;
        private TextBox txtQuantityPerUnit;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}