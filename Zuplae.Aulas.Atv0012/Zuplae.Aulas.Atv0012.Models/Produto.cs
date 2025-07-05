using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto
    {
        private string nomeProduto;
        private string codigoProduto;
        private decimal preco;
        private List<Fornecedor> fornecedores = new List<Fornecedor>();

        public Produto() { }

        public Produto(string nomeProduto, string codigoProduto, decimal preco, Fornecedor fornecedores)
        {
            this.nomeProduto = nomeProduto;
            this.codigoProduto = codigoProduto;
            this.preco = preco;
            this.fornecedores.Add(fornecedores);
        }

        public void SetNomeProduto(string nomeProduto)
        {
            this.nomeProduto = nomeProduto;
        }

        public string GetNomeProduto()
        {
            return nomeProduto;
        }

        public void SetCodigoProduto(string codigoProduto)
        {
            this.codigoProduto = codigoProduto;
        }

        public string GetCodigoProduto()
        {
            return codigoProduto;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
        }

        public List<Fornecedor> GetFornecedores()
        {
            return this.fornecedores;
        }




        public override string ToString()
        {
            string produto = $"Nome do Produto: {nomeProduto}\n codigo do Produto: {codigoProduto}\n preço: {preco}\n Fornecedores:";
            string fornecedoresInfo = "";

            foreach (var fornecedor in this.fornecedores)
            {
                fornecedoresInfo += $"{fornecedor}";
            }
            return produto + fornecedoresInfo;

        }
    }
}
