using System;

class MiPrograma  // Renombramos la clase para evitar conflictos
{
    static void Main()  
    {
        Console.Write("Ingresa un número entero: ");
        int entero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa un número decimal: ");
        double decimalNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa un texto: ");
        string texto = Console.ReadLine() ?? "";  

        Console.Write("Ingresa un valor booleano (true/false): ");
        bool booleano = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine($"Entero: {entero}, Decimal: {decimalNum}, Texto: {texto}, Booleano: {booleano}");
    }
}
