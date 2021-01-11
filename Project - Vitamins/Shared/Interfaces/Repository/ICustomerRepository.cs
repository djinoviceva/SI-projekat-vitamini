using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface ICustomerRepository
    {
        int InsertCustomer(Customer customer);
        Customer FindCustomer(String email, String password);
    }
}
