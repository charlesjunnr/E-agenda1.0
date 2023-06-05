using e_agenda.Dominio.ModuloContato;
using E_agenda1._0.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private IRepositorioContato repositorioContato;
        private ListaContatosControl listaContato;

        public ControladorContato(IRepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }
        public override string ToolTipInserir { get { return "Inserir novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contatos"; } }

        public override string ToolTipExcluir { get { return "Excluir Contatos"; } }

        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            int id = listaContato.ObterIdSelecionado();

            Contato contato = repositorioContato.SelecionarPorId(id);

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }


            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                contato = telaContato.Contato;

                repositorioContato.Editar(id, contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            int id = listaContato.ObterIdSelecionado();

            Contato contato = repositorioContato.SelecionarPorId(id);

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);
                
                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listaContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (listaContato == null)
                listaContato = new ListaContatosControl();

            CarregarContatos();

            return listaContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }
    }
}
