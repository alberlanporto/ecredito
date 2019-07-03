using System.Collections.Generic;
using System.ServiceModel;
using Alberlan.eCredito.Interface.DTO.CalculoFinanciamento;

namespace Alberlan.eCredito.Interface.Comum.CalculoFinanciamento
{
    [ServiceContract()]
    public interface IParcela
    {
        [OperationContract()]
        List<ParcelaDTO> Consultar();

        [OperationContract()]
        List<ParcelaDTO> Incluir(ParcelaDTO parcelaDTO);

        [OperationContract()]
        List<ParcelaDTO> Editar(ParcelaDTO parcelaDTO);

        [OperationContract()]
        List<ParcelaDTO> Excluir(ParcelaDTO parcelaDTO);

        [OperationContract()]
        void IncluirTodos(List<ParcelaDTO> parcelaDTO);
    }
}
