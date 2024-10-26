using System;

public class Exercicio01
{
    public void Rodar()
    {
        int[] N = new int[20];  //declarando um vetor de 20 posições
        Random random = new Random(); //faz o sorteio dos numeros do vetor

        Console.WriteLine("\n\nElementos do vetor:"); 
        for (int i = 0; i < 20; i++) //adiciona cada numero sorteado em cada posição do vetor
        {
            N[i] = random.Next(0, 101); //esta sorteando numero de 0 a 100
            Console.Write(N[i] + " "); //e imprime todos na mesma linha
        }

        int menorElemento = N[0]; //variavel que vai receber o primeiro elemento do vetor N para iniciar a comparação
        int posicaoMenor = 0; //variavel para receber a posição de onde o menor valor está
        int x = 0; //variavel para contar as posições 

        foreach (int num in N) //foreach irá percorrer cada elemento em N
        {
            if (num < menorElemento) //e vai camparar se esse elemento é menor do que o ultimo verificado
            {
                menorElemento = num; //se ele for menor, menorElemento recebe o valor menor atual
                posicaoMenor = x; //e posicaoMenor recebe a posição do menor valor atual
            }
            x++; 
        }
        Console.WriteLine($"\n\nO menor elemento de N é: {menorElemento} e sua posição dentro do vetor é: {posicaoMenor}");

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    
    }
}
