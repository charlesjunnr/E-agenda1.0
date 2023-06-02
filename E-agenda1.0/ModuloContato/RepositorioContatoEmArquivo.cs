using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloContato
{
    

    public class RepositorioContatoEmArquivo : RepositorioBaseEmArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override List<Contato> BuscarRegistros()
        {
            return contextoBase.contatos;
        }


    }
}
