using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jarvis
{
    public class AssistentePessoal
    {
        public void MenuPessoal()
        {
            Console.WriteLine("Assistente Pessoal selecionado.");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1. Adicionar Compromisso Pessoal");
            Console.WriteLine("2. Remover Compromisso Pessoal");
            Console.WriteLine("3. Visualizar Compromissos Pessoais");
            Console.WriteLine("0. Voltar");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarCompromissoPessoal();
                    break;
                case 2:
                    RemoverCompromissoPessoal();
                    break;
                case 3:
                    VisualizarCompromissosPessoais();
                    break;
                case 0:
                    Program.ExibirMenu();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void AdicionarCompromissoPessoal()
        {
            // Implementação
        }

        public void RemoverCompromissoPessoal()
        {
            // Implementação
        }

        public void VisualizarCompromissosPessoais()
        {
            // Implementação
        }
    }
}
