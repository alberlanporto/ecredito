using System.Collections.Generic;
using System.ServiceModel;
using Alberlan.eCredito.Interface.DTO.Cadastro;

namespace Alberlan.eCredito.Interface.Comum.Cadastro
{
    [ServiceContract()]
    public interface ITipoFinanciamento
    {
        [OperationContract()]
        List<TipoFinanciamentoDTO> Consultar();

        [OperationContract()]
        List<TipoFinanciamentoDTO> Incluir(TipoFinanciamentoDTO tipoFinanciamentoDTO);

        [OperationContract()]
        List<TipoFinanciamentoDTO> Editar(TipoFinanciamentoDTO tipoFinanciamentoDTO);

        [OperationContract()]
        List<TipoFinanciamentoDTO> Excluir(TipoFinanciamentoDTO tipoFinanciamentoDTO);

        [OperationContract()]
        void IncluirTodos(List<TipoFinanciamentoDTO> tipoFinanciamentosDTO);
    }
}
