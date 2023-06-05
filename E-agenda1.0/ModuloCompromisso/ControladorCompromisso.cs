using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_agenda.Dominio.ModuloCompromisso;
using e_agenda.Dominio.ModuloContato;

namespace E_agenda1._0.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {

        private IRepositorioCompromisso repositorioCompromisso;
        private IRepositorioContato repositorioContato;
        private ListaCompromissoControl listaCompromisso;

        public ControladorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromissos"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromissos"; } }

        public override void Editar()
        {
            int id = listaCompromisso.ObterIdSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(id);

            if (compromissoSelecionado == null) 
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                   "Edição de Compromissos",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);
            
            telaCompromisso.ConfigurarTela(compromissoSelecionado);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Editar(compromisso.id, compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            int id = listaCompromisso.ObterIdSelecionado();

            Compromisso compromisso = repositorioCompromisso.SelecionarPorId(id);

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromisso.assunto}?", "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Inserir()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromisso = repositorioCompromisso.SelecionarTodos();

            listaCompromisso.AtualizarRegistros(compromisso);
        }

        public override UserControl ObterListagem()
        {
            if (listaCompromisso == null)
                listaCompromisso = new ListaCompromissoControl();

            CarregarCompromissos();

            return listaCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissosForm  telaFiltro = new TelaFiltroCompromissosForm();

            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                StatusFiltroCompromissoEnum status = telaFiltro.ObterStatus();
                DateTime dataInicio = telaFiltro.ObterDataInicio();
                DateTime dataFinal = telaFiltro.ObterDataFinal();

                if(status == StatusFiltroCompromissoEnum.Todos)
                {
                    CarregarCompromissos();
                }else if(status == StatusFiltroCompromissoEnum.Passados)
                {
                    List<Compromisso> compromissosPassados = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
                    CarregarCompromissos(compromissosPassados);
                }
                else if(status == StatusFiltroCompromissoEnum.Futuros)
                {
                    List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);

                    CarregarCompromissos(compromissosFuturos);
                }
            }
        }

        public void CarregarCompromissos(List<Compromisso> compromissosPassados)
        {
            listaCompromisso.AtualizarRegistros(compromissosPassados);
        }
    }
}
