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
    public class VitaminBusiness : IVitaminBusiness
    {
        private readonly IVitaminRepository vitaminRepository;

        public VitaminBusiness(IVitaminRepository _vitaminRepository)
        {
            this.vitaminRepository = _vitaminRepository;
        }
        public List<Vitamin> GetAllVitamins()
        {
            return this.vitaminRepository.GetAllVitamins();
        }
        public Vitamin GetRequiredVitamin(Symptom s)
        {
            return this.GetRequiredVitamin(s);
        }
    }
}
