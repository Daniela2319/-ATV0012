using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Servics
{
    public class EnderecoService 
    {
        #region Propriedades
            private static List<Endereco> enderecos = new List<Endereco>();
        #endregion

        #region Cadastrar
            public int Cadastrar(string logradouro, string numero, string bairro, string cidade, string estado, string cep)
            {
                Endereco endereco = new Endereco();
                endereco.SetLogradouro(logradouro);
                endereco.SetNumero(numero);
                endereco.SetBairro(bairro);
                endereco.SetCidade(cidade);
                endereco.SetEstado(estado);
                endereco.SetCep(cep);
                enderecos.Add(endereco);

                int id = endereco.GetId();
                return id;
            }
        #endregion

        #region Editar
            public void Editar()
            {
            }
        #endregion

        #region Listar
            public void Listar()
            {  
            }
        #endregion

        #region ListarPorId
            public Endereco ListarPorId(int id) 
            {
               Endereco end = enderecos.Find(e => e.GetId() == id);
               return end;
            }
        #endregion

        #region Deletar
            public void Deletar(int id)
            {
            }
        #endregion
    }
}
