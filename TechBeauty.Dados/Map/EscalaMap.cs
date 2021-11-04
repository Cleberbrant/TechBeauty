using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    public class EscalaMap : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> builder)
        {
            builder.ToTable("Escala");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataHoraEntrada)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.DataHoraSaida)
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
