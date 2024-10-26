using System;

public class Exercicio06
{
    public void Rodar() //metodo que retorna se o valor é positivo ou negativo 
    {
        Console.WriteLine("\n\n** Exercicio 06 **\n");
        double numero = 1;
        while (numero != 0) 
        {
            Console.WriteLine("Digite um valor: "); 
            numero = double.Parse(Console.ReadLine());

            if (!Positivo(numero)) //se ele for não positivo, vai retornar que o valor é negativo 
            {
                Console.WriteLine("Esse numero é negativo \n");
            }
            else //se não retorna que o valor é positivo
            {
                Console.WriteLine("Esse numero é positivo \n");
            }
        }
    }

    static bool Positivo(double numero) //função que retorna true se o valor informado for positivo 
    {
        return (numero => 0);
    }
}
