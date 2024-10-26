class Program
{
    public static void Main(string[] args)

    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Qual a maxima permitida da rodovia? ");
        int kmpermitido = int.Parse(Console.ReadLine()); //recebendo a variavel de km maximo permitido

        Console.Write("Qual velocidade você estava dirigindo? ");
        int kmrodado = int.Parse(Console.ReadLine()); //recebendo a variavel de velocidade percorrida

        //se a velocidade rodada for menor ou igual a velocidade permitida, retorna 'você respeita a lei'
        //se a velocidade rodada for até 10% a mais do permitido, retorna o valor da multa a se pagar
        //se a velocidade rodada for maior que 10% e até 30% a mais do permitido, retorna o valor da multa a se pagar
        //senão se a velocidade rodada for maior que 30% a mais do permitido, retorna o valor da multa a ser paga
        if (kmrodado <= kmpermitido)
            Console.Write("Você respeita a lei!");
        if (kmrodado > kmpermitido && kmrodado <= kmpermitido + 10)
            Console.Write("Você pagará R$ 50,00 de multa");
        if (kmrodado > kmpermitido + 10 && kmrodado <= kmpermitido + 30)
            Console.Write("Você pagará R$ 100,00 de multa");
        else if (kmrodado > kmpermitido + 30) //usando senão se para adicionar uma condição, somente com o 'se não' não funcionaria a condição
            Console.Write("Você pagará R$ 200,00 de multa");

    }
}
