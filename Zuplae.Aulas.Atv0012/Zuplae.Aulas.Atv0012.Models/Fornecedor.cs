using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor
    {
        private string razaoSocial;
        private string cnpj;
        private Endereco endereco;

        public Fornecedor() { }

        public Fornecedor(string razaoSocial, string cnpj, Endereco endereco)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.endereco = endereco;
        }

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

        public override string ToString()
        {
            return $" {razaoSocial}, CNPJ: {cnpj}\n {endereco}";
        }

    }
}
