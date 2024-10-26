class Program
{
    public static void Main(string[] args)

    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Digite um simbolo: ");
        char simbolo = char.Parse(Console.ReadLine()); //recebendo a variavel simbolo

        switch (simbolo) //comparando o valor de simbolo 
        {
            case '+': //caso simbolo seja igual a +, retorna 'sinal de maior'
                Console.Write("Sinal de maior");
                break;
            case '-': //caso simbolo seja igual a -, retorna 'sinal de menor'
                Console.Write("Sinal de menor");
                break;
            case '=': //caso simbolo seja igual a =, retorna 'sinal de igual'
                Console.Write("Sinal de igual");
                break;
            default: //caso simbolo não seja nenhuma das opções desejadas, ele retorna 'outro sinal'
                Console.Write("Outro sinal");
                break;
        }
          
    }
}
