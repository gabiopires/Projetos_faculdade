class Program
{
    public static void Main(string[] args)

    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Determine o coeficiente a: ");
        double a = double.Parse(Console.ReadLine()); //recebendo o variavel a

        Console.Write("Determine o coeficiente b: ");
        double b = double.Parse(Console.ReadLine()); //recebendo a variavel b

        if (a != 0) { //se o coeficiente for diferente de 0 ele faz o calculo normal; se não ele para e não calcula
            double x = -b / a;
            Console.Write("O valor de x é " + x); }
        else
            Console.WriteLine("O valor de a não é valido"); //a não pode ser zero, senão o resultado é nulo
    }
}
