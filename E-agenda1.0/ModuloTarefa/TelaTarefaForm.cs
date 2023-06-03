using E_agenda1._0.ModuloCompromisso;
using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_agenda1._0.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        private RepositorioTarefaEmMemoria repositorioTarefa;
        private ListagemTarefaControl listagemTarefaControl;
        public TelaTarefaForm(List<Tarefa> tarefas)
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo.ToString();
                dtpDataInicial.Text = value.dataInicial.ToShortDateString();
                dtpDataFinal.Text = value.dataFinal.ToString();

            }
            get
            {
                return tarefa;
            }

        }

        public void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();
            txtTitulo.Text = tarefaSelecionada.titulo;
            dtpDataInicial.Text = tarefaSelecionada.dataInicial.ToString();
            dtpDataFinal.Text = tarefaSelecionada.dataFinal.ToString();

            if (tarefaSelecionada.prioridade == PrioridadeTarefaEnum.Alta)
                rdbPrioridadeAlta.Checked.ToString();
            else if (tarefaSelecionada.prioridade == PrioridadeTarefaEnum.Normal)
                rdbPrioridadeNormal.Checked.ToString();
            else
                rdbPrioridadeBaixa.Checked.ToString();
        }

        internal Tarefa ObterTarefa()
        {
            int? id = Convert.ToInt32(txtId.Text);

            string titulo = txtTitulo.Text;

            DateTime dataInicial = dtpDataInicial.Value;

            DateTime dataFinal = dtpDataFinal.Value;


            PrioridadeTarefaEnum prioridade;

            if (rdbPrioridadeAlta.Checked)
                prioridade = PrioridadeTarefaEnum.Alta;
            else if (rdbPrioridadeNormal.Checked)
                prioridade = PrioridadeTarefaEnum.Normal;
            else
                prioridade = PrioridadeTarefaEnum.Baixa;

            bool tarefaConcluida = false;

            decimal porcentagem = 0;

            tarefa = new Tarefa(prioridade, titulo, dataInicial, dataFinal, porcentagem, tarefaConcluida);

            tarefa.id = id.ToString() == "" ? 0 : Convert.ToInt32(id); //verifica se o valor que recebe é null e atribui valor de 0

            return tarefa;
        }

        private void lblDataTermino_Click(object sender, EventArgs e)
        {

        }

        private void TelaTarefaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
