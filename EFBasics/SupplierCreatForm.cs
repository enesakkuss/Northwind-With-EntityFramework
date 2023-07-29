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
    public partial class SupplierCreatForm : Form
    {
        public SupplierCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();

            var supplier = new Supplier()
            {
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Address = txtAdress.Text,
                Fax = txtFax.Text,
                HomePage = txtHomepage.Text,
                Phone = txtPhone.Text
            };
            var save=dbContext.Suppliers.Add(supplier);
            dbContext.SaveChanges();

        }
    }
}
