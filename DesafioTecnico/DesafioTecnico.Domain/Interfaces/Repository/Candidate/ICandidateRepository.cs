using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Repository.Candidate
{
    public interface ICandidateRepository
    {
        List<Models.Candidate> GetCandidates();
        Models.Candidate GetCandidate(Guid id);
        Guid AddCandidate(Models.Candidate candidate);
        void EditCandidate(Models.Candidate candidate, Guid id);
        bool DeleteCandidate(Guid id);
        
    }
}