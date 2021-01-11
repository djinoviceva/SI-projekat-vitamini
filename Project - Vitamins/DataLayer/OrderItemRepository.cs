using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public int AddNewOrderItem(OrderItem item)
        {
            var insert = DBConnection.EditData(string.Format("INSERT INTO ORDER_ITEMS VALUES ('{0}', '{1}', '{2}')",
                    item.OrderID, item.VitaminID, item.Quantity));
            DBConnection.CloseConnection();

            return insert;
        }
    }
}
