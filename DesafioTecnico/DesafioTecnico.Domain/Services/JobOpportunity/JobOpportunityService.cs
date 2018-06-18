using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using DesafioTecnico.Domain.Interfaces.Repository.JobOpportunity;
using DesafioTecnico.Domain.Interfaces.Services.JobOpportunity;

namespace DesafioTecnico.Domain.Services.JobOpportunity
{
    public class JobOpportunityService : IJobOpportunityService
    {
        private readonly IJobOpportunityRepository _jobOpportunityRepository;

        public JobOpportunityService(IJobOpportunityRepository jobOpportunityRepository)
        {
            _jobOpportunityRepository = jobOpportunityRepository;
        }

        public List<Models.JobOpportunity> GetJobOpportunities()
        {
            return _jobOpportunityRepository.GetJobOpportunities();
        }

        public Models.JobOpportunity GetJobOpportunity(Guid id)
        {
            return _jobOpportunityRepository.GetJobOpportunity(id);
        }

        public Guid AddJobOpportunity(Models.JobOpportunity jobOpportunity)
        {
            return _jobOpportunityRepository.AddJobOpportunity(jobOpportunity);
        }

        public void EditJobOpportunity(Models.JobOpportunity jobOpportunity, Guid id)
        {
            _jobOpportunityRepository.EditJobOpportunity(jobOpportunity, id);
        }

        public bool DeleteJobOpportunity(Guid id)
        {
            return _jobOpportunityRepository.DeleteJobOpportunity(id);
        }

        public List<Models.JobOpportunity> GetJobOpportunitiesByCompanyId(Guid companyId)
        {
            return _jobOpportunityRepository.GetJobOpportunities().Where(j => j.Company.Id == companyId)
                .Select(c => new Models.JobOpportunity
                {
                    Description = c.Description,
                    Id = c.Id
                })
                .ToList();
        }
    }
}