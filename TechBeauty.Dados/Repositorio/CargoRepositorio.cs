using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio
    {
        protected readonly Contexto contexto;

        public CargoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Cargo cargo)
        {
            contexto.Cargo.Add(cargo);
            contexto.SaveChanges();
        }

        public void Alterar(Cargo cargo)
        {
            contexto.Cargo.Update(cargo);
            contexto.SaveChanges();
        }

        public Cargo SelecionarPorId(int id)
        {
            return contexto.Cargo.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Cargo.Remove(entity);
            contexto.SaveChanges();
        }


        //private void PreencherDados()
        //{
        //    TabelaCargo.Add(Cargo.Criar(1, "Cabelereira", 
        //        "Efetua cortes de cabelo feminino e masculo"));

        //    TabelaCargo.Add(Cargo.Criar(2, "Manicure"));

        //    TabelaCargo.Add(Cargo.Criar(3, "Depiladora"));

        //    TabelaCargo.Add(Cargo.Criar(4, "Colorista"));
        //}

    }
}
