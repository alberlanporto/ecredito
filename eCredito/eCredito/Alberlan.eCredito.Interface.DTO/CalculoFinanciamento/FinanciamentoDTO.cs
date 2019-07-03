using System;
using System.Runtime.Serialization;

namespace Alberlan.eCredito.Interface.DTO.CalculoFinanciamento
{
    [DataContract()]
    public class FinanciamentoDTO
    {
        [DataMember()]
        public int Id { get; set; }

        [DataMember()]
        public int IdTipoFinanciamento { get; set; }

        [DataMember()]
        public int CodCliente { get; set; }

        [DataMember()]
        public double ValorTotal { get; set; }

        [DataMember()]
        public int QtdeParcela { get; set; }

        [DataMember()]
        public DateTime Contratacao { get; set; }

        [DataMember()]
        public DateTime Vencimento { get; set; }

        public FinanciamentoDTO(int id, int idTipoFinanciamento, int codCliente, double valorTotal, int qtdeParcela,
                                DateTime contratacao, DateTime vencimento)
        {
            this.Id = id;
            this.IdTipoFinanciamento = idTipoFinanciamento;
            this.CodCliente = codCliente;
            this.ValorTotal = valorTotal;
            this.QtdeParcela = qtdeParcela;
            this.Contratacao = contratacao;
            this.Vencimento = vencimento;
        }
    }
}
