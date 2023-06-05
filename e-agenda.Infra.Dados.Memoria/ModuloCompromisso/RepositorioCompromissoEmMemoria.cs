using e_agenda.Dominio.ModuloCompromisso;

namespace e_agenda.Infra.Dados.Memoria.ModuloCompromisso
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
