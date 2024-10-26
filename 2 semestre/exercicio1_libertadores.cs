using System;

class Program {
  public static void Main (string[] args) {
    int i = 0;
    
    //Console.WriteLine("Qual a quantidade de partidas?");
    int N = int.Parse(Console.ReadLine());

    while (i < N){
      //Console.WriteLine("Digite o resultado do primeiro jogo: ");
      string []resultado1 = Console.ReadLine().Split('x');
      //Console.WriteLine("Digite o resultado do segundo jogo: ");
      string []resultado2 = Console.ReadLine().Split('x');

      int M1 = int.Parse(resultado1[0]);
      int V1 = int.Parse(resultado1[1]);
      int M2 = int.Parse(resultado2[0]);
      int V2 = int.Parse(resultado2[1]);

      if (M1 + V2 > V1 + M2)
        Console.WriteLine("Time 1");
      else if (M2 + V1 > V2 + M1)
        Console.WriteLine("Time 2");
      else if (V2 > V1)
        Console.WriteLine("Time 1");
      else if (V1 > V2)
        Console.WriteLine("Time 2");
      else
        Console.WriteLine("Penaltis");
      i++;
    }
    
  }
}