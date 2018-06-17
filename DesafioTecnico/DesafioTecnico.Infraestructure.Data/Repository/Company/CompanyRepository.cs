using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTecnico.Domain.Interfaces.Repository.Company;
using DesafioTecnico.Infraestructure.Data.Context;

namespace DesafioTecnico.Infraestructure.Data.Repository.Company
{
    public class CompanyRepository : Repository<Domain.Models.Company>, ICompanyRepository
    {
        public CompanyRepository(DesafioTecnicoContext context) : base(context)
        {
        }

        public List<Domain.Models.Company> GetCompanies()
        {
            return GetAll().ToList();
        }

        public Domain.Models.Company GetCompany(Guid id)
        {
            return GetById(id);
        }

        public Guid  AddCompany(Domain.Models.Company company)
        {
            company.CreatedAt = DateTime.Now;
            Add(company);
            SaveChanges();

            return company.Id;
        }

        public void EditCompany(Domain.Models.Company company, Guid id)
        {
            var companyBase = GetById(id);
            companyBase.Address = company.Address;
            companyBase.Cnpj = company.Cnpj;
            companyBase.Name = company.Name;
            companyBase.JobOpportunities = company.JobOpportunities;
            companyBase.Tecnologies = company.Tecnologies;
            Update(companyBase);
            SaveChanges();
        }

        public bool DeleteCompany(Guid id)
        {
            try
            {
                Remove(id);
                SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            
            
        }
    }
}