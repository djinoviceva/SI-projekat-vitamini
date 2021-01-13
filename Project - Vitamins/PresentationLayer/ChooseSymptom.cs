using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
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
    public partial class ChooseSymptom : Form
    {
        private readonly IVitaminBusiness vitaminBusiness;
        private readonly ISymptomBusiness symptomBusiness;
        private readonly ICustomerDetailBusiness customerDetailBusiness;
        public static Vitamin vitamin;
        public static int Quantity;

        public ChooseSymptom(IVitaminBusiness _vitaminBusiness, ISymptomBusiness _symptomBusiness, ICustomerDetailBusiness _customerDetailBusiness)
        {
            this.vitaminBusiness = _vitaminBusiness;
            this.symptomBusiness = _symptomBusiness;
            this.customerDetailBusiness = _customerDetailBusiness;
            InitializeComponent();
        }
        private void HomeSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHome newForm = new UserHome();
            newForm.ShowDialog();
        }

        private void VitaminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var showVitamins = serviceProvider.GetRequiredService<ShowVitamins>();
                showVitamins.ShowDialog();
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.ShowDialog();
        }

        private void ChooseSymptom_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSuggestVitamin_Click(object sender, EventArgs e)
        {
            List<RadioButton> buttons = new List<RadioButton>();

            buttons.Add(radioButtonS1);
            buttons.Add(radioButtonS2);
            buttons.Add(radioButtonS3);
            buttons.Add(radioButtonS4);
            buttons.Add(radioButtonS5);
            buttons.Add(radioButtonS6);
            buttons.Add(radioButtonS7);

            for(int i=0; i < buttons.Count; i++)
            {
                if (buttons[i].Checked)
                {
                    Symptom s = new Symptom();
                    string description = buttons[i].Text;

                    s = symptomBusiness.FindSymptom(description);

                    /*CustomerDetail detail = new CustomerDetail();
                    detail.CustomerID = LogIn.c.CustomerID;
                    detail.SymptomID = s.SymptomID;

                    if (customerDetailBusiness.InsertCustomerDetail(detail) == true)
                    {
                        MessageBox.Show("Na osnovu unetih simptoma, vitamin je predlozen! Mozete ga poruciti klikom na dugme 'Poruci'!");
                    }*/

                    Vitamin v = new Vitamin();
                    v = vitaminBusiness.GetRequiredVitamin(s);
                    vitamin = v;

                    listBoxSuggestedVitamin.Items.Add(v.VitaminID + ". " + v.VitaminName + " (" + v.Manufacturer + ") - " +
                    v.Price);
                }
                /*else
                {
                    MessageBox.Show("Niste izabrali simptom. Potrebno je da izaberete jedan simptom!");
                }*/
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            Quantity = Convert.ToInt32(textBoxQuantity.Text);
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var orderConfirmation = serviceProvider.GetRequiredService<OrderConfirmation>();
                orderConfirmation.ShowDialog();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IVitaminRepository, VitaminRepository>();
            services.AddScoped<IVitaminBusiness, VitaminBusiness>();
            services.AddScoped<ShowVitamins>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderBusiness, OrderBusiness>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IOrderItemBusiness, OrderItemBusiness>();
            services.AddScoped<OrderConfirmation>();
        }
    }
}
