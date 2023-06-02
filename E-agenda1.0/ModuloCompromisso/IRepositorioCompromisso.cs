using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
        List<Compromisso> SelecionarCompromissosPassados(DateTime now);
    }
}
