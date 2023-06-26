using e_agenda.Dominio.ModuloContato;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.DataClassification;

namespace eagenda.Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato novoContato = ObterContato();

            Contato contato = SelecionarPorId(9);

            Inserir(novoContato);

            Editar(contato);

            Excluir(contato.id);

            List<Contato> contatos = SelecionarTodos();
        }

        private static List<Contato> SelecionarTodos()
        {
            //obter a conexão com o banco

            SqlConnection conexaoComBanco = new SqlConnection();

            conexaoComBanco.ConnectionString = "Data Source=(LocalDb)\\MSSqlLocalDb;" +
                                                "Initial Catalog=eagendaDb;" +
                                                "Integrated Security=True;" +
                                                "Pooling=False";
            conexaoComBanco.Open();
            //cria um comando 
            string sqlSelecionarTodos = @"SELECT	
	                                    [ID], 
	                                    [NOME], 
	                                    [TELEFONE]
                                    FROM 
	                                    [TBContato]";
            SqlCommand comandoDeVisualizacao = new SqlCommand();

            comandoDeVisualizacao.Connection = conexaoComBanco;

            comandoDeVisualizacao.CommandText = sqlSelecionarTodos;
            
            SqlDataReader leitorContatos = comandoDeVisualizacao.ExecuteReader();


            List<Contato> contatos = new List<Contato>();

            while (leitorContatos.Read())
            {
                int idContato = Convert.ToInt32(leitorContatos["ID"]);
                string nome = Convert.ToString(leitorContatos["NOME"])!;
                string telefone = Convert.ToString(leitorContatos["TELEFONE"])!;

                Contato contato = new Contato(nome, "JBS", telefone, "contato@gmail.com", "Funcionário");
                contatos.Add(contato);
            }

            return contatos;
        }   

        private static void Excluir(int id)
        {
            //obter a conexão com o banco

            SqlConnection conexaoComBanco = new SqlConnection();

            conexaoComBanco.ConnectionString = "Data Source=(LocalDb)\\MSSqlLocalDb;" +
                                                "Initial Catalog=eagendaDb;" +
                                                "Integrated Security=True;" +
                                                "Pooling=False";

            conexaoComBanco.Open();

            //cria um comando 
            string sqlExcluir = @"DELETE FROM [TBContato]
	                                WHERE 
                                    [ID] = @ID";

            SqlCommand comandoDeExclusao = new SqlCommand();

            comandoDeExclusao.Connection = conexaoComBanco;

            comandoDeExclusao.CommandText = sqlExcluir;

            //adiciona os parâmetros

            comandoDeExclusao.Parameters.AddWithValue("ID", id);

            //executo o comando

            int linhasAfetadas = comandoDeExclusao.ExecuteNonQuery();

            //fecho a conexão com o banco

            conexaoComBanco.Close();
        }

        private static void Editar(Contato contato)
        {
            //obter a conexão com o banco

            SqlConnection conexaoComBanco = new SqlConnection();

            conexaoComBanco.ConnectionString = "Data Source=(LocalDb)\\MSSqlLocalDb;" +
                                                "Initial Catalog=eagendaDb;" +
                                                "Integrated Security=True;" +
                                                "Pooling=False";

            conexaoComBanco.Open();

            //cria um comando 
            string sqlEditar = @"UPDATE	[TBContato]
	                            SET 
		                            [NOME] = @N,
		                            [TELEFONE] =  @T
	                            WHERE 
		                            [ID] = @ID";

            SqlCommand comandoDeEdicao = new SqlCommand();

            comandoDeEdicao.Connection = conexaoComBanco;

            comandoDeEdicao.CommandText = sqlEditar;

            //adiciona os parâmetros

            comandoDeEdicao.Parameters.AddWithValue("N", contato.nome);

            comandoDeEdicao.Parameters.AddWithValue("T", contato.telefone);

            comandoDeEdicao.Parameters.AddWithValue("ID", contato.id);

            //executo o comando

            int linhasAfetadas = comandoDeEdicao.ExecuteNonQuery();

            //fecho a conexão com o banco

            conexaoComBanco.Close();
        }

        private static Contato SelecionarPorId(int idPesquisado)
        {
            SqlConnection conexaoComBanco = new SqlConnection();

            conexaoComBanco.ConnectionString = "Data Source=(LocalDb)\\MSSqlLocalDb;" +
                                                "Initial Catalog=eagendaDb;" +
                                                "Integrated Security=True;" +
                                                "Pooling=False";
            conexaoComBanco.Open();

            //cria um comando 
            string sqlSelecionarPorId = @"SELECT 
	                                        [ID],
	                                        [NOME],
	                                        [TELEFONE]
                                        FROM 
	                                        [TBContato]
                                        WHERE 
	                                        [ID] = @ID";

            SqlCommand comandoDeSelecao = new SqlCommand();

            comandoDeSelecao.Connection = conexaoComBanco;

            comandoDeSelecao.CommandText = sqlSelecionarPorId;

            //adiciona os parâmetros

            comandoDeSelecao.Parameters.AddWithValue("ID", idPesquisado);

            //executo o comando

            SqlDataReader leitorContatos = comandoDeSelecao.ExecuteReader();


            Contato contato = null!;

            if (leitorContatos.Read())
            {
                int idContato = Convert.ToInt32(leitorContatos["ID"]);
                string nome = Convert.ToString(leitorContatos["NOME"])!;
                string telefone = Convert.ToString(leitorContatos["TELEFONE"])!;

                contato = new Contato(nome, "JBS", telefone, "contato@gmail.com", "Funcionário");
            }
            return contato;

        }

        private static void Inserir(Contato novoContato)
        {
            //obter a conexão com o banco

            SqlConnection conexaoComBanco = new SqlConnection();

            conexaoComBanco.ConnectionString = "Data Source=(LocalDb)\\MSSqlLocalDb;" +
                                                "Initial Catalog=eagendaDb;" +
                                                "Integrated Security=True;" +
                                                "Pooling=False";

            conexaoComBanco.Open();

            //cria um comando 
            string sqlInsert = @"INSERT INTO [TBContato]
                                (
                                    [NOME],
                                    [TELEFONE]
                                )
                                VALUES (
                                    @NOME,
                                    @TELEFONE
                                );";

            sqlInsert += "SELECT SCOPE_IDENTITY ();";

            SqlCommand comandoDeInsercao = new SqlCommand();

            comandoDeInsercao.Connection = conexaoComBanco;

            comandoDeInsercao.CommandText = sqlInsert;

            //adiciona os parâmetros

            comandoDeInsercao.Parameters.AddWithValue("NOME", novoContato.nome);

            comandoDeInsercao.Parameters.AddWithValue("TELEFONE", novoContato.telefone);

            //executo o comando

            object id = comandoDeInsercao.ExecuteScalar();

            novoContato.id = Convert.ToInt32(id);

            //fecho a conexão com o banco

            conexaoComBanco.Close();
        }

        private static Contato ObterContato()
        {
            Console.WriteLine("Digite o nome: ");

            string nome = Console.ReadLine()!;

            Console.WriteLine("Digite o e-mail");

            string email = Console.ReadLine()!;

            Console.WriteLine("Digite a empresa: ");

            string empresa = Console.ReadLine()!;

            Console.WriteLine("Digite o cargo: ");

            string cargo = Console.ReadLine()!;

            Console.WriteLine("Digite o telefone: ");

            string telefone = Console.ReadLine()!;

            return new Contato(nome, empresa, telefone, email, cargo);


        }
    }
}