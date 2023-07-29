namespace EFBasics
{
    public partial class CategoryListForm : Form
    {
        // Entity Framework
        // Nedir? Bir ORM'dir
        // ORM Nedir? Object Relational Mapping demektir
        // Yani o ne demekmi�? Veritaban�ndaki tablolar� ve verileri
        // progpramlama ortam�nda nesnelere d�n��t�ren(map'leyen) yap�lar

        // D�nyadaki tek ORM EF de�ildir
        // Dapper (micro-orm)
        // nHibernate
        // LLBLGen

        // Nereden Ba�l�yoruz?
        // DbContext ad�nda bir s�n�f olu�turarak ba�layaca��z
        // DbContext s�n�f�, ba�lanaca��m�z veritaban�n� temsil eden 
        // ba�lam s�n�f�
        // Ondan sonra, DbContext s�n�f� i�erisinde tablolar� temsil edecek olan
        // DbSet property'lerini ekleyece�iz
        // Ondan sonra servise haz�r, afiyet olsun
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbContext = new NorthWindDbContext();

            // DbSet cinsinden propertylerin (yani Repository'lerin) yan�na
            // ToList() veya ToArray() metodunu yaz�p �a��rmak, bizim AdoNet
            // projesinde yazd���m�z GetAll() metodunu �a��rmakla ayn� i�
            var categories = dbContext.Categories.ToList();

            dataGridView1.DataSource= categories;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchValue = textBox1.Text;

            var dbContext=new NorthWindDbContext();

            var searchCategories = dbContext.Categories
                .Where(c => c.CategoryName.Contains( searchValue))
                .ToList();
            
            //var search= (from c in dbContext.Categories
            //            where c.CategoryName == searchValue
            //            select c).ToList();

            dataGridView1.DataSource= searchCategories;
        }

        private void menuDeleteCategory_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var category=(Category)dataGridView1.SelectedRows[0].DataBoundItem;

                try
                {
                    var dbContext = new NorthWindDbContext();
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                    // Ba�ka Unit Of Work Uyarlamalar�nda bu metodun ad�n�
                    // Commit, CommitChanges, Apply, ApplyChanges �eklinde g�rebilirsiniz

                    MessageBox.Show("Silme ��lemi Ba�ar�l�");

                    dataGridView1.DataSource = dbContext.Categories.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Silme ��lemi Ba�ar�s�z");
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var category = (Category)dataGridView1.SelectedRows[0].DataBoundItem;

                var cateogryUpdateForm = new CategoryUpdateForm(category.CategoryID);
                cateogryUpdateForm.Owner=this.Owner;
                cateogryUpdateForm.Show();
                
            }
        }
    }
}