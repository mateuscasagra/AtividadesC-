using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> tarefas = new List<string>();
        List<bool> concluida = new List<bool>();
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n== MENU ==");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a nova tarefa: ");
                    string tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    concluida.Add(false);
                    break;

                case "2":
                    Console.WriteLine("\n== Lista de Tarefas ==");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluida[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tarefas.Count)
                    {
                        concluida[indice - 1] = true;
                        Console.WriteLine("Tarefa marcada como concluída.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case "4":
                    executando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        Console.WriteLine("\nObrigado por usar a lista de tarefas!");
    }
}
