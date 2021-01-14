using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IVitaminBusiness
    {
        List<Vitamin> GetAllVitamins();
        Vitamin GetRequiredVitamin(Symptom s);
    }
}
