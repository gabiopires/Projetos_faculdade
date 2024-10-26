using System;

class Program
{
    public static void Main(string[] args)
    {
        double[] oleosidade = new double[10];
        int N = int.Parse(Console.ReadLine());
        int index = 1;
        while (N != 0)
        {
            string[] oleo = Console.ReadLine().Split(' ');
            for (int i = 0; i < 10; i++)
            {
                oleosidade[i] = double.Parse(oleo[i]);
            }
            int[] senha = new int[10];
            double temp = 0;
            for (int j = 0; j < 10; j++)
            {
                temp = oleosidade[j];
                for (int g = 0; g < 10; g++)
                {
                    if (oleosidade[g] >= temp)
                    {
                        temp = oleosidade[g];
                        senha[j] = g;
                    }
                }
                oleosidade[senha[j]] = 0;
            }
            Console.Write("Caso " + index + ": ");
            for (int a = 0; a < N; a++)
            {
                if (a == N - 1)
                    Console.Write(senha[a] + "\n");
                else 
                    Console.Write(senha[a]);
            }
            index++;
            N = int.Parse(Console.ReadLine());
        }
    }
}