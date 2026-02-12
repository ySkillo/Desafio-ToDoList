using System;
namespace  ToDoListApi
{
    public class Tarefa{
        public int Id {get; private set;}
        public DateTime DataCriacao{get; private set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public bool Realizado {get; set;}
        public Prioridade Prioridade {get; set;}

        public Tarefa(string nome, string descricao, Prioridade prioridade){
            
            DataCriacao = DateTime.UtcNow;
            Nome = nome;    
            Descricao = descricao;
            Realizado = false;
            Prioridade = prioridade;           
        }
        
    }
}