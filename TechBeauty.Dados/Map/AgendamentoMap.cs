using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PessoaAtendida)
                .HasColumnType("varchar(30)");

            builder.Property(x => x.DataHoraInicio)
                .HasColumnType("smalldatetime");

            builder.Property(x => x.DataHoraTermino)
                .HasColumnType("smalldatetime");

            builder.Property(x => x.DataHoraCriacao)
                .HasColumnType("smalldatetime");

            builder.HasMany<LogAgendamento>(x => x.LogAgendamentos)
                .WithOne(x => x.Agendamento)
                .HasForeignKey(x => x.AgendamentoID);
        }
    }
}