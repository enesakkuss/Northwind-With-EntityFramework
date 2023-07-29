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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();
            dataGridView1.DataSource= dbContext.Employees.ToList();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuEmployeeDeleteForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                try
                {
                    var employee = (Employee)dataGridView1.SelectedRows[0].DataBoundItem;

                    var dbContext = new NorthWindDbContext();
                    dbContext.Employees.Remove(employee);
                    dbContext.SaveChanges();

                    MessageBox.Show("Kayıt Başarıyla Silindi");

                    dataGridView1.DataSource = dbContext.Employees.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }

            }
        }

        private void menuEmployeeUpdateForm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var employee = (Employee)dataGridView1.SelectedRows[0].DataBoundItem;

                var employeeUpdateForm = new EmployeeUpdateForm(employee.EmployeeID);
                employeeUpdateForm.Owner= this.Owner;
                employeeUpdateForm.Show();
            }
        }
    }
}
