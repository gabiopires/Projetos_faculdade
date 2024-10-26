using System;

public class Exercicio07
{
    public void Preenchendo(int[,] M)
    {
        Console.WriteLine("\nElementos da Matriz:");
        Random r = new Random();
        for (int i = 0; i < 5; i++) //sorteando os valores da matriz
        {
            for (int j = 0; j < 5; j++)
            {
                M[i, j] = r.Next(101);
                Console.Write(M[i, j] + "\t"); //e escrevendo na tela
            }
            Console.WriteLine();
        }

    }

    public int Linhaquatro(int[,] M) //metodo para somar a linha 4
    {
        int tamanho = M.GetLength(0), somalquatro = 0; 
        for (int i = 0; i < tamanho; i++) //percorrendo todos os numeros da matriz
                somalquatro += M[3, i]; //mas somando somente os numeros que estão na linha posição 3
        return somalquatro;
    }

    public int Colunadois(int[,] M) //metodo para somar a coluna 2
    {
        int tamanho = M.GetLength(0), somacdois = 0;
        for (int i = 0; i < tamanho; i++) //percorrendo todos os numeros da matriz
            somacdois += M[i, 1]; //mas somando somente os numeros que estão na coluna posição 1
        return somacdois;
    }

    public int DiagonalP(int[,] M) //metodo para somar a diagonal principal 
    {
        int tamanho = M.GetLength(0), somacdois = 0;
        for (int i = 0; i < tamanho; i++) //percorrendo todos os numeros da matriz
            somacdois += M[i, i]; //mas somando somente os numeros que estão nas posições que a coluna e a linha são iguais
        return somacdois;
    }

    public int DiagonalS(int[,] M) //metodo para somar a diagonal secundaria
    {
        int tamanho = M.GetLength(0), somacdois = 0;
        for (int i = 0; i < tamanho; i++) //percorrendo todos os numeros da matriz
            somacdois += M[i, (tamanho - i - 1)]; //mas somando somente os numeros que estão nas posições onde a linha soma de acordo com o for e a coluna vai diminuindo
        return somacdois;
    }

    public int Somamatriz(int[,] M) //metodo para somar a matriz
    {
        int tamanho = M.GetLength(0), soma = 0;
        for (int i = 1; i < tamanho; i++) //percorrendo todos os numeros da matriz
            for (int j = 0; j < tamanho; j++)
            {
                soma += M[i, j]; //somando todos os numeros da matriz, posição de acordo com o i e o j nos for
            }
        return soma;
    }


    public void Rodar()
    {
        int[,] M = new int[5,5]; //declarando a matriz M
        //chamando os metodos para execução 
        Preenchendo(M);
        Linhaquatro(M);
        Colunadois(M);
        DiagonalP(M);
        DiagonalS(M);
        Somamatriz(M);

        //escrevendo os resultados
        Console.WriteLine("\nA soma da linha 4 é: " +  Linhaquatro(M));
        Console.WriteLine("A soma da coluna 2 é: " + Colunadois(M));
        Console.WriteLine("A soma da diagonal principal é: " + DiagonalP(M));
        Console.WriteLine("A soma da diagonal secundária é: " + DiagonalS(M));
        Console.WriteLine("A soma de todos os elementos da matriz é: " + Somamatriz(M));

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}