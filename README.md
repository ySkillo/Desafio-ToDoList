<div align="center">

# ✅ Desafio-ToDoList  
### API RESTful de Gerenciamento de Tarefas  
**ASP.NET Core (.NET 8) + Entity Framework Core + SQLite**

🚀 API moderna para gerenciar tarefas, seguindo boas práticas de arquitetura, Clean Code e documentação com Swagger.

![.NET](https://img.shields.io/badge/.NET-8-purple)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![License](https://img.shields.io/badge/license-MIT-green)
![EF Core](https://img.shields.io/badge/EF%20Core-enabled-blue)

</div>

---

## 📌 Visão Geral

Este projeto permite:

<div align="center">

✅ Criar tarefas  
📋 Listar tarefas  
✏️ Atualizar tarefas  
🗑️ Excluir tarefas  

</div>

Tudo via **endpoints RESTful**, com persistência em banco SQLite.

---

<div align="center">
  <img src="imgAPI.png" width="850">
</div>

---

## 🧱 Tecnologias Utilizadas

<div align="center">

ASP.NET Core (.NET 8)  
Entity Framework Core  
SQLite  
SQL Server (suporte opcional)  
Swagger / OpenAPI  
Dependency Injection  
Repository Pattern  
Service Layer  
CORS  

</div>

---

## 📂 Estrutura do Projeto

/Controllers   → Endpoints da API
/Data          → DbContext e acesso ao banco
/Models        → Entidades do domínio
/Repositories  → Camada de dados
/Services      → Regras de negócio

🛠️ Pré-requisitos
<div align="center">

✅ .NET SDK 8
https://dotnet.microsoft.com/download

✅ Git (opcional)
https://git-scm.com/

✅ IDE recomendada
Visual Studio | VS Code | Rider

</div>

📥 Clonando o Repositório
git clone https://github.com/seu-usuario/todolist-api.git
cd todolist-api

📦 Restaurando Dependências
dotnet restore

🗄️ Banco de Dados (SQLite)

Arquivo:
gerenciador.db

Connection String:

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=gerenciador.db"));
🧱 Criando o Banco de Dados
dotnet ef migrations add InitialCreate
dotnet ef database update

Se não tiver EF Tool:

dotnet tool install --global dotnet-ef
▶️ Rodando o Projeto
dotnet run
🌐 URL da API
<div align="center">

https://localhost:5001

http://localhost:5000

</div>
📄 Swagger — Testar Endpoints
<div align="center">

👉 https://localhost:5001/swagger

</div>

Você poderá:

📌 Testar requisições

📖 Visualizar rotas

🚀 Executar POST, GET, PUT e DELETE

🔄 Endpoints Principais
Método	Rota	Descrição
GET	/api/tarefas	Listar tarefas
GET	/api/tarefas/{id}	Buscar por ID
POST	/api/tarefas	Criar tarefa
PUT	/api/tarefas/{id}	Atualizar tarefa
DELETE	/api/tarefas/{id}	Excluir tarefa


🔓 Configuração CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});
🧠 Conceitos Aplicados
<div align="center">

Arquitetura em camadas
Repository Pattern
Service Layer
Injeção de Dependência
Clean Code
Boas práticas REST
Separação de responsabilidades

</div>
🧪 Ferramentas para Teste
<div align="center">

Postman
Insomnia
Swagger UI
React / Angular / React Native

</div>
🚀 Objetivo do Projeto
<div align="center">

Projeto desenvolvido para treinar backend moderno em .NET, aplicar boas práticas e criar um projeto forte para portfólio no GitHub.

</div>
👨‍💻 Autor
<div align="center">

ySkillo - Matheus Gomes
💻 Desenvolvedor .NET
🔥 Backend | APIs | Clean Architecture

</div>
