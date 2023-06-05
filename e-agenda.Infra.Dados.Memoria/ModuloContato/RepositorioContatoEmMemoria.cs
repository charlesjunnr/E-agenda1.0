using e_agenda.Dominio.ModuloContato;

namespace e_agenda.Infra.Dados.Memoria.ModuloContato
{
    

    public class RepositorioContatoEmMemoria : RepositorioBaseEmMemoria<Contato>
    {
        public RepositorioContatoEmMemoria(List<Contato> contatos)
        {
            this.listaRegistros = contatos;
        }

        
    }
}
