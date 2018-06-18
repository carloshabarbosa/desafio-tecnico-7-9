using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Services.JobOpportunity
{
    public interface IJobOpportunityService
    {
        List<Models.JobOpportunity> GetJobOpportunities();
        Models.JobOpportunity GetJobOpportunity(Guid id);
        Guid AddJobOpportunity(Models.JobOpportunity jobOpportunity);
        void EditJobOpportunity(Models.JobOpportunity jobOpportunity, Guid id);
        bool DeleteJobOpportunity(Guid id);
        List<Models.JobOpportunity> GetJobOpportunitiesByCompanyId(Guid companyId);
    }
}