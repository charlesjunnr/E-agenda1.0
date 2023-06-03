using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloDespesa
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        public List<Despesa> SepararDespesasPorCategoria(Categoria categoria);
        
    }
}
