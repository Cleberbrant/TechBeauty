using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio
    {
        public List<Cargo> TabelaCargo { get; set; } = new List<Cargo>();

        public CargoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Cargo cargo)
        {
            TabelaCargo.Add(cargo);            
        }

        public void Alterar(int id, string nome, string descricao)
        {
            TabelaCargo.FirstOrDefault(x => x.Id == id).Alterar(nome, descricao);
        }

        public Cargo SelecionarPorId(int id)
        {
            return TabelaCargo.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaCargo.Remove(SelecionarPorId(id));
        }


        private void PreencherDados()
        {
            TabelaCargo.Add(Cargo.Criar(1, "Cabelereira", 
                "Efetua cortes de cabelo feminino e masculo"));

            TabelaCargo.Add(Cargo.Criar(2, "Manicure"));

            TabelaCargo.Add(Cargo.Criar(3, "Depiladora"));

            TabelaCargo.Add(Cargo.Criar(4, "Colorista"));
        }

    }
}
