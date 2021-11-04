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
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaborador");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeSocial)
                .HasColumnType("varchar(100)");

            builder.HasMany(e => e.Escalas)
                .WithOne(c => c.Colaborador)
                .HasForeignKey(c => c.ColadoradoresID);

            builder.HasMany<Agendamento>(a => a.Agendamento)
                .WithOne(c => c.Colaborador)
                .HasForeignKey(c => c.ColaboradorID);

            builder.HasMany<ServicoColaborador>(s => s.ServicoColaborador)
                .WithOne(c => c.Colaborador)
                .HasForeignKey(c => c.ColaboradorID);

        }
    }
}
