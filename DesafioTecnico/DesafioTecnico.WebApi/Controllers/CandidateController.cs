using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Candidate;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
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
    }
}