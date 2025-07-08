using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto
    {
        #region Atributos
        private string nomeProduto;
        private string codigoProduto;
        private decimal preco;
        private List<Fornecedor> fornecedores = new List<Fornecedor>();
        #endregion

        #region Metodos
        public Produto() { }

        public Produto(string nomeProduto, string codigoProduto, decimal preco, Fornecedor fornecedores)
        {
            this.SetNomeProduto (nomeProduto);
            this.SetCodigoProduto (codigoProduto);
            this.SetPreco(preco);
            this.AdicionarFornecedor (fornecedores);
        }
        #endregion

        #region NomeProduto, CodigoProduto, Preco, Fornecedores
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
        #endregion

        #region ToString
        public override string ToString()
        {
            string produto = $"Nome do Produto: {GetNomeProduto()}\n codigo do Produto: {GetCodigoProduto()}\n preço: {GetPreco()}\n Fornecedores:";
            string fornecedoresInfo = "";

            foreach (var fornecedor in this.fornecedores)
            {
                fornecedoresInfo += fornecedor;
            }
            return produto + fornecedoresInfo;

        }
        #endregion
    }
}
