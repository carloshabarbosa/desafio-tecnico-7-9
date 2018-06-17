using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class CandidateTecnologyMap : IEntityTypeConfiguration<CandidateTecnology>
    {
        public void Configure(EntityTypeBuilder<CandidateTecnology> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id)
                .IsRequired();

            builder.HasOne(c => c.Candidate).WithMany(c => c.Tecnologies);

            builder.HasOne(c => c.Tecnology);
        }
    }
}