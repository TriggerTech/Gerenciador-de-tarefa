using System;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
        int opcao = 0;

        do
        {
            Console.WriteLine("\n=== Gerenciador de Tarefas ===");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Remover tarefa");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    Console.Write("Título da tarefa: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Prioridade (1=Alta, 2=Média, 3=Baixa): ");
                    int prioridade = int.Parse(Console.ReadLine());
                    gerenciador.AdicionarTarefa(titulo, prioridade);
                    break;

                case 2:
                    gerenciador.ListarTarefas();
                    break;

                case 3:
                    Console.Write("Número da tarefa a concluir: ");
                    int concluir = int.Parse(Console.ReadLine());
                    gerenciador.MarcarConcluida(concluir);
                    break;

                case 4:
                    Console.Write("Número da tarefa a remover: ");
                    int remover = int.Parse(Console.ReadLine());
                    gerenciador.RemoverTarefa(remover);
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}
