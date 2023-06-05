using e_agenda.Dominio.ModuloDespesa;
using e_agenda.Dominio.ModuloCategoria;

namespace e_agenda.Infra.Dados.Memoria.ModuloDespesa
{
    public class RepositorioDespesaEmMemoria : RepositorioBaseEmMemoria<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmMemoria(List<Despesa> despesas)
        {
            this.listaRegistros = despesas;
        }

        public List<Despesa> SepararDespesasPorCategoria(Categoria categoria)
        {
            return listaRegistros.Where(i => i.categorias.Contains(categoria)).ToList();
        }

        public void AtualizarContador()
        {
            throw new NotImplementedException();
        }
    }
}
