using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloContato
{
    [Serializable]

    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
            txtId.Text = "0";
        }


        public Contato Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome.ToString();
                txtTelefone.Text = value.telefone.ToString();
                txtCargo.Text = value.cargo.ToString();
                txtEmail.Text = value.email.ToString();
                txtEmpresa.Text = value.empresa.ToString();

            }
            get
            {
                return contato;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string email = txtEmail.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, empresa, telefone, email, cargo);

            string[] erros = contato.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;

                return;
            }

            if (txtId.Text != "0")
                contato.id = Convert.ToInt32(txtId.Text);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
