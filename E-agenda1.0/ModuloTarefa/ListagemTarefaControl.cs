using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloCompromisso;
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
    public partial class ListagemTarefaControl : UserControl
    {


        public ListagemTarefaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();

        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();


            foreach (Tarefa tarefa in tarefas)
            {
                grid.Rows.Add(tarefa.id,
                    tarefa.titulo,
                    tarefa.prioridade,
                    tarefa.dataInicial.ToShortDateString(),
                    tarefa.dataFinal.ToShortDateString(),
                    tarefa.porcentagemConcluida + "%");
            }


        }

        public int ObterIdSelecionado()
        {
            int id;
            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            }
            catch
            {
                id = -1;
            }

            return id;
        }
        public void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataInicial",
                    HeaderText = "Data Inicial"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataFinal",
                    HeaderText = "Data Final"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "porcentagem",
                    HeaderText = "Progresso"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
