using System;
using System.IO;
using System.Text;

public class Exercicio09
{
    public void Escrever()
    {
        using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt", true, Encoding.ASCII)) //abrindo o arquivo para gravação
        {
            long matricula = 1, telefone = 0;

            while (matricula != 0) //condição pra continuar rodando
            {
                Console.WriteLine($"Digite a matrícula do aluno (digite 0 para sair): "); //recebe os valores do usuario
                matricula = long.Parse(Console.ReadLine());

                if (matricula == 0) //condição para parar de rodar
                    break;

                Console.WriteLine("Digite o telefone: "); //recebe os valores do usuario
                telefone = long.Parse(Console.ReadLine());

                sw.WriteLine($"Aluno: matrícula: {matricula}, telefone: {telefone}"); //escreve no arquivo cada matricula e telefone digitados pelo usuario
            }
            sw.Close();

            Console.WriteLine("Arquivo gravado!");

            StreamReader sr = new StreamReader("C:\\Users\\Gabi\\Documents\\ATP\\lista06\\exemplo.txt"); //abrindo o arquivo para leitura
            String line = sr.ReadLine(); //recebendo o valor de cada linha 
            while (line != null) //condição para parar de rodar quando a linha for nula
            {
                Console.WriteLine(line); //imprime a informação de cada linha
                line = sr.ReadLine(); //armazena a informação da proxima linha
            }
            sr.Close(); //fecha o arquivo

        }
    }

    public void Rodar()
    {
        Escrever(); //chama o metodo

        Console.WriteLine("\n\nPressione Enter para ir para o Menu...");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {} // Espera até que a tecla Enter seja pressionada novamente
    }
}
