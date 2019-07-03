using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using Alberlan.eCredito.Interface.Comum.Cadastro;
using Alberlan.eCredito.Repositorio.Cadastro;
using Alberlan.eCredito.Interface.DTO.Cadastro;
using Alberlan.eCredito.Dominio.Cadastro;

namespace Alberlan.eCredito.Interface.Wcf.Cadastro
{
    public class TipoFinanciamentoFacade : ITipoFinanciamento
    {
        private TipoFinanciamentoRepositorio tipoFinanciamentoRepositorio;

        public TipoFinanciamentoFacade()
        {
            tipoFinanciamentoRepositorio = new TipoFinanciamentoRepositorio();
        }

        public List<TipoFinanciamentoDTO> Consultar()
        {
            List<TipoFinanciamento> tipos = tipoFinanciamentoRepositorio.Consultar();

            List<TipoFinanciamentoDTO> tiposDTO = new List<TipoFinanciamentoDTO>(tipos.Count());

            foreach (TipoFinanciamento tipo in tipos)
            {
                tiposDTO.Add(new TipoFinanciamentoDTO(tipo.Id, tipo.Descricao, tipo.PercentualTaxa));
            }

            return tiposDTO;
        }

        public List<TipoFinanciamentoDTO> Incluir(TipoFinanciamentoDTO tipoFinanciamentoDTO)
        {
            TipoFinanciamento tipo = new TipoFinanciamento();

            tipo.Id = tipoFinanciamentoDTO.Id;
            tipo.Descricao = tipoFinanciamentoDTO.Descricao;
            tipo.PercentualTaxa = tipoFinanciamentoDTO.PercentualTaxa;

            tipoFinanciamentoRepositorio.Incluir(tipo);

            return Consultar();
        }

        public List<TipoFinanciamentoDTO> Editar(TipoFinanciamentoDTO tipoFinanciamentoDTO)
        {
            TipoFinanciamento tipo = new TipoFinanciamento();

            tipo.Id = tipoFinanciamentoDTO.Id;
            tipo.Descricao = tipoFinanciamentoDTO.Descricao;
            tipo.PercentualTaxa = tipoFinanciamentoDTO.PercentualTaxa;

            tipoFinanciamentoRepositorio.Editar(tipo);

            return Consultar();
        }

        public List<TipoFinanciamentoDTO> Excluir(TipoFinanciamentoDTO tipoFinanciamentoDTO)
        {
            TipoFinanciamento tipo = new TipoFinanciamento();

            tipo.Id = tipoFinanciamentoDTO.Id;
            tipo.Descricao = tipoFinanciamentoDTO.Descricao;
            tipo.PercentualTaxa = tipoFinanciamentoDTO.PercentualTaxa;

            tipoFinanciamentoRepositorio.Excluir(tipo);

            return Consultar();
        }

        public void IncluirTodos(List<TipoFinanciamentoDTO> tipoFinanciamentosDTO)
        {
            List<TipoFinanciamento> tipoTodos = new List<TipoFinanciamento>();
            foreach (TipoFinanciamentoDTO tipoDTO in tipoFinanciamentosDTO)
            {
                TipoFinanciamento tipo = new TipoFinanciamento();

                tipo.Id = tipoDTO.Id;
                tipo.Descricao = tipoDTO.Descricao;
                tipo.PercentualTaxa = tipoDTO.PercentualTaxa;

                tipoTodos.Add(tipo);
            }

            tipoFinanciamentoRepositorio.IncluirTodos(tipoTodos);
        }
    }
}
