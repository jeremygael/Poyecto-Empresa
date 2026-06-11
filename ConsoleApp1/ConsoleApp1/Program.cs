using System;

class Program
{
    static void Main()
    {
        // Variables
        int num1, num2, suma;

        // Entrada de datos
        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        // Proceso
        suma = num1 + num2;

        // Salida de datos
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("Agregando un parrafo");
    }
}
