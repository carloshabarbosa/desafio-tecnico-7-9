using System;

namespace DesafioTecnico.Domain.ValueObjects
{
    public class TecnologyWeightValueObject
    {
        public decimal Weight { get; set; }
        public Guid TecnologyId { get; set; }
        public Guid JobOpportunityId { get; set; }    
    }
}