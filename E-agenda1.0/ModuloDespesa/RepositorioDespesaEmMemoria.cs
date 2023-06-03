using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloCategoria;
using E_agenda1._0.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloDespesa
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
