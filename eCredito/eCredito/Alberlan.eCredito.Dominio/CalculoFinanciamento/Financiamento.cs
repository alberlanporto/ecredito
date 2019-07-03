using System;

namespace Alberlan.eCredito.Dominio.CalculoFinanciamento
{
    public class Financiamento
    {
        public int Id { get; set; }
        public int IdTipoFinanciamento { get; set; }
        public int CodCliente { get; set; }
        public double ValorTotal { get; set; }
        public int QtdeParcela { get; set; }
        public DateTime Contratacao { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
