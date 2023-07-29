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
    public partial class ShipperUpdateForm : Form
    {
        private int shipperId;
        private Shipper shipper;
        public ShipperUpdateForm()
        {
            InitializeComponent();
        }
        public ShipperUpdateForm(int id)
        {
            InitializeComponent();
            shipperId= id;
        }

        private void ShipperUpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();

                shipper = dbContext.Shippers.Find(shipperId);
                txtCompanyName.Text = shipper.CompanyName;
                txtPhone.Text = shipper.Phone;
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Ekranına Getirilemedi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                shipper = new Shipper()
                {
                    CompanyName = txtCompanyName.Text,
                    Phone = txtPhone.Text,
                };
                dbContext.Shippers.Update(shipper);
                dbContext.SaveChanges();
                
                MessageBox.Show("Kayıt Başarıyla Güncelendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Güncellenemedi");
            }
        }
    }
}
