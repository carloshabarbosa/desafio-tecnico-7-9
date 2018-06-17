using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DesafioTecnico.Domain.Interfaces.Repository;
using DesafioTecnico.Domain.Interfaces.Repository.Candidate;
using DesafioTecnico.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;

namespace DesafioTecnico.Infraestructure.Data.Repository.Candidate
{
    public class CandidateRepository : Repository<Domain.Models.Candidate>, ICandidateRepository
    {
        
        public CandidateRepository(DesafioTecnicoContext context) : base(context)
        {
        }

        public List<Domain.Models.Candidate> GetCandidates()
        {
            return GetAll().ToList();
        }

        public Domain.Models.Candidate GetCandidate(Guid id)
        {
            return GetById(id);
        }

        public Guid AddCandidate(Domain.Models.Candidate candidate)
        {
            candidate.CreatedAt = DateTime.Now;
            Add(candidate);
            SaveChanges();
            return candidate.Id;
        }

        public void EditCandidate(Domain.Models.Candidate candidate, Guid id)
        {
            var candidateBase = GetById(id);
            candidate.Address = candidate.Address;
            candidateBase.Cpf = candidate.Cpf;
            candidateBase.JobOpportunity = candidate.JobOpportunity;
            candidateBase.Name = candidate.Name;
            candidateBase.Phone = candidate.Phone;
            candidateBase.Tecnologies = candidate.Tecnologies;
            Update(candidateBase);
            SaveChanges();
            
        }

        public bool DeleteCandidate(Guid id)
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