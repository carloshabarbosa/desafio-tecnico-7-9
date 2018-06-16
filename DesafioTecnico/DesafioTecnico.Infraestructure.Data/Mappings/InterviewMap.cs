using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class InterviewMap : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasField("id");

            builder.Property(i => i.Notes)
                .HasField("notes");

            builder.Property(i => i.CreatedAt)
                .HasField("createdAt")
                .IsRequired();

            builder.HasOne(i => i.Candidate);

            builder.HasOne(i => i.JobOpportunity);
        }
    }
}