using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Repository.CompanyTecnology
{
    public interface ICompanyTecnologyRepository
    {
        List<Models.CompanyTecnology> GetCompanyTecnologies();
        List<Models.CompanyTecnology> GetCompanyTecnologiesByCompany(Guid companyId);
        Models.CompanyTecnology GetCompanyTecnology(Guid id);
        Guid AddCompanyTecnology(Models.CompanyTecnology companyTecnology);
        void EditCompanyTecnology(Models.CompanyTecnology companyTecnology, Guid id);
        bool DeleteCompanyTecnology(Guid id);
        
        
    }
}