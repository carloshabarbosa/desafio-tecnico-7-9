using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class CandidateMap : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.Address)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(c => c.Cpf)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(c => c.CreatedAt)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(70)
                .IsRequired();

            builder.HasOne(c => c.JobOpportunity).WithMany(c => c.Candidates);

            builder.HasMany(c => c.Tecnologies);

        }
    }
}