using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto
    {
        public string nomeProduto;
        public string codigoProduto;
        public decimal preco;
        List<Fornecedor> fornecedores = new List<Fornecedor>();

        public Produto() { }

        public Produto(string nomeProduto, string codigoProduto, decimal preco, Fornecedor fornecedores)
        {
            this.nomeProduto = nomeProduto;
            this.codigoProduto = codigoProduto;
            this.preco = preco;
            this.fornecedores.Add(fornecedores);
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
