using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloDespesa
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
    }
}
