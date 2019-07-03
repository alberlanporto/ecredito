using System.Runtime.Serialization;

namespace Alberlan.eCredito.Interface.DTO.CalculoFinanciamento
{
    [DataContract()]
    public class ValidacaoDTO
    {
        [DataMember()]
        public string Tipo { get; set;  }

        [DataMember()]
        public string Inconsistencia { get; set; }
    }
}
