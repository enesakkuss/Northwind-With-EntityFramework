using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFBasics
{
    public partial class ProductCreatForm : Form
    {
        public ProductCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                var product = new Product()
                {
                    ProductName = txtName.Text,
                    CategoryID = (int)cmbCategory.SelectedValue,
                    SupplierId = (int)cmbSupplier.SelectedValue,
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = numUnitPrice.Value,
                    UnitsInStock = (short)numUnitInStock.Value,
                    UnitsOnOrder = (short)numUnitsOnOrder.Value,
                    ReorderLevel = (short)numReorderLevel.Value,
                    Discontinued = chkDiscontinued.Checked
                };
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Kaydedildi");
            }
            catch (Exception)
            {
                MessageBox.Show ("Ürün Kaydedilemedi");
            }
        }

        private void ProductCreatForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var categories = dbContext.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            var suppliers= dbContext.Suppliers.ToList();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";
        }
    }
}
