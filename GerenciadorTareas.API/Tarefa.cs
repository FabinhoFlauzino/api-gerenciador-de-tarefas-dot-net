using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTareas.API;

public class Tarefa
{
    public int Id { get; set; }
    public string TarefaName { get; set; } = string.Empty;
    public string TarefaDesc { get; set; } = string.Empty;
    public TarefaPrioridade TarefaPrioridade { get; set; }
    public DateTime DataFinalizarTarefa { get; set; }
    public TarefaStatus TarefaStatus { get; set; }
}