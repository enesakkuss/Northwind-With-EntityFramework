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
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var supplier = dbContext.Suppliers.ToList();

            dataGridView1.DataSource = supplier;
        }

        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();

            var search = dbContext.Suppliers.Where(s => s.CompanyName.Contains(txtSearchSupplier.Text)).ToList();

            dataGridView1.DataSource = search;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuSupplierDeleteForm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                var supplier=(Supplier)dataGridView1.SelectedRows[0].DataBoundItem;
                try
                {
                    var dbContext = new NorthWindDbContext();
                    dbContext.Suppliers.Remove(supplier);
                    dbContext.SaveChanges();

                    MessageBox.Show("Kayıt Başarıyla Silindi");

                    dataGridView1.DataSource = dbContext.Suppliers.ToList();

                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }
            }
        }

        private void menuSupplierUpdateForm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var supplier = (Supplier)dataGridView1.SelectedRows[0].DataBoundItem;

                var supplierUpdateForm = new SupplierUpdateForm(supplier.SupplierID);
                supplierUpdateForm.Owner = this.Owner;
                supplierUpdateForm.Show();
            }
        }
    }
}
