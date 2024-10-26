using System;

public class Exercicio01
{
    public void Rodar()
    {
        Console.WriteLine("\n\n** Execicio 01 **\nInforme:");
        Console.WriteLine("A) Para fazer a media aritmética das notas."); 
        Console.WriteLine("P) Para fazer a media ponderada das notas.");
        var escolha = Console.ReadLine();

        switch (escolha.ToUpper()) //switch para executar a opção que o usuario escolheu, que chama o metodo para cada conta
        {
            case "A":
                MediaAritmetica(); 
                break;
            case "P":
                MediaPonderada();
                break;
            default:
                Console.WriteLine("Opcão inválida!");
                break;
        }
    }

    public void MediaAritmetica() //metodo para executar a operação de media com as notas que o usuario insere
    {
        double nota = 1, cont = 0, soma = 0, media = 0;

        Console.WriteLine("Digite a nota do aluno: ");
        nota = double.Parse(Console.ReadLine());

        while (nota != 0) //enquanto a nota não for zero, ele vai continuar recebendo valores para fazer a media
        {
            soma += nota;
            cont++;

            Console.WriteLine("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());
        }

        media = soma / cont;
        Console.WriteLine("\nA média das notas é " + media.ToString("F2") + "\n");
    }

    public void MediaPonderada() //metodo para executar a operação de media ponderada com as notas que o usuario insere
    {
        double nota = 1, soma = 0, media = 0;

        Console.WriteLine("Digite a nota do aluno: ");
        nota = double.Parse(Console.ReadLine());

        while (nota != 0) //enquanto a nota não for zero, ele vai continuar recebendo valores para fazer a media
        {
            soma += nota;

            Console.WriteLine("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());
        }

        media = soma / (5 + 3 + 2); 
        Console.WriteLine("\nA média ponderada das notas é " + media.ToString("F2") + "\n");

    }
}
