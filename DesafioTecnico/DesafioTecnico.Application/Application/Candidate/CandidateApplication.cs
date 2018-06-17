using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Candidate;
using DesafioTecnico.Domain.Interfaces.Services.Candidate;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Application.Application.Candidate
{
    public class CandidateApplication : ICandidateApplication
    {
        private readonly ICandidateService _candidateService;

        public CandidateApplication(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        public List<Domain.Models.Candidate> GetCandidates()
        {
            return _candidateService.GetCandidates();
        }

        public Domain.Models.Candidate GetCandidate(Guid id)
        {
            return _candidateService.GetCandidate(id);
        }

        public Guid AddCandidate(CandidateValueObject candidate)
        {
            return _candidateService.AddCandidate(candidate);
        }

        public void EditCandidate(Domain.Models.Candidate candidate, Guid id)
        {
            _candidateService.EditCandidate(candidate,id);
        }

        public bool DeleteCandidate(Guid id)
        {
            return _candidateService.DeleteCandidate(id);
        }
    }
}