using ToDoListApi.DTOs;

namespace ToDoListApi.Services
{
    public interface ITarefaService
    {
        Task<TarefaResponseDTO> CriarAsync(TarefaCreateDTO dto);
        Task<List<TarefaResponseDTO>> ListarAsync();
        Task<bool> DeletarAsync(int id);
        Task<TarefaResponseDTO> AtualizarAsync(int id, TarefaCreateDTO dto);
        Task<TarefaResponseDTO> FinalizarAsync(int id);
    }
}