using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jarvis
{
    public class AssistenteTrabalho
    {
        public void MenuTrabalho()
        {
            Console.WriteLine("Assistente de Trabalho selecionado.");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1. Adicionar Compromisso de Trabalho");
            Console.WriteLine("2. Remover Compromisso de Trabalho");
            Console.WriteLine("3. Visualizar Compromissos de Trabalho");
            Console.WriteLine("0. Voltar");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarCompromissoTrabalho();
                    break;
                case 2:
                    RemoverCompromissoTrabalho();
                    break;
                case 3:
                    VisualizarCompromissosTrabalho();
                    break;
                case 0:
                    Program.ExibirMenu();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void AdicionarCompromissoTrabalho()
        {
            // Implementação
        }

        public void RemoverCompromissoTrabalho()
        {
            // Implementação
        }

        public void VisualizarCompromissosTrabalho()
        {
            // Implementação
        }
    }
}