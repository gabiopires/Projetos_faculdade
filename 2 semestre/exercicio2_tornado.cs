using System;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Qual o numero original de postes?");
        int N = int.Parse(Console.ReadLine());
        while (N != 0)
        {
            int[] postes = new int[N];
            //Console.WriteLine("Qual o estado de cada poste?");
            string[] original = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                postes[i] = int.Parse(original[i]);
            }            
            int construir = 0;
            if (postes[N - 1] == 0 && postes[0] == 0)
            {
                construir++;
                postes[0] = 1;  
            }
            for (int i = 0; i < N - 1; i++)
            {
                if (postes[i] == 0 && postes[i + 1] == 0)
                {
                    construir++;
                    postes[i + 1] = 1;  
                }
            }
            Console.WriteLine(construir);
            //Console.WriteLine("Qual o numero original de postes?");
            N = int.Parse(Console.ReadLine());
        }
    }
}