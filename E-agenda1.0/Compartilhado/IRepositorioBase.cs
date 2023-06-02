using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Inserir(TEntidade entidade);
        void Editar(int id, TEntidade registroAtualizado);
        void Excluir(TEntidade registroSelecionado);
        TEntidade SelecionarPorId(int id);
        List<TEntidade> SelecionarTodos();
        void AtualizarContador();
    }
}
