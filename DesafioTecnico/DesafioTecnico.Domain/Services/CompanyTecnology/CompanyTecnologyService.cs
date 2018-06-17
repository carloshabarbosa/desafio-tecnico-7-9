using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.Interfaces.Repository.CompanyTecnology;
using DesafioTecnico.Domain.Interfaces.Services.Company;
using DesafioTecnico.Domain.Interfaces.Services.CompanyTecnology;
using DesafioTecnico.Domain.Interfaces.Services.Tecnology;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Domain.Services.CompanyTecnology
{
    public class CompanyTecnologyService : ICompanyTecnologyService
    {
        private readonly ICompanyTecnologyRepository _companyTecnologyRepository;
        private readonly ITecnologyService _tecnologyService;

        public CompanyTecnologyService(ICompanyTecnologyRepository companyTecnologyRepository,
            ITecnologyService tecnologyService)
        {
            _companyTecnologyRepository = companyTecnologyRepository;
            _tecnologyService = tecnologyService;
        }

        public List<Models.CompanyTecnology> GetCompanyTecnologies()
        {
            return _companyTecnologyRepository.GetCompanyTecnologies();
        }

        public List<Models.CompanyTecnology> GetCompanyTecnologiesByCompany(Guid companyId)
        {
            return _companyTecnologyRepository.GetCompanyTecnologiesByCompany(companyId);
        }

        public Models.CompanyTecnology GetCompanyTecnology(Guid id)
        {
            return _companyTecnologyRepository.GetCompanyTecnology(id);
        }

        public Guid AddCompanyTecnology(Models.CompanyTecnology companyTecnology)
        {
            return _companyTecnologyRepository.AddCompanyTecnology(companyTecnology);
        }

        public void EditCompanyTecnology(Models.CompanyTecnology companyTecnology, Guid id)
        {

            _companyTecnologyRepository.EditCompanyTecnology(companyTecnology, id);
        }

        public bool DeleteCompanyTecnology(Guid id)
        {
            return _companyTecnologyRepository.DeleteCompanyTecnology(id);
        }

      
    }
}