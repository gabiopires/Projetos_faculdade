using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Qual o ano do seu nascimento? ");
        int nascimento = int.Parse(Console.ReadLine()); //recebendo a variavel ano de nascimento

        Console.Write("Qual o ano atual? ");
        int anoatual = int.Parse(Console.ReadLine()); //recebendo a variavel ano atual

        Console.Write("Você já fez aniversário esse ano? (S/N)");
        string aniversario = Console.ReadLine(); //recebendo a variavel de aniversario

        int idade = anoatual - nascimento; //calculando a idade do usuario

        //se ele já tiver feito aniversário e tiver 18 anos ou mais, vai retornar a idade e que ele pode ter carteira de motorisa;  
        //senão se ele não tiver feito aniversário mas tiver 18 anos ou mais, vai retornar quantos anos ele vai fazer e que ele pode ter carteira de motorista
        //senão se ele não tiver feito aniversário e não tiver 18 anos, vai retornar quantos anos ele vai fazer e que ele não pode tirar carteira ainda
        //se não vai retornar quantos anos ele tem e que ele não pode ter carteira de motorista ainda

        if (aniversario is "S" or "s" && idade >= 18) //Adicionei S ou s pro usuario conseguir escrever maiusculo ou minusculo sem dar erro
            Console.WriteLine("Você tem {0} anos e pode tirar carteira de motorista", idade);
        else if (aniversario is "N" or "n" && idade >= 18) //Adicionei S ou s pro usuario conseguir escrever maiusculo ou minusculo sem dar erro
            Console.WriteLine("Você vai completar {0} anos esse ano e pode tirar carteira de motorista", idade);
        else if (aniversario is "N" or "n" && idade < 18) //Adicionei S ou s pro usuario conseguir escrever maiusculo ou minusculo sem dar erro
            Console.WriteLine("Você vai completar {0} anos esse ano e não pode tirar carteira de motorista ainda", idade);
        else Console.WriteLine("Você tem {0} anos e não pode tirar carteira de motorista ainda", idade);
    }
}
