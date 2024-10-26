class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Digite um numero: ");
        int numero01 = int.Parse(Console.ReadLine()); //recebendo a primeira variavel

        Console.Write("Digite outro numero: ");
        int numero02 = int.Parse(Console.ReadLine()); //recebendo a segunda variavel

        if (numero01 > numero02) //se o numero 1 for maior que numero 2, ele vai retornar o numero 1; Se não, ele retorna o numero 2
             Console.WriteLine("{0} foi o maior numero digitado", numero01);
        else Console.WriteLine("{0} foi o maior numero digitado", numero02);
    }

}