using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Candidate;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável por ações da entidade de candidato
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        /// <summary>
        /// Injeção das depências
        /// </summary>
        private readonly ICandidateApplication _candidateApplication;

        public CandidateController(ICandidateApplication candidateApplication)
        {
            _candidateApplication = candidateApplication;
        }

        // GET api/company
        [HttpGet]
        public ActionResult<IEnumerable<Candidate>> Get()
        {
            return _candidateApplication.GetCandidates();
        }

        // GET api/company/5
        [HttpGet("{id}")]
        public ActionResult<Candidate> Get(Guid id)
        {
            return _candidateApplication.GetCandidate(id);
        }

        // POST api/company
        [HttpPost]
        public void Post([FromBody] CandidateValueObject value)
        {
            _candidateApplication.AddCandidate(value);
        }

        // PUT api/company/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Candidate value)
        {
            _candidateApplication.EditCandidate(value, id);
        }

        // DELETE api/company/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _candidateApplication.DeleteCandidate(id);
        }
        
        // GET api/company/GetCandidatesScoreByJobOpportunity/5
        [HttpGet("{id}")]
        [Route("GetCandidatesScoreByJobOpportunity/{id}")]
        public ActionResult<IEnumerable<CandidateScoreValueObject>> GetCandidatesScoreByJobOpportunity(Guid id)
        {
            return _candidateApplication.GetCandidatesScoreByJobOpportunity(id);
        }

    }
}