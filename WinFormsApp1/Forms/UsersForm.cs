namespace WinFormsApp1
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            grdUser.AutoGenerateColumns = true;
            grdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}