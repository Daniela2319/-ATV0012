using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Servics
{
    public class ProdutoService
    {
        
        private static List<Produto> produtos = new List<Produto>();
        public void Cadastrar(string nomeProduto, decimal preco, Fornecedor fornecedor)
        {
            Produto produto = new Produto();
            produto.SetNomeProduto(nomeProduto);
            produto.SetPreco(preco);
            produto.AdicionarFornecedor(fornecedor);
            produtos.Add(produto);
        }
        public void Editar()
        {
            Console.WriteLine("Editar produto (funcionalidade não implementada)");
        }
        public void Listar()
        {
            Console.WriteLine("Listar produtos (funcionalidade não implementada)");
        }
        public void Deletar()
        {
            Console.WriteLine("Deletar produto (funcionalidade não implementada)");
        }

       
    }
}
