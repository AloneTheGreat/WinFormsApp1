using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;


            AppContext cn = new AppContext();

            using (cn)
            {
                var usercount = cn.Users.Count();

                label1.Text = "Number of users";
                textbox1.Text = usercount.ToString();
                var userbook = cn.UserBooks.Count();

                label2.Text = "Number of books Using :";
                textbox2.Text = userbook.ToString();
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;


                textbox3.Visible = false;
                textbox4.Visible = false;
                textBox5.Visible = false;
                resulttextbox.Visible = false;



                cn.SaveChanges();


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            //  label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;


            textbox3.Visible = true;
            textbox4.Visible = true;
            textBox5.Visible = true;
            resulttextbox.Visible = true;



            AppContext cn = new AppContext();
            using (cn)
            {
                label1.Text = "Number of books";
                var boocount = cn.Books.Select(e => e.Title).Count();
                textbox1.Text = boocount.ToString();


                //label2.Text = "Number of Titles ";
                //var books_Titles = cn.Books.Select(e => e.Title).Count();
                //textbox2.Text = books_Titles.ToString();


                label3.Text = "Number of authors ";
                var books_authos = cn.Books.Select(e => e.Author).Count();
                textbox3.Text = books_authos.ToString();


                label4.Text = "all copies we have   ";
                double books_Tcopies = cn.Books.Select(e => e.TotalCopies).Sum();
                textbox4.Text = books_Tcopies.ToString();



                label5.Text = "Number of available copies";
                double books_availablecopies = cn.Books.Select(e => e.AvailableCopies).Sum();
                if (books_Tcopies < books_availablecopies)
                {
                    books_availablecopies = books_Tcopies;

                }
                textBox5.Text = books_availablecopies.ToString();




                label6.Text = "The current percentage of books available";

                try
                {
                    double result = ((books_availablecopies / books_Tcopies) * 100);

                    resulttextbox.Text = result.ToString() + "%";
                }
                catch (Exception ex)
                {
                    label7.Visible = true;
                    label7.Text = "there is no copies in library";


                }

            }
        }
    }
}