using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.Models;

namespace DesafioTecnico.Domain.ValueObjects
{
    public class JobOpportunityValueObject
    {
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public List<JobOpportunityTecnologyValueObject> Tecnologies { get; set; }
        
    }
}