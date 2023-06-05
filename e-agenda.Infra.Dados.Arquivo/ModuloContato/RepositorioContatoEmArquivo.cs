using e_agenda.Dominio.ModuloContato;

namespace e_agenda.Infra.Dados.Arquivo.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioBaseEmArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override List<Contato> BuscarRegistros()
        {
            return contextoBase.contatos;
        }


    }
}
