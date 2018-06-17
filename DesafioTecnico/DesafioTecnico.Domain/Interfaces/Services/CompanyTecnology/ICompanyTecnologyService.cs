using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Domain.Interfaces.Services.CompanyTecnology
{
    public interface ICompanyTecnologyService
    {
        List<Models.CompanyTecnology> GetCompanyTecnologies();
        List<Models.CompanyTecnology> GetCompanyTecnologiesByCompany(Guid companyId);
        Models.CompanyTecnology GetCompanyTecnology(Guid id);
        Guid AddCompanyTecnology(Models.CompanyTecnology companyTecnology);
        void EditCompanyTecnology(Models.CompanyTecnology companyTecnology, Guid id);
        bool DeleteCompanyTecnology(Guid id);
    }
}