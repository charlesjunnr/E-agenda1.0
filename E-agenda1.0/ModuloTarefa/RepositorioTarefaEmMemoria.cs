using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloTarefa
{
    
    public class RepositorioTarefaEmMemoria : RepositorioBaseEmMemoria<Tarefa>
    {
        public RepositorioTarefaEmMemoria(List<Tarefa> tarefas)
        {
            this.listaRegistros = tarefas;
        }
    }
}
