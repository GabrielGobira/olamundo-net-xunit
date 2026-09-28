using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests
{
    public class HelloWordServiceTests
    {
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
    }
}