using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOrderItemRepository
    {
        int AddNewOrderItem(OrderItem item);
    }
}
