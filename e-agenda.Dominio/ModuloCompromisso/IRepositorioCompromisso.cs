namespace e_agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
        List<Compromisso> SelecionarCompromissosPassados(DateTime now);
    }
}
