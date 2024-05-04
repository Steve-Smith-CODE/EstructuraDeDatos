
//Console.WriteLine("====Programa que determina si un número es impar o par===");
//Declarar variables
//Console.Write("Ingrese un número entero: ");
//var numeroRecibido = Console.ReadLine();
//var numero = int.Parse(numeroRecibido);
//var esPar = false;

//Resolver
//if (numero % 2 == 0)
//{
//    esPar = true;
//}
//Mostrar resultados
//Console.WriteLine(esPar ? "Es Par" : "Es Impar");
//Console.ReadLine();






////Console.WriteLine("====Distancia===");
//Declarar variables
//double d, v, t;
//Console.Write("Ingrese la velocidad constante : ");

//v = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el tiempo: ");
//t = int.Parse(Console.ReadLine());

////Resolver
//d = v * t;
////mostrar resultados
//Console.Write("La distancia en: {0}", d + "m^2");
//Console.ReadLine();


//Console.WriteLine("===Programa Operaciones Básicas===");
////Declarar variables
//double num1, num2, suma, resta, multi, dividir;

//Console.Write("Ingrese el primer número: ");
//num1 = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el segundo número: ");
//num2 = int.Parse(Console.ReadLine());

////Resolver
//suma = num1 + num2;
//resta = num1 - num2;
//multi = num1 * num2;

//if (num2 != 0)
//{
//    dividir = num1 / num2;
//}
//else
//{
//    Console.WriteLine("Error: no se puede dividir entre cero.");
//    dividir = 0;
//}

////Mostrar resultado
//Console.WriteLine("La suma es: " + suma);
//Console.WriteLine("La resta es : " + resta);
//Console.WriteLine("La multiplicacion es : " + multi);
//Console.WriteLine("La division es: " + Math.Round(dividir, 2));

//Console.ReadLine();





//Console.WriteLine("===Programa: Factorial===");

////Declarar variables
//Console.Write("Ingrese un número: ");
//int numero = int.Parse(Console.ReadLine());
//int factorial = 1;

////Resolver
//if (numero < 0)
//{
//    Console.WriteLine("!Error, no puedes ingresar un número negativo!");
//    Console.ReadKey();
//    return;
//}

//for (int i = 1; i <= numero; i++)
//{
//    factorial = factorial * i;
//}

////Mostrar resultados
//Console.WriteLine($"El factorial de {numero} es: {factorial}");
//Console.ReadKey();



//Console.WriteLine("===Programa: Área de un Triángulo===");

////Declarar variables
//Console.Write("Ingrese la base del Triángulo: ");
//int base_t = int.Parse(Console.ReadLine());
//Console.Write("Ingrese la altura del Triangulo: ");
//int altura_t = int.Parse(Console.ReadLine());

////Resolver
//if (base_t <= 0)
//{
//    Console.WriteLine("Error, no puedes ingresar un número negativo o cero para la base!");
//    Console.ReadLine();
//    return;
//}

//if (altura_t <= 0)
//{
//    Console.WriteLine("Error, no puedes ingresar un número negativo o cero para la altura!");
//    Console.ReadLine();
//    return;
//}
//double area = base_t * altura_t / 2.0;

////Mostrar resultados
//Console.WriteLine("El área del Triángulo es: " + area + "cm^2");
//Console.ReadLine();



//Console.WriteLine("==Programa: Número Primo===");

//// Declarar variables
//Console.Write("Ingrese un número: ");
//if (int.TryParse(Console.ReadLine(), out int numero))
//{
//    // Resolver
//    bool esPrimo = EsPrimo(numero);
//    Console.WriteLine($"El número: {numero} {(esPrimo ? "es" : "no es")} Primo");
//}
//else
//{
//    Console.WriteLine("Entrada inválida. Por favor, ingrese un entero válido.");
//}

//// Mostrar resultados
//Console.WriteLine("¡Gracias!");
//Console.ReadLine();

