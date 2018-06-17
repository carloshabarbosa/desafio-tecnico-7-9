using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTecnico.Domain.Interfaces.Repository.Company;
using DesafioTecnico.Domain.Interfaces.Services.Company;
using DesafioTecnico.Domain.Interfaces.Services.CompanyTecnology;
using DesafioTecnico.Domain.Interfaces.Services.JobOpportunity;
using DesafioTecnico.Domain.Interfaces.Services.Tecnology;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.Validations.Company;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Domain.Services.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ICompanyTecnologyService _companyTecnologyService;
        private readonly ITecnologyService _tecnologyService;
        private readonly IJobOpportunityService _jobOpportunityService;

        public CompanyService(ICompanyRepository companyRepository, ICompanyTecnologyService companyTecnologyService, ITecnologyService tecnologyService, IJobOpportunityService jobOpportunityService)
        {
            _companyRepository = companyRepository;
            _companyTecnologyService = companyTecnologyService;
            _tecnologyService = tecnologyService;
            _jobOpportunityService = jobOpportunityService;
        }

        public List<Models.Company> GetCompanies()
        {
            return _companyRepository.GetCompanies();
        }

        public List<Models.CompanyTecnology> GetTecnologyByCompany(Guid companyId)
        {
            return _companyTecnologyService.GetCompanyTecnologiesByCompany(companyId);
        }

        public Models.Company GetCompany(Guid id)
        {
            return _companyRepository.GetCompany(id);
        }

        public Guid AddCompany(Models.Company company)
        {
            return company.IsValid() ? _companyRepository.AddCompany(company) : Guid.Empty;
        }

        public void EditCompany(Models.Company company, Guid id)
        {
            if (company.IsValid())
                _companyRepository.EditCompany(company, id);
        }

        public bool DeleteCompany(Guid id)
        {
            return CanDelete(id) && _companyRepository.DeleteCompany(id);
        }

        public void AddTecnologyToCompany(CompanyTecnologyValueObject companyTecnology)
        {
            var companyTecnologyEntity = new Models.CompanyTecnology
            {
                Company = GetCompany(companyTecnology.CompanyId),
                Tecnology = _tecnologyService.GetTecnology(companyTecnology.TecnologyId)
            };
            _companyTecnologyService.AddCompanyTecnology(companyTecnologyEntity);
        }

        public void OpenJobOpportunity(JobOpportunityValueObject opportunity)
        {
            var company = GetCompany(opportunity.CompanyId);
            if (company == null) return;
            company.JobOpportunities = opportunity.Tecnologies
                .Select(c => new Models.JobOpportunity
                {
                    Candidates = null,
                    Description = opportunity.Description,
                    Tecnologies = opportunity.Tecnologies.
                        Select(o => new JobOpportunityTecnology
                        {
                            Tecnology = _tecnologyService.GetTecnology(o.TecnologyId),
                            Weight = o.Weight
                            
                        }).ToList()
                }).ToList();
                
            EditCompany(company, company.Id);
        }

        private bool CanDelete(Guid id)
        {
            var company = new Models.Company {Id = id};
            var validator = new DeleteCompanyValidation().Validate(company);
            return validator.IsValid;
        }
    }
}