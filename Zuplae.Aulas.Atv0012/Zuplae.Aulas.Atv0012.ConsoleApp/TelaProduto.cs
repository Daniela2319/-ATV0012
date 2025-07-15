using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;
using Zuplae.Aulas.Atv0012.Servics;

namespace Zuplae.Aulas.Atv0012.ConsoleApp
{
    internal class TelaProduto
    {
        private EnderecoService enderecoService = new EnderecoService();
        private FornecedorService fornecedorService = new FornecedorService();
        private ProdutoService produtoService = new ProdutoService();
       

        public void ExecutarMenu()
        {
            Console.Clear();
            Console.WriteLine("================ Modulo de Produto ======================");
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

            Console.WriteLine("Nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Preço do Produto: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Fornecedor (Razão Social): ");
            string razaoSocial = Console.ReadLine();
            Console.WriteLine("Fornecedor (CNPJ): ");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Fornecedor (Endereço - Rua): ");
            string logradouro = Console.ReadLine();
            Console.WriteLine("Fornecedor (Endereço - Número): ");
            string numero = Console.ReadLine();
            Console.WriteLine("Fornecedor (Endereço - Bairro): ");
            string bairro = Console.ReadLine();
            Console.WriteLine("Fornecedor (Endereço - Cidade): ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Fornecedor (Endereço - Estado): ");
            string estado = Console.ReadLine();
            Console.WriteLine("Fornecedor (Endereço - CEP): ");
            string cep = Console.ReadLine();

            var endereco = enderecoService.Cadastrar(logradouro, numero, bairro, cidade, estado, cep);

            var fornecedor = fornecedorService.Cadastrar(razaoSocial, cnpj, endereco);

            produtoService.Cadastrar(nomeProduto, preco, fornecedor);
          
        }
        private void Editar()
        {
            // Implementação do método de edição
        }
        private void Listar()
        {
            // Implementação do método de listagem
        }
        private void Deletar()
        {
            // Implementação do método de deleção
        }
        private void VoltarAoMenuPrincipal()
        {
            // Implementação para voltar ao menu principal
        }
    }
}
