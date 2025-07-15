using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;
using Zuplae.Aulas.Atv0012.Servics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zuplae.Aulas.Atv0012.ConsoleApp
{
    internal class TelaFornecedor
    {
        private FornecedorService fornecedorService = new FornecedorService();
        private EnderecoService enderecoService = new EnderecoService();
        
        public void ExecutarMenu()
        {
            Console.Clear();
            Console.WriteLine("================ Modulo de Fornecedor ======================");
            Console.WriteLine("Escolha uma das opções do menu abaixo:");
            Console.WriteLine("\t1 -  Cadastrar");
            Console.WriteLine("\t2 -  Editar");
            Console.WriteLine("\t3 -  Listar");
            Console.WriteLine("\t4 -  Deletar");
            Console.WriteLine("\t5 -  Voltar ao menu principal");
            Console.Write("Digite o número da opção desejada: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Cadastrar();
                    break;
                case 2:
                    Editar();
                    break;
                case 3:
                    Listar();
                    break;
                case 4:
                    Deletar();
                    break;
                case 5:
                    VoltarAoMenuPrincipal();
                    return;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    ExecutarMenu();
                    break;
            }
        }
        private void Cadastrar()
        {
            Console.WriteLine("Digite Razão Social:");
            string razaoSocial = Console.ReadLine();

            Console.WriteLine("Digite CNPJ:");
            string cnpj = Console.ReadLine();


            Console.WriteLine("Digite Logradouro:");
            string logradouro = Console.ReadLine();

            Console.WriteLine("Digite Número:");
            string numero = Console.ReadLine();

            Console.WriteLine("Digite Bairro:");
            string bairro = Console.ReadLine();

            Console.WriteLine("Digite Cidade:");
            string cidade = Console.ReadLine();

            Console.WriteLine("Digite Estado:");
            string estado = Console.ReadLine();

            Console.WriteLine("Digite CEP:");
            string cep = Console.ReadLine();

            var endereco = enderecoService.Cadastrar(logradouro, numero, bairro, cidade, estado, cep);

            fornecedorService.Cadastrar(razaoSocial, cnpj, endereco);

        }
        private void Editar()
        {
            // Implementar lógica de edição
        }
        private void Listar()
        {
            // Implementar lógica de listagem
        }
        private void Deletar()
        {
            // Implementar lógica de deleção
        }
        private void VoltarAoMenuPrincipal()
        {
            // Implementar lógica para voltar ao menu principal
        }
    }
}
