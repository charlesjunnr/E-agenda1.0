using E_agenda1._0.Compartilhado;

namespace E_agenda1._0.ModuloContato
{
    [Serializable]

    public class Contato : EntidadeBase<Contato>
    {
        
        public string nome;
        public string empresa;
        public string telefone;
        public string email;
        public string cargo;
        public Contato()
        {
        }
        public Contato(string nome, string empresa, string telefone, string email, string cargo)
        {
            this.nome = nome;
            this.empresa = empresa;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
        }

        public override void AtualizarInformacoes(Contato registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.empresa = registroAtualizado.empresa;
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
            this.cargo = registroAtualizado.cargo;
        }

        public override string ToString()
        {
            return "Id: " + id + " , " + nome + "Empresa: " + empresa;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            
            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (string.IsNullOrEmpty(email))
                erros.Add("O campo 'e-mail' é obrigatório");
            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatório");
            if (string.IsNullOrEmpty(cargo))
                erros.Add("O campo 'telefone' é obrigatório");



            return erros.ToArray();
        }
    }

}
