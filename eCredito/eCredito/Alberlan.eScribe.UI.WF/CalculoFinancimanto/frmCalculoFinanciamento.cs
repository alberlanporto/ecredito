using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Alberlan.eCredito.UI.WF.Servico.Cadastro.TipoFinanciamento;
using Alberlan.eCredito.UI.WF.Servico.Cadastro.Cliente;
using Alberlan.eCredito.UI.WF.Servico.CalculoFinanciamento.Financiamento;
using Alberlan.eCredito.Interface.DTO.Cadastro;
using Alberlan.eCredito.Interface.DTO.CalculoFinanciamento;

namespace Alberlan.eCredito.UI.WF.CalculoFinancimanto
{
    public partial class frmCalculoFinanciamento : Form
    {
        TipoFinanciamentoDTO[] tipoFinanciamentoDTO;
        ClienteDTO[] clienteDTO;
        CalculoFinanciamentoDTO calculoFinanciamentoDTO;

        public frmCalculoFinanciamento()
        {
            InitializeComponent();

            CarregTipoFinanciamento();
            CarregCliente();

            lblStatus.Text = "";
        }

        private void CarregTipoFinanciamento()
        {
            using (TipoFinanciamentoClient servicoTipoFinanciamento = new TipoFinanciamentoClient())
            {
                tipoFinanciamentoDTO = servicoTipoFinanciamento.Consultar();

                cbTipoFinanciamento.ValueMember = "Id";
                cbTipoFinanciamento.DisplayMember = "Descricao";
                cbTipoFinanciamento.DataSource = tipoFinanciamentoDTO;
            }
        }

        private void CarregCliente()
        {
            using (ClienteClient servicoCliente = new ClienteClient())
            {
                clienteDTO = servicoCliente.Consultar();

                cbCliente.ValueMember = "Codigo";
                cbCliente.DisplayMember = "Nome";
                cbCliente.DataSource = clienteDTO;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            using (FinanciamentoClient financiamentoClient = new FinanciamentoClient())
            {
                lblStatus.Text = "";
                txtValidacoes.Clear();

                calculoFinanciamentoDTO = financiamentoClient.SolicitarFinanciamento((int)cbCliente.SelectedValue, (int)cbTipoFinanciamento.SelectedValue, 
                                                                                     (double)vlrTotal.Value, (int)qtdParcelas.Value, (DateTime)dtaVencimento.Value);

                lblStatus.Text = calculoFinanciamentoDTO.Status;

                if (calculoFinanciamentoDTO.Validacoes.Count > 0)
                {
                    btnConfirmar.Enabled = false;
                    gvParcelas.DataSource = null;
                    lblTotalFinanciamento.Text = "Total Financiamento: ";
                    lblTotalJuros.Text = "Total Juros: ";

                    foreach (ValidacaoDTO validacao in calculoFinanciamentoDTO.Validacoes)
                    {
                        txtValidacoes.AppendText(string.Format("{0} - {1} \r\n", validacao.Tipo, validacao.Inconsistencia));
                    }
                }
                else
                {
                    btnConfirmar.Enabled = true;

                    gvParcelas.DataSource = calculoFinanciamentoDTO.Parcelas;

                    lblTotalFinanciamento.Text = string.Format("Total Financiamento: {0}", calculoFinanciamentoDTO.TotalFinanciamento.ToString("c"));
                    lblTotalJuros.Text = string.Format("Total Juros: {0}", calculoFinanciamentoDTO.TotalJuros.ToString("c"));
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            using (FinanciamentoClient financiamentoClient = new FinanciamentoClient())
            {
                financiamentoClient.ConfirmarFinanciamento(calculoFinanciamentoDTO);
            }
        }
    }
}
