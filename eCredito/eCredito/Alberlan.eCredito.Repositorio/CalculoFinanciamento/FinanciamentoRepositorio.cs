using System.Collections.Generic;
using System.Linq;
using Alberlan.eCredito.Dominio.CalculoFinanciamento;
using System.Data;

namespace Alberlan.eCredito.Repositorio.CalculoFinanciamento
{
    public class FinanciamentoRepositorio
    {
        private BancoDados bancoDados;

        public FinanciamentoRepositorio()
        {
            bancoDados = new BancoDados();
        }

        public List<Financiamento> Consultar()
        {
            return bancoDados.FinanciamentoCollection.ToList();
        }

        public List<Financiamento> ConsultarPorChave(int iId)
        {
            List<Financiamento> financiamentos = (from Financiamento financiamento in bancoDados.ClienteCollection
                                                  where
                                                  financiamento.Id == iId
                                                  select financiamento).ToList();
            return financiamentos;
        }

        public int Incluir(Financiamento financiamento)
        {
            ExecutarComando(financiamento, EntityState.Added);

            return financiamento.Id;
        }

        public void Editar(Financiamento financiamento)
        {
            ExecutarComando(financiamento, EntityState.Modified);
        }

        public void Excluir(Financiamento financiamento)
        {
            ExecutarComando(financiamento, EntityState.Deleted);
        }

        public void IncluirTodos(List<Financiamento> financiamentos)
        {
            foreach (Financiamento financiamento in financiamentos)
            {
                bancoDados.FinanciamentoCollection.Attach(financiamento);
                bancoDados.ObjectStateManager.ChangeObjectState(financiamento, EntityState.Added);
            }

            bancoDados.SaveChanges();
        }

        private void ExecutarComando(Financiamento financiamento, EntityState estado)
        {
            bancoDados.FinanciamentoCollection.Attach(financiamento);
            bancoDados.ObjectStateManager.ChangeObjectState(financiamento, estado);
            bancoDados.SaveChanges();
        }
    }
}
