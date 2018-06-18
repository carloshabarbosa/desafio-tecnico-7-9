using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Tecnology;
using DesafioTecnico.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável por ações da entidade de tecnologia
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TecnologyController : ControllerBase
    {
        private readonly ITecnologyApplication _tecnologyApplication;

        public TecnologyController(ITecnologyApplication tecnologyApplication)
        {
            _tecnologyApplication = tecnologyApplication;
        }


        // GET api/tecnology
        [HttpGet]
        public ActionResult<IEnumerable<Tecnology>> Get()
        {
            return _tecnologyApplication.GetTecnologies();
        }

        // GET api/tecnology/5
        [HttpGet("{id}")]
        public ActionResult<Tecnology> Get(Guid id)
        {
            return _tecnologyApplication.GetTecnology(id);
        }

        // POST api/tecnology
        [HttpPost]
        public void Post([FromBody] Tecnology value)
        {
            _tecnologyApplication.AddTecnology(value);
        }

        // PUT api/tecnology/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Tecnology value)
        {
            _tecnologyApplication.EditTecnology(value, id);
        }

        // DELETE api/tecnology/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _tecnologyApplication.DeleteTecnology(id);
        }
    }
}