using System;
using System.Security.Principal;

namespace DesafioTecnico.Domain.ValueObjects
{
    public class JobOpportunityTecnologyValueObject
    {
        public Guid TecnologyId { get; set; }
        public int Weight{ get; set; }
    }
}