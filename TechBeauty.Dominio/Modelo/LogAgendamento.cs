using System;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class LogAgendamento
    {
        public DateTime DataCriacao { get; set; }
        public StatusAgendamento Status { get; set; }
        public int IdAgendamento { get; set; }
    }
}
