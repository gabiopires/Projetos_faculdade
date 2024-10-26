using System;

public class Exercicio08
{
    public void Preenchendo(int[,] M)
    {
        Console.WriteLine("\nElementos da Matriz:"); 
        Random r = new Random();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++) 
            {
                M[i, j] = r.Next(101); //sorteando os valores da matriz
                Console.Write(M[i, j] + "\t"); //e imprimindo cada um deles
            }
            Console.WriteLine();
        }

    }
    static void DiagonalP(int[,] M)
    {
        Console.WriteLine("\nElementos da diagonal princial: "); //mostrando os valores da diagonal principal
        for (int i = 0; i < 4; i++) //percorrendo todos os itens da matriz
            Console.Write(M[i,i] + "\t"); //mas mostrando somente aqueles que a posição da coluna é igual ao da linha
    }

    public int Soma(int[,] M) { //metodo para somar os itens abaixo da diagonal principal 

        int soma = 0;
        for (int i = 1; i < 4; i++) //percorrendo os itens da matriz, começando pela linha 1
            for (int j = 0; j < i; j++) //percorrendo os itens da matriz, onde o numero da posição da coluna seja sepre menor que o numero da posição da linha
            {
                soma += M[i, j]; //somando os itens que atendem os requisitos dos for
            }
        return soma;
    }

    public void Rodar()
    {
        int[,] M = new int[4,4]; //declarando a matriz M
        //chamando os metodos para execução 
        Preenchendo(M);
        DiagonalP(M);
        Soma(M);

        Console.WriteLine("\n\nA soma dos itens abaixo da diagonal principal é: " + Soma(M)); //mostrando o resultado da soma

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}