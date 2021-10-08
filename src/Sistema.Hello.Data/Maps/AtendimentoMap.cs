using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Maps
{
    public class AtendimentoMap : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.HasKey(a => a.Id);
            builder.OwnsOne(a => a.Protocolo, protocolo =>
            {
                protocolo.Property(p => p.NumProtocolo)
                    .IsRequired();
            });
            builder.Property(a => a.Descricao)
                .HasMaxLength(500)
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(a => a.DataAtend)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(a => a.HoraAtend)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(a => a.StatusAtendimento)
                .IsRequired();
            builder.HasOne(a => a.Agendamento)
                .WithOne(x => x.Atendimento);
            builder.HasOne(a => a.Cidadao)
                .WithMany(x => x.Atendimentos);
            builder.HasOne(a => a.Colaborador)
                .WithMany(x => x.Atendimentos);
        }
    }
}
