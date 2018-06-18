using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Domain.Interfaces.Services.Candidate
{
    public interface ICandidateService
    {
        List<Models.Candidate> GetCandidates();
        Models.Candidate GetCandidate(Guid id);
        Guid AddCandidate(CandidateValueObject candidate);
        void EditCandidate(Models.Candidate candidate, Guid id);
        bool DeleteCandidate(Guid id);
        List<CandidateScoreValueObject> GetCandidatesScoreByJobOpportunity(Guid jobOpportunityId);
    }
}