using System;

class Program
{
    public static void Preencher(string[] N, int A, int B)
    {
        while (A != 0 && B != 0)
        {
            int[,] Ma = new int[A, B];
            for (int i = 0; i < A; i++)
            {
                string[] M = Console.ReadLine().Split(' ');
                for (int j = 0; j < B; j++)
                {
                    Ma[i, j] = int.Parse(M[j]);
                }
            }
            Calcular(Ma, A, B);
            Console.WriteLine(Calcular(Ma, A, B));
            //Console.WriteLine("Qual a quantidade de participantes e a quantidade de problemas?");
            N = Console.ReadLine().Split(' ');
            A = int.Parse(N[0]);
            B = int.Parse(N[1]);
        }
    }
    public static int Calcular(int[,] Ma, int A, int B)
    {
        int teste1 = 0, teste2 = 0, teste3 = 0, teste4 = 0, veriteste1 = 0, veriteste2 = 0, veriteste3 = 0, veriteste4 = 0;
        for (int i = 0; i < A; i++)
        {
            int somal = 0;
            for (int j = 0; j < B; j++)
            {
                somal += Ma[i, j];
            }
            if (somal != B)
                veriteste1++;
            if (somal != 0)
                veriteste4++;
        }
        for (int j = 0; j < B; j++)
        {
            int somac = 0;
            for (int i = 0; i < A; i++)
            {
                somac += Ma[i, j];
            }
            if (somac != 0)
                veriteste2++;
            if (somac != A)
                veriteste3++;
        }
        if (veriteste1 == A)
            teste1++;
        if (veriteste2 == B)
            teste2++;
        if (veriteste3 == B)
            teste3++;
        if (veriteste4 == A)
            teste4++;
        return teste1 + teste2 + teste3 + teste4;
    }

    public static void Main()
    {
        //Console.WriteLine("Qual a quantidade de participantes e a quantidade de problemas?");
        string[] N = Console.ReadLine().Split(' ');
        int A = int.Parse(N[0]);
        int B = int.Parse(N[1]);
        Preencher(N, A, B);
    }
}