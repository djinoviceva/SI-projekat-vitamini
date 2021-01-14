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
    public partial class Register : Form
    {
        private readonly ICustomerBusiness customerBusiness;
        private string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public Register(ICustomerBusiness _customerBusines)
        {
            this.customerBusiness = _customerBusines;
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) &&
                !string.IsNullOrEmpty(textBoxSurname.Text) &&
                !string.IsNullOrEmpty(textBoxAdress.Text) &&
                !string.IsNullOrEmpty(textBoxCity.Text) &&
                !string.IsNullOrEmpty(textBoxPhone.Text) &&
                !string.IsNullOrEmpty(textBoxEMail.Text) &&
                !string.IsNullOrEmpty(textBoxPassword.Text) &&
                Regex.Match(textBoxEMail.Text, emailRegex).Success)
            {
                Customer c = new Customer();
                c.Name = textBoxName.Text;
                c.Surname = textBoxSurname.Text;
                c.Adress = textBoxAdress.Text;
                c.City = textBoxCity.Text;
                c.PhoneNumber = textBoxPhone.Text;
                c.email = textBoxEMail.Text;
                c.Password = textBoxPassword.Text;

                if (customerBusiness.InsertCustomer(c) == true)
                {
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxAdress.Text = "";
                    textBoxCity.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEMail.Text = "";
                    textBoxPassword.Text = "";

                    Home newForm = new Home();
                    newForm.ShowDialog();
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxAdress.Text = "";
                    textBoxCity.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEMail.Text = "";
                    textBoxPassword.Text = "";
                    MessageBox.Show("Registracija nije uspela! Pokusajte ponovo!");
                }
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
        }
    }
}
