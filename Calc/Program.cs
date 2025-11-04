using Calc.Service;

Console.WriteLine("Calculadora - Realiza a Soma de Dois Valores Inteiros");
Console.WriteLine("Digite o primeiro valor:");
int valor1 = Console.ReadLine() is string input1 && int.TryParse(input1, out int num1) ? num1 : 0;

Console.WriteLine("Digite o segundo valor:");
int valor2 = Console.ReadLine() is string input2 && int.TryParse(input2, out int num2) ? num2 : 0;

Soma calc = new Soma();
int resultado = calc.Somar(valor1, valor2);
Console.WriteLine($"O resultado da soma é: {resultado}");

