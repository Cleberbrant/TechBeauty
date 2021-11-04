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
    public class ServicoColaboradorMap : IEntityTypeConfiguration<ServicoColaborador>
    {
        public void Configure(EntityTypeBuilder<ServicoColaborador> builder)
        {
            builder.ToTable("ServicoColaborador");

            builder.Property(x => x.ID);

        }
    }
}
