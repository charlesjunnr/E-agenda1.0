using e_agenda.Dominio.ModuloCategoria;
using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloDespesa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloCategoria
{
    public partial class ListaCategoriaControl : UserControl
    {
        public ListaCategoriaControl()
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
                    Name = "descricao",
                    HeaderText = "Descrição"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            grid.Rows.Clear();

            foreach (Categoria categoria in categorias)
            {
                grid.Rows.Add(categoria.id, categoria.descricaoCategoria);
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
