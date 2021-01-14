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
    public partial class ShowVitamins : Form
    {
        private readonly IVitaminBusiness vitaminBusiness;
        public ShowVitamins(IVitaminBusiness _vitaminBusiness)
        {
            this.vitaminBusiness = _vitaminBusiness;
            InitializeComponent();
        }

        private void HomeSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHome newForm = new UserHome();
            newForm.ShowDialog();
        }

        private void ChooseSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var chooseSymptom = serviceProvider.GetRequiredService<ChooseSymptom>();
                chooseSymptom.ShowDialog();
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.ShowDialog();
        }

        private void ShowVitamins_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<Vitamin> vitamins = this.vitaminBusiness.GetAllVitamins();
            listBoxShowVitamins.Items.Clear();

            foreach (Vitamin v in vitamins)
            {
                listBoxShowVitamins.Items.Add(v.VitaminID + ". " + v.VitaminName + " (" + v.Manufacturer + ") - " +
                    v.Price);
            }
        }

        private void buttonChooseSymptom_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var chooseSymptom = serviceProvider.GetRequiredService<ChooseSymptom>();
                chooseSymptom.ShowDialog();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IVitaminRepository, VitaminRepository>();
            services.AddScoped<IVitaminBusiness, VitaminBusiness>();
            services.AddScoped<ISymptomRepository, SymptomRepository>();
            services.AddScoped<ISymptomBusiness, SymptomBusiness>();
            services.AddScoped<ICustomerDetailRepository, CustomerDetailRepository>();
            services.AddScoped<ICustomerDetailBusiness, CustomerDetailBusiness>();
            services.AddScoped<ChooseSymptom>();
        }
    }
}
