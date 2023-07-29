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
    public partial class EmployeeUpdateForm : Form
    {
        private int employeeId;
        private Employee employee;
        public EmployeeUpdateForm()
        {
            InitializeComponent();
        }
        public EmployeeUpdateForm(int id)
        {
            InitializeComponent();
            employeeId= id;
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            var reportsTo= dbContext.Employees.ToList();
            cmbReportsTo.DataSource= reportsTo;
            cmbReportsTo.DisplayMember = "FullName";
            cmbReportsTo.ValueMember= "EmployeeID";

            employee = dbContext.Employees.Find(employeeId);
            txtLastName.Text = employee.LastName;
            txtName.Text = employee.FirstName;
            txtAdress.Text = employee.Address;
            txtTitle.Text = employee.Title;
            txtTitleOfCourtesy.Text = employee.TitleOfCourtesy;
            dtpBirthDate.Value = (DateTime)employee.BirthDate;
            dtpHireDate.Value = (DateTime)employee.HireDate;
            txtCity.Text = employee.City;
            txtCountry.Text = employee.Country;
            txtRegion.Text = employee.Region;
            txtPostalCode.Text = employee.PostalCode;
            txtHomePhone.Text = employee.HomePhone;
            txtExtension.Text = employee.Extension;
            txtNotes.Text = employee.Notes;
            cmbReportsTo.SelectedValue = employee.ReportsTo.HasValue?employee.ReportsTo.Value:-1;
            txtPhotoPath.Text = employee.PhotoPath;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                employee = new Employee()
                {
                    EmployeeID = employeeId,
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAdress.Text,
                    Title = txtTitle.Text,
                    TitleOfCourtesy = txtTitleOfCourtesy.Text,
                    BirthDate = dtpBirthDate.Value,
                    HireDate = dtpHireDate.Value,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Region = txtRegion.Text,
                    PostalCode = txtPostalCode.Text,
                    HomePhone = txtHomePhone.Text,
                    Extension = txtExtension.Text,
                    Notes = txtNotes.Text,
                    ReportsTo = (int?)cmbReportsTo.SelectedValue,
                    PhotoPath = txtPhotoPath.Text,
                };
                dbContext.Employees.Update(employee);
                dbContext.SaveChanges();

                MessageBox.Show("Kayıt Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Güncellenemedi");
            }
        }
    }
}
