using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto : BaseModel
    {
        #region Atributos
        private string nomeProduto;
        private string codigoProduto;
        private decimal preco;
        private List<Fornecedor> fornecedores = new List<Fornecedor>();
        #endregion

        #region Contrutores
        public Produto()
        {
            GerarCodigo(); 
        }

        public Produto(string nomeProduto, decimal preco, Fornecedor fornecedores)
        {
            this.SetNomeProduto(nomeProduto);
            this.SetPreco(preco);
            this.AdicionarFornecedor(fornecedores);

            GerarCodigo(); 
        }
        #endregion

        #region NomeProduto, CodigoProduto, Preco, Fornecedores
        public void SetNomeProduto(string nomeProduto)
        {
            if (nomeProduto == "" || nomeProduto == null)
            {
                throw new Exception("O nome do produto não pode ser vazio ou nulo.");
            }
            this.nomeProduto = nomeProduto;
        }

        public string GetNomeProduto()
        {
            return nomeProduto.ToUpper();
        }

        public string GetCodigoProduto()
        {
            return codigoProduto;
        }

        public void SetPreco(decimal preco)
        {
            if (preco < 0 || preco > 100.00m) 
            {
                throw new Exception("O preço deve estar entre R$0,00 e R$100.00.");
            }
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

        #region Metodos
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

        private void GerarCodigo()
        {
            this.codigoProduto = "PV_" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }

        #endregion



    }
}
