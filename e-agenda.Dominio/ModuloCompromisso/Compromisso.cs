using e_agenda.Dominio.Compartilhado;
using e_agenda.Dominio.ModuloContato;

namespace e_agenda.Dominio.ModuloCompromisso
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
            tipoLocal = tipo;

            if (tipoLocal == TipoLocalEnum.Online)
                localOnline = local;
            else
                localPresencial = local;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.id = registroAtualizado.id;
            assunto = registroAtualizado.assunto;
            data = registroAtualizado.data;
            horaInicio = registroAtualizado.horaInicio;
            horaTermino = registroAtualizado.horaTermino;
            contato = registroAtualizado.contato;
            tipoLocal = registroAtualizado.tipoLocal;

            if (registroAtualizado.tipoLocal == TipoLocalEnum.Online)
                localOnline = registroAtualizado.localOnline;
            else
                localPresencial = registroAtualizado.localPresencial;
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
