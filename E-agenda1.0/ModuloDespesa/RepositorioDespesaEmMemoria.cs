using E_agenda1._0.Compartilhado;
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

        public void AtualizarContador()
        {
            throw new NotImplementedException();
        }
    }
}
