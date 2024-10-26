using System;

public class Exercicio03
{
    static void RecebendoValores(int[] X)
    {
        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine("Digite os numeros do vetor:"); //vai receber os numeros do vetor
            X[i] = int.Parse(Console.ReadLine());
        }
    }

    public int[] ValoresNegativos(int[] X)
    {
        int[] N = new int[X.Length]; //declara um novo vetor com o mesmo tamanho do vetor X
        int i = 0;
        foreach (int num in X) //percorre cada numero dentro do vetor X
        {
            if (num < 0) //e se esse numero for negativo ele vai armazenar no vetor N
            {
                N[i] = num;
                i++; //usado para nortear a posição do vetor, e para contar quantos numeros vão ter no vetor
            }
        }
        Array.Resize(ref N, i); //esse codigo vai realocar o tamanho de acordo com a quantidade de numero negativos, evitando posições zeradas no vetor

        return N;
    }

    public void MostrandoValores(int[] X)
    {
        int[] N = ValoresNegativos(X); //declarando o vetor N buscando como referencia o retorno de N na função ValoresNegativos
        Console.WriteLine("\nNovo vetor com valores negativos: "); //e imprime
        foreach (int num in N)
            Console.Write(num + " ");
    }


    public void Rodar()
    {
        Console.WriteLine(); //adicionando um espaço depois das opções dos exercicios

        int[] X = new int[10]; //declarando o vetor X

        RecebendoValores(X); //chamando os metodos para execução 
        MostrandoValores(X);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}