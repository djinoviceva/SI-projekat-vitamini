using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
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

        private void UserHome_Load(object sender, EventArgs e)
        {

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IVitaminRepository, VitaminRepository>();
            services.AddScoped<IVitaminBusiness, VitaminBusiness>();
            services.AddScoped<ShowVitamins>();

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
