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
    public partial class CustomerUpdateForm : Form
    {
        private string customerId;
        private Customer customer;
        public CustomerUpdateForm()
        {
            InitializeComponent();
        }
        public CustomerUpdateForm(string id)
        {
            InitializeComponent();
            customerId= id;
        }
        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            customer=dbContext.Customers.Find(customerId);
            txtCustomerID.Text = customer.CustomerID;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtCompanyName.Text = customer.CompanyName;
            txtContactName.Text = customer.ContactName;
            txtPhone.Text = customer.Phone;
            txtCountry.Text = customer.Country;
            txtPostalCode.Text= customer.PostalCode;
            txtFax.Text= customer.Fax;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                customer = new Customer()
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
                dbContext.Customers.Update(customer);
                dbContext.SaveChanges();

                MessageBox.Show("Kayıt Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Güncellenemedi");
            }
        }
    }
}
