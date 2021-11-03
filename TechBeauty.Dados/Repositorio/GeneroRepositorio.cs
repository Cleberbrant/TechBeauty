using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio
    {
        public List<Genero> TabelaGenero { get; private set; } = new List<Genero>();

        public GeneroRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Genero genero)
        {
            TabelaGenero.Add(genero);            
        }

        public void Alterar(int id, string valor)
        {
            TabelaGenero.FirstOrDefault(x => x.Id == id).Alterar(valor);
        }

        public Genero SelecionarPorId(int id)
        {
            return TabelaGenero.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaGenero.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            Genero genero1 = Genero.Criar(1, "Feminino");
            Incluir(genero1);

            Genero genero2 = Genero.Criar(2, "Masculino");
            Incluir(genero2);

            Genero genero3 = Genero.Criar(3, "Mulher Trans");
            Incluir(genero3);
        }
    }
}
