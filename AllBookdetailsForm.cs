namespace library_MS
{
    public partial class AllBookdetailsForm : Form
    {
        public AllBookdetailsForm()
        {
            InitializeComponent();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsAndOptionForeachbookForm f = new DetailsAndOptionForeachbookForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewBookForm fn = new AddNewBookForm();
            fn.Show(); 
        }
    }
}