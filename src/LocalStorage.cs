using System;
using System.Widons.Forms;
using System.IO;

namespace ProductLis
{
    public partial class Form1: Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void AddProductButtom_Click(object sender, EventArgs e)
        {
           // Abre o formulário de cadastro de produtos
        }

        private void SaveProductButtom_Click(object sender, EventArgs e)
        {
            // Salva o produto selecionado
        }

        private void RemoveProductButtom_Click(object sender, EventArgs e)
        {
            // Remove o produto selecionado
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carrega os produtos do Local Storage
        }
        
        private string GenerateProductHtml(Product product)
        {
            // Gera o HTML para exibir o produto
            // retorna uma string no contendo o HTML
        }

    }
}