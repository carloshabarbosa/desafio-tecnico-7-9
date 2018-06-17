using DesafioTecnico.Application.Application.Candidate;
using DesafioTecnico.Application.Application.Company;
using DesafioTecnico.Application.Application.Tecnology;
using DesafioTecnico.Application.Interfaces.Candidate;
using DesafioTecnico.Application.Interfaces.Company;
using DesafioTecnico.Application.Interfaces.Tecnology;
using DesafioTecnico.Domain.Interfaces.Repository;
using DesafioTecnico.Domain.Interfaces.Repository.Candidate;
using DesafioTecnico.Domain.Interfaces.Repository.Company;
using DesafioTecnico.Domain.Interfaces.Repository.CompanyTecnology;
using DesafioTecnico.Domain.Interfaces.Repository.JobOpportunity;
using DesafioTecnico.Domain.Interfaces.Repository.Tecnology;
using DesafioTecnico.Domain.Interfaces.Services.Candidate;
using DesafioTecnico.Domain.Interfaces.Services.Company;
using DesafioTecnico.Domain.Interfaces.Services.CompanyTecnology;
using DesafioTecnico.Domain.Interfaces.Services.JobOpportunity;
using DesafioTecnico.Domain.Interfaces.Services.Tecnology;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Domain.Services.Candidate;
using DesafioTecnico.Domain.Services.Company;
using DesafioTecnico.Domain.Services.CompanyTecnology;
using DesafioTecnico.Domain.Services.JobOpportunity;
using DesafioTecnico.Domain.Services.Tecnology;
using DesafioTecnico.Infraestructure.Data.Context;
using DesafioTecnico.Infraestructure.Data.Repository;
using DesafioTecnico.Infraestructure.Data.Repository.Candidate;
using DesafioTecnico.Infraestructure.Data.Repository.Company;
using DesafioTecnico.Infraestructure.Data.Repository.CompanyTecnology;
using DesafioTecnico.Infraestructure.Data.Repository.JobOpportunity;
using DesafioTecnico.Infraestructure.Data.Repository.Tecnology;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioTecnico.Infraestructure.CrossCutting.IoC
{
    public class DependencyInjetctionBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<DesafioTecnicoContext>();
            
            services.AddScoped<IRepository<Company>, Repository<Company>>();
            services.AddScoped<IRepository<Candidate>, Repository<Candidate>>();
            services.AddScoped<IRepository<Tecnology>, Repository<Tecnology>>();
            services.AddScoped<IRepository<CompanyTecnology>, Repository<CompanyTecnology>>();
            services.AddScoped<IRepository<JobOpportunity>, Repository<JobOpportunity>>();
            services.AddScoped<IRepository<Candidate>, Repository<Candidate>>();
            
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();
            services.AddScoped<ITecnologyRepository, TecnologyRepository>();
            services.AddScoped<ICompanyTecnologyRepository, CompanyTecnologyRepository>();
            services.AddScoped<IJobOpportunityRepository, JobOpportunityRepository>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();

            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICandidateService, CandidateService>();
            services.AddScoped<ITecnologyService, TecnologyService>(); 
            services.AddScoped<ICompanyTecnologyService, CompanyTecnologyService>(); 
            services.AddScoped<IJobOpportunityService, JobOpportunityService>(); 
            services.AddScoped<ICompanyTecnologyService, CompanyTecnologyService>(); 
            services.AddScoped<ICandidateService, CandidateService>(); 

            services.AddScoped<ICompanyApplication, CompanyApplication>();
            services.AddScoped<ITecnologyApplication, TecnologyApplication>();
            services.AddScoped<ICandidateApplication, CandidateApplication>();
            


        }
    }
}