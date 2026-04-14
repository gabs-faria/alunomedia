using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aluno
    {
        string nome;
        double nota1;
        double nota2;
   
        double media;
        List<string> Historico = new List<string>();

        public void LerDados()
        {
            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());
        }

        public void CalcularMedia()
        {
            media = (nota1 + nota2) / 2;
            Historico.Add($"{nome} sua média é {media}");
            Console.WriteLine($"{nome} Média calculada: {media}");
        }

        public string VerificarSituação()
        {
            string situacao;
            if (media >= 7)
            {
                situacao = "Aprovado :)";
            }
            else if (media >= 5)
            {
                situacao = "Recuperação :|";
            }
            else
            {
                situacao = "Reprovado";
            }

            Historico.Add($"Situação final {situacao}");
            return situacao;
        }

        public void ExibirBoletim()
        {
            Console.WriteLine($"Boletim:{nome} suas notas {nota1},{nota2}, sua média foi {media} sua situação {VerificarSituação()}");
        }

        public void ExibirHistorico()
        {
            Console.WriteLine($"Historico do {nome}");

            if (Historico.Count == 0)
            {
                Console.WriteLine("Não tem nenhum registro");
            }
            else
            {
                foreach (var registro in Historico)
                {
                    Console.WriteLine(registro);
                }
            }
        }
    }
}
