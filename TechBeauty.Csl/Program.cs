using System;
using System.Linq;


namespace TechBeauty.Csl
{
    class Program
    {
        static void Main(string[] args)
        {
            //GeneroRepositorio repoGenero = new GeneroRepositorio();
            // TipoContatoRepositorio repoTipoContato = new TipoContatoRepositorio();
            // ContatoRepositorio repoContato = new ContatoRepositorio(repoTipoContato.TabelaTipoContato);
            //  CargoRepositorio repoCargo = new CargoRepositorio();
            // ServicoRepositorio repoServico = new ServicoRepositorio();
            // RegimeContratualRepositorio repoRegimeContratual = new RegimeContratualRepositorio();
            //  ContratoTrabalhoRepositorio repoContratoTrabalho = new ContratoTrabalhoRepositorio(repoRegimeContratual.TabelaRegimeContratual, repoCargo.TabelaCargo);
            //  EnderecoRepositorio repoEndereco = new EnderecoRepositorio();
            //  ClienteRepositorio repoCliente = new ClienteRepositorio(repoContato.TabelaContato);
            //   OrdemServicoRepositorio repoOrdemServico = new OrdemServicoRepositorio(repoCliente.TabelaCliente);
            //  ColaboradorRepositorio repoColaborador = new ColaboradorRepositorio(repoContato.TabelaContato, repoServico.TabelaServico, repoEndereco.TabelaEndereco, repoGenero.TabelaGenero, repoContratoTrabalho.TabelaContratoTrabalho);

            //  var recebeTipo1 = repoTipoContato.SelecionarPorId(1);
            //  var recebeTipo2 = repoTipoContato.SelecionarPorId(2);

            //  repoContato.Alterar(1, recebeTipo1, "teste");
            //  repoGenero.Alterar(1, "testeGen");
            // repoTipoContato.Alterar(1, "Skype");


            //   foreach (var item in repoCargo.TabelaCargo)
            //   {
            //       Console.WriteLine($"ID: {item.Id} | Nome: {item.Nome} | Descricao: {item.Descricao}");
            //    }

            //  foreach (var item in repoContato.TabelaContato)
            //   {
            //   Console.WriteLine($"ID: {item.Id} | Tipo de Contato: {item.Tipo.Valor} | Descricao: {item.Valor}");
            //  }

            //   foreach (var item in repoGenero.TabelaGenero)
            //  {
            //  Console.WriteLine($"ID: {item.Id} | Genero: {item.Valor}");
            // }

            //  foreach (var item in repoServico.TabelaServico)
            //   {
            //    Console.WriteLine($"ID: {item.Id} | Nome: {item.Nome} | Preco: {item.Preco} | Descricao: {item.Descricao} | Duracao: {item.DuracaoEmMin} Minutos");
            //  }

            // foreach (var item in repoContratoTrabalho.TabelaContratoTrabalho)
            // {
            //  var cargos = string.Join(",", item.Cargos.Select(x => x.Nome));
            //  Console.WriteLine($"ID: {item.Id} | Regime Contratual: {item.RegimeContratual.Valor} | " +
            //   $"Data de Admissao: {item.DataEntrada} | Data de Desligamento: {item.DataDesligamento} | Cargo: {cargos} | CNPJ OU CTPS: {item.CnpjCTPS}");
            // }

            //  foreach (var item in repoEndereco.TabelaEndereco)
            //  {
            //  Console.WriteLine($"ID: {item.Id} | Logradouro: {item.Logradouro} | Cidade: {item.Cidade} | UF: {item.UF} | Numero: {item.Numero} | Complemento: {item.Complemento}");
            // }

            // foreach (var item in repoCliente.TabelaCliente)
            //  {
            // foreach (var contato in item.Contatos)
            //  {
            // Console.WriteLine($"ID: {item.Id} | Nome: {item.Nome} | CPF: {item.CPF} | Data de Nascimento: {item.DataNascimento} | Tipo do Contato: {contato.Tipo.Valor} | Contato: {contato.Valor}");
            // }

            //  }

            //  foreach (var item in repoOrdemServico.TabelaOrdemServico)
            //  {
            //      Console.WriteLine($"ID: {item.Id} | Preco Total: {item.PrecoTotal} | Duracao Total: {item.DuracaoTotal} | Cliente: {item.Cliente.Nome} | Status: {item.Status}");
            //  }

            //  foreach (var item in repoColaborador.TabelaColaborador)
            //  {
            //   var contatos = string.Join(",", item.Contatos.Select(x => x.Valor));
            //   var servicos = string.Join(",", item.Servicos.Select(x => x.Nome));

            //  Console.WriteLine($"ID: {item.Id} | Nome: {item.Nome} | CPF: {item.CPF} | Data de Nascimento: {item.DataNascimento} | " +
            //  $"Contato: {contatos} | Servico: {servicos} | Logradouro: {item.Endereco.Logradouro} | Cidade: {item.Endereco.Cidade} | " +
            // $"UF: {item.Endereco.UF} | Numero: {item.Endereco.Numero} | Complemento: {item.Endereco.Complemento} | Genero: {item.Genero.Valor} | " +
            // $"Regime Contratual: {item.Contrato.RegimeContratual.Valor} | Data de Entrada: {item.Contrato.DataEntrada} | Cargo: {item.Contrato.Cargos} | " +
            // $"CNPJ ou CTPS: {item.Contrato.CnpjCTPS} | Nome Social: {item.NomeSocial}");
            //}

            Console.WriteLine("Teste");
        }
    }
}
