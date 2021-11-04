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
        protected readonly Contexto contexto;

        public ServicoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Servico servico)
        {
            contexto.Servico.Add(servico);
        }

        public void Alterar(Servico servico)
        {
            contexto.Servico.Update(servico);
            contexto.SaveChanges();
        }

        public Servico SelecionarPorId(int id)
        {
            return contexto.Servico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Servico.Remove(entity);
            contexto.SaveChanges();
        }

        //private void PreencherDados()
        //{
        //    TabelaServico.Add(Servico.Criar(1, "Corte Social", 15.00m, "Corte de cabelo no estilo social", 40));
        //    TabelaServico.Add(Servico.Criar(2, "Corte Degrade", 25.00m, "Corte de cabelo no estilo degrade", 55));
        //    TabelaServico.Add(Servico.Criar(3, "Alisamento", 45.00m, "Alisamento de cabelo", 80));
        //}
    }
}
