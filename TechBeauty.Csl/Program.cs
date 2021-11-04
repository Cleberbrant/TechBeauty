using System;
using System.Linq;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Csl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste");

            ColaboradorRepositorio colaboradorRepositorio = new ColaboradorRepositorio(); 
            CargoRepositorio cargoRepositorio = new CargoRepositorio();
            EnderecoRepositorio enderecoRepositorio = new EnderecoRepositorio();

            var recebeEndereco = enderecoRepositorio.SelecionarPorId(2);

            enderecoRepositorio.Alterar(recebeEndereco.Alterar("Recife", "Cidade", "Rj", "", "Perto do posto", "72542506"));

            //cargoRepositorio.Incluir(Cargo.Criar("Cabeleleira", "Corta cabelos longos"));

        }
    }
}
