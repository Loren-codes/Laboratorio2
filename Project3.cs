using System;

class Operaciones // Cambia 'Program' por otro nombre
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nComparaciones:");
        Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
        Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
        Console.WriteLine($"{num1} == {num2}: {num1 == num2}");

        Console.WriteLine("\nOperadores lógicos:");
        Console.WriteLine($"({num1} > 0) && ({num2} > 0): {(num1 > 0 && num2 > 0)}");
        Console.WriteLine($"({num1} > 0) || ({num2} > 0): {(num1 > 0 || num2 > 0)}");
    }
}
