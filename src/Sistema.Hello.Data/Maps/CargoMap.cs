﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Maps
{
    public class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TituloCargo)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasOne(c => c.Setor)
                .WithMany(x => x.Cargos);
        }
    }
}
