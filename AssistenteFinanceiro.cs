using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jarvis
{
    public class AssistenteFinanceiro
    {
        public void MenuFinanceiro()
        {
            Console.WriteLine("Assistente Financeiro selecionado.");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1. Adicionar Despesa");
            Console.WriteLine("2. Remover Despesa");
            Console.WriteLine("3. Visualizar Despesas");
            Console.WriteLine("4. Visualizar Saldo");
            Console.WriteLine("0. Voltar");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarDespesa();
                    break;
                case 2:
                    RemoverDespesa();
                    break;
                case 3:
                    VisualizarDespesas();
                    break;
                case 4:
                    VisualizarSaldo();
                    break;
                case 0:
                    Program.ExibirMenu();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void AdicionarDespesa()
        {
            // Implementação
        }
        public void RemoverDespesa()
        {
            // Implementação
        }

        public void VisualizarDespesas()
        {
            // Implementação
        }

        public void VisualizarSaldo()
        {
            // Implementação
        }
    }
}

