using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Alberlan.eCredito.Interface.DTO.CalculoFinanciamento
{
    [DataContract()]
    public class CalculoFinanciamentoDTO
    {
        [DataMember()]
        public List<ValidacaoDTO> Validacoes { get; set; }

        [DataMember()]
        public List<ParcelaDTO> Parcelas { get; set; }

        [DataMember()]
        public string Status { get; set; }

        [DataMember()]
        public int CodCliente { get; set; }

        [DataMember()]
        public int TipoFinanciamento { get; set; }

        [DataMember()]
        public double TotalFinanciamento { get; set; }

        [DataMember()]
        public double TotalJuros { get; set; }

        [DataMember()]
        public int QtdeParcelas { get; set; }

        [DataMember()]
        public DateTime DataContratacao { get; set; }

        [DataMember()]
        public DateTime DataVencimento { get; set; }
    }
}
