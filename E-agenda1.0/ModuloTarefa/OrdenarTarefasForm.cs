using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda1._0.ModuloTarefa
{
    public partial class OrdenarTarefasForm : Form
    {

        public OrdenarTarefasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public bool ObterFiltro()
        {
            if (rdbPendentes.Checked == true)
            {
                return true;
            }
            else if (rdbPrioritarias.Checked == true)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
