﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alberlan.eCredito.UI.WF.Servico.Cadastro.Cliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servico.Cadastro.Cliente.ICliente")]
    public interface ICliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/Consultar", ReplyAction="http://tempuri.org/ICliente/ConsultarResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/Incluir", ReplyAction="http://tempuri.org/ICliente/IncluirResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Incluir(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO clienteDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/Editar", ReplyAction="http://tempuri.org/ICliente/EditarResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Editar(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO clienteDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/Excluir", ReplyAction="http://tempuri.org/ICliente/ExcluirResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Excluir(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO clienteDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/IncluirTodos", ReplyAction="http://tempuri.org/ICliente/IncluirTodosResponse")]
        void IncluirTodos(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] clientesDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteChannel : Alberlan.eCredito.UI.WF.Servico.Cadastro.Cliente.ICliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteClient : System.ServiceModel.ClientBase<Alberlan.eCredito.UI.WF.Servico.Cadastro.Cliente.ICliente>, Alberlan.eCredito.UI.WF.Servico.Cadastro.Cliente.ICliente {
        
        public ClienteClient() {
        }
        
        public ClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Incluir(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO clienteDTO) {
            return base.Channel.Incluir(clienteDTO);
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Editar(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO clienteDTO) {
            return base.Channel.Editar(clienteDTO);
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] Excluir(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO clienteDTO) {
            return base.Channel.Excluir(clienteDTO);
        }
        
        public void IncluirTodos(Alberlan.eCredito.Interface.DTO.Cadastro.ClienteDTO[] clientesDTO) {
            base.Channel.IncluirTodos(clientesDTO);
        }
    }
}
