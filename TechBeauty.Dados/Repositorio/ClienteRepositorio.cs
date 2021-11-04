using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ClienteRepositorio
    {
        protected readonly Contexto contexto;

        public ClienteRepositorio(List<Contato> contato)
        {
            contexto = new Contexto();
        }

        public void Incluir(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            contexto.Cliente.Update(cliente);
        }

        public Cliente SelecionarPorId(int id)
        {
            return contexto.Cliente.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Cliente.Remove(entity);
            contexto.SaveChanges();
        }

        //public void PreencherDados(List<Contato> contato)
        //{
        //    var contato1 = contato.Where(x => x.Id == 1).FirstOrDefault();
        //    var contato2 = contato.Where(x => x.Id == 2).FirstOrDefault();
        //    var contato3 = contato.Where(x => x.Id == 3).FirstOrDefault();

        //    List<Contato> contatos1 = new List<Contato>() { contato1 };
        //    List<Contato> contatos2 = new List<Contato>() { contato2 };
        //    List<Contato> contatos3 = new List<Contato>() { contato3 };

        //    TabelaCliente.Add(Cliente.Criar(1, "Cleber", "06776457166", new DateTime(2002, 05, 13), contatos1));
        //    TabelaCliente.Add(Cliente.Criar(2, "Thamiris", "06235444466", new DateTime(1998, 03, 30), contatos2));
        //    TabelaCliente.Add(Cliente.Criar(3, "Weslin", "067764575555", new DateTime(2010, 10, 22), contatos3));
        //}
    }
}
