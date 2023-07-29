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
    public partial class ShipperCreatForm : Form
    {
        public ShipperCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                var shipper = new Shipper()
                {
                    CompanyName = txtCompanyName.Text,
                    Phone = txtPhone.Text,
                };
                dbContext.Shippers.Add(shipper);
                dbContext.SaveChanges();

                MessageBox.Show("Kayıt Başarıyla Yapıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Yapılamadı");
            }
        }
    }
}
