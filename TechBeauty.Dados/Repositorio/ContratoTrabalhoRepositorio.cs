using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ContratoTrabalhoRepositorio
    {
        protected readonly Contexto contexto;

        public ContratoTrabalhoRepositorio(List<RegimeContratual> regimeContratual, List<Cargo> cargos)
        {
            contexto = new Contexto();
        }

        public void Incluir(ContratoTrabalho contratoTrabalho)
        {
            contexto.ContratoTrabalho.Add(contratoTrabalho);
            contexto.SaveChanges();
        }

        public void Alterar(ContratoTrabalho contratoTrabalho)
        {
            contexto.ContratoTrabalho.Update(contratoTrabalho);
            contexto.SaveChanges();
        }

        public ContratoTrabalho SelecionarPorId(int id)
        {
            return contexto.ContratoTrabalho.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.ContratoTrabalho.Remove(entity);
            contexto.SaveChanges();
        }

        //public void PreencherDados(List<RegimeContratual> regimeContratual, List<Cargo> cargos)
        //{
        //    var regimeContratual1 = regimeContratual.Where(x => x.Id == 1).FirstOrDefault();
        //    var regimeContratual2 = regimeContratual.Where(x => x.Id == 2).FirstOrDefault();

        //    var cabelereira = cargos.Where(x => x.Id == 1).FirstOrDefault();
        //    var manicure = cargos.Where(x => x.Id == 2).FirstOrDefault();
        //    var depiladora = cargos.Where(x => x.Id == 3).FirstOrDefault();
        //    var colorista = cargos.Where(x => x.Id == 4).FirstOrDefault();

        //    List<Cargo> cargos1 = new List<Cargo>() { cabelereira, manicure };
        //    List<Cargo> cargos2 = new List<Cargo>() { depiladora, colorista };
        //    List<Cargo> cargos3 = new List<Cargo>() { cabelereira, colorista };

        //    TabelaContratoTrabalho.Add(ContratoTrabalho.Criar(1, regimeContratual1, new DateTime(2021, 10, 07), cargos1, "123.456.789-10"));
        //    TabelaContratoTrabalho.Add(ContratoTrabalho.Criar(2, regimeContratual2, new DateTime(2019, 11, 16), cargos2, "321.323.122-10"));
        //    TabelaContratoTrabalho.Add(ContratoTrabalho.Criar(3, regimeContratual1, new DateTime(2009, 01, 03), cargos3, "333.222.111-10"));
        //    TabelaContratoTrabalho.Add(ContratoTrabalho.Criar(4, regimeContratual2, new DateTime(2009, 01, 03), cargos2, "555.444.333-10"));
        //}
    }
}
