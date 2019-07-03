using System.Runtime.Serialization;

namespace Alberlan.eCredito.Interface.DTO.Cadastro
{
    [DataContract()]
    public class TipoFinanciamentoDTO
    {
        [DataMember()]
        public int Id { get; set; }

        [DataMember()]
        public string Descricao { get; set; }

        [DataMember()]
        public double PercentualTaxa { get; set; }

        public TipoFinanciamentoDTO() 
        { }

        public TipoFinanciamentoDTO(int id, string descricao, double percentualTaxa)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.PercentualTaxa = percentualTaxa;
        }
    }
}
