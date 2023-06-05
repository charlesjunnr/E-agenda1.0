using e_agenda.Dominio.ModuloCategoria;

namespace e_agenda.Dominio.ModuloDespesa
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        public List<Despesa> SepararDespesasPorCategoria(Categoria categoria);
        
    }
}
