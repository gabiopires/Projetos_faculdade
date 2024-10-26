class Program
{
    public static void Main(string[] args)
    {
        double total_dias, dias, anos, meses; //dessa vez declarei as variaveis antes 

        Console.Write("A empresa está a quantos dias sem acientes?: ");
        total_dias = double.Parse(Console.ReadLine()); //recebendo o valor do total de dias sem acidentes

        anos = total_dias / 365; //trazendo o valor de anos
        meses = (total_dias % 365)/30; //trazendo o valor de meses
        dias = (total_dias % 365) % 30; //trazendo o valor de dias 

        Console.Write("A empres está a {0} anos, {1} meses e {2} dias sem acidentes", anos.ToString("F0"), meses.ToString("F0"), dias.ToString("F0"));
        //mostrando ao usuario a quantidade final sem casas decimais

    }
}