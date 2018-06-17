using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Repository.JobOpportunity
{
    public interface IJobOpportunityRepository
    {
        List<Models.JobOpportunity> GetJobOpportunities();
        Models.JobOpportunity GetJobOpportunity(Guid id);
        Guid AddJobOpportunity(Models.JobOpportunity jobOpportunity);
        void EditJobOpportunity(Models.JobOpportunity jobOpportunity, Guid id);
        bool DeleteJobOpportunity(Guid id);
    }
}