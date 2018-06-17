using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Domain.Interfaces.Services.Company
{
    public interface ICompanyService
    {
        List<Models.Company> GetCompanies();
        List<Models.CompanyTecnology> GetTecnologyByCompany(Guid companyId);
        Models.Company GetCompany(Guid id);
        Guid AddCompany(Models.Company company);
        void EditCompany(Models.Company company, Guid id);
        bool DeleteCompany(Guid id);
        void AddTecnologyToCompany(CompanyTecnologyValueObject companyTecnologyValueObject);
        void OpenJobOpportunity(JobOpportunityValueObject opportunity);
    }
}