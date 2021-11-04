using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    abstract public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Contato> Contatos { get; set; }
        public int ContatosID { get; set; }
        public List<Cliente> Cliente { get; set; }
        public int ClientesID { get; set; }

    }
}
