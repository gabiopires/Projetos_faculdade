using System;
using System.IO;
using System.Text;

public class Exercicio05
{
    public void Escrever(string gravar)
    {
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            sw.WriteLine(gravar); //gravando a variavel armazenada em gravar
            Console.WriteLine(); //pulando uma linha
        }
        Console.WriteLine("Arquivo gravado!\n");
    }

    public string Ler()
    {
        Console.WriteLine("O que você quer gravar?: "); //solicita o usuario uma frase para gravar
        return Console.ReadLine().ToUpper(); //ToUpper para padronizar todas letras maiusculas
    }

    public void Linhas(String gravar)
    {
        int i = 0;
        StreamReader sr = new StreamReader("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt"); //abrindo o arquivo para leitura
        String line = sr.ReadLine(); //recebe o que esta escrito na linha
        while (line != null) //enquanto a linha não estiver vazia
        {
            Console.WriteLine(line); //ele vai escrever a frase escrita na linha
            line = sr.ReadLine(); //e substitui a variavel para escrever a proxima linha
            i++; //soma a variavel i para contrar a quantidade de linhas
        }
        sr.Close(); //fechando o arquivo
        Console.WriteLine("\nSeu arquivo possui {0} linhas", i); //mostrando a quantidade de linhas do arquivo
    }

    public void Rodar()
    {
        //chama os devidos metodos
        string gravar = Ler();
        Escrever(gravar);
        Linhas(gravar);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
