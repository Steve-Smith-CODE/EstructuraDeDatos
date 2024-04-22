using System;

class Program
{
    static void Main(string[] args)
    {
        //1. Declaración de variables
        int num1;
        int num2;
        int suma;
        int resta;
        int multi;
        int div;
        //2. Pedir datos al usuario
        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        //3. Realizar Operaciones
        suma = num1 + num2;
        resta = num1 - num2;
        multi = num1 * num2;
        div = num1 / num2;
        //4. Mostrar resultado
        Console.WriteLine("Adición: " + suma);
        Console.WriteLine("Sustracción: " + resta);
        Console.WriteLine("Multiplicación: " + multi);
        Console.WriteLine("División: " + div);
    }
}