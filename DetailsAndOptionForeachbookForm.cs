using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_MS
{
    public partial class DetailsAndOptionForeachbookForm : Form
    {
        public DetailsAndOptionForeachbookForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditBookForm fe = new EditBookForm();
            fe.Show();
        }
    }
}
