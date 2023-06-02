using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;
        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);
        public abstract string[] Validar();
    }
}
