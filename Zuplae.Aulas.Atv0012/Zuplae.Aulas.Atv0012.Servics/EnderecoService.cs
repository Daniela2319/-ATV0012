using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Servics
{
    public class EnderecoService
    {
        
        private static List<Endereco> enderecos = new List<Endereco>();
        public Endereco Cadastrar(string logradouro, string numero, string bairro, string cidade, string estado, string cep)
        {
            Endereco endereco = new Endereco();
            endereco.SetLogradouro(logradouro);
            endereco.SetNumero(numero);
            endereco.SetBairro(bairro);
            endereco.SetCidade(cidade);
            endereco.SetEstado(estado);
            endereco.SetCep(cep);
            enderecos.Add(endereco);
            return endereco;
        }
        public void Editar()
        {
        }
        public void Listar()
        {
        }
        public void Deletar()
        {
        }
    }
}
