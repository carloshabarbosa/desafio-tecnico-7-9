using System.IO;
using DesafioTecnico.Domain.Models;
using DesafioTecnico.Infraestructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DesafioTecnico.Infraestructure.Data.Context
{
    public class DesafioTecnicoContext: DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<JobOpportunity> JobOpportunities { get; set; }
        public DbSet<Tecnology> Tecnologies { get; set; }
        public DbSet<TecnologyWeight> TecnologyWeights { get; set; }    
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidateMap());
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new InterviewMap());
            modelBuilder.ApplyConfiguration(new JobOpportunityMap());
            modelBuilder.ApplyConfiguration(new TecnologyMap());
            modelBuilder.ApplyConfiguration(new TecnologyWightMap());
            
            base.OnModelCreating(modelBuilder);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

    }
}