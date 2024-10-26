class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Digite um numero ");
        int numero1 = int.Parse(Console.ReadLine()); //recebendo a variavel do primeiro numero 

        Console.Write("Digite outro numero ");
        int numero2 = int.Parse(Console.ReadLine()); //recebendo a variavel do segundo numero

        if (numero1 + numero2 >= 10) //se a soma dos dois numeros for maior ou igual a dez, ele soma mais 5 e mostra o resultado; se não ele soma sete e mostra o resultado
            Console.WriteLine("O resultado é " + (numero1 + numero2 + 5));
        else
            Console.Write("O resultado é " + (numero1 + numero2 + 7));


    }
}
