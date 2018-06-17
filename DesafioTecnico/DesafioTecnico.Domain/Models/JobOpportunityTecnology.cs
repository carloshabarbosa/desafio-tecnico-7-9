using System.Collections;
using System.Collections.Generic;
using DesafioTecnico.Domain.Core.Models;

namespace DesafioTecnico.Domain.Models
{
    public class JobOpportunityTecnology : Entity
    {
        public int Weight { get; set; }
        
        public JobOpportunity JobOpportunity { get; set; }

        public Tecnology Tecnology { get; set; }
    }
}