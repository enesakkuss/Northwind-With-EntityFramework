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
    public partial class OrderCreatForm : Form
    {
        private List<OrderDetailViewModel> _orderDetails = new List<OrderDetailViewModel>();

        public OrderCreatForm()
        {
            InitializeComponent();
        }

        private void OrderCreatForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var customer = dbContext.Customers.ToList();
            cmbCustomer.DataSource=customer;
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DisplayMember = "CompanyName";

            var employee=dbContext.Employees.ToList();
            cmbSupplier.DataSource=employee;
            cmbSupplier.ValueMember = "EmployeeID";
            cmbSupplier.DisplayMember = "FullName";
            
            var shipper=dbContext.Shippers.ToList();
            cmbShipper.DataSource=shipper;
            cmbShipper.ValueMember = "ShipperID";
            cmbShipper.DisplayMember = "CompanyName";

            
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCustomer.SelectedIndex>=0)
            {
                var customer = (Customer)cmbCustomer.SelectedItem;
                txtCompanyName.Text = customer.CompanyName;
                txtCity.Text = customer.City;
                txtCountry.Text = customer.Country;
                txtAdress.Text = customer.Address;
                txtRegion.Text = customer.Region;
                txtPostalCode.Text = customer.PostalCode;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var orderDetailForm = new OrderDetailForm();
            orderDetailForm.OrderDetailCreated += OrderDetailForm_OrderDatailCreated;
            orderDetailForm.MdiParent = MdiParent;
            orderDetailForm.Show();
        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDetailForm_OrderDatailCreated(OrderDetailViewModel orderDetail)
        {
            _orderDetails.Add(orderDetail);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _orderDetails;
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validasyonları yapmamız gerekiyor
            //if (cmbCustomer.SelectedIndex < 0)
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
                return;
            }

            var order = new Order();
            order.CustomerID = (string)cmbCustomer.SelectedValue;
            order.EmployeeID = (int)cmbSupplier.SelectedValue;
            order.OrderDate = dtpOrderDate.Value;
            order.RequiredDate = dtpRequiredDate.Value;
            order.ShippedDate = dtpSendDate.Value;
            order.Freight = numFreight.Value;
            order.ShipVia = (int)cmbShipper.SelectedValue;

            order.ShipName = txtCompanyName.Text;
            order.ShipCountry = txtCountry.Text;
            order.ShipCity = txtCity.Text;
            order.ShipRegion = txtRegion.Text;
            order.ShipAddress = txtAdress.Text;
            order.ShipPostalCode = txtPostalCode.Text;

            // AutoMapper
            foreach (var detailVM in _orderDetails)
            {
                var orderDetail = new OrderDetail()
                {
                    ProductID = detailVM.ProductId,
                    Quantity = detailVM.Quantity,
                    Discount = detailVM.Discount,
                    UnitPrice = detailVM.UnitPrice
                };

                order.Details.Add(orderDetail);
            }

            try
            {
                var context = new NorthWindDbContext();
                context.Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    
    }
}
