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
    public partial class OrderDetailForm : Form
    {

        public OrderDetailForm()
        {
            InitializeComponent();
        }

        private void OrderProductList_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            cmbProduct.DataSource = dbContext.Products.ToList();
            cmbProduct.DisplayMember= "ProductName";
            cmbProduct.ValueMember= "ProductID";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             var product=(Product)cmbProduct.SelectedItem;

            var orderDetail = new OrderDetailViewModel
            {
                ProductId = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice.HasValue ? product.UnitPrice.Value : 0,
                Quantity = (short)numQuantity.Value,
                Discount = numDiscount.Value,
            };

            OrderDetailCreated?.Invoke(orderDetail);
            Close();
            // Eğer bildiğimiz, klasik yöntemle Formlar arası (nesneler arası)
            // iletişim ile bu işi çözmeye çalışsaydım, aşağıdaki gibi OrderCreateForm
            // üzerindeki public bir metodu çağırıp OrderDetail nesnesini oraya gönderebilirdim
            //_orderCreateForm.AddOrderDetail(orderDetail);


            //OrderDetailCreated(orderDetail);
        }

        public event OrderDetailCreatedEventHandler OrderDetailCreated;

        private void btnCancel_Click(object sender, EventArgs e)
        {
             var orderDetails = new OrderDetailForm();

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem != null)
            {
                var product = (Product)cmbProduct.SelectedItem;
                txtUnitPrice.Text = product.UnitPrice.HasValue
                    ? product.UnitPrice.Value.ToString()
                    : string.Empty;
            }
            else
            {
                txtUnitPrice.Text = string.Empty;
            }
        }
    }
}
