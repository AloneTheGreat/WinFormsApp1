using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.Models;
using System.Collections;

namespace WinFormsApp1
{
    public partial class BooksForm : Form
    {

        public BooksForm()
        {
            InitializeComponent();
            grdBooks.AutoGenerateColumns = true;
            grdBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetCategories();
            GetBooks(0);
        }

        public void GetBooks(int index)
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                if (index == 0)
                {
                    var books = cn.Books.ToList();
                    grdBooks.DataSource = books;
                }
                else
                {
                    var books = cn.Books.Where(b => b.Category.Id == index).ToList();
                    grdBooks.DataSource = books;
                }
            }
            grdBooks.Refresh();
        }

        public void GetBooks(int index, string search)
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                if (index == 0)
                {
                    var books = cn.Books.Where(b => b.Title.StartsWith(search)).ToList();
                    grdBooks.DataSource = books;
                }
                else
                {
                    var books = cn.Books.Where(b => b.Category.Id == index).Where(b => b.Title.StartsWith(search)).ToList();
                    grdBooks.DataSource = books;
                }
            }
            grdBooks.Refresh();
        }

        public void GetCategories()
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                var c = cn.Categories.ToList();
                Category all = new Category() { Id = 0, Name = "All" };
                c.Add(all);
                c.Sort((x, y) => x.Id.CompareTo(y.Id));
                categories.DisplayMember = "Name";
                categories.ValueMember = "Id";
                categories.DataSource = c;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDetailForm f = new BookDetailForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBookForm fn = new AddBookForm();
            fn.Show();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (int)categories.SelectedValue;
            GetBooks(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            int index = (int)categories.SelectedValue;
            GetBooks(index, text);
        }
    }
}