using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloTarefa
{
    [Serializable]
    public class ItemTarefa
    {
        public string descricao;

        public bool estaConcluido;

        public ItemTarefa()
        {
        }
        public ItemTarefa(string descricao)
        {
            this.descricao = descricao;
            this.estaConcluido = false;
        }

        public void ConcluirItem()
        {
            estaConcluido = true;
        }

        public void TornarInconcluido()
        {
            estaConcluido = false;
        }
    }
}
