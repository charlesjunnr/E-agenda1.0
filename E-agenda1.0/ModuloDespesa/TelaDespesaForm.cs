using e_agenda.Dominio.ModuloCategoria;
using e_agenda.Dominio.ModuloDespesa;
using e_agenda.Infra.Dados.Memoria.ModuloDespesa;
using E_agenda1._0.ModuloCategoria;
using E_agenda1._0.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;
        private RepositorioDespesaEmMemoria repositorioDespesa;
        private ListaDespesaControl listaDespesaControl;

        public Despesa Despesa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricao.ToString();
                dtpData.Text = value.data.ToShortDateString();
                txtValor.Text = value.valor.ToString();
                cbxPagamento.Text = value.tipoPagamento.ToString();

            }
            get
            {
                return despesa;
            }
        }

        public TelaDespesaForm(List<Despesa> despesas , List<Categoria> categorias)
        {
            InitializeComponent();

            CarregarCategorias(categorias);

        }

        public void CarregarCategorias(List<Categoria> categorias)
        {
            foreach (Categoria categoria in categorias)
            {
                clbCategorias.Items.Add(categoria);
            }
        }

        public Despesa ObterDespesa()
        {
            int? id = Convert.ToInt32(txtId.Text);

            string descricao = txtDescricao.Text;

            decimal valor = Convert.ToDecimal(txtValor.Text);

            DateTime data = dtpData.Value;

            List<Categoria> categorias = clbCategorias.CheckedItems.Cast<Categoria>().ToList();

            TipoPagamentoEnum pagamento;

            if (clbCategorias.Text == "Dinheiro")
            {
                pagamento = TipoPagamentoEnum.Dinheiro;
            }
            else if (clbCategorias.Text == "Crédito")
            {
                pagamento = TipoPagamentoEnum.Credito;
            }
            else
            {
                pagamento = TipoPagamentoEnum.Debito;
            }

            despesa = new Despesa(descricao, valor, data, pagamento, categorias);

            despesa.id = id.ToString() == "" ? 0 : Convert.ToInt32(id);

            return despesa;
        }

        private void cbxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ConfigurarTela(Despesa despesaSelecionada)
        {
            txtId.Text = despesaSelecionada.id.ToString();
            txtDescricao.Text = despesaSelecionada.descricao.ToString();
            txtValor.Text = despesaSelecionada.valor.ToString();
            dtpData.Text = despesaSelecionada.data.ToShortDateString();
            clbCategorias.Text = despesaSelecionada.tipoPagamento.ToString();
        }
    }
}
