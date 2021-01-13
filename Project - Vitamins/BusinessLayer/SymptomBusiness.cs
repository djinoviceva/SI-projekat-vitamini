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
    public class SymptomBusiness : ISymptomBusiness
    {
        private readonly ISymptomRepository symptomRepository;

        public SymptomBusiness(ISymptomRepository _symptomRepository)
        {
            this.symptomRepository = _symptomRepository;
        }
        public Symptom FindSymptom(string description)
        {
            return this.symptomRepository.FindSymptom(description);
        }
    }
}
