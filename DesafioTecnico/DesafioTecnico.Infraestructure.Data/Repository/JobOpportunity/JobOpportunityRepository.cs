using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTecnico.Domain.Interfaces.Repository.JobOpportunity;
using DesafioTecnico.Infraestructure.Data.Context;

namespace DesafioTecnico.Infraestructure.Data.Repository.JobOpportunity
{
    public class JobOpportunityRepository : Repository<Domain.Models.JobOpportunity>, IJobOpportunityRepository
    {
        public JobOpportunityRepository(DesafioTecnicoContext context) : base(context)
        {
        }

        public List<Domain.Models.JobOpportunity> GetJobOpportunities()
        {
            return GetAll().ToList();
        }

        public Domain.Models.JobOpportunity GetJobOpportunity(Guid id)
        {
            return GetById(id);
        }

        public Guid AddJobOpportunity(Domain.Models.JobOpportunity jobOpportunity)
        {
            jobOpportunity.CreatedAt = DateTime.Now;
            Add(jobOpportunity);
            SaveChanges();
            return jobOpportunity.Id;
        }

        public void EditJobOpportunity(Domain.Models.JobOpportunity jobOpportunity, Guid id)
        {
            var jobOpportunityBase = GetById(id);
            jobOpportunityBase.Candidates = jobOpportunity.Candidates;
            jobOpportunityBase.Company = jobOpportunity.Company;
            jobOpportunityBase.Description = jobOpportunity.Description;
            jobOpportunityBase.Tecnologies = jobOpportunity.Tecnologies;

            Update(jobOpportunityBase);
            SaveChanges();
            
        }

        public bool DeleteJobOpportunity(Guid id)
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