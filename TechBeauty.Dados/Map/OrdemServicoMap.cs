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
    public class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PrecoTotal)
                .HasColumnType("decimal(6,2)");

            builder.Property(x => x.DuracaoTotal)
                .HasColumnType("int");

            builder.Property(x => x.Status)
                .HasColumnType("int")
                .IsRequired();

            builder.HasMany<Agendamento>(a => a.Agendamento)
                .WithOne(x => x.OS)
                .HasForeignKey(x => x.OrdemServicoID);
        }
    }
}
