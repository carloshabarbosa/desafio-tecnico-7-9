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
                .HasField("Id")
                .IsRequired();

            builder.Property(c => c.Address)
                .HasField("address")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(c => c.Cpf)
                .HasField("cpf")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(c => c.Phone)
                .HasField("phone")
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(c => c.CreatedAt)
                .HasField("createdAt")
                .IsRequired();

            builder.Property(c => c.Name)
                .HasField("name")
                .HasMaxLength(70)
                .IsRequired();

            builder.HasOne(c => c.JobOpportunity).WithMany(c => c.Candidates);

            builder.HasMany(c => c.Tecnologies);

        }
    }
}