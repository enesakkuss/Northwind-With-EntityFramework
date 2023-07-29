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
    public partial class ShipperListForm : Form
    {
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            dataGridView1.DataSource = dbContext.Shippers.ToList();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuShipperDeleteForm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                try
                {

                    var shipper = (Shipper)dataGridView1.SelectedRows[0].DataBoundItem;

                    var dbContext = new NorthWindDbContext();
                    dbContext.Shippers.Remove(shipper);
                    dbContext.SaveChanges();

                    MessageBox.Show("Kayıt Başarıyla Silindi");
                    dataGridView1.DataSource = dbContext.Shippers.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }
            }
        }

        private void menuShipperUpdateForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var shipper = (Shipper)dataGridView1.SelectedRows[0].DataBoundItem;

                var shipperUpdateForm = new ShipperUpdateForm(shipper.ShipperID);
                shipperUpdateForm.Owner = this.Owner;
                shipperUpdateForm.Show();
            }
        }
    }
}
