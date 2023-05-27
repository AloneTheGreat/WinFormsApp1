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
        }

        private void clean_Screen()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textbox1.Visible = false;
            textbox2.Visible = false;
            textbox3.Visible = false;
            textbox4.Visible = false;
            textBox5.Visible = false;
            resulttextbox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean_Screen();
            label1.Visible = true;
            label2.Visible = true;

            textbox1.Visible = true; 
            textbox2.Visible = true;


            AppContext cn = new AppContext();

            using (cn)
            {
                var usercount = cn.Users.Count();
                label1.Text = "Number of users :";
                textbox1.Text = usercount.ToString();

                var userbook = cn.UserBooks.Count();
                label2.Text = "Number of Active Users :";
                textbox2.Text = userbook.ToString();

                cn.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean_Screen();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;

            textbox1.Visible = true;
            textbox2.Visible = true;
            textbox3.Visible = true;
            textbox4.Visible = true;
            resulttextbox.Visible = true;



            AppContext cn = new AppContext();
            using (cn)
            {
                label1.Text = "Number of books";
                var boocount = cn.Books.Select(e => e.Title).Count();
                textbox1.Text = boocount.ToString();


                label2.Text = "Number of authors ";
                var books_authos = cn.Books.Select(e => e.Author).Count();
                textbox2.Text = books_authos.ToString();


                label3.Text = "all copies we have   ";
                float books_Tcopies = cn.Books.Select(e => e.TotalCopies).Sum();
                textbox3.Text = books_Tcopies.ToString();



                label4.Text = "Number of available copies";
                float books_availablecopies = cn.Books.Select(e => e.AvailableCopies).Sum();
                if (books_Tcopies < books_availablecopies)
                {
                    books_availablecopies = books_Tcopies;

                }
                textbox4.Text = books_availablecopies.ToString();




                label6.Text = "The current percentage of books available";

                try
                {
                    float result = (books_availablecopies / books_Tcopies) * 100f;

                    resulttextbox.Text = result.ToString("N2") + "%";
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