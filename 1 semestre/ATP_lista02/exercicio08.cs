class Program
{
    public static void Main(string[] args)

    {
        //declaro as variaveis a medida que vou criando o codigo 
        Console.Write("Digite seu salario atual: ");
        double salario = double.Parse(Console.ReadLine()); //recebendo a variavel salario

        Console.Write("Escola uma opção abaixo: \n A = aumento de 8% no salário \n B = aumento de 11% no salário \n C = aumento fixo no salário de R$ 350,00 se o salário atual for até R$ 1000 e de R$ 200,00 se o salário atual for maior que R$ 1000 \n");
        char opcao = char.Parse(Console.ReadLine()); //recebendo a variavel de opção

        double r = 0; //declarando a variavel r, pois não deve declarar variavel dentro de um switch e ela precisa conter alguma informação

        switch (opcao) //comparando a variavel opção
        {
            case 'A': //caso a opção seja A, r vai receber o salario + 8% do salario
                r = salario * 0.08 + salario;
                break;
            case 'B': //caso a opção seja B, r vai receber o salario + 11% do salario
                r = salario * 0.11 + salario;
                break;
            case 'C': //caso a opção seja C, vai se comparar se o salaro for menor ou igual a 1000 r vai receber o valor do salario + 350;  
                if (salario <= 1000)
                       r = salario + 350;
                    if (salario > 1000) //se o salario for maior que 1000 r recebe o valor do salario + 200
                       r = salario + 200;
                break;}

         Console.Write("Seu salario ficou em R$ {0}", r.ToString("F2")); //retornando o valor do salario final com duas casas decimais 
    }
}
