using System;

public class Exercicio03
{
    public void Criptografar(string s)
    {
        string cripto = ""; 

        for (int i = 0; i < s.Length; i++) //percorre pelo vetor
        {
            char deslocado = (char)(s[i] + 3); //desloca a letra do alfabeto para tres casas pra frente

            if (deslocado >= 'X') //se a letra for igual ou maior que x, 
                deslocado = (char)(deslocado - 26); //ao inves de somar 3 pra frente, ele vai diminuir 26 para iniciar o alfabeto novamente

            cripto += deslocado; 
        }

        Console.WriteLine("Texto criptografado: " + cripto);
    }

    public void Rodar()
    {
        Console.WriteLine("Digite uma frase: "); //solicita o usuario uma frase
        string s = Console.ReadLine().ToUpper(); //ToUpper para padronizar todas letras maiusculas

        Criptografar(s); //chama o metodo para criptografar 

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
