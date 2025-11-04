# Calculadora Simples com Testes de Unidade NUnit

Este é um projeto de exemplo **extremamente simples** criado com o objetivo principal de demonstrar a estrutura básica de testes de unidade em .NET 8, utilizando o framework NUnit.

<img width="306" height="331" alt="image" src="https://github.com/user-attachments/assets/e8a54663-a0a8-444d-a00d-5f486aa0654a" />

O projeto é dividido em três partes:
1.  **Aplicação de Console (`Program.cs`)**: A interface do usuário (UI), responsável por interagir com o usuário e capturar a entrada de dados (`Console.ReadLine`).
2.  **Biblioteca de Serviço (`Calc.Service/Soma.cs`)**: A lógica de negócios, isolada em uma classe e método (`Soma.Somar()`).
3.  **Projeto de Testes (`Calc.Tests/SomaTests.cs`)**: O projeto NUnit que testa a lógica de negócios de forma isolada.

## 🎯 Objetivo Pedagógico

O objetivo deste exemplo é ilustrar um dos conceitos mais importantes do design de software: a **Separação de Preocupações (Separation of Concerns)**.

Ao separar a *lógica* (como a soma é calculada) da *interface* (como os números são pedidos ao usuário), tornamos a lógica **testável**. Testes de unidade não devem interagir com o Console ou interfaces gráficas, pois isso quebra a automação. Nós testamos apenas a classe `Soma`.

## 🛠️ Tecnologias e Versões Utilizadas

* **IDE:** Visual Studio 2022
* **Plataforma:** .NET 8
* **Framework de Teste:** NUnit (v4.x)
* **Adaptador de Teste:** NUnit3TestAdapter
* **SDK de Teste:** Microsoft.NET.Test.Sdk

## 🚀 Como Executar

### Executando a Aplicação Principal

1.  Abra o arquivo de solução (`.sln`) no Visual Studio 2022.
2.  No "Solution Explorer" (Gerenciador de Soluções), clique com o botão direito no projeto `MeuProjeto.Console` (ou o nome que você deu ao seu projeto de console).
3.  Selecione "Set as Startup Project" (Definir como Projeto de Inicialização).
4.  Pressione `F5` ou o botão "Start" para executar. O console abrirá e solicitará os dois valores.

### Executando os Testes de Unidade

1.  No menu superior do Visual Studio, vá em **Test** -> **Test Explorer**.
2.  O Test Explorer listará todos os testes encontrados (ex: `Somar_ComDiferentesValores_DeveRetornarSomaCorreta (5 cenários)`).
3.  Clique no ícone de "Play" (Run All Tests In View) para executar os testes.
4.  Todos os testes devem passar e ser exibidos com um ícone verde.

## 🧪 Abordagem de Testes com NUnit

### O que é NUnit?

**NUnit** é um framework de teste de unidade *open-source* para aplicações .NET. Ele fornece um conjunto de **Atributos** (marcadores especiais) e **Asserções** (métodos de verificação) que nos permitem escrever testes automatizados.

* **Atributos (`[TestFixture]`, `[Test]`, `[TestCase]`)**: Identificam para o Visual Studio quais classes e métodos são testes que devem ser executados.
* **Asserções (`Assert.AreEqual()`, `Assert.IsTrue()`)**: Verificam se o resultado de uma operação é o que esperávamos. Se a asserção falhar, o teste falha.

### Testes Implementados (SomaTests.cs)

Neste projeto, não escrevemos testes separados para cada cenário. Em vez disso, usamos uma abordagem de **Teste Orientado a Dados (Data-Driven Testing)** com o atributo `[TestCase]`.

Isso nos permite escrever a lógica do teste **uma única vez** e executá-la múltiplas vezes com diferentes conjuntos de dados.

**Método de Teste:**
`public void Somar_ComDiferentesValores_DeveRetornarSomaCorreta(int v1, int v2, int resultadoEsperado)`

**Cenários de Teste Cobertos:**
Usamos 5 atributos `[TestCase]` para cobrir os cenários mais comuns (casos de borda):
1.  `[TestCase(5, 5, 10)]`
    * **Propósito:** Testa uma soma básica com números positivos.
2.  `[TestCase(10, -5, 5)]`
    * **Propósito:** Testa a soma de um número positivo e um negativo.
3.  `[TestCase(0, 0, 0)]`
    * **Propósito:** Testa o "caso de borda" da soma com zero.
4.  `[TestCase(-3, -7, -10)]`
    * **Propósito:** Testa a soma de dois números negativos.
5.  `[TestCase(1000, 2000, 3000)]`
    * **Propósito:** Testa a soma com valores maiores.
