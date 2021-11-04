using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class RegimeContratualRepositorio
    {
        protected readonly Contexto contexto;

        public RegimeContratualRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(RegimeContratual regimeContratual)
        {
            contexto.RegimeContratual.Add(regimeContratual);
            contexto.SaveChanges();
        }

        public void Alterar(RegimeContratual regimeContratual)
        {
            contexto.RegimeContratual.Update(regimeContratual);
            contexto.SaveChanges();
        }

        public RegimeContratual SelecionarPorId(int id)
        {
            return contexto.RegimeContratual.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.RegimeContratual.Remove(entity);
            contexto.SaveChanges();
        }

        //private void PreencherDados()
        //{
        //    TabelaRegimeContratual.Add(RegimeContratual.Criar(1, "CLT"));
        //    TabelaRegimeContratual.Add(RegimeContratual.Criar(2, "PJ"));
        //}
    }
}
