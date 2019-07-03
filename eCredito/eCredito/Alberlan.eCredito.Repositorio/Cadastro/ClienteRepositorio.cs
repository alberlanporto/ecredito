using System.Collections.Generic;
using System.Linq;
using Alberlan.eCredito.Dominio.Cadastro;
using System.Data;

namespace Alberlan.eCredito.Repositorio.Cadastro
{
    public class ClienteRepositorio
    {
        private BancoDados bancoDados;

        public ClienteRepositorio()
        {
            bancoDados = new BancoDados();
        }

        public List<Cliente> Consultar()
        {
            return bancoDados.ClienteCollection.ToList();
        }

        public List<Cliente> ConsultarPorChave(int iCodigo)
        {
            List<Cliente> clientes = (from Cliente cliente in bancoDados.ClienteCollection
                                      where
                                      cliente.Codigo == iCodigo
                                      select cliente).ToList();

            return clientes;
        }

        public void Incluir(Cliente cliente)
        {
            ExecutarComando(cliente, EntityState.Added);
        }

        public void Editar(Cliente cliente)
        {
            ExecutarComando(cliente, EntityState.Modified);
        }

        public void Excluir(Cliente cliente)
        {
            ExecutarComando(cliente, EntityState.Deleted);
        }

        public void IncluirTodos(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                bancoDados.ClienteCollection.Attach(cliente);
                bancoDados.ObjectStateManager.ChangeObjectState(cliente, EntityState.Added);
            }

            bancoDados.SaveChanges();
        }

        private void ExecutarComando(Cliente cliente, EntityState estado)
        {
            bancoDados.ClienteCollection.Attach(cliente);
            bancoDados.ObjectStateManager.ChangeObjectState(cliente, estado);
            bancoDados.SaveChanges();
        }
    }
}
