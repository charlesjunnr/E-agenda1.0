using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        IRepositorioDespesa repositorioDespesa;
        TelaDespesaForm TelaDespesaForm;
        ListaDespesaControl listaDespesa;

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa)
        {
            this.repositorioDespesa = repositorioDespesa;
        }

        public override string ToolTipInserir => "Inserir nova Despesa";

        public override string ToolTipEditar => "Editar Despesas";

        public override string ToolTipExcluir => "Excluir Despesas";

        public override void Editar()
        {
            int id = listaDespesa.ObterIdSelecionado();

            Despesa despesaSelecionada = repositorioDespesa.SelecionarPorId(id);

            if (despesaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!",
                   "Edição de Despesas",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            TelaDespesaForm telaDespesa = new TelaDespesaForm(despesas);

            telaDespesa.ConfigurarTela(despesaSelecionada);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.ObterDespesa();

                repositorioDespesa.Editar(despesa.id, despesa);

                CarregarDespesas();
            }
        }

        public override void Excluir()
        {
            int id = listaDespesa.ObterIdSelecionado();

            Despesa despesa = repositorioDespesa.SelecionarPorId(id);

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!",
                    "Exclusão de Despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a despesa {despesa.descricao}?", "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }
        }

        public override void Inserir()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            TelaDespesaForm telaDespesa = new TelaDespesaForm(despesas);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.ObterDespesa();

                repositorioDespesa.Inserir(despesa);

                CarregarDespesas();
            }
        }

        public override UserControl ObterListagem()
        {
            if (listaDespesa == null)
                listaDespesa = new ListaDespesaControl();

            CarregarDespesas();

            return listaDespesa;
        }

        public void CarregarDespesas()
        {
            List<Despesa> despesa = repositorioDespesa.SelecionarTodos();

            listaDespesa.AtualizarRegistros(despesa);
        }
            
        

    public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
    }
}
