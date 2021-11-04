using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class TipoContatoRepositorio
    {
        protected readonly Contexto contexto;

        public TipoContatoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(TipoContato tipo)
        {
            contexto.TipoContato.Add(tipo);
            contexto.SaveChanges();
        }

        public void Alterar(TipoContato tipoContato)
        {
            contexto.TipoContato.Update(tipoContato);
            contexto.SaveChanges();
        }

        public TipoContato SelecionarPorId(int id)
        {
            return contexto.TipoContato.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.TipoContato.Remove(entity);
            contexto.SaveChanges();
        }

        //private void PreencherDados()
        //{
        //    Incluir(TipoContato.Criar(1, "Telefone"));
        //    Incluir(TipoContato.Criar(2, "Instagram"));
        //    Incluir(TipoContato.Criar(3, "Tiktok"));
        //}
    }
}
