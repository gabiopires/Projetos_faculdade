using System;

public class Exercicio01
{
    public void Rodar()
    {
        int quantidade = 0;
        Console.WriteLine("Digite uma frase: "); //solicita o usuario uma frase
        string s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++) //percorre pelo vetor
        {
            if (s[i] == ' ') //se ele encontrar um caracter vazio
                quantidade++;  //ele vai somar em uma variavel 
        }

        Console.WriteLine("A frase contém {0} espaços em branco", quantidade); //mostrando a quantidade de vezes que caiu no if, e somou a variavel quantidade

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}