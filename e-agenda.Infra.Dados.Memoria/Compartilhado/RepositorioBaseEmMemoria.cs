﻿namespace e_agenda.Dominio.Compartilhado
{
    public abstract class RepositorioBaseEmMemoria<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros;
        protected int contatorRegistros = 0;

        public virtual void Inserir(TEntidade registro)
        {
            contatorRegistros++;

            registro.id = contatorRegistros;

            listaRegistros.Add(registro);
        }

        public virtual void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Editar(TEntidade registroSelecionado, TEntidade registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        } 

        public virtual void Excluir(int id)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            if (registroSelecionado != null)
                listaRegistros.Remove(registroSelecionado);
        }

        public virtual void Excluir (TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public virtual TEntidade SelecionarPorId(int id)
        {
            if (listaRegistros.Exists(registro => registro.id == id))
                return listaRegistros.First(registro => registro.id == id);

            return null!;

        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return listaRegistros.OrderByDescending(x => x.id).ToList();
        }
    }
}
