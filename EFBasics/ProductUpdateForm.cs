using Microsoft.EntityFrameworkCore;
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
    public partial class ProductUpdateForm : Form
    {
        private int productId;
        private Product product;
        public ProductUpdateForm()
        {
            InitializeComponent();
        }
        public ProductUpdateForm(int id)
        {
            InitializeComponent();
            productId=id;
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var categories = dbContext.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            var suppliers = dbContext.Suppliers.ToList();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";

            product = dbContext.Products.Find(productId);
            txtName.Text = product.ProductName;
            cmbCategory.SelectedValue = product.CategoryID;
            cmbSupplier.SelectedValue = product.SupplierId;
            txtQuantityPerUnit.Text = product.QuantityPerUnit;
            numUnitPrice.Value = (int)product.UnitPrice;
            numUnitInStock.Value = (int)product.UnitsInStock;
            numUnitsOnOrder.Value = (int)product.UnitsOnOrder;
            numReorderLevel.Value = (int)product.ReorderLevel;
            chkDiscontinued.Checked = product.Discontinued;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();

                product = new Product()
                {
                    ProductID = productId,
                    ProductName = txtName.Text,
                    CategoryID = (int)cmbCategory.SelectedValue,
                    SupplierId = (int)cmbSupplier.SelectedValue,
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = numUnitPrice.Value,
                    UnitsInStock = (short?)numUnitInStock.Value,
                    UnitsOnOrder = (short?)numUnitsOnOrder.Value,
                    ReorderLevel = (short?)numUnitsOnOrder.Value,
                    Discontinued = chkDiscontinued.Checked
                };
                dbContext.Products.Update(product);
                dbContext.SaveChanges();

                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
        }
    }
}
