using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id);
            
            builder.Property(c => c.Address)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(c => c.Cnpj)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(18);

            builder.Property(c => c.CreatedAt)
                .IsRequired();

            builder.HasMany(c => c.Tecnologies);

            builder.HasMany(c => c.JobOpportunities).WithOne(c => c.Company);

        }
    }
}