//// Método auxiliar para verificar si un número es primo
//bool EsPrimo(int numero)
//{
//    if (numero <= 1) return false;
//    if (numero == 2) return true;
//    if (numero % 2 == 0) return false;

//    var límite = (int)Math.Floor(Math.Sqrt(numero));

//    for (int i = 3; i <= límite; i += 2)
//    {
//        if (numero % i == 0) return false;
//    }

//    return true;
//}

//Console.WriteLine("===Programa: Inversión de cadena==");
////Declarar variables
//Console.Write("Ingrese la cadena de texto: ");
//string s = Console.ReadLine();
////Resolver
//int i = s.Length - 1;
//string cadena = " ";
//while (i >= 0)
//{
//    cadena += s[i];
//    i = i - 1;
//}
////Mostrar resultado
//Console.WriteLine(cadena);
//Console.ReadLine();







//Console.WriteLine("===Programa: Suma de los primeros n números Pares==");

////Declarar variables
//Console.Write("Ingrese un número: ");
//int n = int.Parse(Console.ReadLine());

////Resolver
//int suma = 0;
//for (int i = 1; i <= n; i++)
//{
//    suma += i * 2;
//}

////Mostrar resultado
//Console.WriteLine("La suma de los primeros " + n + " números pares es: " + suma);
//Console.ReadLine();



//Console.WriteLine("===Programa: Lista de cuadrados de los primeros 10 números===");
////Declarar variables
//int i = 1;

////Resolver
//Console.WriteLine("Los primeros 10 números elevados al cuadrado son:");
//while (i <= 10)
//{
//    int numero = i * i;
//    Console.WriteLine(numero);
//    i++;
//}
////Mostrar resultado
//Console.ReadLine();


//using System.Text.RegularExpressions;

//Console.WriteLine("===Programa: Contar el número de vocales en una cadena de texto===");

//// Declarar variables
//Console.Write("Ingrese una cadena de texto: ");
//string texto = Console.ReadLine();

//if (string.IsNullOrEmpty(texto))
//{
//    Console.WriteLine("La entrada no es una cadena de texto válida.");
//    return;
//}

//// Resolver
//int contadorVocales = 0;
//string patronVocales = "[áéíóúÁÉÍÓÚaeiouAEIOU]";

//foreach (Match match in Regex.Matches(texto, patronVocales))
//{
//    contadorVocales++;
//}

//// Mostrar resultado
//Console.WriteLine($"El número de vocales en la cadena de texto es: {contadorVocales}");
//Console.ReadLine();


//Console.WriteLine("===Programa: Contar el número de vocales en una cadena de texto==");
//Console.WriteLine("Escriba un texto: ");
////Declarar variables
//string Texto = Console.ReadLine().ToLower();
////Resolver
//int contador = 0;
//for (int i = 0; i < Texto.Length; i++)
//{
//    if (Texto[i] == 'a' || Texto[i] == 'e' || Texto[i] == 'i' || Texto[i] == 'o' || Texto[i] == 'u')
//    {
//        contador++;
//    }
//}
////Mostrar resultado
//Console.WriteLine("El número de vocales en el texto es: " + contador);
//Console.ReadLine();


//Console.WriteLine("===Programa: Serie de Fibonacci===");

////Declarar variables
//int numTerms = 10;

//// Variables para almacenar los dos primeros términos de la serie
//int a = 0, b = 1;

//// Mostrar el primer término (0)
//Console.WriteLine("Los primeros " + numTerms + " números de la serie Fibonacci son:");
//Console.Write(a + " ");

//// Generar y mostrar los siguientes términos de la serie Fibonacci
//for (int i = 2; i <= numTerms; i++)
//{
//    int temp = a + b; // suma los números anteriores para dar el siguiente número
//    Console.Write(temp + " "); // escribe el número temp y un espacio
//    a = b; // cambia el valor de b por el de a
//    b = temp; // y el valor de temp por el de b
//}

//Console.ReadKey();





