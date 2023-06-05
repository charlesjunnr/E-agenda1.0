namespace e_agenda.Dominio.ModuloCategoria
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string descricaoCategoria;
        public Categoria(string descricaoCategoria)
        {
            this.descricaoCategoria = descricaoCategoria;
        }
        public Categoria()
        {
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            this.descricaoCategoria = registroAtualizado.descricaoCategoria;
        }

        public override string ToString()
        {
            return $"{descricaoCategoria}";
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
