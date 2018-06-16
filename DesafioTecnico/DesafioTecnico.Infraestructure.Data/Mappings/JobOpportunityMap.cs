using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class JobOpportunityMap : IEntityTypeConfiguration<JobOpportunity>
    {
        public void Configure(EntityTypeBuilder<JobOpportunity> builder)
        {
            builder.HasKey(j => j.Id);
            
            builder.Property(j => j.Id)
                .HasField("id");

            builder.Property(j => j.Description)
                .HasField("description")
                .IsRequired();

            builder.Property(j => j.CreatedAt)
                .HasField("createdAt")
                .IsRequired();

            builder.HasMany(j => j.Candidates).WithOne(c => c.JobOpportunity);
            
            builder.HasMany(j => j.Tecnologies);
            
            builder.HasOne(j => j.Company).WithMany(c => c.JobOpportunities);
        }
    }
}