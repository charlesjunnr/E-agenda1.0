using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloTarefa
{
    public partial class ConcluirEtapasTarefasForms : Form
    {
        public ConcluirEtapasTarefasForms(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            CarregarItensTarefa(tarefaSelecionada);

            AlimentarBarraDeProgresso(tarefaSelecionada);
        }

        private void ConcluirEtapasTarefasForms_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CarregarItensTarefa(Tarefa tarefaSelecionada)
        {
            txtTarefa.Text = tarefaSelecionada.titulo;

            clbEtapasTarefa.Items.Clear();

            List<ItemTarefa> itemTarefas = tarefaSelecionada.itensTarefa.ToList();

            foreach (ItemTarefa itens in itemTarefas)
            {
                if (itens.estaConcluido != true)
                    clbEtapasTarefa.Items.Add(itens.descricao);
            }
        }

        public void ConcluirEtapasTarefasCaixa(Tarefa tarefaSelecionada)
        {
            foreach (ItemTarefa itens in tarefaSelecionada.itensTarefa)
            {
                if (clbEtapasTarefa.CheckedItems.Contains(itens.descricao))
                {
                    tarefaSelecionada.IncrementarItemConcluido();
                    itens.ConcluirItem();
                }
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {


        }

        public void AlimentarBarraDeProgresso(Tarefa tarefaSelecionada)
        {
            progressBarEtapas.Increment((int)tarefaSelecionada.porcentagemConcluida);
        }
    }
}
