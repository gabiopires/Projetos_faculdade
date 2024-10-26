using System;
using System.IO;
using System.Text;

public class Program
{   //declarando as variaveis, matrizes e vetores necessarios
    const int NUM_PRODUTOS = 4;
    const int DIAS_MES = 30;
    static string[] produtos = new string[NUM_PRODUTOS];
    static int[] estoque = new int[NUM_PRODUTOS];
    static int[,] vendas = new int[DIAS_MES, NUM_PRODUTOS];

    static void Main(string[] args)
    {
        int opcao;

        do //switch para chamar o metodo de acordo com a opção desejada do usuario
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1 – Importar arquivo de produtos");
            Console.WriteLine("2 – Registrar venda");
            Console.WriteLine("3 – Relatório de vendas");
            Console.WriteLine("4 – Relatório de estoque");
            Console.WriteLine("5 – Criar arquivo de vendas");
            Console.WriteLine("6 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    RegistrarProdutos();
                    ImportarArquivoDeProdutos();
                    break;
                case 2:
                    RegistrarVenda();
                    break;
                case 3:
                    RelatorioDeVendas();
                    break;
                case 4:
                    RelatorioDeEstoque();
                    break;
                case 5:
                    CriarArquivoDeVendas();
                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.\n");
                    break;
            }
        } while (opcao != 6);
    }

    static void RegistrarProdutos()
    {
        using (StreamWriter sw = new StreamWriter("produtos.txt", true, Encoding.ASCII)) //abrindo o arquivo parar gravação
        {
            for (int i = 0; i < NUM_PRODUTOS; i++) //repetição para gravar produtos 
            {
                Console.WriteLine("\n**Registro de Produtos**\n");
                Console.WriteLine("Digite o nome do produto {0}: ", i);
                string produto = Console.ReadLine();

                Console.WriteLine("Digite a quantidade em estoque para o produto {0}: ", produto);
                int quantidadeEstoque = int.Parse(Console.ReadLine());

                sw.WriteLine("{0},{1}", produto, quantidadeEstoque); //gravando os produtos no arquivo
            }
        }
    }

    static void ImportarArquivoDeProdutos()
    {
        using (StreamReader sr = new StreamReader("produtos.txt")) //abrindo o arquivo para leitura
            {
                for (int i = 0; i < NUM_PRODUTOS; i++) //repetição para percorrer todas as linhas com os produtos 
                {
                    string linha = sr.ReadLine();
                    if (linha != null) //se nao for uma linha vazia, ele vai pegar as informações e gravar nos vetores 
                    {
                        string[] dados = linha.Split(','); //armazena no vetor os dados da linha, separando com base nas vírgulas encontradas
                        produtos[i] = dados[0]; //atribui os dados coletados da linha até a primeira virgula para o vetor produtos
                        estoque[i] = int.Parse(dados[1]); //atribui os dados coletados após a primeira virgula para o estoque, convertendo para int
                    }
                }
            }
        Console.WriteLine("\nArquivo de produtos importado com sucesso.");

        Console.WriteLine("\nPressione Enter para ir para o Menu...\n");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { } // Espera até que a tecla Enter seja pressionada novamente
    }

    static void RegistrarVenda()
    {
        Console.Write("\nDigite o número do produto (0-3): "); 
        int numProduto = int.Parse(Console.ReadLine());

        if (numProduto < 0 || numProduto >= NUM_PRODUTOS) //testa se o numero digitado é valido
        {
            Console.WriteLine("\nNúmero do produto inválido.");
            return;
        }

        Console.Write("\nDigite o dia do mês (1-30): ");
        int dia = int.Parse(Console.ReadLine());
        Console.Write("\nDigite a quantidade vendida: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade > estoque[numProduto]) //testa se a quantidade a ser retirada do estoque é maior do que o produto possui no estoque
        {
            Console.WriteLine("\nQuantidade de venda excede o estoque disponível.");
            return;
        }

        vendas[dia - 1, numProduto] += quantidade; //armazena a quantidade da venda, na posição do dia informado (menos 1 pra pegar a posição correta) e o numero do produto informado
        estoque[numProduto] -= quantidade; //diminui o estoque do produto de acordo com o numero do produto digitado
        Console.WriteLine("\nVenda registrada com sucesso.");

        Console.WriteLine("\nPressione Enter para ir para o Menu...\n");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { } // Espera até que a tecla Enter seja pressionada novamente
    }

    static void RelatorioDeVendas()
    {
        Console.WriteLine("\n**Relatório de vendas diárias**\n");
        for (int dia = 0; dia < DIAS_MES; dia++) //repetição até concluir os dias de um mês (1 a 30)
        {
            Console.Write($"Dia {dia + 1}: "); 
            for (int prod = 0; prod < NUM_PRODUTOS; prod++) //repetição parar mostrar todos os produtos por dia
            {
                Console.Write($"{produtos[prod]}: {vendas[dia, prod]} "); //mostra o dia com a quantidade vendida no dia
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPressione Enter para ir para o Menu...\n");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { } // Espera até que a tecla Enter seja pressionada novamente
    }

    static void RelatorioDeEstoque()
    {
        Console.WriteLine("\n**Relatório de Estoque**\n");
        for (int i = 0; i < NUM_PRODUTOS; i++) //repetição para repetir a quantidade de produtos
        {
            Console.WriteLine($"{produtos[i]}: {estoque[i]}"); //mostra o produto e quantidade de estoque atual
        }

        Console.WriteLine("\nPressione Enter para ir para o Menu...\n");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { } // Espera até que a tecla Enter seja pressionada novamente
    }

    static void CriarArquivoDeVendas()
    {
        using (StreamWriter sr = new StreamWriter("vendas.txt"))
        {
            for (int i = 0; i < NUM_PRODUTOS; i++) //repitção para gravar todos os produtos
            {
                int totalVendas = 0; 
                for (int dia = 0; dia < DIAS_MES; dia++) //repetição para somar a venda de cada dia por produto
                {
                    totalVendas += vendas[dia, i]; 
                }
                sr.Write($"{produtos[i]}: {totalVendas}"); //grava no arquivo o total de vendas no mês de cada produto
            }
        }
        Console.WriteLine("\nArquivo de vendas criado com sucesso.");

        Console.WriteLine("\nPressione Enter para ir para o Menu...\n");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { } // Espera até que a tecla Enter seja pressionada novamente
    }
}
