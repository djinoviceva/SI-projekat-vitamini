using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Vitamin
    {
        public int VitaminID { get; set; }
        public string VitaminName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
