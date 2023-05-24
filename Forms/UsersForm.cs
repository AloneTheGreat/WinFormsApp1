using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            grdUser.AutoGenerateColumns = true;
            grdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetUsers();
        }

        public void GetUsers()
        {
            AppContext cn;
            using (cn = new AppContext())
            {
                var users = cn.Users.ToList();
                grdUser.DataSource = users;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AppContext cn = new AppContext();
            string text = txtSearch.Text;
            var usersfromtextsearch = (from s in cn.Users
                                       where s.Name.StartsWith(text) || s.SSN.StartsWith(text)
                                       select s).ToList();
            grdUser.DataSource = usersfromtextsearch;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            adduserForm news = new adduserForm();
            news.ButtonClicked += new EventHandler(AddBookForm_ButtonClicked);
            news.Show(this);
            btnAddUser.Enabled = false;
        }

        private void AddBookForm_ButtonClicked(object? sender, EventArgs e)
        {
            GetUsers();
            btnAddUser.Enabled = true;
        }

        private void GrdUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserDetailForm UDF = new UserDetailForm();
            UDF.Show(this);
        }
    }
}