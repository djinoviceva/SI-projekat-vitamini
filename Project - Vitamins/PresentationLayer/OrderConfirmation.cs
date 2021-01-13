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
    public partial class OrderConfirmation : Form
    {
        private readonly IOrderBusiness orderBusiness;
        private readonly IOrderItemBusiness orderItemBusiness;
        public OrderConfirmation (IOrderBusiness _orderBusiness, IOrderItemBusiness _orderItemBusiness)
        {
            this.orderBusiness = _orderBusiness;
            this.orderItemBusiness = _orderItemBusiness;
            InitializeComponent();
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {
            listBoxCustomer.MultiColumn = true;
            listBoxCustomer.Items.Add("Ime i prezime: " + LogIn.c.Name + " " + LogIn.c.Surname);
            listBoxCustomer.Items.Add("Adresa: " + LogIn.c.Adress);
            listBoxCustomer.Items.Add("Grad: " + LogIn.c.City);
            listBoxCustomer.Items.Add("Broj telefona: " + LogIn.c.PhoneNumber);
            listBoxCustomer.Items.Add("e-mail: " + LogIn.c.email);

            listBoxOrder.Items.Add(ChooseSymptom.vitamin.VitaminName + " - " 
                + ChooseSymptom.vitamin.Manufacturer + " - " + ChooseSymptom.Quantity + "kom.");

            textBoxTotal.Text = Convert.ToString(orderItemBusiness.TotalPrice(ChooseSymptom.vitamin.Price,
                ChooseSymptom.Quantity));
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Order o = new Order();
            o.OrderID = random.Next(1000, 10000);
            o.CustomerID = LogIn.c.CustomerID;
            o.Date = DateTime.Now;

            if (orderBusiness.AddNewOrder(o) == true)
            {
                OrderItem item = new OrderItem();
                item.OrderID = o.OrderID;
                item.VitaminID = ChooseSymptom.vitamin.VitaminID;
                item.Quantity = ChooseSymptom.Quantity;

                if (orderItemBusiness.AddNewOrderItem(item) == true)
                {
                    MessageBox.Show("Porudzbina je kreirana!");
                }
            }
        }
    }
}
