using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Maps
{
    public class SetorMap : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.TituloSetor)
                .HasMaxLength(50)
                .IsRequired();
            builder.OwnsOne(s => s.Endereco, endereco =>
            {
                endereco.Property(e => e.Rua).IsRequired();
                endereco.Property(e => e.Numero).IsRequired();
                endereco.Property(e => e.Bairro).IsRequired();
                endereco.Property(e => e.Cidade).IsRequired();
                endereco.Property(e => e.Cep).IsRequired();
                endereco.Property(e => e.Estado).IsRequired();
            });
            builder.HasOne(s => s.Secretaria)
                .WithMany(s => s.Setores);
        }
    }
}
