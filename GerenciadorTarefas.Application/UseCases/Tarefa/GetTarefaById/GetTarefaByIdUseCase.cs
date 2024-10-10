using GerenciadorTarefas.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.GetTarefaById;

public class GetTarefaByIdUseCase
{
    public ResponseTarefaJson Execute(int id)
    {
        var dados = new ResponseTarefaJson
        {
            Id = id
        };

        return dados;
    }
}
