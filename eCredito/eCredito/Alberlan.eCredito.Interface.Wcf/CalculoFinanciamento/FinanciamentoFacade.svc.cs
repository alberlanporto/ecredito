using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using Alberlan.eCredito.Interface.Comum.CalculoFinanciamento;
using Alberlan.eCredito.Repositorio.CalculoFinanciamento;
using Alberlan.eCredito.Interface.DTO.CalculoFinanciamento;
using Alberlan.eCredito.Interface.DTO.Cadastro;
using Alberlan.eCredito.Dominio.CalculoFinanciamento;
using Alberlan.eCredito.Repositorio.Cadastro;

namespace Alberlan.eCredito.Interface.Wcf.CalculoFinanciamento
{
    public class FinanciamentoFacade : IFinanciamento
    {
        private FinanciamentoRepositorio financiamentoRepositorio;
        private TipoFinanciamentoRepositorio tipoFinanciamentoRepositorio;
        private ParcelaRepositorio parcelaRepositorio;

        public FinanciamentoFacade()
        {
            financiamentoRepositorio = new FinanciamentoRepositorio();
            tipoFinanciamentoRepositorio = new TipoFinanciamentoRepositorio();
            parcelaRepositorio = new ParcelaRepositorio();
        }

        public List<FinanciamentoDTO> Consultar()
        {
            List<Financiamento> financiamentos = financiamentoRepositorio.Consultar();

            List<FinanciamentoDTO> financiamentosDTO = new List<FinanciamentoDTO>(financiamentos.Count());

            foreach (Financiamento financiamento in financiamentos)
            {
                financiamentosDTO.Add(new FinanciamentoDTO(financiamento.Id, financiamento.IdTipoFinanciamento, financiamento.CodCliente,
                                                           financiamento.ValorTotal, financiamento.QtdeParcela, financiamento.Contratacao, financiamento.Vencimento));
            }

            return financiamentosDTO;
        }

        public List<FinanciamentoDTO> Incluir(FinanciamentoDTO financiamentoDTO)
        {
            Financiamento financiamento = new Financiamento();

            financiamento.Id = financiamentoDTO.Id;
            financiamento.IdTipoFinanciamento = financiamentoDTO.IdTipoFinanciamento;
            financiamento.CodCliente = financiamentoDTO.CodCliente;
            financiamento.ValorTotal = financiamentoDTO.ValorTotal;
            financiamento.QtdeParcela = financiamentoDTO.QtdeParcela;
            financiamento.Contratacao = financiamentoDTO.Contratacao;
            financiamento.Vencimento = financiamentoDTO.Vencimento;

            financiamentoRepositorio.Incluir(financiamento);

            return Consultar();
        }

        public List<FinanciamentoDTO> Editar(FinanciamentoDTO financiamentoDTO)
        {
            Financiamento financiamento = new Financiamento();

            financiamento.Id = financiamentoDTO.Id;
            financiamento.IdTipoFinanciamento = financiamentoDTO.IdTipoFinanciamento;
            financiamento.CodCliente = financiamentoDTO.CodCliente;
            financiamento.ValorTotal = financiamentoDTO.ValorTotal;
            financiamento.QtdeParcela = financiamentoDTO.QtdeParcela;
            financiamento.Contratacao = financiamentoDTO.Contratacao;
            financiamento.Vencimento = financiamentoDTO.Vencimento;

            financiamentoRepositorio.Editar(financiamento);

            return Consultar();
        }

        public List<FinanciamentoDTO> Excluir(FinanciamentoDTO financiamentoDTO)
        {
            Financiamento financiamento = new Financiamento();

            financiamento.Id = financiamentoDTO.Id;
            financiamento.IdTipoFinanciamento = financiamentoDTO.IdTipoFinanciamento;
            financiamento.CodCliente = financiamentoDTO.CodCliente;
            financiamento.ValorTotal = financiamentoDTO.ValorTotal;
            financiamento.QtdeParcela = financiamentoDTO.QtdeParcela;
            financiamento.Contratacao = financiamentoDTO.Contratacao;
            financiamento.Vencimento = financiamentoDTO.Vencimento;

            financiamentoRepositorio.Excluir(financiamento);

            return Consultar();
        }

