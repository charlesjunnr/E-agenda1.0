using e_agenda.Dominio.ModuloCategoria;
using e_agenda.Dominio.ModuloCompromisso;
using e_agenda.Dominio.ModuloContato;
using e_agenda.Dominio.ModuloDespesa;
using e_agenda.Dominio.ModuloTarefa;
using e_agenda.Infra.Dados.Arquivo.Compartilhado;
using e_agenda.Infra.Dados.Arquivo.ModuloCategoria;
using e_agenda.Infra.Dados.Arquivo.ModuloCompromisso;
using e_agenda.Infra.Dados.Arquivo.ModuloContato;
using e_agenda.Infra.Dados.Arquivo.ModuloDespesa;
using e_agenda.Infra.Dados.Arquivo.ModuloTarefa;
using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloCategoria;
using E_agenda1._0.ModuloCompromisso;
using E_agenda1._0.ModuloContato;
using E_agenda1._0.ModuloDespesa;
using E_agenda1._0.ModuloTarefa;
using System.Runtime.CompilerServices;

namespace E_agenda1._0

{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private static TelaPrincipalForm telaPrincipal;

        public static ContextoDados contexto = new ContextoDados(true);

        private IRepositorioContato repositorioContato = new RepositorioContatoEmArquivo(contexto);
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoEmArquivo(contexto);
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaArquivo(contexto);
        private IRepositorioDespesa repositorioDespesa = new RepositorioDespesaEmArquivo(contexto);
        private IRepositorioCategoria repositorioCategoria = new RepositorioCategoriaEmArquivo(contexto);

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        private void contatosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                return telaPrincipal;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            painelRegistros.Controls.Clear();

            painelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        public void AtualizarRodape(string mensagem)
        {
            lblStatus.Text = mensagem;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            controlador.AdicionarEtapasTarefa();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrosMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripOrganizarTarefas_Click(object sender, EventArgs e)
        {
            controlador.OrdenarTarefas();
        }

        private void btnFinalizarEtapas_Click(object sender, EventArgs e)
        {
            controlador.FinalizarEtapasTarefa();
        }

        private void despesasMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria, repositorioDespesa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void toolStripButtonDespesasCategorias_Click(object sender, EventArgs e)
        {
            controlador.VisualizarDespesasCategorias();
        }
    }
}