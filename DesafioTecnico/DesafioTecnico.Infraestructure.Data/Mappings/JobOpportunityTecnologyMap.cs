using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class JobOpportunityTecnologyMap : IEntityTypeConfiguration<JobOpportunityTecnology>
    {
        public void Configure(EntityTypeBuilder<JobOpportunityTecnology> builder)
        {
            builder.HasKey(j => j.Id);
            
            builder.Property(j => j.Id)
                .IsRequired();

            builder.HasOne(j => j.JobOpportunity).WithMany(j => j.Tecnologies);

            builder.HasOne(j => j.Tecnology);
        }
    }
}