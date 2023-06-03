using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloDespesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        IRepositorioCategoria repositorioCategoria;
        TelaCategoriaForm telaCategoriaForm;
        ListaCategoriaControl listaCategoriaControl;
        IRepositorioDespesa repositorioDespesa;
        TelaVisualizacaoDespesasCategoriaForm telaVisualizacaoForm;
        
        public ControladorCategoria(IRepositorioCategoria repositorioCategoria, IRepositorioDespesa repositorioDespesa)
        {
            this.repositorioCategoria = repositorioCategoria;
            this.repositorioDespesa = repositorioDespesa;
        }

        public override string ToolTipInserir => "Inserir Categoria";

        public override string ToolTipEditar => "Editar Categoria";

        public override string ToolTipExcluir => "Excluir Categoria";

        public override void Editar()
        {
            int id = listaCategoriaControl.ObterIdSelecionado();

            Categoria categoriaSelecionada = repositorioCategoria.SelecionarPorId(id);

            if (categoriaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                   "Edição de Categorias",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm(categorias);

            telaCategoria.ConfigurarTela(categoriaSelecionada);

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Editar(categoria.id, categoria);

                CarregarCategorias();
            }
        }

        public override void Excluir()
        {
            int id = listaCategoriaControl.ObterIdSelecionado();

            Categoria categoria = repositorioCategoria.SelecionarPorId(id);

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                    "Exclusão de Categorias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a categoria {categoria.descricaoCategoria}?", "Exclusão de Categorias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Excluir(categoria);

                CarregarCategorias();
            }
        }

        public override void Inserir()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm(categorias);

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Inserir(categoria);

                CarregarCategorias();
            }
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            listaCategoriaControl.AtualizarRegistros(categorias);
        }

        public override UserControl ObterListagem()
        {
            if (listaCategoriaControl == null)
                listaCategoriaControl = new ListaCategoriaControl();

            CarregarCategorias();

            return listaCategoriaControl;
        }

        

        public override void VisualizarDespesasCategorias()
        {
            int id = listaCategoriaControl.ObterIdSelecionado();

            Categoria categoria = repositorioCategoria.SelecionarPorId(id);
            
            List<Despesa> despesas = repositorioDespesa.SepararDespesasPorCategoria(categoria);
                                  
            TelaVisualizacaoDespesasCategoriaForm telaVisualizacao = new TelaVisualizacaoDespesasCategoriaForm(despesas, categoria);

            telaVisualizacao.ShowDialog();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";
        }
    }
}
