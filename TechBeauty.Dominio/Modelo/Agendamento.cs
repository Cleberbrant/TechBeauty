using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public int ServicoID { get; set; }
        public Colaborador Colaborador { get; set; }
        public int ColaboradorID { get; set; }
        public string PessoaAtendida { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public OrdemServico OS { get; set; }
        public int OrdemServicoID { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraTermino { get; set; }
        public List<LogAgendamento> LogAgendamentos { get; set; }
        public int LogAgendamentosID { get; set; }

        public static Agendamento Criar(int id, Servico servico, Colaborador colaborador, string pessoaAtendida, DateTime dataHoraCriacao, OrdemServico os, DateTime dataHoraInicio, DateTime dataHoraTermino)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = id;
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendida = pessoaAtendida;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.OS = os;
            agendamento.DataHoraInicio = dataHoraInicio;
            agendamento.DataHoraTermino = dataHoraTermino;

            return agendamento;
        }

        public void Alterar(Servico servico, Colaborador colaborador, string pessoaAtendida, DateTime dataHoraCriacao, OrdemServico os, DateTime dataHoraInicio, DateTime dataHoraTermino)
        {
            Servico = servico;
            Colaborador = colaborador;
            PessoaAtendida = pessoaAtendida;
            DataHoraCriacao = dataHoraCriacao;
            OS = os;
            DataHoraInicio = dataHoraInicio;
            DataHoraTermino = dataHoraTermino;
        }
    }
}
