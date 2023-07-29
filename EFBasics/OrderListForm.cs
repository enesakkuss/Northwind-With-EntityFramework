using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Veri Tabanı Task/Import Data
namespace EFBasics
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            dataGridView1.DataSource = dbContext.Orders.ToList();
        }
    }
}
