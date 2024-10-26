using System;

public class Exercicio04
{
    public void Rodar()
    {
        Console.WriteLine("\n\n** Exercicio 04 **\n");
        double i = 1, lado1 = 0, lado2 = 0, lado3 = 0;
        while (lado1 >= 0)
        {
            Console.WriteLine("\nDigite um valor negativo para o primeiro lado para sair");
            Console.WriteLine("Triangulo " + i); // Título de cada conjunto, ex.: Triangulo 1, Triangulo 2, ...
            Console.Write("Digite o valor do primeiro lado: ");
            lado1 = double.Parse(Console.ReadLine());

            if (lado1 < 0) //testa se o valor do primeiro lado foi inserido 0 para poder parar o programa ou continuar rodando
                break;

            Console.Write("Digite o valor do segundo lado: ");
            lado2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado: ");
            lado3 = double.Parse(Console.ReadLine());

            if (!Triangulo(lado1, lado2, lado3)) //Chama a função para identificar se pode ser um triângulo, se retornar não verdadeiro vai parar o programa
            {
                Console.WriteLine("Esses lados informados não formam um triângulo."); 
            }
            else
            {
                Qualtriangulo(lado1, lado2, lado3); // Chama o método para identificar qual é o tipo de triângulo
            }
            i++;
        }
    }

    //Função que recebe três valores do Rodar() e verifica se podem formar um triângulo
    static bool Triangulo(double lado1, double lado2, double lado3)
    {
        return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
    }

    // Método que recebe três valores do Rodar() e identifica qual triângulo vai ser 
    static void Qualtriangulo(double lado1, double lado2, double lado3)
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Esse é um triângulo equilátero.");
        }
        else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
        {
            Console.WriteLine("Esse é um triângulo isósceles.");
        }
        else
        {
            Console.WriteLine("Esse é um triângulo escaleno.");
        }
    }
}
