using System;
using System.Runtime.Serialization;

namespace Alberlan.eCredito.Interface.DTO.CalculoFinanciamento
{
    [DataContract()]
    public class ParcelaDTO
    {
        [DataMember()]
        public int Id { get; set; }

        [DataMember()]
        public int Numero { get; set; }

        [DataMember()]
        public double Valor { get; set; }

        [DataMember()]
        public DateTime Vencimento { get; set; }

        [DataMember()]
        public DateTime? Pagamento { get; set; }

        public ParcelaDTO()
        { }

        public ParcelaDTO(int id, int numero, double valor, DateTime vencimento, DateTime? pagamento)
        {
            this.Id = id;
            this.Numero = numero;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Pagamento = pagamento;
        }
    }
}
