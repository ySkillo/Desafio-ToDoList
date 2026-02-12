using ToDoListApi.DTOs;

namespace ToDoListApi.Repositories
{
    public interface ITarefaRepository
    {
        Task<Tarefa> AdicionarAsync(Tarefa tarefa);
        Task<List<Tarefa>> ListarAsync();
        Task<bool> DeletarAsync(int id);
        Task<Tarefa> AtualizarAsync(int id, TarefaCreateDTO dto);
        Task<Tarefa> FinalizarAsync(int id);
    }
}