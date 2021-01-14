using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LogIn : Form
    {
        private readonly ICustomerBusiness customerBusiness;
        public static Customer c;
        private string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public LogIn(ICustomerBusiness _customerBusines)
        {
            this.customerBusiness = _customerBusines;
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEMail.Text) &&
                !string.IsNullOrEmpty(textBoxPassword.Text) &&
                Regex.Match(textBoxEMail.Text, emailRegex).Success)
            {
                string email = textBoxEMail.Text;
                string password = textBoxPassword.Text;

                Customer customer = new Customer();
                customer = customerBusiness.FindCustomer(email, password);
                c = customer;

                if (customer != null)
                {
                    UserHome newForm = new UserHome();
                    newForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Prijava nije uspela! Pokusajte ponovo!");
                    textBoxEMail.Text = "";
                    textBoxPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
        }
    }
}
