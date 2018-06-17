using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Company;
using DesafioTecnico.Domain.Interfaces.Services;
using DesafioTecnico.Domain.Interfaces.Services.Company;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Application.Application.Company
{
    public class CompanyApplication : ICompanyApplication
    {
        private readonly ICompanyService _companyService;

        public CompanyApplication(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public List<Domain.Models.Company> GetCompanies()
        {
            return _companyService.GetCompanies();
        }

        public List<Domain.Models.CompanyTecnology> GetCompanyTecnologiesByCompany(Guid companyId)
        {
            return _companyService.GetTecnologyByCompany(companyId);
        }

        public Domain.Models.Company GetCompany(Guid id)
        {
            return _companyService.GetCompany(id);
        }

        public Guid AddCompany(Domain.Models.Company company)
        {
            return _companyService.AddCompany(company);
        }

        public void EditCompany(Domain.Models.Company company, Guid id)
        {
            _companyService.EditCompany(company, id);
        }

        public bool DeleteCompany(Guid id)
        {
            return _companyService.DeleteCompany(id);
        }

        public void AddTecnologyToCompany(CompanyTecnologyValueObject companyTecnologyValueObject)
        {
            _companyService.AddTecnologyToCompany(companyTecnologyValueObject);
        }

        public void OpenJobOpportunity(JobOpportunityValueObject opportunity)
        {
            _companyService.OpenJobOpportunity(opportunity);
        }
    }
}