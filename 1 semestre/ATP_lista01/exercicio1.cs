class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou criando o codigo 

        Console.Write("Digite a altura do retangulo: "); 
        int alt = int.Parse(Console.ReadLine()); //recebendo a variavel da altura do triangulo

        Console.Write("Digite a base do retangulo: ");
        int bas = int.Parse(Console.ReadLine()); //recebendo a variavel da base do triangulo

        int area = alt * bas; //calculando a area
        int peri = 2 * (alt + bas); //calculando o perimetro
        double diagonal = Math.Sqrt(Math.Pow(alt, 2) + Math.Pow(bas, 2)); //calculando a diagonal 

        Console.WriteLine("O retangulo possui a area de {0}, o perimetro de {1} e a diagonal de {2}", area, peri, diagonal.ToString("F2")); //printando o resultado para o usuario o Tostring formata quantas casas serão exibidas depois da virgula
    }
}