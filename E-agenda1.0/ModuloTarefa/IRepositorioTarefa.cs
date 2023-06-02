using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloTarefa
{

    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> ObterTarefasPendentes();
        List<Tarefa> SelecionarTodosPorPrioridade();

    }
}
