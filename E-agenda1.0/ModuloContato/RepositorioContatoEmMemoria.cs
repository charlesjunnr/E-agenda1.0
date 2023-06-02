using E_agenda1._0.Compartilhado;


namespace E_agenda1._0.ModuloContato
{
    

    public class RepositorioContatoEmMemoria : RepositorioBaseEmMemoria<Contato>
    {
        public RepositorioContatoEmMemoria(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }

        
    }
}
