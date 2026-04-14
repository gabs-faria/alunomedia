using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            int opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - cadastrar aluno");
                Console.WriteLine("2 - Exibir boletim");
                Console.WriteLine("3 - Exibir histórico");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a opção desejada:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        aluno.LerDados();
                        aluno.CalcularMedia();
                        break;
                    case 2:
                        aluno.ExibirBoletim();
                        break;
                    case 3:
                        aluno.ExibirHistorico();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
