using System;

class Program
{
    public static void Main()
    {
        //Console.WriteLine("Qual o número de países participantes?");
        int N = int.Parse(Console.ReadLine());
        int[,] matriz = new int[N, 3];
        string[] paises = new string[N];
        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            paises[i] = entrada[0];
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = int.Parse(entrada[j + 1]);
            }
        }
        InsertionSort(paises, matriz);
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{paises[i]} {matriz[i, 0]} {matriz[i, 1]} {matriz[i, 2]}");
        }
    }
    public static void InsertionSort(string[] paises, int[,] matriz)
    {
        for (int i = 1; i < matriz.GetLength(0); i++)
        {
            int[] temp = { matriz[i, 0], matriz[i, 1], matriz[i, 2] };
            string paisTemp = paises[i];
            int j = i - 1;
            while (j >= 0 && (matriz[j, 0] < temp[0] ||
                (matriz[j, 0] == temp[0] && matriz[j, 1] < temp[1]) ||
                (matriz[j, 0] == temp[0] && matriz[j, 1] == temp[1] && matriz[j, 2] < temp[2]) ||
                (matriz[j, 0] == temp[0] && matriz[j, 1] == temp[1] && matriz[j, 2] == temp[2] && paises[j].CompareTo(paisTemp) > 0)))
            {
                for (int k = 0; k < 3; k++)
                {
                    matriz[j + 1, k] = matriz[j, k];
                }
                paises[j + 1] = paises[j];
                j--;
            }
            for (int k = 0; k < 3; k++)
            {
                matriz[j + 1, k] = temp[k];
            }
            paises[j + 1] = paisTemp;
        }
    }
}
