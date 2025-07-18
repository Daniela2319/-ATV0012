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
        #region Atributos
            private static List<Fornecedor> fornecedores = new List<Fornecedor>();
        #endregion

        #region Cadastrar
            public int Cadastrar(string razaoSocial, string cnpj, Endereco endereco) 
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.SetRazaoSocial(razaoSocial);
                fornecedor.SetCnpj(cnpj);
                fornecedor.SetEndereco(endereco);
                fornecedores.Add(fornecedor);
                fornecedor.GetId();

                int id = fornecedor.GetId();
                return id;
            }
        #endregion

        #region Editar
            public void Editar()
            {
                // Implementar lógica de edição
            }
        #endregion

        #region Listar
            public void Listar()
            {
                // Implementar lógica de listagem
            }
        #endregion

        #region ListarPorId
            public Fornecedor ListarPorId(int id)
            {
                Fornecedor fornecedor = fornecedores.Find(f => f.GetId() == id);
                return fornecedor;
            }
        #endregion

        #region Deletar
            public void Deletar()
            {
                // Implementar lógica de deleção
            }
        #endregion
    }
}
