using E_agenda1._0.Compartilhado;
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
    public partial class ListaCompromissoControl : UserControl
    {
        public ListaCompromissoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridSomenteLeitura();

            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();


            foreach (Compromisso compromisso in compromissos)
            {
                grid.Rows.Add(compromisso.id, compromisso.assunto, compromisso.contato.nome, compromisso.data.ToShortDateString(), compromisso.horaInicio, compromisso.horaTermino, compromisso.tipoLocal, compromisso.localOnline);
            }

        }

        public int ObterIdSelecionado()
        {
            int id;
            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            }
            catch
            {
                id = -1;
            }

            return id;
        }
        public void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "assunto",
                    HeaderText = "Assunto"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "contato",
                    HeaderText = "Contato"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horainicio",
                    HeaderText = "Hora Início"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horatermino",
                    HeaderText = "Hora Término"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tipoLocal",
                    HeaderText = "Modalidade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "local",
                    HeaderText = "Endereço"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
