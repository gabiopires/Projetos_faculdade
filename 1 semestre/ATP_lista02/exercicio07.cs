class Program
{
    public static void Main(string[] args)

    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Digite um valor de x para calcular y: ");
        double x = double.Parse(Console.ReadLine()); //recebendo a variavel x

        if (x <= 1) //se x for menor ou igual a 1, vai retornar que 1 é 1
            Console.WriteLine("O valor de y é 1");
        if (x > 1 && x <= 2) //se x for maior que 1 e menor ou igual a 2, retorna que y é 2
            Console.WriteLine("O valor de y é 2");
        if (x > 2 && x <= 3) //se x for maior que 2 e menor ou igual a 3, retorna que y é x2
            Console.WriteLine("O valor de y é x2");
        else if (x > 3) //senão se x for maior que 3, retorna que y é x3
            Console.WriteLine("O valor de y é x3");
    }
}
