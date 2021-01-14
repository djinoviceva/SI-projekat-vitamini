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
    public class OrderItemBusiness : IOrderItemBusiness
    {
        private readonly IOrderItemRepository orderItemRepository;

        public OrderItemBusiness(IOrderItemRepository _orderItemRepository)
        {
            this.orderItemRepository = _orderItemRepository;
        }
        public bool AddNewOrderItem(OrderItem item)
        {
            if (this.orderItemRepository.AddNewOrderItem(item) > 0)
            {
                return true;
            }
            return false;
        }
        public decimal TotalPrice(decimal price, int quantity)
        {
            return price * quantity;
        }
    }
}
