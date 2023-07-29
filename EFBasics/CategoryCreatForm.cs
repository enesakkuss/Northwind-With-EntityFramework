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
    public partial class CategoryCreatForm : Form
    {
        public CategoryCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category();
                category.CategoryName = txtCategoryName.Text;
                category.Description = txtDescription.Text;

                var dbContext = new NorthWindDbContext();
                dbContext.Categories.Add(category);

                // dbContext -> Unit Of Work -> İş Birimi
                // dbContext'e biriktirilmiş ne kadar EKLENECEK, GÜNCELLENEK VE/VEYA
                // SİLİNECEK kayıt varsa, bunla SaveChanges çağırılana kadar veritabanına
                // gönderilmez.Adı üzerinde, dbContext üzerinde memory (RAM) içinde
                // biriktirilir, bekler..

                dbContext.SaveChanges();

                MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Oluşturulamadı");
            }
            
        }
    }
}
