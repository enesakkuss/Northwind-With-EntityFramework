namespace EFBasics
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorşiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryCreat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryList = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreatSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductUpdateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.nakliyeciYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreatShipperForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanYötenimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÇalışanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarınListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorşiYönetimiToolStripMenuItem,
            this.tedarikçiYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.nakliyeciYönetimiToolStripMenuItem,
            this.çalışanYötenimiToolStripMenuItem,
            this.müşteriYönetimiToolStripMenuItem,
            this.siparişYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorşiYönetimiToolStripMenuItem
            // 
            this.kategorşiYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoryCreat,
            this.menuCategoryList});
            this.kategorşiYönetimiToolStripMenuItem.Name = "kategorşiYönetimiToolStripMenuItem";
            this.kategorşiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategorşiYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // menuCategoryCreat
            // 
            this.menuCategoryCreat.Name = "menuCategoryCreat";
            this.menuCategoryCreat.Size = new System.Drawing.Size(158, 22);
            this.menuCategoryCreat.Text = "Yeni Kategori";
            this.menuCategoryCreat.Click += new System.EventHandler(this.menuCategoryCreat_Click);
            // 
            // menuCategoryList
            // 
            this.menuCategoryList.Name = "menuCategoryList";
            this.menuCategoryList.Size = new System.Drawing.Size(158, 22);
            this.menuCategoryList.Text = "Tüm Kategoriler";
            this.menuCategoryList.Click += new System.EventHandler(this.menuCategoryList_Click);
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            this.tedarikçiYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreatSupplier,
            this.menuSupplierList});
            this.tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            this.tedarikçiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi Yönetimi";
            // 
            // menuCreatSupplier
            // 
            this.menuCreatSupplier.Name = "menuCreatSupplier";
            this.menuCreatSupplier.Size = new System.Drawing.Size(160, 22);
            this.menuCreatSupplier.Text = "Yeni Tedarikçi";
            this.menuCreatSupplier.Click += new System.EventHandler(this.menuCreatSupplier_Click);
            // 
            // menuSupplierList
            // 
            this.menuSupplierList.Name = "menuSupplierList";
            this.menuSupplierList.Size = new System.Drawing.Size(160, 22);
            this.menuSupplierList.Text = "Tüm Tedarikçiler";
            this.menuSupplierList.Click += new System.EventHandler(this.menuSupplierList_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductListForm,
            this.menuProductUpdateForm});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuProductListForm
            // 
            this.menuProductListForm.Name = "menuProductListForm";
            this.menuProductListForm.Size = new System.Drawing.Size(149, 22);
            this.menuProductListForm.Text = "Yeni Ürün Ekle";
            this.menuProductListForm.Click += new System.EventHandler(this.menuProductListForm_Click);
            // 
            // menuProductUpdateForm
            // 
            this.menuProductUpdateForm.Name = "menuProductUpdateForm";
            this.menuProductUpdateForm.Size = new System.Drawing.Size(149, 22);
            this.menuProductUpdateForm.Text = "Ürün Listesi";
            this.menuProductUpdateForm.Click += new System.EventHandler(this.menuProductUpdateForm_Click);
            // 
            // nakliyeciYönetimiToolStripMenuItem
            // 
            this.nakliyeciYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreatShipperForm,
            this.menuShipperListForm});
            this.nakliyeciYönetimiToolStripMenuItem.Name = "nakliyeciYönetimiToolStripMenuItem";
            this.nakliyeciYönetimiToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.nakliyeciYönetimiToolStripMenuItem.Text = "Nakliyeci Yönetimi";
            // 
            // menuCreatShipperForm
            // 
            this.menuCreatShipperForm.Name = "menuCreatShipperForm";
            this.menuCreatShipperForm.Size = new System.Drawing.Size(157, 22);
            this.menuCreatShipperForm.Text = "Yeni Nakliyeci";
            this.menuCreatShipperForm.Click += new System.EventHandler(this.menuCreatShipperForm_Click);
            // 
            // menuShipperListForm
            // 
            this.menuShipperListForm.Name = "menuShipperListForm";
            this.menuShipperListForm.Size = new System.Drawing.Size(157, 22);
            this.menuShipperListForm.Text = "Nakliyeci Listesi";
            this.menuShipperListForm.Click += new System.EventHandler(this.menuShipperListForm_Click);
            // 
            // çalışanYötenimiToolStripMenuItem
            // 
            this.çalışanYötenimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÇalışanToolStripMenuItem,
            this.çalışanlarınListesiToolStripMenuItem});
            this.çalışanYötenimiToolStripMenuItem.Name = "çalışanYötenimiToolStripMenuItem";
            this.çalışanYötenimiToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.çalışanYötenimiToolStripMenuItem.Text = "Çalışan Yönetimi";
            // 
            // yeniÇalışanToolStripMenuItem
            // 
            this.yeniÇalışanToolStripMenuItem.Name = "yeniÇalışanToolStripMenuItem";
            this.yeniÇalışanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniÇalışanToolStripMenuItem.Text = "Yeni Çalışan";
            this.yeniÇalışanToolStripMenuItem.Click += new System.EventHandler(this.yeniÇalışanToolStripMenuItem_Click);
            // 
            // çalışanlarınListesiToolStripMenuItem
            // 
            this.çalışanlarınListesiToolStripMenuItem.Name = "çalışanlarınListesiToolStripMenuItem";
            this.çalışanlarınListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çalışanlarınListesiToolStripMenuItem.Text = "Çalışanların Listesi";
            this.çalışanlarınListesiToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarınListesiToolStripMenuItem_Click);
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem});
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yeniMüşteriToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniMüşteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriToolStripMenuItem_Click);
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSiparişToolStripMenuItem,
            this.siparişListesiToolStripMenuItem});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // yeniSiparişToolStripMenuItem
            // 
            this.yeniSiparişToolStripMenuItem.Name = "yeniSiparişToolStripMenuItem";
            this.yeniSiparişToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.yeniSiparişToolStripMenuItem.Text = "Yeni Sipariş";
            this.yeniSiparişToolStripMenuItem.Click += new System.EventHandler(this.yeniSiparişToolStripMenuItem_Click);
            // 
            // siparişListesiToolStripMenuItem
            // 
            this.siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            this.siparişListesiToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            this.siparişListesiToolStripMenuItem.Click += new System.EventHandler(this.siparişListesiToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategorşiYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCategoryCreat;
        private ToolStripMenuItem menuCategoryList;
        private ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCreatSupplier;
        private ToolStripMenuItem menuSupplierList;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuProductListForm;
        private ToolStripMenuItem menuProductUpdateForm;
        private ToolStripMenuItem nakliyeciYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCreatShipperForm;
        private ToolStripMenuItem menuShipperListForm;
        private ToolStripMenuItem çalışanYötenimiToolStripMenuItem;
        private ToolStripMenuItem yeniÇalışanToolStripMenuItem;
        private ToolStripMenuItem çalışanlarınListesiToolStripMenuItem;
        private ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişListesiToolStripMenuItem;
        private ToolStripMenuItem yeniSiparişToolStripMenuItem;
    }
}