using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AppContext cn = new AppContext();
            using (cn)
            {
                var usercount = cn.Users.Count();
                userccount.Visible = true;
                userccount.Text = "Number of users";
                usercounttextbox.Text = usercount.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppContext cn = new AppContext();
            using (cn)
            {

                var boocount = cn.Books.Count();
                userccount.Visible = true;
                userccount.Text = "Number of books";
                usercounttextbox.Text = boocount.ToString();

            }

        }
    }
}
