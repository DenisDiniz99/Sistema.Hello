using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Maps
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.Matricula)
                .IsRequired();
            builder.Property(c => c.DataCad)
                .IsRequired();
            builder.HasOne(c => c.Cargo)
                .WithMany(x => x.Colaboradores);
        }
    }
}
