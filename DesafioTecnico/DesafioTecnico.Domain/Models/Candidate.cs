using System;
using System.Collections;
using System.Collections.Generic;
using DesafioTecnico.Domain.Core.Models;
using DesafioTecnico.Domain.Validations.Candidate;

namespace DesafioTecnico.Domain.Models
{
    public class Candidate : Entity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public IList<CandidateTecnology> Tecnologies { get; set; }
        public JobOpportunity JobOpportunity { get; set; }

        public bool IsValid()
        {
            var validator = new CandidateIsValidValidation().Validate(this);
            return validator.IsValid;
        }
    }
}