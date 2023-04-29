using System;
using System.Data;
using MySql.Data.MySqlClient;

using System;
using System.Data;
using MySql.Data.MySqlClient;
// instale o datapack se nescessario Install-Package MySql.Data

namespace AgilFornec
{
    public class GerenciadorDeBancoDeDados
    {
        private string connectionString = "Server=seu_servidor;Database=seu_banco_de_dados;Uid=seu_usuario;Pwd=sua_senha;"; // ATUALIZE AS INFORMAÇÕES DE ACORDO COM O SEU SERVIDOR
        public bool CadastrarProduto(string nome, string descricao, string marca, string gramatura, int quantidade_minima, int quantidade_maxima) // Método para cadastrar um produto
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO PRODUTO (nome, descricao, marca, gramatura, quantidade_minima, quantidade_maxima) VALUES (@nome, @descricao, @marca, @gramatura, @quantidade_minima, @quantidade_maxima)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@descricao", descricao);
                        command.Parameters.AddWithValue("@marca", marca);
                        command.Parameters.AddWithValue("@gramatura", gramatura);
                        command.Parameters.AddWithValue("@quantidade_minima", quantidade_minima);
                        command.Parameters.AddWithValue("@quantidade_maxima", quantidade_maxima);

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar produto: " + ex.Message);
                return false;
            }
        }
    }
}
