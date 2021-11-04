using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ColaboradorRepositorio
    {
        protected readonly Contexto contexto;

        public ColaboradorRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Colaborador colaborador)
        {
            contexto.Colaborador.Add(colaborador);
            contexto.SaveChanges();
        }

        public void Alterar(Colaborador colaborador)
        {
            contexto.Colaborador.Update(colaborador);
            contexto.SaveChanges();
        }

        public Colaborador SelecionarPorId(int id)
        {
            return contexto.Colaborador.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Colaborador.Remove(entity);
            contexto.SaveChanges();
        }

        //public void PreencherDados(List<Contato> contato, List<Servico> servico, List<Endereco> endereco, List<Genero> genero, List<ContratoTrabalho> contrato)
        //{
        //    var contato1 = contato.Where(x => x.Id == 1).FirstOrDefault();
        //    var contato2 = contato.Where(x => x.Id == 2).FirstOrDefault();
        //    var contato3 = contato.Where(x => x.Id == 3).FirstOrDefault();

        //    List<Contato> contatos1 = new List<Contato>() { contato1 };
        //    List<Contato> contatos2 = new List<Contato>() { contato2 };
        //    List<Contato> contatos3 = new List<Contato>() { contato3 };

        //    var servico1 = servico.Where(x => x.Id == 1).FirstOrDefault();
        //    var servico2 = servico.Where(x => x.Id == 1).FirstOrDefault();
        //    var servico3 = servico.Where(x => x.Id == 1).FirstOrDefault();

        //    List<Servico> servicos1 = new List<Servico>() { servico1 };
        //    List<Servico> servicos2 = new List<Servico>() { servico2 };
        //    List<Servico> servicos3 = new List<Servico>() { servico3 };

        //    var endereco1 = endereco.Where(x => x.Id == 1).FirstOrDefault();
        //    var endereco2 = endereco.Where(x => x.Id == 2).FirstOrDefault();

        //    var genero1 = genero.Where(x => x.Id == 1).FirstOrDefault();
        //    var genero2 = genero.Where(x => x.Id == 2).FirstOrDefault();
        //    var genero3 = genero.Where(x => x.Id == 3).FirstOrDefault();

        //    var contrato1 = contrato.Where(x => x.Id == 1).FirstOrDefault();
        //    var contrato2 = contrato.Where(x => x.Id == 2).FirstOrDefault();
        //    var contrato3 = contrato.Where(x => x.Id == 3).FirstOrDefault();
        //    var contrato4 = contrato.Where(x => x.Id == 4).FirstOrDefault();

        //    TabelaColaborador.Add(Colaborador.Criar(1, "Maxwell", "123456789", new DateTime(2002, 05, 13), contatos1, servicos1, endereco1, genero1, contrato1, "Weslin"));
        //    TabelaColaborador.Add(Colaborador.Criar(2, "Nery", "123456783", new DateTime(1998, 03, 30), contatos2, servicos2, endereco2, genero2, contrato2));
        //    TabelaColaborador.Add(Colaborador.Criar(3, "Matheus", "12344567", new DateTime(2010, 10, 22), contatos3, servicos3, endereco1, genero3, contrato3, "Matheuszin dias"));
        //}
    }
}
