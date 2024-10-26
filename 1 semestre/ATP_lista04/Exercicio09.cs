using System;

public class Exercicio09
{
    public void Rodar() //metodo para exibir a media final dos alunos aprovados chamado a função media()
    {
        Console.WriteLine("\n\n** Execicio 09 **\nInforme:");
        Console.WriteLine("A media final do alunos aprovado é " + Media());
    }

    static double Media()
    {
        double nota = 0, notaaprovados = 0, mediaaluno = 0, cont = 0;

        Console.Write("Quantos alunos são? ");
        int N = int.Parse(Console.ReadLine()); //vai definir quantos alunos vão ser

        for (int i = 0; i < N; i++) //recebe as notas ate atingir a quantidade de alunos definida
        {
            Console.Write("Qual a nota do aluno?: ");
            nota = double.Parse(Console.ReadLine()); 
            if (nota > 6) //verifica se a nota do aluno é maior que 6 para guardar as notas aprovadas  
            {
                notaaprovados += nota;
                cont++;
            }
        }

        mediaaluno = notaaprovados / cont; //calcula a media dos alunos aprovados e retorna na função
        return mediaaluno;
    }
}