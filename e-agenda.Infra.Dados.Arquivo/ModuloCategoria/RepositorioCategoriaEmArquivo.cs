using e_agenda.Dominio.ModuloCategoria;

namespace e_agenda.Infra.Dados.Arquivo.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioBaseEmArquivo<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override List<Categoria> BuscarRegistros()
        {
            return contextoBase.categorias;
        }
    }
}
