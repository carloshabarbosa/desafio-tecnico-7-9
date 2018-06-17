using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.Models;

namespace DesafioTecnico.Domain.ValueObjects
{
    public class CandidateValueObject 
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Guid> Tecnologies { get; set; }
        public Guid JobOpportunityId { get; set; }
    }
}