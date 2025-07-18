using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor : BaseModel
    {
        #region Atributos
        private string razaoSocial;
        private string cnpj;
        private Endereco endereco;
        #endregion

        #region Construtor
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
            if (string.IsNullOrWhiteSpace(razaoSocial))
            {
                throw new Exception("Razão social não pode ser vazia nem conter apenas espaços.");
            }
            return razaoSocial.ToUpper();
        }

        public void SetCnpj(string cnpj)
        {
            //if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14)
            //{
            //    throw new Exception("CNPJ inválido. Deve ter 14 caracteres.");
            //}
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

        #region Metodo
        public override string ToString()
        {
            return $" {GetRazaoSocial()}, CNPJ: {GetCnpj()}\n {GetEndereco()}";
        }
        #endregion

    }
}
