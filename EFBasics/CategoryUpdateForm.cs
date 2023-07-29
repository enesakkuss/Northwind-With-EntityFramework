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
    public partial class CategoryUpdateForm : Form
    {
        private Category _category;
        private int categoryId;
        public CategoryUpdateForm(int id)
        {
            InitializeComponent();
            categoryId = id;
        }
        public CategoryUpdateForm()
        {
            InitializeComponent();
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new NorthWindDbContext();
                _category = dbContext.Categories.Find(categoryId);
                txtCategoryName.Text = _category.CategoryName;
                txtDescription.Text = _category.Description;
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
                _category = new Category()
                {
                    CategoryID = categoryId,
                    CategoryName = txtCategoryName.Text,
                    Description = txtDescription.Text,
                };
                dbContext.Update(_category);
                dbContext.SaveChanges();

                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncellenemedi");
            }
            
        }
    }
}
