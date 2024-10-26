class Program
{
    public static void Main(string[] args)
    {
        //declaro as variaveis a medida que vou construindo o codigo
        Console.Write("Qual o valor do salario minimo atual?: ");
        double salario = double.Parse(Console.ReadLine()); //recebendo a variavel do salario

        Console.Write("Qual foi a quantidade de kWh gasto?: ");
        double kwh = double.Parse(Console.ReadLine()); //recebendo a variavel de kwh

        double valorcadakwh = salario / 700; 
        //calculando o valor de cada kwh, se o valor é referente a 1/7 do salario e a cada 100kwh, pra não fazer duas multiplicações posso dividir direto por 700 
        double valorapaga = kwh * valorcadakwh; //calculando o valor a pagar por cada kwh usado
        double desconto = valorapaga / 10; //calculando o desconto de 10% em cima do valor
        double novovalor = valorapaga - desconto; //variavel contendo o novo valor com desconto 

        Console.Write(valorcadakwh.ToString("F2") + " é o valor de cada kWh, você pagará o total de R$" + valorapaga.ToString("F2") + " e com um desconto de 10% você vai pagar R$" + novovalor.ToString("F2")); 
        //mostrando ao usuario os valores com duas casas decimais
    }
}
