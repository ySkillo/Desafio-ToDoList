using ToDoListApi.DTOs;
using ToDoListApi.Repositories;

namespace ToDoListApi.Services
{
    public class TarefaService : ITarefaService
{
    private readonly ITarefaRepository _repository;

    public TarefaService(ITarefaRepository repository)
    {
        _repository = repository;
    }

    public async Task<TarefaResponseDTO> CriarAsync(TarefaCreateDTO dto)
    {
        var tarefa = new Tarefa(
            dto.Nome,
            dto.Descricao,
            dto.Prioridade
        );

        await _repository.AdicionarAsync(tarefa);

        return new TarefaResponseDTO
        {
            Id = tarefa.Id,
            Nome = tarefa.Nome,
            Descricao = tarefa.Descricao,
            Prioridade = tarefa.Prioridade
        };
    }

    public async Task<List<TarefaResponseDTO>> ListarAsync()
    {
        var tarefas = await _repository.ListarAsync();

        return tarefas.Select(t => new TarefaResponseDTO
        {
            Id = t.Id,
            Nome = t.Nome,
            Descricao = t.Descricao,
            Prioridade = t.Prioridade,
            Realizado = t.Realizado
        }).ToList();
    }

    public async Task<bool> DeletarAsync(int id)
    {
        return await _repository.DeletarAsync(id);
    }

    public async Task<TarefaResponseDTO> AtualizarAsync(int id, TarefaCreateDTO dto)
    {
        var tarefaAtualizada = await _repository.AtualizarAsync(id, dto);

        if (tarefaAtualizada == null) return null;

        return new TarefaResponseDTO
        {
            Id = tarefaAtualizada.Id,
            Nome = tarefaAtualizada.Nome,
            Descricao = tarefaAtualizada.Descricao,
            Prioridade = tarefaAtualizada.Prioridade  
        };
    }

    public async Task<TarefaResponseDTO> FinalizarAsync(int id)
    {
        var tarefaFinalizada = await _repository.FinalizarAsync(id);

        if (tarefaFinalizada == null) return null;

        return new TarefaResponseDTO
        {
            Id = tarefaFinalizada.Id,
            Nome = tarefaFinalizada.Nome,
            Descricao = tarefaFinalizada.Descricao,
            Prioridade = tarefaFinalizada.Prioridade,
            Realizado = tarefaFinalizada.Realizado
        };
    }

}

}