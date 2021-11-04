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
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnType("date")
                .IsRequired();

            builder.HasMany<Contato>(c => c.Contatos)
                .WithOne(p => p.Pessoa)
                .HasForeignKey(p => p.PessoaID);

            builder.HasMany<Cliente>(cl => cl.Cliente)
                .WithOne(p => p.Pessoa)
                .HasForeignKey(p => p.PessoaID);


        }
    }
}
