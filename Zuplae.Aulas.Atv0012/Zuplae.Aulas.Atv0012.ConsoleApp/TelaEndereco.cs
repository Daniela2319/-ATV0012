using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Servics;

namespace Zuplae.Aulas.Atv0012.ConsoleApp
{
    internal class TelaEndereco
    {
        private EnderecoService enderecoService = new EnderecoService();
        public void ExecutarMenu()
        {
            Console.Clear();
            Console.WriteLine("================ Modulo de Endereço ======================");
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
        public void Cadastrar()
        {
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
            enderecoService.Cadastrar(logradouro, numero, bairro, cidade, estado, cep);
        }
        private void Editar()
        {
          
        }
        private void Listar() 
        { }

        private void Deletar() 
        { }

        private void VoltarAoMenuPrincipal()
        {
            Console.WriteLine("Voltando ao menu principal...");
            Console.ReadKey();
            ExecutarMenu();
        }
    }
}
