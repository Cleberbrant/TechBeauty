using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EnderecoRepositorio
    {
        public List<Endereco> TabelaEndereco { get; set; } = new List<Endereco>();

        public EnderecoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Endereco endereco)
        {
            TabelaEndereco.Add(endereco);
        }

        public void Alterar(int id, string logradouro, string cidade, string uf, string numero, string complemento, string cep, string bairro)
        {
            TabelaEndereco.FirstOrDefault(x => x.Id == id).Alterar(logradouro, cidade, uf, numero, complemento, cep, bairro);
        }

        public Endereco SelecionarPorId(int id)
        {
            return TabelaEndereco.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaEndereco.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            TabelaEndereco.Add(Endereco.Criar(1, "Rua", "Santa Maria", "DF", "03", "Perto do postinho", "72542506", "Norte"));
            TabelaEndereco.Add(Endereco.Criar(2, "Rua", "Gama", "DF", "15", "Perto da pracinha", "72542506", "Sul"));
        }
    }
}