//Console.WriteLine("==Programa: Ordenamiento de lista===");
//// Declarar variables
//Console.Write("Ingrese una lista de números separados por espacios: ");
//string input = Console.ReadLine();
////Resolver
//List<int> numbers = input.Split(' ').Select(int.Parse).ToList();// Convertir la entrada del usuario en una lista de números
//numbers.Sort();// Ordenar la lista de números
//// Mostrar el resultado
//Console.WriteLine("La lista ordenada de menor a mayor es:");
//foreach (int number in numbers)
//{
//    Console.Write(number + " ");
//}
//Console.ReadKey();




//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("=== Programa: Palíndromo ===");

//        // Solicitar al usuario que ingrese una palabra
//        Console.Write("Ingrese una palabra: ");
//        string palabra = Console.ReadLine();

//        if (string.IsNullOrEmpty(palabra))
//        {
//            Console.WriteLine("La entrada no es una palabra válida.");
//            return;
//        }
//        // Verificar si la palabra ingresada es un palíndromo
//        if (EsPalindromo(palabra))
//        {
//            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
//        }
//        else
//        {
//            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
//        }

//        // Esperar a que el usuario presione Enter antes de salir
//        Console.ReadLine();
//    }
//    // Función para verificar si una palabra es un palíndromo
//    static bool EsPalindromo(string palabra)
//    {
//        // Convertir la palabra a minúsculas para hacer la comparación sin distinción entre mayúsculas y minúsculas
//        palabra = palabra.ToLower();

//        int n = palabra.Length;
//        // Verificar carácter por carácter para determinar si la palabra es un palíndromo
//        for (int i = 0; i < n / 2; i++)
//        {
//            if (palabra[i] != palabra[n - 1 - i])
//            {
//                return false; // Si los caracteres no coinciden, la palabra no es un palíndromo
//            }
//        }

//        return true; // Si la comparación llega hasta aquí, la palabra es un palíndromo
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    Ejercicio12-Palabra Palíndromo
//    {
//        Console.WriteLine("Ingrese una palabra:");
//        string palabra = Console.ReadLine();

//        if (EsPalindromo(palabra))
//        {
//            Console.WriteLine("La palabra es un palíndromo.");
//        }
//        else
//{
//    Console.WriteLine("La palabra no es un palíndromo.");
//}
//    }

//    static bool EsPalindromo(string palabra)
//{
//    Convertir la palabra a minúsculas para hacer la comparación de manera insensible a mayúsculas
//        palabra = palabra.ToLower();

//    Obtener la longitud de la palabra
//        int n = palabra.Length;

//    Iterar sobre la mitad de la palabra para comparar los caracteres de ambos extremos
//        for (int i = 0; i < n / 2; i++)
//    {
//        Comparar el carácter actual con su correspondiente en la otra mitad de la palabra
//            if (palabra[i] != palabra[n - 1 - i])
//        {
//            Si hay alguna diferencia, la palabra no es un palíndromo
//                return false;
//        }
//    }

//    Si no se encontraron diferencias, la palabra es un palíndromo
//        return true;
//}
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
//            Console.WriteLine("El área del círculo es: " + Math.Round(area, 2));
//        }

//        Console.ReadLine();
//    }
//}




//using System;

//namespace SumaDeDigitos
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Ejercicio 15 - Suma de Dígitos

//            // Declarar variables
//            Console.Write("Ingrese un número: ");
//            int numero = Convert.ToInt32(Console.ReadLine());


//            int suma = CalcularSumaDeDigitos(numero);

//            // Mostrar resultados
//            Console.WriteLine("La suma de los dígitos es: " + suma);

//            Console.ReadLine();
//        }
//        //Resolver
//        static int CalcularSumaDeDigitos(int numero)
//        {
//            int suma = 0;

//            while (numero > 0)
//            {
//                int digito = numero % 10;
//                suma += digito;
//                numero /= 10;
//            }

//            return suma;
//        }
//    }
//}