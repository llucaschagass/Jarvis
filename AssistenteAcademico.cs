using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jarvis
{
    public class AssistenteAcademico
    {
     public void MenuAcademico(){
        Console.WriteLine("Assistente Acadêmico selecionado.");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1. Adicionar Compromisso Acadêmico");
            Console.WriteLine("2. Remover Compromisso Acadêmico");
            Console.WriteLine("3. Visualizar Compromissos Acadêmicos");
            Console.WriteLine("0. Voltar");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarCompromissoAcademico();
                    break;
                case 2:
                    RemoverCompromissoAcademico();
                    break;
                case 3:
                    VisualizarCompromissosAcademicos();
                    break;
                case 0:
                    Program.ExibirMenu();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
     }  

        public void AdicionarCompromissoAcademico()
        {
            // Implementação
        }

        public void RemoverCompromissoAcademico()
        {
            // Implementação
        }

        public void VisualizarCompromissosAcademicos()
        {
            // Implementação
        }
    }
}