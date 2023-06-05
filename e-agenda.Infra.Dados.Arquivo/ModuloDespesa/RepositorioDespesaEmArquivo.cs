using e_agenda.Dominio.ModuloDespesa;
using e_agenda.Dominio.ModuloCategoria;


namespace e_agenda.Infra.Dados.Arquivo.ModuloDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioBaseEmArquivo<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override List<Despesa> BuscarRegistros()
        {
            return contextoBase.despesas;
        }

        public List<Despesa> SepararDespesasPorCategoria(Categoria categoria)
        {
            return BuscarRegistros().Where(i => i.categorias.Contains(categoria)).ToList();
        }
    }
}
