using e_agenda.Dominio.ModuloCompromisso;

namespace e_agenda.Infra.Dados.Arquivo.ModuloCompromisso
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
