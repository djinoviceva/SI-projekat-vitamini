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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var register = serviceProvider.GetRequiredService<Register>();
                register.ShowDialog();
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<LogIn>();
                login.ShowDialog();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerBusiness, CustomerBusiness>();
            services.AddScoped<Register>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerBusiness, CustomerBusiness>();
            services.AddScoped<LogIn>();
        }
    }
}
