using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LogIn : Form
    {
        private readonly ICustomerBusiness customerBusiness;
        public static Customer c;
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
    }
}
