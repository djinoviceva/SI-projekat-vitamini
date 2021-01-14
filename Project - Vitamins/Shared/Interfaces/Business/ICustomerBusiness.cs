using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface ICustomerBusiness
    {
        bool InsertCustomer(Customer customer);
        Customer FindCustomer(string email, string password);
    }
}
