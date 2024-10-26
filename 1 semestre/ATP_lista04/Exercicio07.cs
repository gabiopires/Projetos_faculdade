using System;

public class Exercicio07
{
    public void Rodar()
    {
        Console.WriteLine("\n\n** Execicio 07 **\nInforme:");
        Console.Write("Quantos alunos você deseja verificar o resultado final? ");
        int N = int.Parse(Console.ReadLine()); //vai definir quantos alunos vão ser

        double mediaaluno = 0;

        for (int i = 0; i < N; i++) //vai receber as medias dos alunos até alcançar a quantidade de alunos definido
        {
            Console.Write("Qual a média do aluno?: ");
            mediaaluno = double.Parse(Console.ReadLine());

            Media(mediaaluno); // Chama o método para exibir a nota final de cada aluno
    }

    static void Media(double mediaaluno) //define a nota final de cada aluno de acordo com sua nota
    {
        string final = "";

        if (mediaaluno <= 39)
        {
            final = "F";
        }
        else if ((mediaaluno > 39) && (mediaaluno <= 59))
        {
            final = "E";
        }
        else if ((mediaaluno > 60) && (mediaaluno <= 69))
        {
            final = "D";
        }
        else if ((mediaaluno > 70) && (mediaaluno <= 79))
        {
            final = "C";
        }
        else if ((mediaaluno > 80) && (mediaaluno <= 89))
        {
            final = "B";
        }
        else if (mediaaluno >= 90)
        {
            final = "A";
        }

        // Exibe a nota final do aluno
        Console.WriteLine("A nota final do aluno vai ser: " + final);
       }
    }
}
