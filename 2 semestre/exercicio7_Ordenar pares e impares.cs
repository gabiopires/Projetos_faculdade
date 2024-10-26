using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual a quantidade de números no vetor?:");
        int N = int.Parse(Console.ReadLine());
        int[] numeros = new int[N];
        int[] pares = new int[N];
        int[] impares = new int[N];
        Console.WriteLine("Digite os números: ");
        for (int i = 0; i < N; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0)
                pares[i] = numeros[i];
            else if (numeros[i] % 2 != 0)
                impares[i] = numeros[i];
        }
        InsertionSort(pares, impares);
    }

    public static void InsertionSort(int[] pares, int[] impares)
    {
        for (int i = 1; i < pares.GetLength(0); i++)
        {
            int aux = pares[i];
            int j = i - 1;
            while (j >= 0 && pares[j] > aux)
            {
                pares[j + 1] = pares[j];
                j--;
            }
            pares[j + 1] = aux;
        }
        for (int i = 1; i < impares.GetLength(0); i++)
        {
            int aux = impares[i];
            int j = i - 1;
            while (j >= 0 && impares[j] < aux)
            {
                impares[j + 1] = impares[j];
                j--;
            }
            impares[j + 1] = aux;
        }
        PrintVetor(pares, impares);
    }

    public static void PrintVetor(int[] pares, int[] impares)
    {
      foreach(int num in pares){
        if (num != 0)
          Console.Write(num + " ");
      }
      foreach(int num in impares){
        if (num != 0)
          Console.Write(num + " ");
      }  
    }
}
