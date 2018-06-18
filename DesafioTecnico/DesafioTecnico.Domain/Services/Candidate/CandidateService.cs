using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTecnico.Domain.Interfaces.Repository.Candidate;
using DesafioTecnico.Domain.Interfaces.Services.Candidate;
using DesafioTecnico.Domain.Interfaces.Services.JobOpportunity;
using DesafioTecnico.Domain.Interfaces.Services.Tecnology;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.Validations.Candidate;
using DesafioTecnico.Domain.ValueObjects;

namespace DesafioTecnico.Domain.Services.Candidate
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IJobOpportunityService _jobOpportunityService;
        private readonly ITecnologyService _tecnologyService;

        public CandidateService(ICandidateRepository candidateRepository, IJobOpportunityService jobOpportunityService, ITecnologyService tecnologyService)
        {
            _candidateRepository = candidateRepository;
            _jobOpportunityService = jobOpportunityService;
            _tecnologyService = tecnologyService;
        }

        public List<Models.Candidate> GetCandidates()
        {
            return _candidateRepository.GetCandidates();
        }

        public Models.Candidate GetCandidate(Guid id)
        {
            return _candidateRepository.GetCandidate(id);
        }

        public Guid AddCandidate(CandidateValueObject candidate)
        {
            var candidateEntity = new Models.Candidate
            {
                Address = candidate.Address,
                Cpf = candidate.Cpf,
                JobOpportunity = _jobOpportunityService.GetJobOpportunity(candidate.JobOpportunityId),
                Name = candidate.Name,
                Phone = candidate.Phone,
                Tecnologies = candidate.Tecnologies.Select(c => new CandidateTecnology
                {
                    Tecnology = _tecnologyService.GetTecnology(c)
                }).ToList()
            };
            
            return candidateEntity.IsValid() ? _candidateRepository.AddCandidate(candidateEntity) : Guid.Empty;
        }

        public void EditCandidate(Models.Candidate candidate, Guid id)
        {
            if (candidate.IsValid())
            {
                _candidateRepository.EditCandidate(candidate, id);
            }
        }

        public bool DeleteCandidate(Guid id)
        {
            return CanDelete(id) && _candidateRepository.DeleteCandidate(id);
        }
        
        public List<CandidateScoreValueObject> GetCandidatesScoreByJobOpportunity(Guid jobOpportunityId)
        {
            var jobOpportunity = _jobOpportunityService.GetJobOpportunities()
                .FirstOrDefault(j => j.Id == jobOpportunityId);

            return jobOpportunity.Candidates.Select(c => new CandidateScoreValueObject
                {
                    Id = c.Id,
                    Name = c.Name,
                    Score = c.Tecnologies
                        .Join(jobOpportunity.Tecnologies, 
                            x => x.Tecnology.Id, 
                            y => y.Tecnology.Id, 
                            (x, y) => new { x, y}).Sum(t => t.y.Weight)
                })
                .OrderByDescending(t => t.Score)
                .ToList();
        }

        private bool CanDelete(Guid id)
        {
            var candidate = new Models.Candidate {Id = id};
            var deleteValidator = new DeleteCandidateValidation().Validate(candidate);
            return deleteValidator.IsValid;
        }
        
    }
}