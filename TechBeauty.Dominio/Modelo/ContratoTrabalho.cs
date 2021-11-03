using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho
    {
        public int Id { get; set; }
        public RegimeContratual RegimeContratual { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataDesligamento { get; set; }
        public List<CargoContratoTrabalho> CargosContratosTrabalho { get; set; }
        public string CnpjCTPS { get; set; }
        public List<ContratoTrabalho> ContratosDeTrabalho { get; set; }
        public int RegimeContratualID { get; set; }


        public static ContratoTrabalho Criar(int id, RegimeContratual regimeContratual, DateTime dataEntrada, List<Cargo> cargos, string cnpjCTPS, DateTime? dataDesligamento = null)
        {
            ContratoTrabalho contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.Id = id;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = dataEntrada;
            contratoTrabalho.DataDesligamento = dataDesligamento;
            //contratoTrabalho.Cargos = cargos;
            contratoTrabalho.CnpjCTPS = cnpjCTPS;

            return contratoTrabalho;
        }

        public void Alterar(int id, RegimeContratual regimeContratual, DateTime dataEntrada, DateTime dataDesligamento, List<Cargo> cargos, string cnpjCTPS)
        {
            RegimeContratual = regimeContratual;
            DataEntrada = dataEntrada;
            DataDesligamento = dataDesligamento;
            //Cargos = cargos;
            CnpjCTPS = cnpjCTPS;
        }
    }
}
