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
    public partial class SupplierUpdateForm : Form
    {
        private int supplierId;
        private Supplier supplier;
        public SupplierUpdateForm()
        {
            InitializeComponent();
        }
        public SupplierUpdateForm(int id)
        {
            InitializeComponent();
            supplierId = id;
        }

        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                supplier = dbContext.Suppliers.Find(supplierId);
                txtCompanyName.Text = supplier.CompanyName;
                txtContactName.Text = supplier.ContactName;
                txtContactTitle.Text = supplier.ContactTitle;
                txtCountry.Text = supplier.Country;
                txtFax.Text = supplier.Fax;
                txtPhone.Text = supplier.Phone;
                txtPostalCode.Text = supplier.PostalCode;
                txtRegion.Text = supplier.Region;
                txtHomepage.Text = supplier.HomePage;
                txtCity.Text = supplier.City;
                txtAdress.Text = supplier.Address;
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Ekranına Getirilemedi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                supplier = new Supplier()
                {
                    SupplierID = supplierId,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Country = txtCountry.Text,
                    Fax = txtFax.Text,
                    Phone = txtPhone.Text,
                    PostalCode = txtPostalCode.Text,
                    Region = txtRegion.Text,
                    HomePage = txtHomepage.Text,
                    City = txtCity.Text,
                    Address = txtAdress.Text
                };
                dbContext.Suppliers.Update(supplier);
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
