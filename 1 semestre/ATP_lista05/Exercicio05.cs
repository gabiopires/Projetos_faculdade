using System;

public class Exercicio05
{
    public int[] Sorteio(int[] N)
    {
        Random random = new Random(); 

        for (int i = 0; i < N.Length; i++) //soteando 3 valores para o vetor N
        {
            N[i] = random.Next(10, 50);
        }
        return N;
    }

    public void Tentativa(int[] N)
    {
        int recebetentativa = 0; //variavel para armazenar a tentativa do usuario 
        bool acertou = false; //variavel para o While continuar rodando até o usuario acertar
        Console.WriteLine("\n** Sorteio **");
        do
        {
            Console.WriteLine("Digite a sua tentativa com um numero de 10 a 50: ");
            recebetentativa = int.Parse(Console.ReadLine()); //armazena a tentativa
            foreach(int num in N) //percorre cada posição no vetor N
            {
                if (num == recebetentativa) //e compara se o numero da tentativa é igual ao numero da posição no vetor 
                {
                    Console.WriteLine("**Você Ganhou!** \nnumero sorteado:" + num); 
                    acertou = true; //se o numero da tentativa tiver em alguma posição do vetor, é mudado a variavel para parar o While
                }
            }
        }
        while(acertou == false);
    }
    public void Rodar()
    {
        int[] N = new int[3]; //declarando o vetor N
        Sorteio(N); //chamando os metodos para execução 
        Tentativa(N);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}