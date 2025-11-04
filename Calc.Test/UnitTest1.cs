// 1. Importar o NUnit
using NUnit.Framework;

// 2. Importar o namespace da classe que queremos testar.
// Para isso, o projeto que será testado precisa estar referenciado no projeto de teste.
using Calc.Service;

namespace Calc.Test
{
    // 3. O nome da classe de teste geralmente reflete a classe sendo testada
    [TestFixture]
    public class SomaTests
    {
        // Usamos TestCase para testar vários cenários
        // com uma única implementação de teste.

        [TestCase(5, 5, 10)]         // Cenário 1: 5 + 5 = 10
        [TestCase(10, -5, 5)]        // Cenário 2: 10 + (-5) = 5
        [TestCase(0, 0, 0)]          // Cenário 3: 0 + 0 = 0
        [TestCase(-3, -7, -10)]      // Cenário 4: (-3) + (-7) = -10
        [TestCase(1000, 2000, 3000)] // Cenário 5: Números grandes
        public void Somar_ComDiferentesValores_DeveRetornarSomaCorreta(int v1, int v2, int resultadoEsperado)
        {
            // Arrange (Organizar)
            // Instanciamos a classe "Soma"
            Soma calc = new Soma();

            // Act (Agir)
            // Chamamos o método Somar com os parâmetros do TestCase
            int resultadoReal = calc.Somar(v1, v2);

            // Assert (Verificar)
            // Verificamos se o resultado real é igual ao resultado esperado
            Assert.AreEqual(resultadoEsperado, resultadoReal,
                $"A soma de {v1} + {v2} deveria ser {resultadoEsperado}, mas foi {resultadoReal}.");
        }
    }
}