using E_agenda1._0.ModuloCompromisso;
using E_agenda1._0.ModuloContato;
using E_agenda1._0.ModuloTarefa;
using System.Text.Json.Serialization;
using System.Text.Json;
using E_agenda1._0.ModuloDespesa;

namespace E_agenda1._0.Compartilhado
{
    public class ContextoDados
    {
        public List<Contato> contatos;
        public List<Compromisso> compromissos;
        public List<Tarefa> tarefas;
        public List<Despesa> despesas;

        public ContextoDados()
        {
            this.contatos =  new List<Contato>();
            this.compromissos = new List<Compromisso>();
            this.tarefas = new List<Tarefa>();
            this.despesas = new List<Despesa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            DeserializarEmJson();
        }

        private const string NOME_ARQUIVO = "C:\\Users\\Charles Junior\\source\\repos\\E-agenda1.0\\E-agenda1.0\\Compartilhado\\dados.json";

        public void DeserializarEmJson()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            string registrosJson = File.ReadAllText(NOME_ARQUIVO);

            if (registrosJson.Length > 0)
            {
                ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, opcoes);
                
                this.contatos = ctx.contatos;
                this.compromissos = ctx.compromissos;
                this.tarefas = ctx.tarefas;

            }
        }
        public void SerializarEmJson()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            string registrosJson = JsonSerializer.Serialize(this, opcoes);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);

        }
    }
}
