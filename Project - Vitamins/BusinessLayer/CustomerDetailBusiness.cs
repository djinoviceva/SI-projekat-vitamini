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
    public class CustomerDetailBusiness : ICustomerDetailBusiness
    {
        private readonly ICustomerDetailRepository customerDetailRepository;

        public CustomerDetailBusiness(ICustomerDetailRepository _customerDetailRepository)
        {
            this.customerDetailRepository = _customerDetailRepository;
        }
        public bool InsertCustomerDetail(CustomerDetail detail)
        {
            if (this.customerDetailRepository.InsertCustomerDetail(detail) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
