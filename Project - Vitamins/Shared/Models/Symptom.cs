using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Symptom
    {
        public int SymptomID { get; set; }
        public string Description { get; set; }
        public int VitaminID { get; set; }
    }
}
