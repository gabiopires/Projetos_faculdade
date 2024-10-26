class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou construindo o codigo
        Console.Write("Digite o local onde x1 se encontra no plano: ");
        double x1 = double.Parse(Console.ReadLine()); //recebendo a variavel de x1 do plano 

        Console.Write("Digite o local onde y1 se encontra no plano: ");
        double y1 = double.Parse(Console.ReadLine()); //recebendo a variavel de y1 do plano 

        Console.Write("Digite o local onde x2 se encontra no plano: ");
        double x2 = double.Parse(Console.ReadLine()); //recebendo a variavel de x2 do plano 

        Console.Write("Digite o local onde y2 se encontra no plano: ");
        double y2 = double.Parse(Console.ReadLine()); //recebendo a variavel de y2 do plano 

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //calculo da distancia entre os dois pontos

        Console.Write("A distancia entre os pontos é de: " + d.ToString("F0")); //mostrando ao usuario os valores sem casa decimal 

    }
}