using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Application.Interfaces.Company
{
    public interface ICompanyApplication
    {
        List<Domain.Models.Company> GetCompanies();
        List<Domain.Models.CompanyTecnology> GetCompanyTecnologiesByCompany(Guid companyId);
        Domain.Models.Company GetCompany(Guid id);
        Guid AddCompany(Domain.Models.Company company);
        void EditCompany(Domain.Models.Company company, Guid id);
        bool DeleteCompany(Guid id);
        void AddTecnologyToCompany(CompanyTecnologyValueObject companyTecnologyValueObject);
        void OpenJobOpportunity(JobOpportunityValueObject opportunity);
        List<JobOpportunity> GetJobOpportunitiesByCompanyId(Guid companyId);
    }
}