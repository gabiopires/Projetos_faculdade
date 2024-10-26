using System;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            //eu declaro as variaveis a medida que vou construindo o codigo 
            Console.Write("Digite a base de um triangulo retangulo: ");
            double bas = int.Parse(Console.ReadLine()); //recebendo a variavel de um cateto

            Console.Write("Digite a altura de um triangulo retangulo: ");
            double altura = int.Parse(Console.ReadLine()); //recebendo a variavel do outro cateto

            double hipotenusa = Math.Sqrt(bas * bas + altura * altura); //calculando a hipotenusa

            Console.Write("A hipotenusa do retangulo é: " + hipotenusa.ToString("F0")); //mostrando o resultado sem nenhuma casa decimal
        }
    }
}