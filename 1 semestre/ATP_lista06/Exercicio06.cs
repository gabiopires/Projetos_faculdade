using System;
using System.IO;
using System.Text;

public class Exercicio06
{
    public void Escrever(int soma)
    {
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            sw.WriteLine(soma); //gravando a variavel armazenada em soma
        }
        Console.WriteLine("Arquivo gravado!\n");
    }

    public int Divisor(int numero)
    {
        int soma = 0;
        Console.WriteLine("Seus Divisores são: "); 
        for (int i = 1; i <= numero; i++) //de acordo com o numero iformado, ele vai diminuindo até chegar em zero
        {
            if (numero % i == 0) //ele vai testar numero por numero se é divisor 
            {
                soma += i; //se for ele vai somar para fazer a soma
                Console.Write(i + " "); //e vai escrever na tela o divisor 
            }
        }
        Console.WriteLine();
        return soma;
    }

    public void Rodar()
    {
        Console.WriteLine("Digite um numero: "); //solicita o usuario um numero
        int numero = int.Parse(Console.ReadLine());

        //chama os devidos metodos
        int soma = Divisor(numero);
        Escrever(soma);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
