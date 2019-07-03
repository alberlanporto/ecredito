using System;
using System.Collections.Generic;
using System.ServiceModel;
using Alberlan.eCredito.Interface.DTO.CalculoFinanciamento;

namespace Alberlan.eCredito.Interface.Comum.CalculoFinanciamento
{
    [ServiceContract()]
    public interface IFinanciamento
    {
        [OperationContract()]
        List<FinanciamentoDTO> Consultar();

        [OperationContract()]
        List<FinanciamentoDTO> Incluir(FinanciamentoDTO financiamentoDTO);

        [OperationContract()]
        List<FinanciamentoDTO> Editar(FinanciamentoDTO financiamentoDTO);

        [OperationContract()]
        List<FinanciamentoDTO> Excluir(FinanciamentoDTO financiamentoDTO);

        [OperationContract()]
        void IncluirTodos(List<FinanciamentoDTO> financiamentosDTO);

        [OperationContract()]
        List<ValidacaoDTO> Verificar(double valorSolicitado, int qdtParcela, DateTime dtaPrimeiroVencto, int tipoFinanciamento);

        [OperationContract()]
        CalculoFinanciamentoDTO SolicitarFinanciamento(int codCliente, int tipoFinanciamento, double valorSolicitado, int qdtParcela, DateTime dtaPrimeiroVencto);

        [OperationContract()]
        bool ConfirmarFinanciamento(CalculoFinanciamentoDTO calculoFinanciamentoDTO);
    }
}
