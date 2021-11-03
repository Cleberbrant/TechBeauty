using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class TipoContatoRepositorio
    {
        public List<TipoContato> TabelaTipoContato { get; set; } = new List<TipoContato>();

        public TipoContatoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(TipoContato tipo)
        {
            TabelaTipoContato.Add(tipo);            
        }

        public void Alterar(int id, string valor)
        {
            TabelaTipoContato.FirstOrDefault(x => x.Id == id).Alterar(valor);
        }

        public TipoContato SelecionarPorId(int id)
        {
            return TabelaTipoContato.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaTipoContato.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            Incluir(TipoContato.Criar(1, "Telefone"));
            Incluir(TipoContato.Criar(2, "Instagram"));
            Incluir(TipoContato.Criar(3, "Tiktok"));
        }
    }
}
