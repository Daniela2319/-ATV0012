using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor
    {
        public string razaoSocial;
        public string cnpj;
        Endereco endereco;

        public Fornecedor() { }

        public Fornecedor(string razaoSocial, string cnpj, Endereco endereco)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.endereco = endereco;
        }

        public override string ToString()
        {
            return $" {razaoSocial}, CNPJ: {cnpj}\n {endereco}";
        }

    }
}
