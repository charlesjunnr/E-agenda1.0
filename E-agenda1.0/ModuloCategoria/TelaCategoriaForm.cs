using e_agenda.Dominio.ModuloCategoria;
using e_agenda.Infra.Dados.Memoria.ModuloCategoria;
using E_agenda1._0.ModuloDespesa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {
        private Categoria categoria;
        private RepositorioCategoriaEmMemoria repositorioCategoria;
        private ListaCategoriaControl listaCategoriaControl;

        public TelaCategoriaForm(List<Categoria> categoriaSelecionada)
        {
            InitializeComponent();
        }

        public Categoria Categoria
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricaoCategoria.ToString();
            }
            get
            {
                return categoria;
            }
        }

        public Categoria ObterCategoria()
        {
            int? id = Convert.ToInt32(txtId.Text);

            string descricao = txtDescricao.Text;

            categoria = new Categoria(descricao);

            return categoria;
        }

        public void ConfigurarTela(Categoria categoriaSelecionada)
        {
            txtId.Text = txtId.Text.ToString();
            txtDescricao.Text = txtDescricao.Text.ToString();
        }
    }
}
