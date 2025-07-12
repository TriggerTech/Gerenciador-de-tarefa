using System;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(string titulo, int prioridade)
    {
        tarefas.Add(new Tarefa(titulo, prioridade));
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ListarTarefas()
    {
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            return;
        }

        var ordenadas = tarefas.OrderBy(t => t.Prioridade).ToList();

        for (int i = 0; i < ordenadas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ordenadas[i]}");
        }
    }

    public void RemoverTarefa(int indice)
    {
        if (indice < 1 || indice > tarefas.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }
        tarefas.RemoveAt(indice - 1);
        Console.WriteLine("Tarefa removida.");
    }

    public void MarcarConcluida(int indice)
    {
        if (indice < 1 || indice > tarefas.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }
        tarefas[indice - 1].Concluida = true;
        Console.WriteLine("Tarefa marcada como concluída.");
    }
}
