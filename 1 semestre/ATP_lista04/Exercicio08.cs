using System;

public class Exercicio08
{
    public void Rodar()  //metodo para receber o valor de S e chamar a função para exibir o resultado do calculo
    {
        Console.WriteLine("\n\n** Execicio 08 **\nInforme:");
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        double resultado = CalcularS(N);
        
        Console.WriteLine("O valor de S é: " + resultado.ToString("F2") + "\n");
    }

    // Função para calcular S
    static double CalcularS(int N)
    {
        double S = 0;
        int numerador = 2;
        int denominador = 4;

        for (int i = 1; i <= N; i++)
        {
            S += (double)numerador / denominador;
            numerador = i * i + 1;
            denominador = i + 3;
        }

        return S;
    }
}