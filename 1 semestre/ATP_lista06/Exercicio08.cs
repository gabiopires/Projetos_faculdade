using System;
using System.IO;
using System.Text;

public class Exercicio08
{
    public int Faturamento(int veiculos, int aluguel)
    {
        int faturamentoanual = (veiculos * aluguel)/3 * 12; //calculo do aluguel anual de acordo com o enunciado
        
        Console.WriteLine("O faturamento anual é de R$ " + faturamentoanual); //escreve na tela o resultado

        return faturamentoanual; //retorna pra função
    }

    public double Atraso(int veiculos, int aluguel)
    {
        double multa = (((veiculos * aluguel)/3) /10) * 0.2; //calculo da multa de acordo com o enunciado

        Console.WriteLine("O valor ganho com multas no mês é de R$ " + multa); //escreve na tela o resultado

        return multa; //retorna pra função
    }

    public double Manutencao(int veiculos, int aluguel)
    {
        double manutencaoAnual = (veiculos * 0.02) * 600; //calculo da manutenção de acordo com o enunciado

        Console.WriteLine("O valor gasto com manutenção  anual é de R$ " + manutencaoAnual); //escreve na tela o resultado

        return manutencaoAnual; //retorna pra função
    }
    public void Escrever(int veiculos, int aluguel)
    {
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            //escreve no arquivo os resultados
            sw.WriteLine("Faturamento anual: R$ " + Faturamento(veiculos, aluguel));
            sw.WriteLine("Multa mensal: R$ " + Atraso(veiculos, aluguel));
            sw.WriteLine("Manutenção anual: R$ " + Manutencao(veiculos, aluguel));

        }
        Console.WriteLine("Arquivo gravado!");
    }

    public void Rodar()
    {
        //recebe os valores do usuario
        Console.WriteLine("Quantos veiculos a locadora possui?: "); 
        int veiculos = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual valor você cobra por aluguel?: ");
        int aluguel = int.Parse(Console.ReadLine());

        //chama os devidos metodos
        Faturamento(veiculos, aluguel);
        Atraso(veiculos, aluguel);
        Manutencao(veiculos, aluguel);
        Escrever(veiculos, aluguel);

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente

    }
}
