using System;

public class Exercicio05
{
    public void Rodar()
    {
        Console.WriteLine("\n\n** Exercicio 05 **\n");
        Console.WriteLine("O MDC dos numeros informado é " + MDC() + "\n"); //metodo que retorna o valor de mdc, puxando o retorno da função mdc()
    }

    static int MDC() //função que calcula o mdc de dois valores inseridos pelo usuario
    {
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());

        while (b != 0) //calcula o mdc enquanto b for diferente de 0
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
