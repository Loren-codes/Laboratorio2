using System;

partial class Program {
    static void Main() {
        Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"División: {num1} / {num2} = {(double)num1 / num2}");
    }
}
