// See https://aka.ms/new-console-template for more information

using Zuplae.Aulas.Atv0012.Models;

Endereco endereco = new Endereco("Flores", "123", "Jardim", "São Paulo", "SP", "01234-567");



Fornecedor fornecedor = new Fornecedor("Fornecedor XYZ", "12.345.678/0001-90", endereco);



Produto produto = new Produto("Produto ABC", "ABC123", 99.99m, fornecedor);
Console.WriteLine(produto);