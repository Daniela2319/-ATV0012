using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor
    {
        #region Atributos
        private string razaoSocial;
        private string cnpj;
        private Endereco endereco;
        #endregion

        #region Metodos
        public Fornecedor() { }

        public Fornecedor(string razaoSocial, string cnpj, Endereco endereco)
        {
            this.SetRazaoSocial (razaoSocial);
            this.SetCnpj (cnpj);
            this.SetEndereco (endereco);
        }
        #endregion

        #region RazaoSocial, Cnpj, Endereco
        public void SetRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }

        public string GetRazaoSocial()
        {
            return razaoSocial;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public Endereco GetEndereco()
        {
            return endereco;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $" {GetRazaoSocial()}, CNPJ: {GetCnpj()}\n {GetEndereco()}";
        }
        #endregion

    }
}
