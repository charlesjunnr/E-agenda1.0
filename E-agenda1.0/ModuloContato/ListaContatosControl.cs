using E_agenda1._0.Compartilhado;


namespace E_agenda1._0.ModuloContato
{
    public partial class ListaContatosControl : UserControl
    {

        public ListaContatosControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();

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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "email",
                    HeaderText = "E-mail"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cargo",
                    HeaderText = "Cargo"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach (Contato contato in contatos)
            {
                grid.Rows.Add(contato.id, contato.nome, contato.telefone, contato.email, contato.cargo);
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
