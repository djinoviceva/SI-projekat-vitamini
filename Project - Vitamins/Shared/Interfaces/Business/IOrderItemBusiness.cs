using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IOrderItemBusiness
    {
        bool AddNewOrderItem(OrderItem item);
        decimal TotalPrice(decimal price, int quantity);
    }
}
