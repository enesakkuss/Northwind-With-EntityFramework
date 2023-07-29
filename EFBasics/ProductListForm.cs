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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var productList = dbContext.Products.ToList();
            dataGridView1.DataSource=productList;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuProductDeleteForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                try
                {
                    var product = (Product)dataGridView1.SelectedRows[0].DataBoundItem;

                    var dbContext = new NorthWindDbContext();
                    var result = dbContext.Products.Remove(product);
                    dbContext.SaveChanges();

                    MessageBox.Show("Silme İşlemi Başarılı");

                    dataGridView1.DataSource=dbContext.Products.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme İşlemi Başarısız");
                }

                
            }
        }

        private void menuProductUpdateForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var product = (Product)dataGridView1.SelectedRows[0].DataBoundItem;

                var productUpdateForm=new ProductUpdateForm(product.ProductID);
                productUpdateForm.Owner = this.Owner;
                productUpdateForm.Show();
            }
        }
    }
}
