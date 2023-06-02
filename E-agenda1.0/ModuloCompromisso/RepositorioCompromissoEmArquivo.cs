using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloCompromisso
{
    

    public class RepositorioCompromissoEmArquivo : RepositorioBaseEmArquivo<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override List<Compromisso> BuscarRegistros()
        {
            return contextoBase.compromissos;
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return BuscarRegistros().Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime now)
        {
            return BuscarRegistros().Where(x => x.data < now).ToList();
        }
    }
}
