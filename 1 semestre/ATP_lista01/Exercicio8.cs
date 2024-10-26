using System.ComponentModel.Design;
class Program
{
    public static void Main(string[] args)
    {
        //não declarei as variaveis antes, fui declarando conforme fui criando o codigo
        Console.Write("Digite a sua conta corrente, somente com 3 digitos: "); 
        int conta = int.Parse(Console.ReadLine()); //recebendo a variavel conta corrente

        int centena = conta / 100; //separando o digito da centena para somar o inverso depois
        int dezena = (conta % 100) / 10; //separando o digito da dezena para somar o inverso depois
        int unidade = conta % 10; //separando o digito da unidade para somar o inverso depois
        int inverso = unidade * 100 + dezena * 10 + centena; //formando o numero completo inverso para somar ao numero da conta
        int soma_inverso = conta + inverso; //somando a conta com o inverso da conta
        int centena_soma = soma_inverso/ 100; //pegando o digito da centena, do resultado da soma inversa
        int dezena_soma = soma_inverso % 100 / 10; // pegando o digito da dezena, do resultado da soma inversa
        int unidade_soma = soma_inverso % 10; // pegando o digito da unidade, do resultado da soma inversa
        int x0 = 0; //milhar sempre vai ser zero, pois é multiplicado por zero
        int x1 = centena_soma * 1; //multiplicando a centena pelo numero de sua ordem
        int x2 = dezena_soma * 2; //multiplicando a dezena pelo numero de sua ordem
        int x3 = unidade_soma * 3; //multiplicando a unidade pelo numero de sua ordem
        int soma_multipli = x0 + x1 + x2 + x3; //somando a multiplicação para separar o ultimo numero 
        //como o maximo que a soma da multiplicação pode ser é 54, não precisamos separar o numero desde a centena dessa vez, podemos começar pela dezena. 
        int x2_soma = soma_multipli / 10; //separando a dezena 
        int x3_soma = soma_multipli % 10; //separando a unidade para o resultado
        Console.Write("O Digito verificar da sua conta é " + x3_soma); //printando o resultado do digito para o usuario 
    }
}