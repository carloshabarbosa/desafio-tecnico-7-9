using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Company;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável por ações da entidade empresa
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyApplication _companyApplication;

        public CompanyController(ICompanyApplication companyApplication)
        {
            _companyApplication = companyApplication;
        }

        // GET api/company
        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return _companyApplication.GetCompanies();
        }

        // GET api/company/5
        [HttpGet("{id}")]
        public ActionResult<Company> Get(Guid id)
        {
            return _companyApplication.GetCompany(id);
        }

        // POST api/company
        [HttpPost]
        public void Post([FromBody] Company value)
        {
            _companyApplication.AddCompany(value);
        }

        // PUT api/company/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Company value)
        {
            _companyApplication.EditCompany(value, id);
        }

        // DELETE api/company/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _companyApplication.DeleteCompany(id);
        }
        
        // POST api/company/addTecnologyToCompany
        [HttpPost]
        [Route("AddTecnologyToCompany")]
        public void AddTecnologyToCompany([FromBody] CompanyTecnologyValueObject value)
        {
            _companyApplication.AddTecnologyToCompany(value);
        }
       
        // GET api/company/getTecnologiesByCompany/5
        [HttpGet("{id}")]
        [Route("GetTecnologiesByCompany/{id}")]
        public ActionResult<IEnumerable<CompanyTecnology>> GetTecnologiesByCompany(Guid id)
        {
            return _companyApplication.GetCompanyTecnologiesByCompany(id);
        }
        
        // POST api/company/OpenJobOpportunity
        [HttpPost]
        [Route("OpenJobOpportunity")]
        public void OpenJobOpportunity([FromBody] JobOpportunityValueObject value)
        {
            _companyApplication.OpenJobOpportunity(value);
        }
        
        // GET api/company/getTecnologiesByCompany/5
        [HttpGet("{id}")]
        [Route("GetJobOpportunitiesByCompanyId/{id}")]
        public ActionResult<IEnumerable<JobOpportunity>> GetJobOpportunitiesByCompanyId(Guid id)
        {
            return _companyApplication.GetJobOpportunitiesByCompanyId(id);
        }
    }
}