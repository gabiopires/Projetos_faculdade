using System;
using System.IO;
using System.Text;

public class Exercicio07
{
    public void Ler()
    {
        int N = 0, c = 0;
        string letras = "";
        Console.WriteLine("Quantas letras você quer gravar?: "); //solicita o usuario a quantidade de letras que serão gravadas
        N = int.Parse(Console.ReadLine());
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            for (int i = 0; i < N; i++) //vai repetir enquanto não alcançar o N informado
            {
                letras = Console.ReadLine(); //recebendo as letras
                sw.Write(letras); //escrevendo no arquivo cada uma
                if (letras == "A") //e testando as vogais para escrever na tela quantas são
                    c++;
                else if (letras == "E")
                    c++;
                else if (letras == "I")
                    c++;
                else if (letras == "O")
                    c++;
                else if (letras == "U")
                    c++;
            }
        }
        Console.WriteLine("Arquivo gravado!");
        Console.WriteLine("Você digitou {0} vogais", c);
    }

    public void Rodar()
    {
        Ler(); //chama o metodo

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
