using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Maps
{
    public class SecretariaMap : IEntityTypeConfiguration<Secretaria>
    {
        public void Configure(EntityTypeBuilder<Secretaria> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.TituloSecretaria)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
