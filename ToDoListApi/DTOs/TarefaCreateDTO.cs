using System.Text.Json.Serialization;
namespace ToDoListApi.DTOs
{
    public class TarefaCreateDTO
    {
        public string Nome {get; set;} = null!;
        public string Descricao {get; set;} = null!;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Prioridade Prioridade {get; set;}
    }
}