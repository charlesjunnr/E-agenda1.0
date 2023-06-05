using e_agenda.Dominio.ModuloDespesa;
using E_agenda1._0.Compartilhado;
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

namespace E_agenda1._0.ModuloDespesa
{
    public partial class ListaDespesaControl : UserControl
    {
        public ListaDespesaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridSomenteLeitura();

            grid.ConfigurarGridZebrado();
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
                    Name = "despesa",
                    HeaderText = "Despesa"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "categoria",
                    HeaderText = "Categoria"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            grid.Rows.Clear();

            foreach (Despesa despesa in despesas)
            {
                grid.Rows.Add(despesa.id, despesa.descricao, "R$" + despesa.valor, despesa.data.ToShortDateString(), String.Join(", ", despesa.categorias));            
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
    }
}
