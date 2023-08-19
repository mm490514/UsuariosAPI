# UsuariosApi

**UsuariosApi** é um projeto que fornece uma API para gerenciamento de usuários, incluindo cadastro, autenticação e outras funcionalidades relacionadas.

## Requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) - Certifique-se de ter o SDK instalado para executar o projeto.
- Banco de dados MySQL - A aplicação utiliza o MySQL como banco de dados. Certifique-se de ter um banco de dados configurado e a conexão definida no arquivo `appsettings.json`.

## Configuração

1. Clone este repositório para o seu sistema local.
2. Abra o arquivo `appsettings.json` e configure a conexão com o banco de dados MySQL no atributo `"UsuarioConnection"`.
3. Execute o seguinte comando no diretório raiz do projeto para aplicar as migrações e configurar o banco de dados:
   
   ```
   dotnet ef database update
   ```

## Como Executar

1. Navegue até o diretório raiz do projeto usando o terminal.
2. Execute o seguinte comando para iniciar a aplicação:

   ```
   dotnet run
   ```

3. Acesse a API através do navegador ou ferramentas como [Postman](https://www.postman.com/) usando a URL `https://localhost:5001`.

## Documentação da API

A API é documentada usando o Swagger. Após iniciar a aplicação, você pode acessar a documentação da API em:

```
https://localhost:5001/swagger
```

## Contribuição

Contribuições são bem-vindas! Se você encontrar problemas ou tiver sugestões para melhorias, sinta-se à vontade para abrir uma [issue](https://github.com/seu-usuario/UsuariosApi/issues) ou enviar um [pull request](https://github.com/seu-usuario/UsuariosApi/pulls).
