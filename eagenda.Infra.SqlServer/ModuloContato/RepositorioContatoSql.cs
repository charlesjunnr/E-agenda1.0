using e_agenda.Dominio.ModuloContato;
using Microsoft.Data.SqlClient;

namespace eagenda.Infra.SqlServer.ModuloContato
{
    public class RepositorioContatoSql : IRepositorioContato
    {
        public void AtualizarContador()
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, Contato registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Contato registroSelecionado)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Contato entidade)
        {
            throw new NotImplementedException();
        }

        public Contato SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contato> SelecionarTodos(int id)
        {

            //abrir uma conexão

            SqlConnection conexaoComBanco = new SqlConnection();

            conexaoComBanco.ConnectionString = "Data Source=(LocalDb)\\MSSqlLocalDb;Initial Catalog=eagendaDb;Integrated Security=True;Pooling=False";

            conexaoComBanco.Open();

            //criar um comando

            string sqlSelecionarTodos = @"SELECT 
	                                        [ID],
	                                        [NOME],
	                                        [TELEFONE],
                                            [EMPRESA],
                                            [EMAIL],
                                            [CARGO]
                                        FROM 
	                                        [TBContato]";
            SqlCommand comandoDeVisualizacao = new SqlCommand();

            comandoDeVisualizacao.Connection = conexaoComBanco;

            comandoDeVisualizacao.CommandText = sqlSelecionarTodos;

            SqlDataReader leitorContatos = comandoDeVisualizacao.ExecuteReader();

            List<Contato> contatos = new List<Contato>();

            while(leitorContatos.Read())
            {
                int idContato = Convert.ToInt32(leitorContatos["ID"]);

                string nome = Convert.ToString(leitorContatos["NOME"])!;

                string telefone = Convert.ToString(leitorContatos["TELEFONE"])!;

                string empresa = Convert.ToString(leitorContatos["EMPRESA"])!;

                string email = Convert.ToString(leitorContatos["EMAIL"])!;

                string cargo = Convert.ToString(leitorContatos["CARGO"])!;

            }
            return contatos;

        }
    }
}
