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
    class CargoContratoTrabalhoMap : IEntityTypeConfiguration<CargoContratoTrabalho>
    {
        public void Configure(EntityTypeBuilder<CargoContratoTrabalho> builder)
        {
            builder.ToTable("Cargo_ContratoTrabalho");

            builder.HasKey(x => new { x.CargoID, x.ContratoTrabalhoID });

            builder.HasOne(c => c.Cargo)
                .WithMany(cct => cct.CargosContratosTrabalho)
                .HasForeignKey(c => c.CargoID);

            builder.HasOne(ct => ct.ContratoTrabalho)
                .WithMany(cct => cct.CargosContratosTrabalho)
                .HasForeignKey(ct => ct.ContratoTrabalhoID);

            builder.Property(x => x.ID)
                .UseIdentityColumn();
        }
    }
}
