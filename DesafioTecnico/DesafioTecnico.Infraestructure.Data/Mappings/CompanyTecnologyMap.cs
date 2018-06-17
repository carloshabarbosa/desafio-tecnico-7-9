using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class CompanyTecnologyMap : IEntityTypeConfiguration<CompanyTecnology>
    {
        public void Configure(EntityTypeBuilder<CompanyTecnology> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id)
                .IsRequired();

            builder.HasOne(c => c.Company).WithMany(c => c.Tecnologies);

            builder.HasOne(c => c.Tecnology);
        }
    }
}