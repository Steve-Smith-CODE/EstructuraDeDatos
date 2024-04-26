//using System;

//namespace Ejercicio01
//{
//    class Ejericio01Program
//    {
//        static void Main(string[] args)
//        {
//            //1. Declaración de variables
//            int num1;
//            int num2;
//            int suma;
//            int resta;
//            int multi;
//            int div;

//            //2. Pedir datos al usuario
//            Console.Write("Ingrese el primer número: ");
//            num1 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Ingrese el segundo número: ");
//            num2 = Convert.ToInt32(Console.ReadLine());

//            //3. Realizar Operaciones
//            suma = num1 + num2;
//            resta = num1 - num2;
//            multi = num1 * num2;

//            if (num2 != 0)
//            {
//                div = num1 / num2;
//            }
//            else
//            {
//                Console.WriteLine("Error: no se puede dividir entre cero.");
//                div = 0; // o cualquier otro valor que desees asignar
//            }

//            //4. Mostrar resultado
//            Console.WriteLine("Adición: " + suma);
//            Console.WriteLine("Sustracción: " + resta);
//            Console.WriteLine("Multiplicación: " + multi);
//            Console.WriteLine("División: " + div);
//        }
//    }
//}



//using System;

//namespace Ejercicio02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Determinar si es un número es Par o Impar en c#
//            Console.WriteLine("Introducir número");
//            int numero = Convert.ToInt32(Console.ReadLine());
//            if (numero % 2 == 0)
//            {
//                Console.WriteLine("El número " + numero + " es Par.");
//            }
//            else
//            {
//                Console.WriteLine("El número " + numero + " es Impar.");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//namespace Ejercicio03
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Calcular el área de un triangulo en C#
//            Console.WriteLine("Ingrese la base del triangulo: ");
//            int base_t = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Ingrese la altura del triangulo: ");
//            int altura_t = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("El área del triangulo es :" + (double)(base_t * altura_t) + "cm^2");
//            Console.ReadLine();

//        }
//    }
//}
//using System;
//namespace Ejercicio
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			//Calcular el factorial de un número
//			Console.WriteLine("Ingrese un número: ");
//			int  numero = Convert.ToInt32(Console.ReadLine());
//			int factorial = 1;
//			for (int i = 1; i <= numero; i++)
//			{
//				factorial = factorial * i;

//			}
//			Console.WriteLine(" EL factorial del " + numero + " es:" + factorial);
//			Console.ReadKey();	

//		}

//	}
//}

//using System;
//namespace Ejercicio05
//{
//
//    class Program
//    {
//        static void Main(string[] args) 
//        {
//            //Determinar si es un número primo
//            Console.WriteLine("Introducir un número: ");
//            int numero = Convert.ToInt32(Console.ReadLine());
//            if (numero % 2 == 0 ) 
//            {
//                Console.WriteLine("El número " + numero + "es Par");    
//            }
//            else
//            {
//                Console.WriteLine("El número " + numero + " es Impar"); 
//            }
//            Console.ReadKey();     
//        }   

//    }
//}

using System;

class Program
{
    static void Main()
    {
        //Invertir la cadena de texto-Ejercicio06

        Console.WriteLine("Ingrese texto: ");
        string  s = Console.ReadLine();
        int i = s.Length - 1;
        string aux = "";
        while (i >= 0)
        {
            aux = aux + s[i];
            i = i - 1;
        }  
        Console.WriteLine(aux);
        Console.ReadLine();
    }

    static string InvertirCadena(string input)
    {
        char[] caracteres = input.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
