using System;

public class Exercicio09
{
    public void Preenchendo(int[,] A, int[,] B)
    {
        Console.WriteLine("\nElementos da Matriz A:");

        Random r = new Random();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                A[i, j] = r.Next(101); //sorteando e escrevendo os itens da matriz A
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nElementos da Matriz B:");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                B[i, j] = r.Next(101); //sorteando e escrevendo os itens da matriz B
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }

    public int[,] Soma(int[,] A, int[,] B) //metodo para preencher uma matriz com a soma das matrizes A e B
    {
        int[,] S = new int[4,6]; //declarando a nova matriz

        Console.WriteLine("\nA soma das matrizes A e B resulta na matriz: ");

        for (int i = 0; i < 4; i++) //percorrendo todas as linhas da matriz
            for (int j = 0; j < 6; j++) //percorrendo todas as colunas da matriz dentro da linha i
            {
                S[i,j] = A[i, j] + B[i, j]; //cada posição é somada e armazenada em S
            }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(S[i, j] + "\t"); //for para mostrar a nova matriz com a soma
            }
            Console.WriteLine();
        }

        return S;
    }

    public int[,] Diferença(int[,] A, int[,] B) //metodo para preencher uma matriz com a subtração das matrizes A e B
    {
        int[,] D = new int[4, 6];

        Console.WriteLine("\nA diferença das matrizes A e B resulta na matriz: ");

        for (int i = 0; i < 4; i++) //percorrendo todas as linhas da matriz
            for (int j = 0; j < 6; j++) //percorrendo todas as colunas da matriz dentro da linha i
            {
                D[i, j] = A[i, j] - B[i, j]; //cada posição é subtraida e armazenada em D
            }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(D[i, j] + "\t"); //for para mostrar a nova matriz com a soma
            }
            Console.WriteLine();
        }

        return D;
    }


    public void Rodar()
    {
        int[,] A = new int[4, 6]; //declarando a matriz A
        int[,] B = new int[4, 6]; //declarando a matriz B
        //chamando os metodos para execução 
        Preenchendo(A, B);
        Soma(A, B);
        Diferença(A, B);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}