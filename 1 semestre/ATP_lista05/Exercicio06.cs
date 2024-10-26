using System;

public class Exercicio06
{
    public void RecebendoValores(int[] X)
    {
        int dia = 1;
        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine("Digite a temperatura do dia {0} de Outubro, entre 15° e 40°:", dia); //recebe os valores do usuario
            X[i] = int.Parse(Console.ReadLine());
            dia++; //soma do dia para alterar no ConsoleWrite
        }
    }

    public double Media(int[] X)
    {
        double soma = 0;

        foreach (int num in X) //percorre cada posição no vetor
        {
            soma += num; //e soma cada numero
        }

        double m = soma / X.Length; //calcula a media de acordo com a quantidade de posições no vetor

        return m;
    }

    public void Escrevendo(int[] X, double m)
    {
        int[] D = new int[31]; //declarando um vetor para a quantidade de dias abaixo da media
        int menortemp = 40, maiortemp = 15, i = 0, dia = 1; //variaveis necessarias para as comparações
        foreach (int num in X) //vai percorrer cada numero no vetor X
        {
            if (num < menortemp) //vai comparar se o numero da posição é menor que a menor temperatura já armazenada
            {
                menortemp = num; //se for, ele vai armazer a menor temperatura nova 
            }
            if (num > maiortemp) //vai comparar se o numero da posição é maior que a maior temperatura já armazenada
            {
                maiortemp = num; //se for, ele vai armazenar a nova maior temperatura 
            }
            if (num < m) //vai comparar se o numero da posição é menor que a media das temperaturas
            {
                D[i] = dia; //se for, ele vai armazenar no vetor D o numero do dia que a temperatura foi menor que a media
                i++; //ele também adiciona mais 1 no i, para adicionar as posições corretas
            }
            dia++; //adiciona mais 1 no dia, fora do if, para ele contar todos os 31 dias
        }

        Array.Resize(ref D, i); //reformula a quantidade de posições de D de acordo com a quantidade de dias que a temperatura foi menor que a media. Isso evita as posições zeradas

        Console.WriteLine("A menor temperatura foi: " + menortemp);
        Console.WriteLine("A maior temperatura foi: " + maiortemp);
        Console.WriteLine("A temperatura média do mês foi: " + m.ToString("F2"));
        Console.WriteLine("Os dias nos quais a temperatura foi inferior a temperatura média foram: ");
        foreach (int num in D)
        {
            Console.Write(num + ", "); //escreve cada posição de D para mostrar todos os dias que a temperatura foi menor que a media
        }
    }

    public void Rodar()
    {
        Console.WriteLine(); //adicionar um espaço depois do menu de opções 
        int[] X = new int[31]; //declarando o vetor X
        double m; //variavel da media

        //chamando os metodos para execução 
        RecebendoValores(X); 
        m = Media(X); // Receber o valor retornado pela função Media
        Escrevendo(X, m);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}