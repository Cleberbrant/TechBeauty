﻿using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa
    {        
        public List<Servico> Servicos { get; set; }
        public Endereco Endereco { get; set; }
        public Genero Genero { get; set; }
        public string NomeSocial { get; set; }
        public ContratoTrabalho Contrato { get; set; }

        public static Colaborador Criar(int id, string nome, string cpf, 
        DateTime dataNascimento, List<Contato> contatos, List<Servico> servicos, 
        Endereco endereco, Genero genero, ContratoTrabalho contrato, string NomeSocial = "")
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = id;
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
        Endereco endereco, Genero genero, ContratoTrabalho contrato, string nomeSocial = "")
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