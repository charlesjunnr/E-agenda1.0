using e_agenda.Dominio.ModuloCategoria;
using e_agenda.Dominio.ModuloDespesa;

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
