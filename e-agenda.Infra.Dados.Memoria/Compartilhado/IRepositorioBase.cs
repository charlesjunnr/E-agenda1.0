namespace e_agenda.Infra.Dados.Memoria.Compartilhado
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
