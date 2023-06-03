using E_agenda1._0.ModuloCategoria;
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
    public partial class TelaVisualizacaoDespesasCategoriaForm : Form
    {
        public TelaVisualizacaoDespesasCategoriaForm(List<Despesa> despesas, Categoria categoria)
        {
            InitializeComponent();

            PopularDespesas(despesas, categoria);
        }

        public void PopularDespesas(List<Despesa> despesas, Categoria categoria)
        {
            foreach (Despesa despesa in despesas)
            {
                listBoxDespesas.Items.Add(despesa);
            }

            lblCategoria.Text = categoria.descricaoCategoria;

        }

        private void VisualizacaoDespesasCategoriaForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
