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
//namespace Ejercicio04
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Calcular el factorial de un número
//            Console.WriteLine("Ingrese un número: ");
//            int numero = Convert.ToInt32(Console.ReadLine());
//            int factorial = 1;
//            for (int i = 1; i <= numero; i++)
//            {
//                factorial = factorial * i;

//            }
//            Console.WriteLine(" EL factorial del " + numero + " es:" + factorial);
//            Console.ReadKey();

//        }

//    }
//}

//using System;
//namespace Ejercicio05
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Determinar si es un número primo
//            Console.WriteLine("Introducir un número: ");
//            int numero = Convert.ToInt32(Console.ReadLine());
//            if (numero % 2 == 0)
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

//using System;

//class Program
//{
//    static void Main()
//    {
//        //Ejercicio06-Invertir la cadena de texto

//        Console.WriteLine("Ingrese texto: ");
//        string s = Console.ReadLine();
//        int i = s.Length - 1;
//        string aux = "";
//        while (i >= 0)
//        {
//            aux = aux + s[i];
//            i = i - 1;
//        }
//        Console.WriteLine(aux);
//        Console.ReadLine();
//    }

//    static string InvertirCadena(string input)
//    {
//        char[] caracteres = input.ToCharArray();
//        Array.Reverse(caracteres);
//        return new string(caracteres);
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Ejercicio07 - Calcular la suma de números pares en un rango especifico
//        Console.WriteLine("Ingrese un número: ");
//        int numero1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Ingrese otro número: ");
//        int numero2 = Convert.ToInt32(Console.ReadLine());
//        int n1 = numero1 % 2 != 0 ? numero1 + 1 : numero1;
//        int n2 = numero2 % 2 != 0 ? numero2 + 1 : numero2;

//        int sumPar = 0;
//        for (int i = n1; i <= n2; i += 2)
//        {
//            sumPar += i;
//        }

//        Console.WriteLine("La suma de los números pares en el rango [" + numero1 + ", " + numero2 + "] es: " + sumPar);

//        Console.ReadKey();
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    //Ejercicio08-Lista de los primeros 10 números elevado al cuadrado
//    {
//        List<int> cuadrados = new List<int>();//lista entera cuadrados es igual a una lista nueva

//        for (int i = 1 // desde el rango 1
//            ; i <= 10 // hasta el 10
//            ; i++) // se ira sumando a i + 1
//        {
//            cuadrados.Add(i * i); // se añade cada respuesta a la lista de cuadrados creada
//        }
//        Console.WriteLine("Cuadrados de los primeros 10 números naturales:");
//        foreach (int cuadrado in cuadrados) // foreach se usa para iterar en la lista de cuadrados creada
//        {
//            Console.WriteLine(cuadrado); //Imprimir la lista cuadrados
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //Ejercicio09-Calcular la suma de número de vocales en un texto
//        Console.WriteLine("Escriba un texto: ");
//        string texto = Console.ReadLine().ToLower(); // Convert the input to lowercase for case-insensitive comparison
//        int contador = 0;

//        for (int i = 0; i < texto.Length; i++)
//        {
//            if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
//            {
//                contador++;
//            }
//        }

//        Console.WriteLine("La cantidad de vocales encontradas en el texto es :" + contador);
//        Console.ReadKey();
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//Ejercicio10-Serie de Fibonacci de los primeros 10
//    {
//        // Número de términos de la serie Fibonacci a generar
//        int numTerms = 10;

//    // Variables para almacenar los dos primeros términos de la serie
//    int a = 0, b = 1;

//    // Mostrar el primer término (0)
//    Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
//        Console.Write(a + " ");

//        // Generar y mostrar los siguientes términos de la serie Fibonacci
//        for (int i = 2; i <= numTerms; i++)
//        {
//            int temp = a + b; // suma los números anteriores para dar el siguiente número
//    Console.Write(temp + " "); // escribe el número temp y un espacio
//            a = b; // cambia el valor de b por el de a
//            b = temp; // y el valor de temp por el de b
//        }
//Console.ReadKey();
//    }
//}





//using System;

//class Program
//{
//    static void Main(string[] args)
//    //Ejercicio12-Palabra Palíndromo
//    {
//        Console.WriteLine("Ingrese una palabra:");
//        string palabra = Console.ReadLine();

//        if (EsPalindromo(palabra))
//        {
//            Console.WriteLine("La palabra es un palíndromo.");
//        }
//        else
//        {
//            Console.WriteLine("La palabra no es un palíndromo.");
//        }
//    }

//    static bool EsPalindromo(string palabra)
//    {
//        // Convertir la palabra a minúsculas para hacer la comparación de manera insensible a mayúsculas
//        palabra = palabra.ToLower();

//        // Obtener la longitud de la palabra
//        int n = palabra.Length;

//        // Iterar sobre la mitad de la palabra para comparar los caracteres de ambos extremos
//        for (int i = 0; i < n / 2; i++)
//        {
//            // Comparar el carácter actual con su correspondiente en la otra mitad de la palabra
//            if (palabra[i] != palabra[n - 1 - i])
//            {
//                // Si hay alguna diferencia, la palabra no es un palíndromo
//                return false;
//            }
//        }

//        // Si no se encontraron diferencias, la palabra es un palíndromo
//        return true;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    //Ejercicio13-Tabla de Multiplicar
//    {
//        Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
//        int numero = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Tabla de multiplicar del {numero}:");
//        for (int i = 1; i <= 12; i++)
//        {
//            int resultado = numero * i;
//            Console.WriteLine($"{numero} x {i} = {resultado}");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Ejercicio14-Área de un círculo

//        Console.Write("Escriba el radio del círculo: ");
//        double radio = Convert.ToDouble(Console.ReadLine());

//        if (radio == 0)
//        {
//            Console.WriteLine("El radio del círculo es cero, el área no existe.");
//        }
//        else
//        {
//            double area = Math.PI * Math.Pow(radio, 2);
//            Console.WriteLine("El área del círculo es: " + area);
//        }
//    }
//}