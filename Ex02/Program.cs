using System;
using System.Collections.Generic;

namespace Ex02
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            Console.WriteLine("Escolha o tipo de produto:");
            Console.WriteLine("1 - Alimentação");
            Console.WriteLine("2 - Higiene");

            if (int.TryParse(Console.ReadLine(), out int tipo))
            {
                try
                {
                    Produto produto = ProductFactory.CriadorProdutos(tipo);

                    Console.Write("Descrição do produto: ");
                    produto.Descricao = Console.ReadLine();

                    if (produto is Alimentacao alimentacao)
                    {
                        Console.Write("Quantidade de Kcalorias: ");
                        if (int.TryParse(Console.ReadLine(), out int kcal))
                        {
                            alimentacao.kCalorias = kcal;
                        }
                    }
                    else if (produto is Higiene higiene)
                    {
                        Console.Write("PH do produto: ");
                        if (int.TryParse(Console.ReadLine(), out int ph))
                        {
                            higiene.Ph = ph;
                        }
                    }

                    produtos.Add(produto);
                    Console.WriteLine("Produto adicionado com sucesso!\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}\n");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida, tente novamente.");
            }
        }

        static void ListarProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto criado.\n");
                return;
            }

            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto.ToString());
                if (produto is Higiene higiene)
                {
                    Console.WriteLine($"PH em texto: {higiene.PHporExtenso()}");
                }
                Console.WriteLine("--------------------");
            }
        }
    }
}
