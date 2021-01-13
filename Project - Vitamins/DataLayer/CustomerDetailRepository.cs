using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerDetailRepository : ICustomerDetailRepository
    {
        public int InsertCustomerDetail(CustomerDetail detail)
        {
            var insert = DBConnection.EditData(string.Format("INSERT INTO CUSTOMER_DETAILS VALUES ('{0}', '{1}')",
                    detail.CustomerID, detail.SymptomID));
            DBConnection.CloseConnection();

            return insert;
        }
    }
}
