using E_agenda1._0.Compartilhado;
using E_agenda1._0.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_agenda1._0.ModuloCompromisso
{
    [Serializable]

    public class Compromisso : EntidadeBase<Compromisso>
    {
        
        public Contato contato;

        public string assunto;

        public DateTime data;

        public TimeSpan horaInicio;

        public TimeSpan horaTermino;

        public string localOnline;

        public string localPresencial;

        public TipoLocalEnum tipoLocal;

        public Compromisso()
        {
        }
        public Compromisso(string assunto, 
            DateTime data, 
            TimeSpan horaInicio, 
            TimeSpan horaTermino,
            Contato contato,
            string local, 
            TipoLocalEnum tipo)
        {
            this.assunto = assunto;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.contato = contato;
            this.tipoLocal = tipo;

            if(tipoLocal == TipoLocalEnum.Online)
                this.localOnline = local;
            else
                this.localPresencial = local;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.assunto = registroAtualizado.assunto;
            this.data = registroAtualizado.data;
            this.horaInicio = registroAtualizado.horaInicio;
            this.horaTermino = registroAtualizado.horaTermino;
            this.contato = registroAtualizado.contato;
            this.tipoLocal = registroAtualizado.tipoLocal;

            if (registroAtualizado.tipoLocal == TipoLocalEnum.Online)
                this.localOnline = registroAtualizado.localOnline;
            else
                this.localPresencial = registroAtualizado.localPresencial;
        }

        public override string ToString()
        {
            return "Id: " + id + "\t" + assunto + "\t Data: " + data.DayOfYear.ToString();
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
                erros.Add("O campo 'assunto' é obrigatório");

            return erros.ToArray();
        }
    }
}
