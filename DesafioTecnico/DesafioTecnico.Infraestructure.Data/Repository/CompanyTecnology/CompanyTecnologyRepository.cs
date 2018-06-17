using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTecnico.Domain.Interfaces.Repository.CompanyTecnology;
using DesafioTecnico.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DesafioTecnico.Infraestructure.Data.Repository.CompanyTecnology
{
    public class CompanyTecnologyRepository : Repository<Domain.Models.CompanyTecnology>, ICompanyTecnologyRepository 
    {
        public CompanyTecnologyRepository(DesafioTecnicoContext context) : base(context)
        {
        }

        public List<Domain.Models.CompanyTecnology> GetCompanyTecnologies()
        {
            return GetAll().ToList();
        }

        public List<Domain.Models.CompanyTecnology> GetCompanyTecnologiesByCompany(Guid companyId)
        {
            return GetAll()
                .Where(c => c.Company.Id == companyId)
                .Include(c => c.Tecnology)
                .ToList();
        }
        public Domain.Models.CompanyTecnology GetCompanyTecnology(Guid id)
        {
            return GetById(id);
        }

        public Guid AddCompanyTecnology(Domain.Models.CompanyTecnology companyTecnology)
        {
            companyTecnology.CreatedAt = DateTime.Now;
            
            Add(companyTecnology);
            SaveChanges();
            return companyTecnology.Id;
        }

        public void EditCompanyTecnology(Domain.Models.CompanyTecnology companyTecnology, Guid id)
        {
            var companyTecnologyBase = GetById(id);
            companyTecnologyBase.Company = companyTecnology.Company;
            companyTecnologyBase.Tecnology = companyTecnology.Tecnology;
            Update(companyTecnologyBase);
            SaveChanges();
        }

        public bool DeleteCompanyTecnology(Guid id)
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