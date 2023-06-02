using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloTarefa
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
