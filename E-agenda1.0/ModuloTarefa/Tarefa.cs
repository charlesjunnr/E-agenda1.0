using E_agenda1._0.Compartilhado;

namespace E_agenda1._0.ModuloTarefa
{
    [Serializable]
    public class Tarefa : EntidadeBase<Tarefa>
    {
        
        public PrioridadeTarefaEnum prioridade;
        public string titulo;
        public DateTime dataInicial;
        public DateTime dataFinal;
        public decimal porcentagemConcluida;
        public int itensConcluidos { get; set; }
        public bool tarefaConcluida;
        public List<ItemTarefa> itensTarefa;

        public Tarefa()
        {
        }
        public Tarefa(PrioridadeTarefaEnum prioridade, 
            string titulo, 
            DateTime dataRegistro, 
            DateTime dataConclusao, 
            decimal porcentagemConcluida, 
            bool tarefaConcluida)
        {
            this.prioridade = prioridade;
            this.titulo = titulo;
            this.dataInicial = dataRegistro;
            this.dataFinal = dataConclusao;
            this.porcentagemConcluida = porcentagemConcluida;
            this.tarefaConcluida = tarefaConcluida;
            this.itensTarefa = new List<ItemTarefa>();
            this.itensConcluidos = 0;
            
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.prioridade = registroAtualizado.prioridade;
            this.titulo = registroAtualizado.titulo;
            this.dataInicial = registroAtualizado.dataInicial;
            this.dataFinal = registroAtualizado.dataFinal;
            this.porcentagemConcluida = registroAtualizado.porcentagemConcluida;
            this.tarefaConcluida = registroAtualizado.tarefaConcluida;
            this.itensTarefa = registroAtualizado.itensTarefa;
        }

        public void AdicionarItemNaLista(ItemTarefa item)
        {
            itensTarefa.Add(item);
        }

        public override string ToString()
        {
            return "Id: " + id + " , " + titulo + "Prioridade: " + prioridade;
        }

        public void IncrementarItemConcluido()
        {
            itensConcluidos++;

        }

        public void AtribuirPorcentagemTarefa()
        {
            int percentualTotal = this.itensTarefa.Count;

            if (percentualTotal == 0)
            {
                this.porcentagemConcluida = 0;
            }
            else
            {
                this.porcentagemConcluida = 100 * this.itensConcluidos / (percentualTotal);
            }

        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'título' é obrigatório");

            return erros.ToArray();
        }
    }
}
