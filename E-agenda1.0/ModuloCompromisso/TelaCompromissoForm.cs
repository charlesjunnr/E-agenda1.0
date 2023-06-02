using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloCompromisso
{
    [Serializable]

    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        private RepositorioContatoEmMemoria repositorioContato;
        private ListaContatosControl listaContato;

        List<Contato> listaContatos = new List<Contato>();

        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            foreach (Contato contato in contatos)
            {
                cboxContatos.Items.Add(contato);
            }

        }

        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto.ToString();
                txtData.Text = value.data.ToShortDateString();
                txtHoraInicio.Text = value.horaInicio.ToString();
                txtHoraTermino.Text = value.horaTermino.ToString();
                cboxContatos.Text = value.contato.ToString();

            }
            get
            {
                return compromisso;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        internal Compromisso ObterCompromisso()
        {

            int? id = Convert.ToInt32(txtId.Text);

            string assunto = txtAssunto.Text;

            DateTime data = txtData.Value;

            TimeSpan horarioInicio = txtHoraInicio.Value.TimeOfDay;
            TimeSpan horarioTermino = txtHoraTermino.Value.TimeOfDay;

            TipoLocalEnum tipo = rdbPresencial.Checked ? TipoLocalEnum.Presencial : TipoLocalEnum.Online;

            string local;

            Contato contato = (Contato)cboxContatos.SelectedItem;

            if (rdbPresencial.Checked)
                local = txtLocalOnline.Text;
            else
                local = txtLocalPresencial.Text;

            compromisso = new Compromisso(assunto, data, horarioInicio, horarioTermino, contato, local, tipo);

            compromisso.id = id.ToString() == "" ? 0 : Convert.ToInt32(id); //verifica se o valor que recebe é null e atribui valor de 0

            return compromisso;
        }

        internal void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            txtId.Text = compromissoSelecionado.id.ToString();
            txtAssunto.Text = compromissoSelecionado.assunto;
            txtData.Value = compromissoSelecionado.data;
            txtHoraInicio.Value = compromissoSelecionado.data + compromissoSelecionado.horaInicio;
            txtHoraTermino.Value = compromissoSelecionado.data + compromissoSelecionado.horaTermino;
            cboxContatos.SelectedItem = compromissoSelecionado.contato;

            if (compromissoSelecionado.tipoLocal == TipoLocalEnum.Presencial)
            {
                rdbPresencial.Checked = true;
                txtLocalPresencial.Text = compromisso.localPresencial;
            }
            else
            {
                rdbOnline.Checked = true;
                txtLocalOnline.Text = compromissoSelecionado.localOnline;
            }


        }
    }
}
