using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloCompromisso;
using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloTarefa
{
    
    public  class ControladorTarefa : ControladorBase
    {
        IRepositorioTarefa repositorioTarefa;
        TelaTarefaForm TelaTarefaForm;
        ListagemTarefaControl listaTarefa;
        

        public ControladorTarefa(IRepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefas"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefas"; } }

        public override void Editar()
        {
            int id = listaTarefa.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(id);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                   "Edição de Tarefas",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            TelaTarefaForm telaTarefa = new TelaTarefaForm(tarefas);

            telaTarefa.ConfigurarTela(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Editar(tarefa.id, tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            int id = listaTarefa.ObterIdSelecionado();

            Tarefa tarefa = repositorioTarefa.SelecionarPorId(id);

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Inserir()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            TelaTarefaForm telaTarefa = new TelaTarefaForm(tarefas);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        private void CarregarTarefas(List<Tarefa> tarefasPassadas)
        {
            listaTarefa.AtualizarRegistros(tarefasPassadas);
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefa = repositorioTarefa.SelecionarTodos();

            listaTarefa.AtualizarRegistros(tarefa);
        }

        public override UserControl ObterListagem()
        {
            if (listaTarefa == null)
                listaTarefa = new ListagemTarefaControl();

            CarregarTarefas();

            return listaTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void AdicionarEtapasTarefa()
        {
            int id = listaTarefa.ObterIdSelecionado();

            Tarefa tarefa = repositorioTarefa.SelecionarPorId(id);

            EtapasTarefaForm etapasTarefaForm = new EtapasTarefaForm(tarefa);

            DialogResult opcaoEscolhida = etapasTarefaForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.Yes)
            {
                List<ItemTarefa> itemTarefas = etapasTarefaForm.BuscarItem();

                foreach(ItemTarefa item in itemTarefas)
                {
                    tarefa.AdicionarItemNaLista(item);
                }

                repositorioTarefa.Editar(tarefa.id, tarefa);

                var listaTarefas = repositorioTarefa.SelecionarTodos();

                listaTarefa.AtualizarRegistros(listaTarefas);

            }
        }

        public List<Tarefa> SelecionarTodosPorPrioridade()
        {
            List<Tarefa> tarefasOrdenadas = repositorioTarefa.SelecionarTodos().OrderBy(x => x.prioridade).ToList();

            return tarefasOrdenadas;
        }

        public List<Tarefa> SelecionarPendentes()
        {
            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTodos().Where(x => x.porcentagemConcluida < 100).ToList();

            return tarefasPendentes;
        }

        public override void OrdenarTarefas()
        {
            OrdenarTarefasForm ordenarTarefasForm = new OrdenarTarefasForm();

            DialogResult opcaoEscolhida = ordenarTarefasForm.ShowDialog();
            bool ordem = false;

            if (opcaoEscolhida == DialogResult.OK)
            {
                ordenarTarefasForm.ObterFiltro(ordem);

                if (ordem == true) 
                {
                    List<Tarefa> tarefasPorOrdem = SelecionarPendentes();
                    CarregarTarefas(tarefasPorOrdem);
                }
                else if(ordem == false)
                {
                    List<Tarefa> tarefasPorOrdem = SelecionarTodosPorPrioridade();
                    CarregarTarefas(tarefasPorOrdem);
                }
            }
        }
    }
}
