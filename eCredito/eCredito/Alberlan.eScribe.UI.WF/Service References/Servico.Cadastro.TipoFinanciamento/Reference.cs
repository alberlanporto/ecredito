﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alberlan.eCredito.UI.WF.Servico.Cadastro.TipoFinanciamento {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servico.Cadastro.TipoFinanciamento.ITipoFinanciamento")]
    public interface ITipoFinanciamento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITipoFinanciamento/Consultar", ReplyAction="http://tempuri.org/ITipoFinanciamento/ConsultarResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITipoFinanciamento/Incluir", ReplyAction="http://tempuri.org/ITipoFinanciamento/IncluirResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Incluir(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO tipoFinanciamentoDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITipoFinanciamento/Editar", ReplyAction="http://tempuri.org/ITipoFinanciamento/EditarResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Editar(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO tipoFinanciamentoDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITipoFinanciamento/Excluir", ReplyAction="http://tempuri.org/ITipoFinanciamento/ExcluirResponse")]
        Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Excluir(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO tipoFinanciamentoDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITipoFinanciamento/IncluirTodos", ReplyAction="http://tempuri.org/ITipoFinanciamento/IncluirTodosResponse")]
        void IncluirTodos(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] tipoFinanciamentosDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITipoFinanciamentoChannel : Alberlan.eCredito.UI.WF.Servico.Cadastro.TipoFinanciamento.ITipoFinanciamento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TipoFinanciamentoClient : System.ServiceModel.ClientBase<Alberlan.eCredito.UI.WF.Servico.Cadastro.TipoFinanciamento.ITipoFinanciamento>, Alberlan.eCredito.UI.WF.Servico.Cadastro.TipoFinanciamento.ITipoFinanciamento {
        
        public TipoFinanciamentoClient() {
        }
        
        public TipoFinanciamentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TipoFinanciamentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TipoFinanciamentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TipoFinanciamentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Incluir(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO tipoFinanciamentoDTO) {
            return base.Channel.Incluir(tipoFinanciamentoDTO);
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Editar(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO tipoFinanciamentoDTO) {
            return base.Channel.Editar(tipoFinanciamentoDTO);
        }
        
        public Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] Excluir(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO tipoFinanciamentoDTO) {
            return base.Channel.Excluir(tipoFinanciamentoDTO);
        }
        
        public void IncluirTodos(Alberlan.eCredito.Interface.DTO.Cadastro.TipoFinanciamentoDTO[] tipoFinanciamentosDTO) {
            base.Channel.IncluirTodos(tipoFinanciamentosDTO);
        }
    }
}
