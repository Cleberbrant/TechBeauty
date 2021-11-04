using Microsoft.EntityFrameworkCore;
using System;
using TechBeauty.Dados.Map;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados
{
    public class Contexto : DbContext
    {
        public DbSet<CargoContratoTrabalho> CargoContratoTrabalho { get; set; }
        public DbSet<RegimeContratual> RegimeContratual { get; set; }
        public DbSet<ContratoTrabalho> ContratoTrabalho { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicoColaborador> ServicoColaborador { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<LogAgendamento> LogAgendamento { get; set; }
        public DbSet<Escala> Escala { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MIR-0552; Database=TechBeautyEF; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CargoContratoTrabalhoMap());
            modelBuilder.ApplyConfiguration(new RegimeContratualMap());
            modelBuilder.ApplyConfiguration(new ContratoTrabalhoMap());
            modelBuilder.ApplyConfiguration(new CargoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new OrdemServicoMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
            modelBuilder.ApplyConfiguration(new ServicoColaboradorMap());
            modelBuilder.ApplyConfiguration(new TipoContatoMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new LogAgendamentoMap());
            modelBuilder.ApplyConfiguration(new EscalaMap());
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
