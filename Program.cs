using System;

namespace Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMenu();
        }

        public static void ExibirMenu()
        {
            Console.WriteLine("Selecione o assistente que deseja utilizar:");
            Console.WriteLine("1. Assistente Pessoal");
            Console.WriteLine("2. Assistente Financeiro");
            Console.WriteLine("3. Assistente Acadêmico");
            Console.WriteLine("4. Assistente de Trabalho");
            Console.WriteLine("0. Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AssistentePessoal assistentePessoal = new AssistentePessoal();
                    break;
                case 2:
                    AssistenteFinanceiro assistenteFinanceiro = new AssistenteFinanceiro();
                    break;
                case 3:
                    AssistenteAcademico assistenteAcademico = new AssistenteAcademico();
                    break;
                case 4:
                    AssistenteTrabalho assistenteTrabalho = new AssistenteTrabalho();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}



