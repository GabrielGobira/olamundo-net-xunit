# olamundo-net-xunit

Projeto de estudo em **C# / .NET** para praticar testes automatizados com **xUnit**, usando o clássico "Hello World" como base.

## Sobre o projeto

O projeto contém um serviço simples, o `HelloWordService`, que gera uma saudação. Os testes verificam se o comportamento esperado é mantido, como o retorno da saudação padrão (`"Hello World!"`) quando o nome informado é nulo ou vazio.

O objetivo é aprender:

- a estrutura de uma solução .NET com projeto de aplicação e projeto de testes separados;
- a escrever testes unitários com xUnit (`[Fact]`, `Assert`);
- o padrão **AAA** (Arrange, Act, Assert) para organizar os testes;
- o fluxo básico de versionamento com Git e GitHub.

## Tecnologias

- C#
- .NET
- xUnit
- Git e GitHub

## Estrutura

```
OlaMundoNet/
├── MeuPrimeiroTeste.App/      # Código da aplicação (HelloWordService)
├── MeuPrimeiroTeste.Tests/    # Testes unitários com xUnit
├── MeuPrimeiroTeste.slnx      # Arquivo da solução
├── .gitignore
├── LICENSE
└── README.md
```

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) recente (o formato de solução `.slnx` requer .NET 9 ou superior)
- [Git](https://git-scm.com/)
- Um editor, como o [Visual Studio Code](https://code.visualstudio.com/) com a extensão C# Dev Kit

## Como executar

Clone o repositório e entre na pasta:

```bash
git clone https://github.com/GabrielGobira/olamundo-net-xunit.git
cd olamundo-net-xunit
```

Restaure as dependências e compile:

```bash
dotnet restore
dotnet build
```

## Como rodar os testes

```bash
dotnet test
```

Para ver os resultados com mais detalhes:

```bash
dotnet test --logger "console;verbosity=detailed"
```

## Exemplo de teste

Os testes seguem o padrão AAA:

```csharp
[Fact]
public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
{
    // Arrange (Preparação)
    var service = new HelloWordService();

    // Act (Ação)
    var resultado = service.GerarSaudacao(null);

    // Assert (Verificação)
    Assert.Equal("Hello World!", resultado);
}
```

## Próximos passos

- [ ] Adicionar testes para nomes preenchidos
- [ ] Cobrir mais cenários de borda (espaços em branco, nomes longos)
- [ ] Configurar integração contínua com GitHub Actions

## Autor

**Gabriel Gobira**  
GitHub: [@GabrielGobira](https://github.com/GabrielGobira)

## Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
