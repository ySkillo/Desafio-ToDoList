const apiBase = "http://localhost:5210/api/tarefas"; // ajuste a porta se necessário

// Função para listar tarefas
async function listarTarefas() {
    const res = await fetch(apiBase);
    const tarefas = await res.json();
    var pririty = "";
    const lista = document.getElementById("listaTarefas");
    lista.innerHTML = "";

    tarefas.forEach(t => {
        const li = document.createElement("li");
        if(t.prioridade == 0){
            pririty = "Alta"
        }else if(t.prioridade == 1){
            pririty = "Média"
        }else{
            pririty = "Baixa"
        }

        li.textContent = `Nome: ${t.nome} - Descricao: ${t.descricao} - Prioridade: ${pririty}`;
        if (t.realizado) li.classList.add("realizado");
        lista.appendChild(li);
    });
}

// Função para adicionar tarefa
async function adicionarTarefa() {
    const nome = document.getElementById("nome").value;
    const descricao = document.getElementById("descricao").value;
    const prioridade = parseInt(document.getElementById("prioridade").value);


    if (!nome || !descricao) {
        alert("Preencha todos os campos!");
        return;
    }

    const res = await fetch(apiBase, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ nome, descricao, prioridade })
    });

    if (res.ok) {
        document.getElementById("nome").value = "";
        document.getElementById("descricao").value = "";
        await listarTarefas();
    } else {
        alert("Erro ao criar tarefa!");
    }
}

// Event listener
document.getElementById("adicionar").addEventListener("click", adicionarTarefa);

// Inicializa lista
listarTarefas();
