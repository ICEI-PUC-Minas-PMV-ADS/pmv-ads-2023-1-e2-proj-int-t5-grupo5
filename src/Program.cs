using System;
using AgilFornec; // Importe o namespace, se necessário

namespace AgilFornec
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBancoDeDados gerenciador = new GerenciadorDeBancoDeDados();

            bool sucesso = gerenciador.CadastrarProduto("Produto Exemplo", "Descrição do produto", "Marca", "500g", 10, 100);

            if (sucesso)
            {
                Console.WriteLine("Produto cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar produto.");
            }
        }
    }
}