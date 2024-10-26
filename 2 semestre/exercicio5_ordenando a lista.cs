using System;

class Program
{
    public static void Main()
    {
        //Console.WriteLine("Qual o número de crianças da lista?");
        int N = int.Parse(Console.ReadLine());
        string[] criancas = new string[N];
        string[] contador = new string[N];
        int comportadas = 0, naocomportadas = 0;
        for (int i = 0; i < N; i++)
        {
            string[] cont = Console.ReadLine().Split(' ');
            contador[i] = cont[0];
            criancas[i] = cont[1];
            if (contador[i] == "+")
                comportadas++;
            else if (contador[i] == "-")
                naocomportadas++;
        }
        InsertionSort(N, criancas);
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(criancas[i]);
        }
        Console.WriteLine("Se comportaram: {0} | Nao se comportaram: {1}", comportadas, naocomportadas);
    }

    public static void InsertionSort(int N, string[] criancas)
    {
        for (int i = 1; i < N; i++)
        {
            string temp = criancas[i];
            int j = i - 1;
            while (j >= 0 && criancas[j].CompareTo(temp) > 0)
            {
                criancas[j + 1] = criancas[j];
                j--;
            }
            criancas[j + 1] = temp;
        }
    }
}
