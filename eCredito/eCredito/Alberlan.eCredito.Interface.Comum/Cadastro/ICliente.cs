using System.Collections.Generic;
using System.ServiceModel;
using Alberlan.eCredito.Interface.DTO.Cadastro;

namespace Alberlan.eCredito.Interface.Comum.Cadastro
{
    [ServiceContract()]
    public interface ICliente
    {
        [OperationContract()]
        List<ClienteDTO> Consultar();

        [OperationContract()]
        List<ClienteDTO> Incluir(ClienteDTO clienteDTO);

        [OperationContract()]
        List<ClienteDTO> Editar(ClienteDTO clienteDTO);

        [OperationContract()]
        List<ClienteDTO> Excluir(ClienteDTO clienteDTO);

        [OperationContract()]
        void IncluirTodos(List<ClienteDTO> clientesDTO);
    }
}
