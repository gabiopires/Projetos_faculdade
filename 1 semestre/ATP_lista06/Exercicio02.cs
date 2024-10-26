using System;

public class Exercicio02
{

    public void Rodar()
    {
        int quantidade = 0;
        Console.WriteLine("Digite uma frase: "); //solicita o usuario uma frase
        string s = Console.ReadLine().ToUpper(); //ToUpper para padronizar todas letras maiusculas

        for (int i = 0; i < s.Length; i++) //percorre pelo vetor
        {
            //cada if vai comparar a vogal e vai somar caso seja a esperada
            if (s[i] == 'A')
                quantidade++;
            if (s[i] == 'E')
                quantidade++;
            if (s[i] == 'I')
                quantidade++;
            if (s[i] == 'O')
                quantidade++;
            if (s[i] == 'U')
                quantidade++;
        }

        Console.WriteLine("A frase contém {0} vogais", quantidade); //mostrando a quantidade de vezes que caiu no if, e somou a variavel quantidade

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}