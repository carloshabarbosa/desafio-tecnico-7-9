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
            
            builder.Property(c => c.Id)
                .HasField("id");
            
            builder.Property(c => c.Address)
                .HasField("address")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(c => c.Cnpj)
                .HasField("cnpj")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasField("name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Phone)
                .HasField("phone")
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(c => c.CreatedAt)
                .HasField("createAt")
                .IsRequired();

            builder.HasMany(c => c.Tecnologies);

            builder.HasMany(c => c.JobOpportunities).WithOne(c => c.Company);

        }
    }
}