using DesafioTecnico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnico.Infraestructure.Data.Mappings
{
    public class TecnologyMap : IEntityTypeConfiguration<Tecnology>
    {
        public void Configure(EntityTypeBuilder<Tecnology> builder)
        {
            builder.HasKey(t => t.Id);
            
            builder.Property(t => t.Id)
                .HasField("id");

            builder.Property(t => t.Name)
                .HasField("name")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(t => t.IsActive)
                .HasField("isActive")
                .IsRequired();

            builder.Property(t => t.CreatedAt)
                .HasField("createdAt")
                .IsRequired();

        }
    }
}