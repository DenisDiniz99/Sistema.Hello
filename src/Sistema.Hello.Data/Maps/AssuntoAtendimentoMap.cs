using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Maps
{
    public class AssuntoAtendimentoMap : IEntityTypeConfiguration<AssuntoAtendimento>
    {
        public void Configure(EntityTypeBuilder<AssuntoAtendimento> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.TituloAssunto)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
