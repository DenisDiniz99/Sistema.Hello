using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Hello.Data.Maps
{
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.DataAtend)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(a => a.HoraAtend)
                .HasColumnType("datetime")
                .IsRequired();
            builder.OwnsOne(a => a.Protocolo, protocolo =>
            {
                protocolo.Property(p => p.NumProtocolo)
                    .IsRequired();
            });
            builder.Property(a => a.TipoAtendimento)
                .IsRequired();
            builder.HasOne(a => a.Setor)
                .WithMany(x => x.Agendamentos);
            builder.HasOne(a => a.AssuntoAtendimento)
                .WithMany(x => x.Agendamentos);
            builder.HasOne(a => a.Colaborador)
                .WithMany(x => x.Agendamentos);
            builder.HasOne(a => a.Cidadao)
                .WithMany(x => x.Agendamentos);
            builder.Property(a => a.Observacao)
                .HasMaxLength(200)
                .HasColumnType("varchar");
        }
    }
}
