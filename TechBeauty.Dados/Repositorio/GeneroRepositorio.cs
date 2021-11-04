using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio
    {
        protected readonly Contexto contexto;

        public GeneroRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Genero genero)
        {
            contexto.Genero.Add(genero);            
        }

        public void Alterar(Genero genero)
        {
            contexto.Genero.Update(genero);
            contexto.SaveChanges();
        }

        public Genero SelecionarPorId(int id)
        {
            return contexto.Genero.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Genero.Remove(entity);
            contexto.SaveChanges();
        }

        //private void PreencherDados()
        //{
        //    Genero genero1 = Genero.Criar(1, "Feminino");
        //    Incluir(genero1);

        //    Genero genero2 = Genero.Criar(2, "Masculino");
        //    Incluir(genero2);

        //    Genero genero3 = Genero.Criar(3, "Mulher Trans");
        //    Incluir(genero3);
        //}
    }
}
