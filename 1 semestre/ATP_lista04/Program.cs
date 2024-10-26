using System;

public class Program
{
    public static void Main()
    {
        int escolha;
        do //uma repetição para continuar rodando o codigo depois que algum exercicio finalizar 
        {
            Console.WriteLine("Informe:");
            Console.WriteLine("0) Para encerrar a execução");
            Console.WriteLine("1) Para rodar o exercício 1.");
            Console.WriteLine("2) Para rodar o exercício 2.");
            Console.WriteLine("3) Para rodar o exercício 3.");
            Console.WriteLine("4) Para rodar o exercício 4.");
            Console.WriteLine("5) Para rodar o exercício 5.");
            Console.WriteLine("6) Para rodar o exercício 6.");
            Console.WriteLine("7) Para rodar o exercício 7.");
            Console.WriteLine("8) Para rodar o exercício 8.");
            Console.WriteLine("9) Para rodar o exercício 9.");
            Console.WriteLine("10) Para rodar o exercício 10.");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha) //switch para acionar o exercicio selecionado pelo usuario, casa case chama o metodo relacionado a opção escolhida
            {
                case 1:
                    Exercicio01 exercicio01 = new Exercicio01();
                    exercicio01.Rodar();
                    break;
                case 2:
                    Exercicio02 exercicio02 = new Exercicio02();
                    exercicio02.Rodar();
                    break;
                case 3:
                    Exercicio03 exercicio03 = new Exercicio03();
                    exercicio03.Rodar();
                    break;
                case 4:
                    Exercicio04 exercicio04 = new Exercicio04();
                    exercicio04.Rodar();
                    break;
                case 5:
                    Exercicio05 exercicio05 = new Exercicio05();
                    exercicio05.Rodar();
                    break;
                case 6:
                    Exercicio06 exercicio06 = new Exercicio06();
                    exercicio06.Rodar();
                    break;
                case 7:
                    Exercicio07 exercicio07 = new Exercicio07();
                    exercicio07.Rodar();
                    break;
                case 8:
                    Exercicio08 exercicio08 = new Exercicio08();
                    exercicio08.Rodar();
                    break;
                case 9:
                    Exercicio09 exercicio09 = new Exercicio09();
                    exercicio09.Rodar();
                    break;
                case 10:
                    Exercicio10 exercicio10 = new Exercicio10();
                    exercicio10.Rodar();
                    break;
                case 0:
                    Console.WriteLine("Encerrando a execução."); 
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (escolha != 0); //adicionei uma condição para o codigo não ficar em loop infinito
    }
}
