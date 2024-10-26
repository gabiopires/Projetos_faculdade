using System;

public class Exercicio03
{
    public void Rodar()
    {
        Console.WriteLine("\n\n** Execicio 03 **\nInforme:");
        Console.Write("Quantos conjuntos de 3 valores você deseja inserir? ");
        int N = int.Parse(Console.ReadLine()); //vai definir quantos conjuntos vão ser exibidos

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"\nConjunto {i + 1}:"); //vai ser o titulo de cada conjunto, ex.: conjunto 1, conjunto 2, ...
            Console.Write("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int c = int.Parse(Console.ReadLine());

            ExibirEmOrdemCrescente(a, b, c); // Chama o método para organizar e exibir os valores em ordem crescente
        }
    }

    // Método que recebe três inteiros do Rodar(), organiza e exibe em ordem crescente
    static void ExibirEmOrdemCrescente(int a, int b, int c)
    {
        int temp;

        // Garante que 'a' seja o menor valor
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        if (a > c)
        {
            temp = a;
            a = c;
            c = temp;
        }

        // Agora, 'a' é o menor valor, resta ordenar 'b' e 'c'
        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        // Exibe os valores ordenados
        Console.WriteLine("Valores em ordem crescente: {0}, {1}, {2}, \n", a, b, c);
    }
}
