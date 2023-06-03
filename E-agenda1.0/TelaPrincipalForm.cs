using E_agenda1._0.Compartilhado;
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
        private IRepositorioDespesa repositorioDespesa = new RepositorioDespesaEmMemoria(new List<Despesa>());


        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
            //PopularRepositorios();
        }

        public void PopularRepositorios()
        {
            Contato antonio = new Contato("Antonio B.", "Celesc", "99999-5555", "antonio@gmail.com", "Atendente");
            Contato joaquim = new Contato("Joaquim C.", "Semasa", "99777-2222", "joaquim@gmail.com", "Externo");
            Contato ademir = new Contato("Ademir D.", "Secretaria da Ed.", "92222-2332", "ademir@gmail.com", "Secretário");
            Contato milena = new Contato("Milena E.", "Secretaria do Turismo", "93333-2345", "milena@gmail.com", "Gerente");

            repositorioContato.Inserir(antonio);
            repositorioContato.Inserir(joaquim);
            repositorioContato.Inserir(ademir);
            repositorioContato.Inserir(milena);



            Compromisso rpgDungeons = new Compromisso("RPG - Dungeons and Dragons", new DateTime(2023, 05, 28), new TimeSpan(15, 0, 0), new TimeSpan(18, 0, 0), joaquim, "Discord", TipoLocalEnum.Online);
            Compromisso rpgWod = new Compromisso("RPG - Mundo das Trevas", new DateTime(2023, 05, 22), new TimeSpan(12, 0, 0), new TimeSpan(14, 0, 0), antonio, "Discord", TipoLocalEnum.Online);
            Compromisso rpgChangeling = new Compromisso("RPG - Changeling", new DateTime(2023, 06, 02), new TimeSpan(20, 0, 0), new TimeSpan(22, 0, 0), ademir, "Discord", TipoLocalEnum.Online);
            Compromisso rpgVampire = new Compromisso("RPG - Vampiro", new DateTime(2023, 05, 29), new TimeSpan(09, 0, 0), new TimeSpan(11, 0, 0), milena, "Discord", TipoLocalEnum.Online);

            repositorioCompromisso.Inserir(rpgWod);
            repositorioCompromisso.Inserir(rpgChangeling);
            repositorioCompromisso.Inserir(rpgVampire);
            repositorioCompromisso.Inserir(rpgDungeons);

            //Tarefa limparCasa = new Tarefa(PrioridadeTarefaEnum.Alta, "Limpar a Casa", new DateTime(2023, 06, 01), new DateTime(2023, 06, 07), 0, false);
            //Tarefa prepararAulas = new Tarefa(PrioridadeTarefaEnum.Normal, "Preparar Aulas", new DateTime(2023, 05, 29), new DateTime(2023, 06, 01), 0, false);

            //limparCasa.itensTarefa.Add(new ItemTarefa("Arrumar o quarto"));
            //limparCasa.itensTarefa.Add(new ItemTarefa("Passar Pano"));
            //limparCasa.itensTarefa.Add(new ItemTarefa("Varrer o chão"));
            //prepararAulas.itensTarefa.Add(new ItemTarefa("Separar os vídeos"));
            //prepararAulas.itensTarefa.Add(new ItemTarefa("Organizar as atividades"));
            //prepararAulas.itensTarefa.Add(new ItemTarefa("Alimentar o sistema"));

            //repositorioTarefa.Inserir(limparCasa);
            //repositorioTarefa.Inserir(prepararAulas);
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
            controlador = new ControladorDespesa(repositorioDespesa);

            ConfigurarTelaPrincipal(controlador);
        }
    }
}