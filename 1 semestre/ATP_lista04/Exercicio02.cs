using System;
public class Exercicio02
{
    public void Rodar()
    {
        Console.WriteLine("\nA media salarial da população é de R$ " + Media() + "\n"); //imprime a media chamado a função media()
    }

    static double Media() //função que recebe o valor do salario para retornar a media salarial 
    {
        double salario = 0, filhos = 0, totalsalario = 0, contsala = 0; 

        Console.WriteLine("\n\n** Execicio 02 **\nInforme:");
        Console.WriteLine("Quantas pessoas você deseja incluir? "); //primeiro seleciona a quantidade de pessoas que são incluidas
        int cont = int.Parse(Console.ReadLine());

        while (contsala < cont) //depois recebe o valor do salario até atingir a quantidade de pessoas definidas
        {
            Console.WriteLine("Qual o seu salario atual? ");
            salario = double.Parse(Console.ReadLine());

            totalsalario += salario;
            contsala++;

            Console.WriteLine("Quantos filhos você tem? ");
            filhos = double.Parse(Console.ReadLine());
        }
        return (totalsalario / contsala); //retorna a media

    }
}