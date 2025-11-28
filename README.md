# API Minimal com .NET

Este projeto é uma API desenvolvida com a abordagem de Minimal APIs do .NET, como parte do desafio de projeto do Bootcamp Akad - Fullstack Developer da DIO.

## 📖 Descrição

O objetivo deste projeto é construir uma API RESTful simples e funcional, utilizando os recursos mais recentes do ASP.NET Core para criar endpoints de forma concisa e eficiente. A API demonstra operações básicas de CRUD (Create, Read, Update, Delete) para um recurso específico.

A interface da API pode ser acessada e testada através do Swagger, que é iniciado juntamente com a aplicação.

## ✨ Funcionalidades

-   **CRUD Completo:** Implementação dos métodos HTTP (GET, POST, PUT, DELETE) para manipulação de recursos.
-   **Documentação com Swagger:** Geração automática de documentação da API, permitindo fácil visualização e teste dos endpoints.
-   **Estrutura Simplificada:** Uso do padrão Minimal API para reduzir o código boilerplate e focar na lógica de negócio.
-   **Projeto de Testes:** Solução preparada com um projeto dedicado para a implementação de testes unitários ou de integração.

## 🛠️ Tecnologias Utilizadas

-   **[.NET 6+](https://dotnet.microsoft.com/download/dotnet/6.0)**: Framework principal para a construção da aplicação.
-   **[ASP.NET Core](https://docs.microsoft.com/aspnet/core/)**: Para a criação da API RESTful.
-   **[C#](https://docs.microsoft.com/dotnet/csharp/)**: Linguagem de programação utilizada.
-   **[Swagger (Swashbuckle)](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)**: Para documentação e teste de endpoints.

## 🚀 Como Executar o Projeto

Siga os passos abaixo para executar o projeto em seu ambiente local.

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
*   [.NET SDK 6](https://dotnet.microsoft.com/download/dotnet/6.0) ou superior.
*   Um editor de código de sua preferência, como [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/).

### Rodando a Aplicação

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/seu-usuario/minimal-api.git
    ```

2.  **Navegue até a pasta do projeto da API:**
    ```bash
    cd minimal-api/Api
    ```

3.  **Execute a aplicação com o comando `dotnet run`:**
    ```bash
    dotnet run
    ```

4.  **Acesse a documentação no navegador:**
    Após a execução, a API estará disponível em `http://localhost:5000` (ou outra porta indicada no terminal).

    Para acessar a interface do Swagger e testar os endpoints, abra o seguinte endereço no seu navegador:
    ```
    http://localhost:5000/swagger
    ```


