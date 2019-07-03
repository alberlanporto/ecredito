using System.Collections.Generic;
using System.Linq;
using Alberlan.eCredito.Dominio.Cadastro;
using System.Data;
using Alberlan.eCredito.Dominio.Cadastro;
using Alberlan.eCredito.Interface.DTO.Cadastro;

namespace Alberlan.eCredito.Repositorio.Cadastro
{
    public class TipoFinanciamentoRepositorio
    {
        private BancoDados bancoDados;

        public TipoFinanciamentoRepositorio()
        {
            bancoDados = new BancoDados();
        }

        public List<TipoFinanciamento> Consultar()
        {
            return bancoDados.TipoFinanciamentoCollection.ToList();
        }

        public TipoFinanciamentoDTO ConsultarPorChave(int iId)
        {
            TipoFinanciamentoDTO tipoFinanciamentosDTO = (from TipoFinanciamento tipoFinanciamento in bancoDados.TipoFinanciamentoCollection
                                                          where
                                                          tipoFinanciamento.Id == iId
                                                          select new TipoFinanciamentoDTO
                                                          {
                                                              Id = tipoFinanciamento.Id,
                                                              Descricao = tipoFinanciamento.Descricao,
                                                              PercentualTaxa = tipoFinanciamento.PercentualTaxa
                                                          }).FirstOrDefault();

            return tipoFinanciamentosDTO;
        }

        public void Incluir(TipoFinanciamento tipoFinanciamento)
        {
            ExecutarComando(tipoFinanciamento, EntityState.Added);
        }

        public void Editar(TipoFinanciamento tipoFinanciamento)
        {
            ExecutarComando(tipoFinanciamento, EntityState.Modified);
        }

        public void Excluir(TipoFinanciamento tipoFinanciamento)
        {
            ExecutarComando(tipoFinanciamento, EntityState.Deleted);
        }

        public void IncluirTodos(List<TipoFinanciamento> tipoFinanciamentos)
        {
            foreach (TipoFinanciamento tipoFinanciamento in tipoFinanciamentos)
            {
                bancoDados.TipoFinanciamentoCollection.Attach(tipoFinanciamento);
                bancoDados.ObjectStateManager.ChangeObjectState(tipoFinanciamento, EntityState.Added);
            }

            bancoDados.SaveChanges();
        }

        private void ExecutarComando(TipoFinanciamento tipoFinanciamento, EntityState estado)
        {
            bancoDados.TipoFinanciamentoCollection.Attach(tipoFinanciamento);
            bancoDados.ObjectStateManager.ChangeObjectState(tipoFinanciamento, estado);
            bancoDados.SaveChanges();
        }
    }
}
