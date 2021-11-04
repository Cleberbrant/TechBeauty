using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public List<Colaborador> Colaboradores { get; set; }

        public static Endereco Criar(string logradouro, string cidade, string uf, string numero, string complemento, string cep, string bairro = "Sem bairro")
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = logradouro;
            endereco.Cidade = cidade;
            endereco.UF = uf;
            endereco.Numero = numero;
            endereco.Complemento = complemento;
            endereco.CEP = cep;
            endereco.Bairro = bairro;

            return endereco;
        }

        public Endereco Alterar(string logradouro, string cidade, string uf, string numero, string complemento, string cep, string bairro = "Sem numero")
        {
            Logradouro = logradouro;
            Cidade = cidade;
            UF = uf;
            Numero = numero;
            Complemento = complemento;
            CEP = cep;
            Bairro = bairro;

            return this;
        }
    }
}