        public void IncluirTodos(List<FinanciamentoDTO> financiamentosDTO)
        {
            List<Financiamento> financiamentoTodos = new List<Financiamento>();
            foreach (FinanciamentoDTO financiamentoDTO in financiamentosDTO)
            {
                Financiamento financiamento = new Financiamento();

                financiamento.Id = financiamentoDTO.Id;
                financiamento.IdTipoFinanciamento = financiamentoDTO.IdTipoFinanciamento;
                financiamento.CodCliente = financiamentoDTO.CodCliente;
                financiamento.ValorTotal = financiamentoDTO.ValorTotal;
                financiamento.QtdeParcela = financiamentoDTO.QtdeParcela;
                financiamento.Contratacao = financiamentoDTO.Contratacao;
                financiamento.Vencimento = financiamentoDTO.Vencimento;

                financiamentoTodos.Add(financiamento);
            }

            financiamentoRepositorio.IncluirTodos(financiamentoTodos);
        }

        public List<ValidacaoDTO> Verificar(double valorSolicitado, int qdtParcela, DateTime dtaPrimeiroVencto, int tipoFinanciamento)
        {
            List<ValidacaoDTO> validacoesDTO = new List<ValidacaoDTO>();
            
            // Verificando limite máximo de valor solicitado
            if (valorSolicitado > 1000000)
            {
                ValidacaoDTO validacaoDTO = new ValidacaoDTO();

                validacaoDTO.Tipo = "1";
                validacaoDTO.Inconsistencia = "O valor solicitado ultrapassou o limite de R$ 1.000.000,00.";
                validacoesDTO.Add(validacaoDTO);
            }

            // Verifica quantidade de parcela minima
            if (qdtParcela < 5)
            {
                ValidacaoDTO validacaoDTO = new ValidacaoDTO();

                validacaoDTO.Tipo = "2";
                validacaoDTO.Inconsistencia = "A quantidade mínima de parcelas deve ser 5.";
                validacoesDTO.Add(validacaoDTO);
            }

            // Verifica quantidade de parcela maxima
            if (qdtParcela > 72)
            {
                ValidacaoDTO validacaoDTO = new ValidacaoDTO();

                validacaoDTO.Tipo = "3";
                validacaoDTO.Inconsistencia = "A quantidade máxima de parcelas deve ser 72.";
                validacoesDTO.Add(validacaoDTO);
            }

            int iDifDias = (int)dtaPrimeiroVencto.Subtract(DateTime.Today).TotalDays;
            
            // Verifica primeiro vencimento menor que 15 dias
            if (iDifDias < 15)
            {
                ValidacaoDTO validacaoDTO = new ValidacaoDTO();

                validacaoDTO.Tipo = "4";
                validacaoDTO.Inconsistencia = "A data do primeiro vencimento está menor que 15 dias da data solicitada.";
                validacoesDTO.Add(validacaoDTO);
            }

            // Verifica primeiro vencimento maior que 40 dias
            if (iDifDias > 40)
            {
                ValidacaoDTO validacaoDTO = new ValidacaoDTO();

                validacaoDTO.Tipo = "5";
                validacaoDTO.Inconsistencia = "A data do primeiro vencimento está maior que 40 dias da data solicitada.";
                validacoesDTO.Add(validacaoDTO);
            }

            if (tipoFinanciamento == 3 && valorSolicitado < 15000)
            {
                ValidacaoDTO validacaoDTO = new ValidacaoDTO();

                validacaoDTO.Tipo = "6";
                validacaoDTO.Inconsistencia = "Para o crédito de pessoa jurídica, o valor mínimo a ser liberado é de R$ 15.000,00.";
                validacoesDTO.Add(validacaoDTO);
            }

            return validacoesDTO;
        }

