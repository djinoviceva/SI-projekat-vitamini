using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class OrderItem
    {
        public int OrderID { get; set; }
        public int VitaminID { get; set; }
        public int Quantity { get; set; }
    }
}
