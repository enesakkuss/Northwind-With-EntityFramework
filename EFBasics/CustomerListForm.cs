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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            dataGridView1.DataSource = dbContext.Customers.ToList();
        }

        private void menuDeleteCustomerForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                try
                {

                    var customer = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

                    var dbContext = new NorthWindDbContext();
                    dbContext.Customers.Remove(customer);
                    dbContext.SaveChanges();

                    MessageBox.Show("Kayıt Başarıyla Silindi");

                    dataGridView1.DataSource = dbContext.Customers.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuCustomerUpdateForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var customer = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

                var customerUpdateForm = new CustomerUpdateForm(customer.CustomerID);
                customerUpdateForm.Owner= this.Owner;
                customerUpdateForm.Show();

            }
        }
    }
}
