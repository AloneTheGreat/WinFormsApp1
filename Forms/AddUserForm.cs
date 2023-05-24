using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class adduserForm : Form
    {
        public event EventHandler? ButtonClicked;
        public adduserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            AppContext cn = new AppContext();

            string username = newusername.Text;
            string ssn = SSN.Text;
            string phone = phonetext.Text;
            string email = Emailtext.Text;

            var usersfromDB = (from s in cn.Users
                               where s.SSN == ssn
                               select s).ToList();
            if (usersfromDB.Any())
            {
                lblAddError.Text = "User already exists";
                lblAddError.Visible = true;
            }
            else
            {
                AppContext cnn = new AppContext();
                User newuser = new User()
                {
                    Name = username,
                    SSN = ssn,
                    Email = email,
                    Phone = phone

                };

                cnn.Users.Add(newuser);
                cnn.SaveChanges();

                this.Close();
                if (ButtonClicked != null)
                    ButtonClicked(this, e);
            }
        }

        private void AdduserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
    }
}
