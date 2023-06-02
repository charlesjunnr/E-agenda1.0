using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloCompromisso
{
    

    public class RepositorioCompromissoEmMemoria : RepositorioBaseEmMemoria<Compromisso>
    {
        public RepositorioCompromissoEmMemoria(List<Compromisso> compromissos)
        {
            this.listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            return listaRegistros.Where (x => x.data <  now).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return listaRegistros.Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }
    }
}
