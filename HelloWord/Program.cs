// See https://aka.ms/new-console-template for more information

// Sistema de cadastro de produtos

using ProdutoNamespace;

int id_produtos = 0;

string texto_menu = "Menu de opções\n" +
                    "1 - Cadastrar produto\n" +
                    "2 - Listar produtos\n" +
                    "3 - Sair";

int opcao;

do{    
    Console.WriteLine(texto_menu);

    Console.WriteLine("Digite a opção: ");
    opcao = int.Parse(Console.ReadLine());

    Console.Clear(); // Clears the console
    switch (opcao)
    {
        case 1:
            id_produtos ++;

            Console.WriteLine("Cadastrando produto...");

            int id = id_produtos;

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine()?.ToString() ?? string.Empty;

            Console.Write("Digite o preço do porudto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
                    
            Produto produto = new Produto(id, nome, preco, quantidade);
            break;
        case 2:
            Console.WriteLine("Listando produtos...");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcao != 3);


// Console.Write("Digite um número: ");

// int numero1 = int.Parse(Console.ReadLine());

// Console.Write("Digite outro número: ");

// int numero2 = int.Parse(Console.ReadLine());

// Console.WriteLine($"A soma dos números é: {numero1 + numero2}");

