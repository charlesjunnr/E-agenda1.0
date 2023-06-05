using e_agenda.Dominio.ModuloTarefa;

namespace e_agenda.Infra.Dados.Memoria.ModuloTarefa
{
    
    public class RepositorioTarefaEmMemoria : RepositorioBaseEmMemoria<Tarefa>
    {
        public RepositorioTarefaEmMemoria(List<Tarefa> tarefas)
        {
            this.listaRegistros = tarefas;
        }
    }
}
