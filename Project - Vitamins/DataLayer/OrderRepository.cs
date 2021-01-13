using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderRepository : IOrderRepository
    {
        public int AddNewOrder(Order order)
        {
            var insert = DBConnection.EditData(string.Format("INSERT INTO ORDERS VALUES ('{0}', '{1}', '{2}')",
                    order.OrderID, order.CustomerID, order.Date));
            DBConnection.CloseConnection();

            return insert;
        }
    }
}
