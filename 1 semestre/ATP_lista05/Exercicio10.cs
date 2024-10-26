using System;

public class Exercicio10
{
    public void Preenchendo(int[,] M)
    {
        Console.WriteLine("\nElementos da Matriz M:"); 

        Random r = new Random();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                M[i, j] = r.Next(201); //sorteando e escrevendo os itens da matriz M
                Console.Write(M[i, j] + "\t"); 
            }
            Console.WriteLine();
        }

    }

    public void Trocalinhadois(int[,] M) //metodo para trocar os itens da linha 2 pela 8
    {
        Console.WriteLine("\nA matriz após trocar a linha 2 pela 8 fica: ");
        int[] troca = new int[10]; //declarando um vetor para guardar temporariamente os valores da linha para troca

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            troca[i] = M[1, i]; //e adiciona os itens da linha na posição 1 no vetor temporario
        }

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            M[1, i] = M[7, i]; //substitui os itens da linha na posição 1 pelos itens da linha na posição 7
            M[7, i] = troca[i]; //e substitui os itens da linha na posição 7 pelos itens guardados no vetor temporario
        }

        for (int i = 0; i < 10; i++) //percorre os itens da nova matriz
        {
            for (int j = 0; j < 10; j++)
                Console.Write(M[i, j] + "\t"); //e imprime os itens da nova matriz
            Console.WriteLine();
        }
    }

    public void Trocacoluna(int[,] M) //metodo para trocar os itens da coluna 4 pela 10
    {
        Console.WriteLine("\nA matriz após trocar a coluna 4 pela 10 fica: ");

        int[] troca = new int[10]; //declarando um vetor para guardar temporariamente os valores da coluna para troca

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            troca[i] = M[i, 3]; //e adiciona os itens da coluna na posição 3 no vetor temporario
        }

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            M[i, 3] = M[i, 9]; //substitui os itens da coluna na posição 3 pelos itens da linha na posição 9
            M[i, 9] = troca[i]; //e substitui os itens da coluna na posição 9 pelos itens guardados no vetor temporario
        }

        for (int i = 0; i < 10; i++) //percorre os itens da nova matriz 
        {
            for (int j = 0; j < 10; j++) 
                Console.Write(M[i, j] + "\t"); //e escreve o os itens da nova matriz
            Console.WriteLine();
        }
    }

    public void Trocadiagonais(int[,] M) //metodo para trocar os itens da diagonal principal pela diagonal secundaria 
    {
        Console.WriteLine("\nA matriz após trocar a diagonal principal pela secundaria fica: ");

        int[] troca = new int[10]; //declarando um vetor para guardar temporariamente os valores da diagonal para troca

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            troca[i] = M[i, i]; //e adiciona os itens da diagonal principal no vetor temporario
        }
        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            M[i, i] = M[i, 10 - i - 1]; //substitui os itens da diagonal principal pelos itens da diagonal secundaria 
            M[i, 10 - i - 1] = troca[i]; //e substitui os itens da diagonal secundaria pelos itens guardados no vetor temporario
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++) //percorre os itens da nova matriz
                Console.Write(M[i, j] + "\t"); //e escreve os itens da nova matriz
            Console.WriteLine();
        }
    }

    public void Trocandolinhacoluna(int[,] M) //metodo para trocar os itens da linha 4 pelos itens da coluna 10
    {
        Console.WriteLine("\nA matriz após trocar a linha 4 pela coluna 10 fica: ");

        int[] troca = new int[10]; //declarando um vetor para guardar temporariamente os valores para troca

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            troca[i] = M[3, i]; //e adiciona os itens da linha na posição 3 no vetor temporario
        }

        for (int i = 0; i < 10; i++) //percorre os itens da matriz
        {
            M[3, i] = M[i, 9]; //substitui os itens da linha na posição 3 pelos itens da coluna na posição 9
            M[i, 9] = troca[i]; //e substitui os itens da coluna na posição 9 pelos itens guardados no vetor temporario
        }

        for (int i = 0; i < 10; i++) //percorre os itens da nova matriz
        {
            for (int j = 0; j < 10; j++)
                Console.Write(M[i, j] + "\t"); //e imprime os itens da nova matriz
            Console.WriteLine();
        }
    }


    public void Rodar()
    {
        int[,] M = new int[10, 10]; //declarando a matriz M
        //chamando os metodos para execução 
        Preenchendo(M);
        Trocalinhadois(M);
        Trocacoluna(M);
        Trocadiagonais(M);
        Trocandolinhacoluna(M);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}