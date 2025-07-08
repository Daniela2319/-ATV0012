// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
using Zuplae.Aulas.Atv0012.Models;



Console.WriteLine("-------------------------------------------- ATV0012 --------------------------------------------");
Console.WriteLine("----------------------------- CADASTRO DE PRODUTO E FORNECEDOR -----------------------------\n");
Endereco endereco = new Endereco();
endereco.SetLogradouro("Rua das Flores");
endereco.SetNumero("123");
endereco.SetBairro("Jardim das Rosas");
endereco.SetCidade("São Paulo");
endereco.SetEstado("SP");
endereco.SetCep("01234-567");

Fornecedor fornecedor = new Fornecedor();
fornecedor.SetRazaoSocial("Fornecedor A LTDA");
fornecedor.SetCnpj("12.345.678/0001-90");
fornecedor.SetEndereco(endereco);


Produto produto = new Produto();
produto.SetNomeProduto("Produto TV");
produto.SetCodigoProduto("TV123");
produto.SetPreco(1500.00m);
produto.AdicionarFornecedor(fornecedor);

List<Fornecedor> fornecedores = produto.GetFornecedores();
Console.WriteLine(produto);

Console.WriteLine("------------------------------------------- PRODUTOS -------------------------------------------- ");
string nome = produto.GetNomeProduto();
decimal preco = produto.GetPreco();

Console.WriteLine(nome);
Console.WriteLine(preco);





// Exemplo de uso com usuario
Console.WriteLine("Digite o nome do produto:");
string nomeProduto = Console.ReadLine();
Console.WriteLine("Digite o código do produto:");
string codigoProduto = Console.ReadLine();
Console.WriteLine("Digite o preço do produto:");
decimal precoProduto = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite a razão social do fornecedor:");
string razaoSocial = Console.ReadLine();
Console.WriteLine("Digite o CNPJ do fornecedor:");
string cnpjFornecedor = Console.ReadLine();
Console.WriteLine("Digite o logradouro do endereço:");
string logradouro = Console.ReadLine();
Console.WriteLine("Digite o número do endereço:");
string numero = Console.ReadLine();
Console.WriteLine("Digite o bairro do endereço:");
string bairro = Console.ReadLine();
Console.WriteLine("Digite a cidade do endereço:");
string cidade = Console.ReadLine();
Console.WriteLine("Digite o estado do endereço:");
string estado = Console.ReadLine();
Console.WriteLine("Digite o CEP do endereço:");
string cep = Console.ReadLine();

Endereco enderecoUsuario = new Endereco(logradouro, numero, bairro, cidade, estado, cep);
Fornecedor fornecedorUsuario = new Fornecedor(razaoSocial, cnpjFornecedor, enderecoUsuario);
Produto produtoUsuario = new Produto(nomeProduto, codigoProduto, precoProduto, fornecedorUsuario);
Console.WriteLine(produtoUsuario);



