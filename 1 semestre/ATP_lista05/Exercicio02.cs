using System;

public class Exercicio02
{
    public void RecebendoNotas(double[] N)
    {
        for (int i = 0; i < N.Length; i++)
        {
            Console.WriteLine("Digite as notas dos alunos: "); 
            N[i] = double.Parse(Console.ReadLine()); //recebe as notas dos alunos
        }
    }

    public void Media(double[] N)
    {
        double soma = 0;
        for (int i = 0; i < N.Length; i++) //vai percorrer cada numero no vetor
        {
            soma += N[i]; //e somar todos os numeros
        }

        double mediaturma = soma / N.Length; //vai calcular a media, length pega o tamanho do vetor selecionado

        int acimamedia = 0;

        for (int i = 0; i < N.Length; i++) //vai percorrer cada numero no vetor
        {
            if (N[i] > mediaturma) //e vai conferir se cada numero está acima da media, se tiver ele vai armazenar mais 1
                acimamedia++;
        }

        Console.WriteLine("A media da turma é: " + mediaturma);
        Console.WriteLine(acimamedia + " alunos ficaram acima da media");
        
    } 

    public void Rodar()
    {
        Console.WriteLine();
        
        double[] N = new double[10]; //declarando o vetor N

        RecebendoNotas(N); //chamando os metodos para execução 
        Media(N);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente

    }
}