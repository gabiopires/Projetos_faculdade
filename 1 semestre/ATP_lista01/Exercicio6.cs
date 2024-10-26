class Program
{
    public static void Main(string[] args)
    {
        int a, b, aux; //dessa vez declarei as variaveis antes 

        Console.Write("Digite um valor para A: ");
        a = int.Parse(Console.ReadLine()); //recebendo o valor de a

        Console.Write("Digite um valor para B: ");
        b = int.Parse(Console.ReadLine()); //recebendo o valor de b

        aux = a; //gravando o valor de a em um auxiliar para quando sobrebor com o b não perdermos o valor de a
        a = b; //sobrepondo o valor de a com b
        b = aux; //guardando o valor de a em b

        Console.Write("Invertendo, o valor de A fica {0} e o valor de B fica {1}", a, b); //invertendo para o usuario 
    }
}