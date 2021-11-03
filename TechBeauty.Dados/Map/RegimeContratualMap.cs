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
    class RegimeContratualMap : IEntityTypeConfiguration<RegimeContratual>
    {
        public void Configure(EntityTypeBuilder<RegimeContratual> builder)
        {
            //Nome da tabela
            builder.ToTable("RegimeContratual");

            //Indico pro entity qual prop vai ser equivalente a minha primary key
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.HasMany<ContratoTrabalho>(r => r.ContratosDeTrabalho)
                .WithOne(c => c.RegimeContratual)
                .HasForeignKey(c => c.RegimeContratualID);
        }
    }
}
