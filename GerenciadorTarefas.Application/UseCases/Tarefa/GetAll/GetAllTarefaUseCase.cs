using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.GetAll;

public class GetAllTarefaUseCase
{
    public ResponseAllTarefaJson Execute()
    {
        return new ResponseAllTarefaJson
        {
            Tarefas = [
                new ResponseShortTarefaJson
                {
                    Id = 1,
                    TarefaDesc = "Tarefa 1",
                    TarefaName = "Fazer qualquer coisa 1",
                    DataFinalizarTarefa = DateTime.Now.AddDays(10),
                    TarefaPrioridade = Communication.Enums.TarefaPrioridade.Media,
                    TarefaStatus = Communication.Enums.TarefaStatus.EmAndamento
                },
            ]
        };
    }
}
