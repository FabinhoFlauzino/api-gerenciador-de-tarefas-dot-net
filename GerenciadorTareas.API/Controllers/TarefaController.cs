using GerenciadorTarefas.Application.UseCases.Tarefa.Create;
using GerenciadorTarefas.Application.UseCases.Tarefa.Delete;
using GerenciadorTarefas.Application.UseCases.Tarefa.GetAll;
using GerenciadorTarefas.Application.UseCases.Tarefa.GetTarefaById;
using GerenciadorTarefas.Application.UseCases.Tarefa.Update;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTareas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTarefaByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTarefaUseCase();

        var response = useCase.Execute();

        if (response.Tarefas.Count != 0)
        {
            return Ok();
        }

        return NoContent();
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTarefaJson request)
    {
        var useCase = new CreateTarefaUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, RequestTarefaJson request)
    {
        var useCase = new UpdateTarefaUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTarefaByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}
