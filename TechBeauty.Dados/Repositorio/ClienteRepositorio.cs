using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ClienteRepositorio
    {
        public List<Cliente> TabelaCliente { get; set; } = new List<Cliente>();

        public ClienteRepositorio(List<Contato> contato)
        {
            PreencherDados(contato);
        }

        public void Incluir(Cliente cliente)
        {
            TabelaCliente.Add(cliente);
        }

        public void Alterar(int id, string nome, string cpf, DateTime dataNascimento, List<Contato> contatos)
        {
            TabelaCliente.FirstOrDefault(x => x.Id == id).Alterar(nome, cpf, dataNascimento, contatos);
        }

        public Cliente SelecionarPorId(int id)
        {
            return TabelaCliente.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaCliente.Remove(SelecionarPorId(id));
        }

        public void PreencherDados(List<Contato> contato)
        {
            var contato1 = contato.Where(x => x.Id == 1).FirstOrDefault();
            var contato2 = contato.Where(x => x.Id == 2).FirstOrDefault();
            var contato3 = contato.Where(x => x.Id == 3).FirstOrDefault();

            List<Contato> contatos1 = new List<Contato>() { contato1 };
            List<Contato> contatos2 = new List<Contato>() { contato2 };
            List<Contato> contatos3 = new List<Contato>() { contato3 };

            TabelaCliente.Add(Cliente.Criar(1, "Cleber", "06776457166", new DateTime(2002, 05, 13), contatos1));
            TabelaCliente.Add(Cliente.Criar(2, "Thamiris", "06235444466", new DateTime(1998, 03, 30), contatos2));
            TabelaCliente.Add(Cliente.Criar(3, "Weslin", "067764575555", new DateTime(2010, 10, 22), contatos3));
        }
    }
}
