using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public decimal PrecoTotal { get; set; }
        public int DuracaoTotal { get; set; }
        public Cliente Cliente { get; set; } //ef
        public int ClienteID { get; set; } //ef
        public List<Agendamento> Agendamento { get; set; }
        public int AgendamentoID { get; set; }
        public StatusOS Status { get; set; }

        public static OrdemServico Criar(int id, decimal precoTotal, int duracaoTotal, Cliente cliente, StatusOS status)
        {
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.Id = id;
            ordemServico.PrecoTotal = precoTotal;
            ordemServico.DuracaoTotal = duracaoTotal;
            ordemServico.Cliente = cliente;
            ordemServico.Status = status;

            return ordemServico;
        }

        public void Alterar(decimal precoTotal, int duracaoTotal, Cliente cliente, StatusOS status)
        {
            PrecoTotal = precoTotal;
            DuracaoTotal = duracaoTotal;
            Cliente = cliente;
            Status = status;
        }
    }
}
