using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using ToDoListApi.DTOs;

namespace ToDoListApi.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Tarefa> AdicionarAsync(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();
            return tarefa;
        }
        
        public async Task<List<Tarefa>> ListarAsync()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<bool> DeletarAsync(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa == null) return false;

            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Tarefa> AtualizarAsync(int id, TarefaCreateDTO dto)
        {
            var tarefaExistente = await _context.Tarefas.FindAsync(id);
            if (tarefaExistente == null) return null;

            tarefaExistente.Nome = dto.Nome;
            tarefaExistente.Descricao = dto.Descricao;
            tarefaExistente.Prioridade = dto.Prioridade;

            await _context.SaveChangesAsync();

            return tarefaExistente;
        }

        public async Task<Tarefa> FinalizarAsync(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa == null) return null;

            tarefa.Realizado = true;
            await _context.SaveChangesAsync();

            return tarefa;
        }   
        
    }
}