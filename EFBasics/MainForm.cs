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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuCategoryCreat_Click(object sender, EventArgs e)
        {
            var categoryCreatForm=new CategoryCreatForm();
            categoryCreatForm.Owner=this;
            categoryCreatForm.Show();
        }

        private void menuCategoryList_Click(object sender, EventArgs e)
        {
            var categoryCreatForm = new CategoryListForm();
            categoryCreatForm.Owner=this;
            categoryCreatForm.Show();
        }

        private void menuSupplierList_Click(object sender, EventArgs e)
        {
            var supplierListForm = new SupplierListForm();
            supplierListForm.Owner = this;
            supplierListForm.Show();
        }

        private void menuCreatSupplier_Click(object sender, EventArgs e)
        {
            var supplierCreatForm=new SupplierCreatForm();
            supplierCreatForm.Owner = this;
            supplierCreatForm.Show();
        }

        private void menuProductUpdateForm_Click(object sender, EventArgs e)
        {
            var productListForm = new ProductListForm();
            productListForm.Owner = this;
            productListForm.Show();
        }

        private void menuProductListForm_Click(object sender, EventArgs e)
        {
            var productCreatForm = new ProductCreatForm();
            productCreatForm.Owner = this;
            productCreatForm.Show();
        }

        private void menuShipperListForm_Click(object sender, EventArgs e)
        {
            var shipperListForm=new ShipperListForm();
            shipperListForm.Owner=this;
            shipperListForm.Show();
        }

        private void menuCreatShipperForm_Click(object sender, EventArgs e)
        {
            var shipperCreatForm = new ShipperCreatForm();
            shipperCreatForm.Owner = this;
            shipperCreatForm.Show();
        }

        private void çalışanlarınListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeListForm = new EmployeeListForm();
            employeeListForm.Owner = this;
            employeeListForm.Show();
        }

        private void yeniÇalışanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeCreatForm = new EmployeeCreatForm();
            employeeCreatForm.Owner = this;
            employeeCreatForm.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerListForm = new CustomerListForm();
            customerListForm.Owner = this;
            customerListForm.Show();
        }

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerCreatForm = new CustomerCreatForm();
            customerCreatForm.Owner = this;
            customerCreatForm.Show();
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderListForm = new OrderListForm();
            orderListForm.Owner = this;
            orderListForm.Show();
        }

        private void yeniSiparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderCreatForm = new OrderCreatForm();
            orderCreatForm.Owner = this;
            orderCreatForm.Show();
        }
    }
}
