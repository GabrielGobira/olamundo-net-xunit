using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroTeste.App
{
    public class HelloWordService
    {
        public string GerarSaudacao(string? nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return "Hello World!";
            }

            return $"Hello, {nome}!";
        }
    }
}