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
    public partial class EmployeeCreatForm : Form
    {
        public EmployeeCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                var employee = new Employee()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Title = txtTitle.Text,
                    TitleOfCourtesy = txtTitleOfCourtesy.Text,
                    BirthDate = dtpBirthDate.Value,
                    HireDate = dtpHireDate.Value,
                    Address = txtAdress.Text,
                    City = txtCity.Text,
                    Region = txtRegion.Text,
                    PostalCode = txtPostalCode.Text,
                    Country = txtCountry.Text,
                    HomePhone = txtHomePhone.Text,
                    Extension = txtExtension.Text,
                    Notes = txtNotes.Text,
                    ReportsTo = (int?)cmbReportsTo.SelectedValue,
                    PhotoPath = txtPhotoPath.Text
                };
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                MessageBox.Show("Yeni Kayıt Başarıyla Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Yeni Kayıt Eklenemedi");
                
            }
            
        }

        private void EmployeeCreatForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var employee = dbContext.Employees.ToList();
            cmbReportsTo.DataSource = employee;
            cmbReportsTo.ValueMember = "EmployeeID";
            cmbReportsTo.DisplayMember = "FullName";

        }
    }
}
