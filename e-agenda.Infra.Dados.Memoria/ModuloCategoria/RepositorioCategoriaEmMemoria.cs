using e_agenda.Dominio.ModuloCategoria;

namespace e_agenda.Infra.Dados.Memoria.ModuloCategoria
{
    public class RepositorioCategoriaEmMemoria : RepositorioBaseEmMemoria<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmMemoria(List<Categoria> categorias)
        {
            this.listaRegistros = categorias; 
        }

        public void AtualizarContador()
        {
            throw new NotImplementedException();
        }
    }
}
