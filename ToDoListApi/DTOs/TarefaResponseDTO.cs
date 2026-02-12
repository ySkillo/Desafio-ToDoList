namespace ToDoListApi.DTOs
{
    public class TarefaResponseDTO
    {
        public int Id {get; set;}
        public string Nome {get; set;} = null!;
        public string Descricao {get; set;} = null!;
        public Prioridade Prioridade {get; set;}
        public bool Realizado {get; set;}
    }
}