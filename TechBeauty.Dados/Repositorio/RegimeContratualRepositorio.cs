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
        public List<RegimeContratual> TabelaRegimeContratual { get; set; } = new List<RegimeContratual>();

        public RegimeContratualRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(RegimeContratual regimeContratual)
        {
            TabelaRegimeContratual.Add(regimeContratual);
        }

        public void Alterar(int id, string valor)
        {
            TabelaRegimeContratual.FirstOrDefault(x => x.Id == id).Alterar(valor);
        }

        public RegimeContratual SelecionarPorId(int id)
        {
            return TabelaRegimeContratual.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaRegimeContratual.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            TabelaRegimeContratual.Add(RegimeContratual.Criar(1, "CLT"));
            TabelaRegimeContratual.Add(RegimeContratual.Criar(2, "PJ"));
        }
    }
}
