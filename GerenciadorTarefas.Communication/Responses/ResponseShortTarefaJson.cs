using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Responses;

public class ResponseShortTarefaJson
{
    public int Id { get; set; }
    public string TarefaName { get; set; } = string.Empty;
    public string TarefaDesc { get; set; } = string.Empty;
    public TarefaPrioridade TarefaPrioridade { get; set; }
    public DateTime DataFinalizarTarefa { get; set; }
    public TarefaStatus TarefaStatus { get; set; }
}