        public CalculoFinanciamentoDTO SolicitarFinanciamento(int codCliente, int tipoFinanciamento, double valorSolicitado, int qdtParcela, DateTime dtaPrimeiroVencto)
        {
            CalculoFinanciamentoDTO calculoFinanciamentoDTO = new CalculoFinanciamentoDTO();
            TipoFinanciamentoDTO tipoFinanciamentoDTO = new TipoFinanciamentoDTO();
            tipoFinanciamentoDTO = tipoFinanciamentoRepositorio.ConsultarPorChave(tipoFinanciamento);

            calculoFinanciamentoDTO.Validacoes = Verificar(valorSolicitado, qdtParcela, dtaPrimeiroVencto, tipoFinanciamento);

            if (calculoFinanciamentoDTO.Validacoes.Count > 0)
            {
                calculoFinanciamentoDTO.Status = "Reprovado";
            }
            else
            {
                calculoFinanciamentoDTO.Status = "Aprovado";

                List<ParcelaDTO> parcelasDTO = new List<ParcelaDTO>();
                
                double dVlrParcelaBruto = (valorSolicitado / qdtParcela);
                double dVlrParcelaJuros = (dVlrParcelaBruto * (tipoFinanciamentoDTO.PercentualTaxa / 100));
                DateTime dtaVencimento = dtaPrimeiroVencto;

                // Gerando as Parcelas
                for (int i = 0; i < qdtParcela; i++)
                {
                    ParcelaDTO parcelaDTO = new ParcelaDTO();

                    parcelaDTO.Id = 0;
                    parcelaDTO.Numero = (i + 1);
                    parcelaDTO.Valor = (dVlrParcelaBruto + dVlrParcelaJuros);
                    parcelaDTO.Vencimento = (i == 0 ? dtaPrimeiroVencto : dtaVencimento);

                    parcelasDTO.Add(parcelaDTO);

                    dtaVencimento.AddMonths(1);
                }

                calculoFinanciamentoDTO.CodCliente = codCliente;
                calculoFinanciamentoDTO.TipoFinanciamento = tipoFinanciamento;
                calculoFinanciamentoDTO.QtdeParcelas = qdtParcela;
                calculoFinanciamentoDTO.DataContratacao = DateTime.Now;
                calculoFinanciamentoDTO.DataVencimento = (parcelasDTO).Max(s => s.Vencimento);
                calculoFinanciamentoDTO.TotalFinanciamento = (parcelasDTO).Sum(s => s.Valor);
                calculoFinanciamentoDTO.TotalJuros = (dVlrParcelaJuros + qdtParcela);
                calculoFinanciamentoDTO.Parcelas = parcelasDTO;
            }

            return calculoFinanciamentoDTO;
        }

        public bool ConfirmarFinanciamento(CalculoFinanciamentoDTO calculoFinanciamentoDTO)
        {
            // Gravando o Financiamento
            Financiamento financiamento = new Financiamento();
            financiamento.IdTipoFinanciamento = calculoFinanciamentoDTO.TipoFinanciamento;
            financiamento.CodCliente = calculoFinanciamentoDTO.CodCliente;
            financiamento.ValorTotal = calculoFinanciamentoDTO.TotalFinanciamento;
            financiamento.QtdeParcela = calculoFinanciamentoDTO.QtdeParcelas;
            financiamento.Contratacao = calculoFinanciamentoDTO.DataContratacao;
            financiamento.Vencimento = calculoFinanciamentoDTO.DataVencimento;

            int Idfinanciamento = financiamentoRepositorio.Incluir(financiamento);

            // Gravando as Parcelas
            List<Parcela> parcelas = (from p in calculoFinanciamentoDTO.Parcelas
                                         select new Parcela
                                         {
                                             Id = Idfinanciamento,
                                             Numero = p.Numero,
                                             Valor = p.Valor,
                                             Vencimento = p.Vencimento
                                         }).ToList();

            parcelaRepositorio.IncluirTodos(parcelas);

            return true;
        }
    }
}
