using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Repository.Company
{
    public interface ICompanyRepository
    {
        List<Models.Company> GetCompanies();
        Models.Company GetCompany(Guid id);
        Guid AddCompany(Models.Company company);
        void EditCompany(Models.Company company, Guid id);
        bool DeleteCompany(Guid id);
    }
}