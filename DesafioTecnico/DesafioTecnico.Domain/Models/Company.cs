using System.Collections.Generic;
using DesafioTecnico.Domain.Core.Models;
using DesafioTecnico.Domain.Validations.Company;

namespace DesafioTecnico.Domain.Models
{
    public class Company : Entity
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public IList<CompanyTecnology> Tecnologies { get; set; }
        public IList<JobOpportunity> JobOpportunities { get; set; }

        public bool IsValid()
        {
            var validation = new CompanyIsValidValidation().Validate(this);
            return validation.IsValid;
        }
    }
}