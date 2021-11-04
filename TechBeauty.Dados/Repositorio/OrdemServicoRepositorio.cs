using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dados.Repositorio
{
    public class OrdemServicoRepositorio
    {
        protected readonly Contexto contexto;

        public OrdemServicoRepositorio(List<Cliente> cliente)
        {
            contexto = new Contexto();
        }

        public void Incluir(OrdemServico ordemServico)
        {
            contexto.OrdemServico.Add(ordemServico);
        }

        public void Alterar(OrdemServico ordemServico)
        {
            contexto.OrdemServico.Update(ordemServico);
            contexto.SaveChanges();
        }

        public OrdemServico SelecionarPorId(int id)
        {
            return contexto.OrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.OrdemServico.Remove(entity);
            contexto.SaveChanges();
        }

        //public void PreencherDados(List<Cliente> cliente)
        //{
        //    var cliente1 = cliente.Where(x => x.Id == 1).FirstOrDefault();
        //    var cliente2 = cliente.Where(x => x.Id == 2).FirstOrDefault();
        //    var cliente3 = cliente.Where(x => x.Id == 3).FirstOrDefault();

        //    TabelaOrdemServico.Add(OrdemServico.Criar(1, 45.00m, 60, cliente1, StatusOS.Concluido));
        //    TabelaOrdemServico.Add(OrdemServico.Criar(2, 38.00m, 46, cliente2, StatusOS.ParcialmenteConcluido));
        //    TabelaOrdemServico.Add(OrdemServico.Criar(3, 65.00m, 85, cliente3, StatusOS.Pendente));
        //}
    }
}
