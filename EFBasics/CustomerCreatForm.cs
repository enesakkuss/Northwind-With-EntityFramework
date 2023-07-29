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
    public partial class CustomerCreatForm : Form
    {
        public CustomerCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                var customer = new Customer()
                {
                    CustomerID = txtCustomerID.Text,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    Region = txtRegion.Text,
                    PostalCode = txtPostalCode.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    Fax = txtFax.Text,
                };
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();

                MessageBox.Show("Kayıt Başarıyla Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Eklenemedi");
            }
        }
    }
}
