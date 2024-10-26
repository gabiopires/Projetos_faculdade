class Program
{
    public static void Main(string[] args)
        
    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Qual o valor da diaria? ");
        double diaria = double.Parse(Console.ReadLine()); //recebendo a variavel da diária

        double promocao = diaria * 0.25; //calculando o valor de desconto da promoção
        double diariapromocional = diaria - promocao; //calculando o valor que ficará com o desconto da promoção
        double ocupacao80 = 75 * 0.80; //calculando a quantidade de quartos com 80% de ocupação
        double arrecadoupromocao = ocupacao80 * diariapromocional; //calculando quanto arrecadou com 80% de ocupação
        double ocupacao50 = 75 * 50 / 100; //calculando a quantidade de quartos com 50% dee ocupação
        double arrecadounormal = ocupacao50 * diaria; //calculando quanto arrecadou com 50% de ocupação

        //retornando o valor da diaria promocional com duas casas decimais
        Console.WriteLine("O valor da diaria promocional é R$ " + diariapromocional.ToString("F2")); 
        //retornando o total arrecadado com 80% de ocupação e com diaria promoconal com duas casas decimais
        Console.WriteLine("O valor total arrecadado com 80% de ocupação e diária promocional foi de R$ " + arrecadoupromocao.ToString("F2"));
        //retornando o total arrecadado com 50% de ocupação e com diaria normal com duas casas decimais
        Console.WriteLine("O valor total arrecadado com 50% de ocupação e diária normal foi de R$ " + arrecadounormal.ToString("F2"));
        //retornando a diferença de valores arrecadados entre a diária normal e a diária promocional com duas casas decimais 
        Console.WriteLine("A diferença de valores da arrecadação normal e com promoção foi de R$ " + (arrecadoupromocao - arrecadounormal).ToString("F2"));
    }
}
