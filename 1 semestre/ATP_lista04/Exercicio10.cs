using System;

public class Exercicio10
{
    public void Rodar()
    {
        Console.WriteLine("\n\n** Execicio 10 **\nInforme:");
        Console.Write("Quantos nadadores você deseja verificar a categoria? "); //recebe a quantidade de nadadores que vão ser
        int N = int.Parse(Console.ReadLine());

        double idade = 0;

        for (int i = 0; i < N; i++) //recebe a idade de cada nadador e retorna a cateria puxando o metodo categoria() até alcançar a quantidade informada
        {
            Console.Write("Qual a idade do nadador?: ");
            idade = double.Parse(Console.ReadLine());

            Categoria(idade);
        }

        static void Categoria(double idade) //separa por cada categoria de acordo com a idade do nadador informada
        {
            string final = "";

            if ((idade > 5) && (idade <= 7))
            {
                final = "F";
            }
            else if ((idade > 8) && (idade <= 10))
            {
                final = "E";
            }
            else if ((idade > 11) && (idade <= 13))
            {
                final = "D";
            }
            else if ((idade > 14) && (idade <= 15))
            {
                final = "C";
            }
            else if ((idade > 16) && (idade <= 17))
            {
                final = "B";
            }
            else if (idade >= 18)
            {
                final = "A";
            }
            else
                Console.WriteLine("Categoria não classificada");

            // Exibe a categoria do nadador 
            Console.WriteLine("A categoria do nadador vai ser: " + final + "\n");
        }
    }
}
