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
    public class ClienteFacade : ICliente
    {
        private ClienteRepositorio clienteRepositorio;

        public ClienteFacade()
        {
            clienteRepositorio = new ClienteRepositorio();
        }

        public List<ClienteDTO> Consultar()
        {
            List<Cliente> clientes = clienteRepositorio.Consultar();

            List<ClienteDTO> clientesDTO = new List<ClienteDTO>(clientes.Count());

            foreach (Cliente cliente in clientes)
            {
                clientesDTO.Add(new ClienteDTO(cliente.Codigo, cliente.Nome, cliente.Uf, cliente.Celular));
            }

            return clientesDTO;
        }

        public List<ClienteDTO> Incluir(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente();

            cliente.Codigo = clienteDTO.Codigo;
            cliente.Nome = clienteDTO.Nome;
            cliente.Uf = clienteDTO.Uf;
            cliente.Celular = clienteDTO.Celular;

            clienteRepositorio.Incluir(cliente);

            return Consultar();
        }

        public List<ClienteDTO> Editar(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente();

            cliente.Codigo = clienteDTO.Codigo;
            cliente.Nome = clienteDTO.Nome;
            cliente.Uf = clienteDTO.Uf;
            cliente.Celular = clienteDTO.Celular;

            clienteRepositorio.Editar(cliente);

            return Consultar();
        }

        public List<ClienteDTO> Excluir(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente();

            cliente.Codigo = clienteDTO.Codigo;
            cliente.Nome = clienteDTO.Nome;
            cliente.Uf = clienteDTO.Uf;
            cliente.Celular = clienteDTO.Celular;

            clienteRepositorio.Excluir(cliente);

            return Consultar();
        }

        public void IncluirTodos(List<ClienteDTO> clientesDTO)
        {
            List<Cliente> clienteTodos = new List<Cliente>();
            foreach (ClienteDTO clienteDTO in clientesDTO)
            {
                Cliente cliente = new Cliente();

                cliente.Codigo = clienteDTO.Codigo;
                cliente.Nome = clienteDTO.Nome;
                cliente.Uf = clienteDTO.Uf;
                cliente.Celular = clienteDTO.Celular;

                clienteTodos.Add(cliente);
            }

            clienteRepositorio.IncluirTodos(clienteTodos);
        }
    }
}
