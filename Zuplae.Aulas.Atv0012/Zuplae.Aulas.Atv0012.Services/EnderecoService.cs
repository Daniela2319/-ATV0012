using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public class EnderecoService
    {   
        private static List<Endereco> enderecos = new List<Endereco>();
        private Endereco endereco = new Endereco();
        public void Cadastrar(string logradouro, string numero, string bairro, string cidade, string estado, string cep) 
        {
            endereco.SetLogradouro(logradouro);
            endereco.SetNumero(numero);
            endereco.SetBairro(bairro);
            endereco.SetCidade(cidade);
            endereco.SetEstado(estado);
            endereco.SetCep(cep);
            enderecos.Add(endereco);
        }
        public void Editar()
        {

        }
        public void Listar()
        {
            Console.Write("\tListando endereços cadastrados:\n");
            int contador = 1;
            foreach (var endereco in enderecos)
            {
                Console.WriteLine($"{contador++}. Logradouro: {endereco.GetLogradouro()} - " +
                    $"Número: {endereco.GetNumero()} - Bairro: {endereco.GetBairro()} - Cidade: {endereco.GetCidade()} - Estado: {endereco.GetEstado()} - CEP: {endereco.GetCep()}");
            }
        }
        public void Deletar()
        { }
    }
}
