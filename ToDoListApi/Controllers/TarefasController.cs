using Microsoft.AspNetCore.Mvc;
using ToDoListApi.DTOs;
using ToDoListApi.Services;

namespace ToDoListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _service;

        public TarefasController(ITarefaService service)
        {
            _service = service;
        }

        // POST api/tarefas
        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] TarefaCreateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var tarefa = await _service.CriarAsync(dto);

            return CreatedAtAction(nameof(Listar), tarefa);
        }

        // GET api/tarefas
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var tarefas = await _service.ListarAsync();
            return Ok(tarefas);
        }

        // DELETE api/tarefas/{id}
        [HttpDelete("{id}/deletar")]
        public async Task<IActionResult> Deletar(int id)
        {
            var sucesso = await _service.DeletarAsync(id);
            if (!sucesso)
                return NotFound();

            return NoContent();
        }
        
        // UPDATE api/tarefas/{id}
        [HttpPut("{id}/atualizar")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] TarefaCreateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var tarefaAtualizada = await _service.AtualizarAsync(id, dto);
            if (tarefaAtualizada == null)
                return NotFound();

            return Ok(tarefaAtualizada);
        }

        // PATCH api/tarefas/{id}/finalizar
        [HttpPatch("{id}/finalizar")]
        public async Task<IActionResult> Finalizar(int id)
        {
            var tarefaFinalizada = await _service.FinalizarAsync(id);
            if (tarefaFinalizada == null)
                return NotFound();

            return Ok(tarefaFinalizada);
        }

    }
}
