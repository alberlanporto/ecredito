using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Alberlan.eCredito.Dominio.Cadastro;
using Alberlan.eCredito.Dominio.CalculoFinanciamento;

namespace Alberlan.eCredito.Repositorio
{
    public class BancoDados : ObjectContext
    {
        #region "Cadastros"
        public ObjectSet<Cliente> ClienteCollection { get; set; }
        public ObjectSet<TipoFinanciamento> TipoFinanciamentoCollection { get; set; }
        #endregion

        #region "CalculoFinanciamento"
        public ObjectSet<Financiamento> FinanciamentoCollection { get; set; }
        public ObjectSet<Parcela> ParcelaCollection { get; set; }
        #endregion

        public BancoDados()
            : base("name = DBeCredito")
        {
            #region "Cadastros"
            ClienteCollection = CreateObjectSet<Cliente>();
            TipoFinanciamentoCollection = CreateObjectSet<TipoFinanciamento>();
            #endregion

            #region "CalculoFinanciamento"
            FinanciamentoCollection = CreateObjectSet<Financiamento>();
            ParcelaCollection = CreateObjectSet<Parcela>();
            #endregion
        }
    }
}
