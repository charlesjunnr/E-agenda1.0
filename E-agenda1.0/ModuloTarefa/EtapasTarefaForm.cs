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
    [Serializable]

    public partial class EtapasTarefaForm : Form
    {

        List<ItemTarefa> listaItensTarefa = new List<ItemTarefa>();

        public EtapasTarefaForm(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            ConcluirTarefa();

            CarregarItensTarefa(tarefaSelecionada);

        }

        private void CarregarItensTarefa(Tarefa tarefaSelecionada)
        {
            txtTarefa.Text = tarefaSelecionada.titulo;

            clbEtapas.Items.Clear();

            List<ItemTarefa> itemTarefas = tarefaSelecionada.itensTarefa.ToList();

            foreach (ItemTarefa itens in itemTarefas)
            {
                clbEtapas.Items.Add(itens.descricao);
            }
        }

        public void ConcluirTarefa()
        {
            for (int i = 0; i < listaItensTarefa.Count; i++)
            {
                foreach (CheckBox c in clbEtapas.CheckedItems)
                {
                    listaItensTarefa[i].ConcluirItem();
                }

            }

        }

        private void EtapasTarefaForm_Load(object sender, EventArgs e)
        {
        }

        public List<ItemTarefa> BuscarItem()
        {
            return listaItensTarefa;
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            string descricao = txtEtapa.Text;

            ItemTarefa itemTarefa = new ItemTarefa(descricao);

            listaItensTarefa.Add(itemTarefa);

            clbEtapas.Items.Add(itemTarefa.descricao);

            txtEtapa.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
