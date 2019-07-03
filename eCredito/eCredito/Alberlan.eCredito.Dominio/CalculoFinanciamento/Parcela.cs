using System;

namespace Alberlan.eCredito.Dominio.CalculoFinanciamento
{
    public class Parcela
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime? Pagamento { get; set; }
    }
}
