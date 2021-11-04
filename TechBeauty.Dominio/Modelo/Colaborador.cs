using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa
    {        
        public List<Servico> Servicos { get; set; }
        public Genero Genero { get; set; }
        public string NomeSocial { get; set; }
        public int GeneroID { get; set; }
        public List<ContratoTrabalho> Contrato { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecosID { get; set; }
        public List<Escala> Escalas { get; set; }
        public List<Agendamento> Agendamento { get; set; }
        public List<ServicoColaborador> ServicoColaborador { get; set; }
     
        public static Colaborador Criar(string nome, string cpf, 
        DateTime dataNascimento, List<Contato> contatos, List<Servico> servicos, 
        Endereco endereco, Genero genero, List<ContratoTrabalho> contrato, string NomeSocial = "")
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Nome = nome;
            colaborador.CPF = cpf;
            colaborador.DataNascimento = dataNascimento;
            colaborador.Contatos = contatos;
            colaborador.Servicos = servicos;
            colaborador.Endereco = endereco;
            colaborador.Genero = genero;
            colaborador.Contrato = contrato;
            colaborador.NomeSocial = NomeSocial;

            return colaborador;
        }

        public void Alterar(string nome, string cpf,
        DateTime dataNascimento, List<Contato> contatos, List<Servico> servicos,
        Endereco endereco, Genero genero, List<ContratoTrabalho> contrato, string nomeSocial = "")
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Contatos = contatos;
            Servicos = servicos;
            Endereco = endereco;
            Genero = genero;
            Contrato = contrato;
            NomeSocial = nomeSocial;
        }
    }
}
