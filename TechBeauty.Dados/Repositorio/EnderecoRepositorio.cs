using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EnderecoRepositorio
    {
        protected readonly Contexto contexto;

        public EnderecoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Endereco endereco)
        {
            contexto.Endereco.Add(endereco);
            contexto.SaveChanges();
        }

        public void Alterar(Endereco endereco)
        {
            contexto.Endereco.Update(endereco);
            contexto.SaveChanges();
        }

        public Endereco SelecionarPorId(int id)
        {
            return contexto.Endereco.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Endereco.Remove(entity);
            contexto.SaveChanges();
        }

        //private void PreencherDados()
        //{
        //    TabelaEndereco.Add(Endereco.Criar(1, "Rua", "Santa Maria", "DF", "03", "Perto do postinho", "72542506", "Norte"));
        //    TabelaEndereco.Add(Endereco.Criar(2, "Rua", "Gama", "DF", "15", "Perto da pracinha", "72542506", "Sul"));
        //}
    }
}
