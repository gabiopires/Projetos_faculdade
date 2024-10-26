class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Digite a sua nota: ");
        double nota = double.Parse(Console.ReadLine()); //recebendo a variavel da nota

        
        if (nota > 10) //se a nota for maior que 10, retorna nota invalida
            Console.WriteLine("Nota inválida");
        if (nota >= 8 && nota <= 10) //se a nota for entre 8 e 10, retorna nota ótima
            Console.WriteLine("ótimo");
        if (nota >= 7 && nota < 8) //se a nota for entre 7 e 8, retorna nota boa
            Console.WriteLine("Bom");
        if (nota >= 5 && nota < 7) //se a nota for entre 5 e 7, retorna nota regular 
            Console.WriteLine("Regular");
        if (nota < 5) //se a nota for menor que 5, retorna nota regular
            Console.WriteLine("Insatisfatorio");
        else if (nota < 0) //senão se a nota for menor que 0, retorna nota inválida. Usei senão se para incluir uma condição, somente com o 'se não' não funcionaria 
            Console.WriteLine("Nota inválida");
    }
}
