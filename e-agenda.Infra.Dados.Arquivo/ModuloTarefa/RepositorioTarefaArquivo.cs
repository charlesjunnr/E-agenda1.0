using e_agenda.Dominio.ModuloTarefa;

namespace e_agenda.Infra.Dados.Arquivo.ModuloTarefa
{
    
    public class RepositorioTarefaArquivo : RepositorioBaseEmArquivo<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override List<Tarefa> BuscarRegistros()
        {
            return contextoBase.tarefas;
        }

        public List<Tarefa> ObterTarefasPendentes()
        {
            throw new NotImplementedException();
        }

        public List<Tarefa> SelecionarTodosPorPrioridade()
        {
            throw new NotImplementedException();
        }
    }
}
