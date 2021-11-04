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
    class LogAgendamentoMap : IEntityTypeConfiguration<LogAgendamento>
    {
        public void Configure(EntityTypeBuilder<LogAgendamento> builder)
        {
            builder.ToTable("LogAgendamento");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.DataCriacao)
                .HasColumnType("smalldatetime")
                .IsRequired();

            builder.Property(x => x.Status)
                .HasColumnType("int")
                .IsRequired();

        }
    }
}