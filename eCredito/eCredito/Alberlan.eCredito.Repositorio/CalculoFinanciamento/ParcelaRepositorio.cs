using System.Collections.Generic;
using System.Linq;
using Alberlan.eCredito.Dominio.CalculoFinanciamento;
using System.Data;

namespace Alberlan.eCredito.Repositorio.CalculoFinanciamento
{
    public class ParcelaRepositorio
    {
        private BancoDados bancoDados;

        public ParcelaRepositorio()
        {
            bancoDados = new BancoDados();
        }

        public List<Parcela> Consultar()
        {
            return bancoDados.ParcelaCollection.ToList();
        }

        public List<Parcela> ConsultarPorChave(int iId)
        {
            List<Parcela> parcelas = (from Parcela parcela in bancoDados.ClienteCollection
                                      where
                                      parcela.Id == iId
                                      select parcela).ToList();

            return parcelas;
        }

        public void Incluir(Parcela parcela)
        {
            ExecutarComando(parcela, EntityState.Added);
        }

        public void Editar(Parcela parcela)
        {
            ExecutarComando(parcela, EntityState.Modified);
        }

        public void Excluir(Parcela parcela)
        {
            ExecutarComando(parcela, EntityState.Deleted);
        }

        public void IncluirTodos(List<Parcela> parcelas)
        {
            foreach (Parcela parcela in parcelas)
            {
                bancoDados.ParcelaCollection.Attach(parcela);
                bancoDados.ObjectStateManager.ChangeObjectState(parcela, EntityState.Added);
            }

            bancoDados.SaveChanges();
        }

        private void ExecutarComando(Parcela parcela, EntityState estado)
        {
            bancoDados.ParcelaCollection.Attach(parcela);
            bancoDados.ObjectStateManager.ChangeObjectState(parcela, estado);
            bancoDados.SaveChanges();
        }
    }
}
