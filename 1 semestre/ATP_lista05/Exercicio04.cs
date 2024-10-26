using System;

public class Exercicio04
{
    public void Preenchendo(int[] N, int[] X)
    {

        Console.WriteLine("\nPreencha valores para o vetor N: ");

        for (int i = 0; i < N.Length; i++)
        {
            N[i] = int.Parse(Console.ReadLine()); //solicita os valores do vetor N

        }

        Console.WriteLine("\nPreencha valores para o vetor X: ");

        for (int i = 0; i < X.Length; i++) //solicita os valores do vetor X
        {
            X[i] = int.Parse(Console.ReadLine());

        }
    }

    public void trocandovalores(int[] N, int[] X, int[] Z)
    {
        for (int i = 0; i < N.Length; i++) //vai percorrer cada numero no vetor
        {
            Z[i * 2] = N[i];      //vai armazer nas posições pares o numero do vetor N
            Z[i * 2 + 1] = X[i];  //vai armazenar nas posições impares o numero do vetor X
        }
    }

    public void MostrandoValores(int[] Z)
    {
        Console.WriteLine("\nVetor Z intercalado:");
        foreach (int numZ in Z)
        {
            Console.Write(numZ + " "); //escrevendo o vetor alternado
        }
        Console.WriteLine();
    }

    public void Rodar()
    {
        int[] N = new int[10]; //declarando os vetores

        int[] X = new int[10];

        int[] Z = new int[20];

        Preenchendo(N, X);    //chamando os metodos para execução 
        trocandovalores(N, X, Z);
        MostrandoValores(Z);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}