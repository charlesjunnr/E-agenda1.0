using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloCompromisso
{
    [Serializable]
    public partial class TelaFiltroCompromissosForm : Form
    {
        public TelaFiltroCompromissosForm()
        {
            InitializeComponent();
        }

        private void TelaFiltroCompromissosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        public StatusFiltroCompromissoEnum ObterStatus()
        {
            if (rdbVisualizarCompromissosPassados.Checked == true)
            {
                return StatusFiltroCompromissoEnum.Passados;

            }
            else if (rdbVisualizarCompromissosFuturos.Checked == true)
            {
                return StatusFiltroCompromissoEnum.Futuros;
            }
            else
            {
                return StatusFiltroCompromissoEnum.Todos;
            }
        }

        public DateTime ObterDataInicio()
        {
            return txtDataInicial.Value;
        }

        public DateTime ObterDataFinal()
        {
            return txtDataFinal.Value;
        }
    }
}
