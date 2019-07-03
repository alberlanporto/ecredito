using System.Runtime.Serialization;

namespace Alberlan.eCredito.Interface.DTO.Cadastro
{
    [DataContract()]
    public class ClienteDTO
    {
        [DataMember()]
        public int Codigo { get; set; }

        [DataMember()]
        public string Nome { get; set; }

        [DataMember()]
        public string Uf { get; set; }

        [DataMember()]
        public string Celular { get; set; }

        public ClienteDTO(int codigo, string nome, string uf, string celular)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Uf = uf;
            this.Celular = celular;
        }
    }
}
