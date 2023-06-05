using e_agenda.Dominio.ModuloCategoria;

namespace e_agenda.Dominio.ModuloDespesa
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;
        public decimal valor;
        public DateTime data;
        public TipoPagamentoEnum tipoPagamento;
        public List<Categoria> categorias;

        public Despesa(string descricao, decimal valor, DateTime data, TipoPagamentoEnum tipoPagamento, List<Categoria> categorias)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.tipoPagamento = tipoPagamento;
            this.categorias = categorias;
        }

        public Despesa()
        {
        }
        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.valor = registroAtualizado.valor;
            this.data = registroAtualizado.data;
            this.tipoPagamento = registroAtualizado.tipoPagamento;
            this.categorias = registroAtualizado.categorias;
        }
        public override string ToString()
        {
            return $"{descricao} | {valor} | {data.ToShortDateString()} | {tipoPagamento} | ";
        }
        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
