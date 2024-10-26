class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou construindo o codigo
        Console.Write("Qual será o valor da aplicação mensal?: R$ ");
        double aplic = int.Parse(Console.ReadLine()); //recebendo o valor da aplicação mensal

        Console.Write("Qual a porcentagem da taxa de juros mensal?: ");
        double taxjuros = int.Parse(Console.ReadLine()); //recebendo o valor do juros mensal

        Console.Write("Quantos meses o valor ficará aplicado?: ");
        int meses = int.Parse(Console.ReadLine()); //recebendo a quantidade de meses que ficará aplicado

        double juros = taxjuros / 100; //convertendo a taxa de juros para ficar calculavel
        double rendi = (aplic * (Math.Pow(1 + juros,meses) - 1)) / juros; //fazendo o calculo final do rendimento

        Console.Write("O rendimento final será de R$ " + rendi.ToString("F2")); //mostrando ao usuario o valor final de seu rendimento com duas casas decimais depois da virgula
    }
}