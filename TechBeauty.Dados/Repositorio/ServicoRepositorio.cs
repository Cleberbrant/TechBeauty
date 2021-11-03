using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ServicoRepositorio
    {
        public List<Servico> TabelaServico { get; set; } = new List<Servico>();

        public ServicoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Servico servico)
        {
            TabelaServico.Add(servico);
        }

        public void Alterar(int id, string nome, decimal preco, string descricao, int duracaoEmMin)
        {
            TabelaServico.FirstOrDefault(x => x.Id == id).Alterar(nome, preco, descricao, duracaoEmMin);
        }

        public Servico SelecionarPorId(int id)
        {
            return TabelaServico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaServico.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            TabelaServico.Add(Servico.Criar(1, "Corte Social", 15.00m, "Corte de cabelo no estilo social", 40));
            TabelaServico.Add(Servico.Criar(2, "Corte Degrade", 25.00m, "Corte de cabelo no estilo degrade", 55));
            TabelaServico.Add(Servico.Criar(3, "Alisamento", 45.00m, "Alisamento de cabelo", 80));
        }
    }
}
