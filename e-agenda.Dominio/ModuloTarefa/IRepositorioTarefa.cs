using e_agenda.Dominio.ModuloTarefa;

namespace e_agenda.Dominio.ModuloTarefa
{

    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> ObterTarefasPendentes();
        List<Tarefa> SelecionarTodosPorPrioridade();

    }
}
