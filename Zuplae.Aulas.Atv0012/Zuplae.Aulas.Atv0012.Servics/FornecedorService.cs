using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Servics
{
    public class FornecedorService 
    {
        private static List<Fornecedor> fornecedores = new List<Fornecedor>();

        public Fornecedor Cadastrar(string razaoSocial, string cnpj, Endereco endereco) 
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.SetRazaoSocial(razaoSocial);
            fornecedor.SetCnpj(cnpj);
            fornecedor.SetEndereco(endereco);
            fornecedores.Add(fornecedor);
            return fornecedor;
        }
        public void Editar()
        {
            // Implementar lógica de edição
        }
        public void Listar()
        {
            // Implementar lógica de listagem
        }
        public void Deletar()
        {
            // Implementar lógica de deleção
        }
    }
}
