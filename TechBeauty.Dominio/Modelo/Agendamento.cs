using System;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public Colaborador Colaborador { get; set; }
        public string PessoaAtendida { get; set; }
        public DateTime DataHora { get; set; }
        public OrdemServico OS { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public DateTime DataHoraExecucao { get; set; }

        public static Agendamento Criar(int id, Servico servico, Colaborador colaborador, string pessoaAtendida, DateTime dataHora, OrdemServico os, DateTime dataHoraCriacao, DateTime dataHoraExecucao)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = id;
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendida = pessoaAtendida;
            agendamento.DataHora = dataHora;
            agendamento.OS = os;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.DataHoraExecucao = dataHoraExecucao;

            return agendamento;
        }

        public void Alterar(Servico servico, Colaborador colaborador, string pessoaAtendida, DateTime dataHora, OrdemServico os, DateTime dataHoraCriacao, DateTime dataHoraExecucao)
        {
            Servico = servico;
            Colaborador = colaborador;
            PessoaAtendida = pessoaAtendida;
            DataHora = dataHora;
            OS = os;
            DataHoraCriacao = dataHoraCriacao;
            DataHoraExecucao = dataHoraExecucao;
        }
    }
}
