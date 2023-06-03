using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloDespesa
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;
        public decimal valor;
        public DateTime data;
        public TipoPagamentoEnum tipoPagamento;

        public Despesa(string descricao, decimal valor, DateTime data, TipoPagamentoEnum tipoPagamento)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.tipoPagamento = tipoPagamento;
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
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
