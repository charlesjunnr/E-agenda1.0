using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloDespesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloCategoria
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string descricaoCategoria;
        public Categoria(string descricaoCategoria)
        {
            this.descricaoCategoria = descricaoCategoria;
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            this.descricaoCategoria = registroAtualizado.descricaoCategoria;
        }

        public override string ToString()
        {
            return $"{descricaoCategoria}";
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
