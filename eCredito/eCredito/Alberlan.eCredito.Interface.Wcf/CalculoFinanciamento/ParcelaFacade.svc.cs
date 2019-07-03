using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using Alberlan.eCredito.Interface.Comum.CalculoFinanciamento;
using Alberlan.eCredito.Repositorio.CalculoFinanciamento;
using Alberlan.eCredito.Interface.DTO.CalculoFinanciamento;
using Alberlan.eCredito.Dominio.CalculoFinanciamento;

namespace Alberlan.eCredito.Interface.Wcf.CalculoFinanciamento
{
    public class ParcelaFacade : IParcela
    {
        private ParcelaRepositorio parcelaRepositorio;

        public ParcelaFacade()
        {
            parcelaRepositorio = new ParcelaRepositorio();
        }

        public List<ParcelaDTO> Consultar()
        {
            List<Parcela> parcelas = parcelaRepositorio.Consultar();

            List<ParcelaDTO> parcelasDTO = new List<ParcelaDTO>(parcelas.Count());

            foreach (Parcela parcela in parcelas)
            {
                parcelasDTO.Add(new ParcelaDTO(parcela.Id, parcela.Numero, parcela.Valor, parcela.Vencimento, parcela.Pagamento));
            }

            return parcelasDTO;
        }

        public List<ParcelaDTO> Incluir(ParcelaDTO parcelaDTO)
        {
            Parcela parcela = new Parcela();

            parcela.Id = parcelaDTO.Id;
            parcela.Numero = parcelaDTO.Numero;
            parcela.Valor = parcelaDTO.Valor;
            parcela.Vencimento = parcelaDTO.Vencimento;
            parcela.Pagamento = parcelaDTO.Pagamento;

            parcelaRepositorio.Incluir(parcela);

            return Consultar();
        }

        public List<ParcelaDTO> Editar(ParcelaDTO parcelaDTO)
        {
            Parcela parcela = new Parcela();

            parcela.Id = parcelaDTO.Id;
            parcela.Numero = parcelaDTO.Numero;
            parcela.Valor = parcelaDTO.Valor;
            parcela.Vencimento = parcelaDTO.Vencimento;
            parcela.Pagamento = parcelaDTO.Pagamento;

            parcelaRepositorio.Editar(parcela);

            return Consultar();
        }

        public List<ParcelaDTO> Excluir(ParcelaDTO parcelaDTO)
        {
            Parcela parcela = new Parcela();

            parcela.Id = parcelaDTO.Id;
            parcela.Numero = parcelaDTO.Numero;
            parcela.Valor = parcelaDTO.Valor;
            parcela.Vencimento = parcelaDTO.Vencimento;
            parcela.Pagamento = parcelaDTO.Pagamento;

            parcelaRepositorio.Excluir(parcela);

            return Consultar();
        }

        public void IncluirTodos(List<ParcelaDTO> parcelasDTO)
        {
            List<Parcela> parcelaTodos = new List<Parcela>();
            foreach (ParcelaDTO parcelaDTO in parcelasDTO)
            {
                Parcela parcela = new Parcela();

                parcela.Id = parcelaDTO.Id;
                parcela.Numero = parcelaDTO.Numero;
                parcela.Valor = parcelaDTO.Valor;
                parcela.Vencimento = parcelaDTO.Vencimento;
                parcela.Pagamento = parcelaDTO.Pagamento;

                parcelaTodos.Add(parcela);
            }

            parcelaRepositorio.IncluirTodos(parcelaTodos);
        }
    }
}
