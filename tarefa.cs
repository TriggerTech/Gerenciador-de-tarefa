public class Tarefa
{
    public string Titulo { get; set; }
    public int Prioridade { get; set; }  // 1 = Alta, 2 = Média, 3 = Baixa
    public bool Concluida { get; set; }

    public Tarefa(string titulo, int prioridade)
    {
        Titulo = titulo;
        Prioridade = prioridade;
        Concluida = false;
    }

    public override string ToString()
    {
        string status = Concluida ? "[✔]" : "[ ]";
        string prioridadeTexto = Prioridade == 1 ? "Alta" : Prioridade == 2 ? "Média" : "Baixa";
        return $"{status} {Titulo} (Prioridade: {prioridadeTexto})";
    }
}
