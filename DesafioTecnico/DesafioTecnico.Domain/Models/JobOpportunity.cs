using System.Collections;
using System.Collections.Generic;
using DesafioTecnico.Domain.Core.Models;
    
namespace DesafioTecnico.Domain.Models
{
    public class JobOpportunity : Entity
    {
        public string Description { get; set; }
        public IList<JobOpportunityTecnology> Tecnologies { get; set; }
        public IList<Candidate> Candidates { get; set; }
        public Company Company { get; set; }
    }
}