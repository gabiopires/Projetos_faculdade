using System;
using System.IO;
using System.Text;

public class Exercicio04
{
    public void Escrever(string gravar)
    {
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            for (int x = 0; x < gravar.Length; x++) //percorrendo o vetor
            {
                sw.Write(gravar[x]); //gravando cada letra separada
            }
        }
        Console.WriteLine("Arquivo gravado!");
    }

    public string Ler()
    {
        Console.WriteLine("O que você quer gravar?: "); //solicita o usuario uma frase para gravar
        return Console.ReadLine().ToUpper(); //ToUpper para padronizar todas letras maiusculas
    }

    public void Contar(string gravar)
    {
        int c = 0;
        for (int x = 0; x < gravar.Length; x++) //percorre pelo vetor
        {
            if (gravar[x] == 'A') //confere se a letra iterada é um A
                c++; //se for ele vai somar mais 1 na variavel
        }
        Console.WriteLine("Você digitou {0} vogais A", c); //para mostrar quantas vezes o usuario digitou a vogal a 
    }

    public void Rodar()
    {
        //chama os devidos metodos
        string gravar = Ler();
        Escrever(gravar);
        Contar(gravar);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
