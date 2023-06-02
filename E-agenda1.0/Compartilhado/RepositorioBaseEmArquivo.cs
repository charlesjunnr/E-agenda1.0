﻿using E_agenda1._0.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_agenda1._0.Compartilhado
{
    
    public abstract class RepositorioBaseEmArquivo<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        private int contador { get; set; }
        private List<TEntidade> entidades { get; set; }

        protected ContextoDados contextoBase;
        public RepositorioBaseEmArquivo(ContextoDados contexto)
        {
            this.contextoBase = contexto;
            this.entidades = BuscarRegistros();
            
            AtualizarContador();
        }

        public abstract List<TEntidade> BuscarRegistros();
        public void AtualizarContador()
        {
            if (entidades.Count != 0)
                contador = entidades.Max(x => x.id);
        }
        public void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade entidadeSelecionada = SelecionarPorId(id);

            entidadeSelecionada.AtualizarInformacoes(registroAtualizado);

            contextoBase.SerializarEmJson();

        }
        public void Excluir(TEntidade entidadeSelecionada)
        {
            entidades.Remove(entidadeSelecionada);

            contextoBase.SerializarEmJson();
        }
        public void Inserir(TEntidade entidade)
        {
            contador++;

            entidade.id = contador;

            entidades.Add(entidade);

            contextoBase.SerializarEmJson();
        }
        public TEntidade SelecionarPorId(int id)
        {
            TEntidade entidade = entidades.FirstOrDefault(x => x.id == id);

            return entidade;
        }
        public List<TEntidade> SelecionarTodos()
        {
            return entidades;
        }
    }
}
