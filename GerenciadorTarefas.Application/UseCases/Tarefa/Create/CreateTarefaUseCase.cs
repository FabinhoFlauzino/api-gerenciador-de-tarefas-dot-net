using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Create;

public class CreateTarefaUseCase
{
    public ResponseTarefaJson Execute(RequestTarefaJson request)
    {
        return new ResponseTarefaJson
        {
            Id = request.Id,
            TarefaName = request.TarefaName,
            TarefaDesc = request.TarefaDesc,
            TarefaPrioridade = request.TarefaPrioridade,
            DataFinalizarTarefa = request.DataFinalizarTarefa,
            TarefaStatus = request.TarefaStatus
        };
    }
}
