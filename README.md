
# 📌 MicroAPI - Cadastro de Usuários e Tarefas

Este é um projeto simples de API REST criado com **C# e .NET 8**, que permite o cadastro, listagem, edição e remoção de **usuários** e **tarefas**. Ideal para estudos e prática de Web API com Entity Framework Core.

---

## 🚀 Tecnologias Utilizadas

- ✅ C#  
- ✅ .NET 8  
- ✅ Entity Framework Core  
- ✅ SQLite (banco de dados local para testes)  
- ✅ Swagger (para documentação e testes da API)  

---

## 🔧 Funcionalidades

- 📋 Cadastro de usuários (nome e email)  
- 📋 Cadastro de tarefas com status  
- ✏️ Atualização de dados  
- ❌ Remoção de usuários e tarefas  
- 🔍 Busca por ID e listagem completa  

---

## 🛠️ Como Rodar o Projeto

1. **Clone o repositório**

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd MicroApi
```

2. **Restaure os pacotes**

```bash
dotnet restore
```

3. **Crie o banco de dados com EF Core**

```bash
dotnet ef database update
```

4. **Execute a aplicação**

```bash
dotnet run
```

5. Acesse o Swagger:  
[https://localhost:xxxx/swagger](https://localhost:xxxx/swagger) *(o número da porta pode variar)*

---

## 💾 Banco de Dados

- Utilizei o **SQLite** com um arquivo `.db` local para simular um banco de dados real.
- Isso facilita os testes sem depender de servidores externos.
- Basta alterar a connection string no `appsettings.json`:

```json
"ConnectionStrings": {
  "DataBase": "Data Source=BancoFake.db"
}
```
---

## 📚 Aprendizados

Com esse projeto, aprendi na prática:

- Como estruturar uma Web API com boas práticas
- Como usar o Entity Framework Core com SQLite
- Criar migrations e aplicar alterações no banco
- Injetar dependências e criar repositórios
- Utilizar o Swagger para testes e documentação

---

## 🤝 Contribuições

Sinta-se à vontade para abrir issues, sugerir melhorias ou enviar PRs!  
Esse projeto é voltado para aprendizado, e toda colaboração é bem-vinda 🙌

---

## 📄 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

---

Feito com 💻 e muita curiosidade por [Daniel Beling](https://github.com/danielbeling)
