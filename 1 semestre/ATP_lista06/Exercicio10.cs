using System;
using System.IO;
using System.Text;

public class Exercicio10
{
    public void Escrever()
    {
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            double numero = 1, maior = 0, menor = double.MaxValue, calmedia = 0, i = 0;
            while (numero != 0) //condição para continuar rodando 
            {
                Console.WriteLine($"Digite um numero: "); //recebe os valores do usuario
                numero = double.Parse(Console.ReadLine());

                if (numero == 0) //condição para parar de rodar
                    break;
                if (numero > maior) //testa se o numero digitado é maior, se for ele armazena
                    maior = numero;
                if (numero < menor) //testa se o numero digitado é menor, se for ele armazena
                    menor = numero;
                i++; //soma a quantidade
                calmedia += numero; //soma os numeros para fazer a media

                sw.WriteLine(numero); //grava no arquivo cada numero digitado
            }
            sw.Close(); //fecha o arquivo

            double media = calmedia / i; //calcula a media

            //imprime os resultados
            Console.WriteLine("Arquivo gravado!");
            Console.WriteLine("O maior valor digitado foi " + maior);
            Console.WriteLine("O menor valor digitado foi " + menor);
            Console.WriteLine("A media dos valores digitados foi de " + media);
        }
    }

    public void Rodar()
    {
        Escrever(); //chama os metodos

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
