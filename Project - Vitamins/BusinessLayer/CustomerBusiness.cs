using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerBusiness(ICustomerRepository _customerRepository)
        {
            this.customerRepository = _customerRepository;
        }
        public bool InsertCustomer(Customer customer)
        {
            if (this.customerRepository.InsertCustomer(customer) > 0)
            {
                return true;
            }
            return false;
        }
        public Customer FindCustomer(string email, string password)
        {
            return this.customerRepository.FindCustomer(email, password);
        }
    }
}
