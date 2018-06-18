using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Application.Interfaces.Candidate
{
    public interface ICandidateApplication
    {
        List<Domain.Models.Candidate> GetCandidates();
        Domain.Models.Candidate GetCandidate(Guid id);
        Guid AddCandidate(CandidateValueObject candidate);
        void EditCandidate(Domain.Models.Candidate candidate, Guid id);
        bool DeleteCandidate(Guid id);
        List<CandidateScoreValueObject> GetCandidatesScoreByJobOpportunity(Guid jobOpportunityId);
    }
}