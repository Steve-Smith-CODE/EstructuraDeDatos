//1.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números primos. 

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static bool EsPrimo(int numero)
//    {
//        if (numero <= 1) return false;
//        for (int i = 2; i * i <= numero; i++)
//        {
//            if (numero % i == 0) return false;
//        }
//        return true;
//    }

//    static HashSet<int> NumerosPrimos(HashSet<int> numeros)
//    {
//        HashSet<int> primos = new HashSet<int>();
//        foreach (int numero in numeros)
//        {
//            if (EsPrimo(numero))
//            {
//                primos.Add(numero);
//            }
//        }
//        return primos;
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa los números separados por espacios: ");
//        string entrada = Console.ReadLine();

//        // Dividir la entrada en números
//        string[] numerosTexto = entrada.Split(' ');

//        // Convertir los números a enteros
//        HashSet<int> numeros = new HashSet<int>();
//        foreach (string numeroTexto in numerosTexto)
//        {
//            if (int.TryParse(numeroTexto, out int numero))
//            {
//                numeros.Add(numero);
//            }
//        }

//        HashSet<int> primos = NumerosPrimos(numeros);

//        Console.WriteLine("Números primos:");
//        foreach (int primo in primos)
//        {
//            Console.Write(primo + " ");
//        }
//    }
//}


//}
//2.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada. 

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static HashSet<string> FiltrarPorLetra(HashSet<string> palabras, char letra)
//    {
//        return palabras.Where(palabra => palabra.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
//                       .ToHashSet();
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la letra a buscar: ");
//        char letra = Console.ReadKey().KeyChar;
//        Console.WriteLine(); // Salto de línea

//        // Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        // Filtrar las palabras que comienzan con la letra especificada
//        var palabrasFiltradas = FiltrarPorLetra(palabras.ToHashSet(), letra);

//        Console.WriteLine($"Palabras que comienzan con la letra '{letra}':");
//        foreach (var palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//}


//3.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son divisibles por un número determinado.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static HashSet<int> FiltrarPorDivisor(HashSet<int> numeros, int divisor)
//    {
//        return numeros.Where(numero => numero % divisor == 0).ToHashSet();
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa los números separados por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa el número divisor: ");
//        int divisor = int.Parse(Console.ReadLine());

//        Dividir la entrada en números
//        string[] numerosTexto = entrada.Split(' ');

//        Convertir los números a enteros
//        HashSet<int> numeros = new HashSet<int>();
//        foreach (string numeroTexto in numerosTexto)
//        {
//            if (int.TryParse(numeroTexto, out int numero))
//            {
//                numeros.Add(numero);
//            }
//        }

//        HashSet<int> divisibles = FiltrarPorDivisor(numeros, divisor);

//        Console.WriteLine($"Números divisibles por {divisor}:");
//        foreach (int divisible in divisibles)
//        {
//            Console.Write(divisible + " ");
//        }
//    }
//}


//4.	Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en ambos conjuntos. 
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static HashSet<int> InterseccionConjuntos(HashSet<int> conjunto1, HashSet<int> conjunto2)
//    {
//        return conjunto1.Intersect(conjunto2).ToHashSet();
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa los números del primer conjunto separados por espacios: ");
//        string entrada1 = Console.ReadLine();

//        Console.Write("Ingresa los números del segundo conjunto separados por espacios: ");
//        string entrada2 = Console.ReadLine();

//        // Dividir la entrada en números
//        string[] numerosTexto1 = entrada1.Split(' ');
//        string[] numerosTexto2 = entrada2.Split(' ');

//        // Convertir los números a enteros
//        HashSet<int> conjunto1 = new HashSet<int>();
//        foreach (string numeroTexto in numerosTexto1)
//        {
//            if (int.TryParse(numeroTexto, out int numero))
//            {
//                conjunto1.Add(numero);
//            }
//        }

//        HashSet<int> conjunto2 = new HashSet<int>();
//        foreach (string numeroTexto in numerosTexto2)
//        {
//            if (int.TryParse(numeroTexto, out int numero))
//            {
//                conjunto2.Add(numero);
//            }
//        }

//        HashSet<int> interseccion = InterseccionConjuntos(conjunto1, conjunto2);

//        Console.WriteLine("Números en la intersección de los conjuntos:");
//        foreach (int numero in interseccion)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}


//5.	Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el primer conjunto, pero no en el segundo. 

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Ejemplo de uso de la función DiferenciaConjuntos
//        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
//        HashSet<int> conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

//        HashSet<int> resultado = DiferenciaConjuntos(conjuntoA, conjuntoB);

//        Console.WriteLine("Elementos en el conjunto A que no están en el conjunto B:");
//        foreach (int numero in resultado)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    static HashSet<int> DiferenciaConjuntos(HashSet<int> conjuntoA, HashSet<int> conjuntoB)
//    {
//        HashSet<int> resultado = new HashSet<int>(conjuntoA);
//        resultado.ExceptWith(conjuntoB);
//        return resultado;
//    }
////}
////6.    Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el segundo conjunto, pero no en el primero. 

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        //Ejemplo de conjuntos de números
//        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
//        HashSet<int> conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

//        //Llamada a la función y obtención del resultado
//        HashSet<int> resultado = DiferenciaInversaConjuntos(conjuntoA, conjuntoB);

//        //Impresión de los números que están en el conjunto B pero no en el A
//        Console.WriteLine("Números en el conjunto B que no están en el conjunto A:");
//        foreach (int numero in resultado)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    //La función que devuelve los números que están en el conjunto B pero no en el A
//    static HashSet<int> DiferenciaInversaConjuntos(HashSet<int> conjuntoA, HashSet<int> conjuntoB)
//    {
//        HashSet<int> resultado = new HashSet<int>(conjuntoB);
//        resultado.ExceptWith(conjuntoA);
//        return resultado;
//    }
//}
////7.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son anagramas.
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static HashSet<string> EncontrarAnagramas(HashSet<string> palabras)
//    {
//        HashSet<string> anagramas = new HashSet<string>();

//        foreach (string palabra1 in palabras)
//        {
//            foreach (string palabra2 in palabras)
//            {
//                if (EsAnagrama(palabra1, palabra2))
//                {
//                    anagramas.Add(palabra1);
//                    anagramas.Add(palabra2);
//                }
//            }
//        }

//        return anagramas;
//    }

//    static bool EsAnagrama(string palabra1, string palabra2)
//    {
//        if (palabra1.Length != palabra2.Length)
//            return false;

//        char[] arreglo1 = palabra1.ToLower().ToCharArray();
//        char[] arreglo2 = palabra2.ToLower().ToCharArray();

//        Array.Sort(arreglo1);
//        Array.Sort(arreglo2);

//        return arreglo1.SequenceEqual(arreglo2);
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        // Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        // Encontrar los anagramas
//        var anagramas = EncontrarAnagramas(new HashSet<string>(palabras));

//        Console.WriteLine("Palabras que son anagramas:");
//        foreach (var anagrama in anagramas)
//        {
//            Console.WriteLine(anagrama);
//        }
//    }
//}


//8.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos.


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        HashSet<string> palabras = new HashSet<string> { "anilina", "reconocer", "casa", "oso", "roma", "rodar", };
//        HashSet<string> palindromos = EncontrarPalindromos(palabras);

//        Console.WriteLine("Palíndromos encontrados:");
//        foreach (string palindromo in palindromos)
//        {
//            Console.WriteLine(palindromo);
//        }
//    }

//    static HashSet<string> EncontrarPalindromos(HashSet<string> palabras)
//    {
//        HashSet<string> palindromos = new HashSet<string>();
//        foreach (string palabra in palabras)
//        {
//            if (EsPalindromo(palabra))
//            {
//                palindromos.Add(palabra);
//            }
//        }
//        return palindromos;
//    }

//    static bool EsPalindromo(string palabra)
//    {
//        int i = 0;
//        int j = palabra.Length - 1;
//        while (i < j)
//        {
//            if (palabra[i] != palabra[j])
//            {
//                return false;
//            }
//            i++;
//            j--;
//        }
//        return true;
//    }
//}

//9.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada.
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la longitud deseada para las palabras: ");
//        int longitudDeseada = int.Parse(Console.ReadLine());

//        // Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        // Filtrar las palabras por longitud
//        var palabrasFiltradas = FiltrarPorLongitud(palabras, longitudDeseada);

//        Console.WriteLine($"Palabras con longitud de {longitudDeseada} caracteres:");
//        foreach (string palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    static HashSet<string> FiltrarPorLongitud(string[] palabras, int longitudDeseada)
//    {
//        HashSet<string> palabrasFiltradas = new HashSet<string>();
//        foreach (string palabra in palabras)
//        {
//            if (palabra.Length == longitudDeseada)
//            {
//                palabrasFiltradas.Add(palabra);
//            }
//        }
//        return palabrasFiltradas;
//    }
//}


//10.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada. 
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa la letra a buscar: ");
//        char letra = Console.ReadKey().KeyChar;
//        Console.WriteLine();

//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        string[] palabras = entrada.Split(' ');

//        var palabrasFiltradas = palabras.Where(palabra => palabra.Contains(letra));

//        Console.WriteLine("Palabras que contienen la letra '{0}':", letra);
//        foreach (var palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//}




//11.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor. 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa los números con espacios: ");//Declaración de variables
//        string entrada = Console.ReadLine();

//        string[] numerosTexto = entrada.Split(' ');
//        int[] numeros = numerosTexto.Select(int.Parse).ToArray();

//        Array.Sort(numeros);//Ordena los elementos

//        Console.WriteLine("Números ordenados de menor a mayor:");
//        foreach (var numero in numeros)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}


//12.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de mayor a menor. 
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa los números separados por espacios: ");//Declarar variables
//        string entrada = Console.ReadLine();

//        string[] numerosTexto = entrada.Split(' ');

//        int[] numeros = numerosTexto.Select(int.Parse).ToArray();//convertir en número entero

//        // Ordenar los números de mayor a menor
//        Array.Sort(numeros);
//        Array.Reverse(numeros);

//        Console.WriteLine("Números ordenados de mayor a menor:");
//        foreach (var numero in numeros)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}

//13.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están duplicados.


//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> conjuntoNumeros = new List<int>();
//        Console.WriteLine("Ingrese números separados por espacios:");
//        conjuntoNumeros.AddRange(Console.ReadLine().Split(' ').Select(int.Parse));

//        HashSet<int> resultado = EncontrarDuplicados(conjuntoNumeros);
//        Console.WriteLine("Números duplicados:");
//        foreach (var numero in resultado)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    static HashSet<int> EncontrarDuplicados(List<int> numeros)
//    {
//        return new HashSet<int>(numeros.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key));
//    }
//}


//14.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que no están duplicados. 

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> conjuntoNumeros = new List<int>();
//        Console.WriteLine("Ingrese números separados por espacios:");
//        conjuntoNumeros.AddRange(Console.ReadLine().Split(' ').Select(int.Parse));

//        HashSet<int> resultado = EncontrarNoDuplicados(conjuntoNumeros);
//        Console.WriteLine("Números no duplicados:");
//        foreach (var numero in resultado)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    static HashSet<int> EncontrarNoDuplicados(List<int> numeros)
//    {
//        return new HashSet<int>(numeros.GroupBy(n => n).Where(g => g.Count() == 1).Select(g => g.Key));
//    }
//}

//15.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son primos y están ordenados de menor a mayor.
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static bool EsPrimo(int numero)
//    {
//        if (numero <= 1) return false;
//        for (int i = 2; i * i <= numero; i++)
//        {
//            if (numero % i == 0) return false;
//        }
//        return true;
//    }

//    static List<int> NumerosPrimosEnRango(int desde, int hasta)
//    {
//        List<int> listaPrimos = new List<int>();

//        if (desde < 2) desde = 2; // Aseguramos que desde sea >= 2

//        for (int entero = desde; entero <= hasta; entero++)
//        {
//            if (EsPrimo(entero))
//            {
//                listaPrimos.Add(entero);
//            }
//        }

//        return listaPrimos;
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa el valor inicial del rango: ");
//        int desde = int.Parse(Console.ReadLine());

//        Console.Write("Ingresa el valor final del rango: ");
//        int hasta = int.Parse(Console.ReadLine());

//        List<int> primosEnRango = NumerosPrimosEnRango(desde, hasta);

//        Console.WriteLine("Números primos en el rango [{0}, {1}]:", desde, hasta);
//        foreach (var primo in primosEnRango)
//        {
//            Console.Write(primo + " ");
//        }
//    }
//}

//16.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos y están ordenadas de menor a mayor. 

//using System;
//using System.Linq;

//class Program
//{
//    static bool EsPalindromo(string palabra)
//    {
//        palabra = palabra.ToLower(); // Convertimos a minúsculas para ser insensibles a mayúsculas
//        int izquierda = 0;
//        int derecha = palabra.Length - 1;

//        while (izquierda < derecha)
//        {
//            if (palabra[izquierda] != palabra[derecha])
//                return false;

//            izquierda++;
//            derecha--;
//        }

//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        Filtrar las palabras palíndromas
//        var palindromos = palabras.Where(EsPalindromo).OrderBy(p => p);

//        Console.WriteLine("Palabras palíndromas ordenadas de menor a mayor:");
//        foreach (var palindromo in palindromos)
//        {
//            Console.WriteLine(palindromo);
//        }
//    }
//}

//17.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada y están ordenadas de menor a mayor. 
//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la longitud deseada para las palabras: ");
//        int longitudDeseada = int.Parse(Console.ReadLine());

//        // Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        // Filtrar las palabras por longitud
//        var palabrasFiltradas = palabras.Where(palabra => palabra.Length == longitudDeseada)
//                                        .OrderBy(palabra => palabra);

//        Console.WriteLine($"Palabras de longitud {longitudDeseada} ordenadas de menor a mayor:");
//        foreach (var palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//}

//18.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada y están ordenadas de mayor a menor. 
//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la letra a buscar: ");
//        char letra = Console.ReadKey().KeyChar;
//        Console.WriteLine(); // Salto de línea

//        Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        Filtrar las palabras que contienen la letra especificada
//        var palabrasFiltradas = palabras.Where(palabra => palabra.Contains(letra))
//                                        .OrderByDescending(palabra => palabra);

//        Console.WriteLine($"Palabras que contienen la letra '{letra}' ordenadas de mayor a menor:");
//        foreach (var palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//}

//19.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor y que no están duplicados. 
//using System;
//using System.Linq;
//using System.Collections.Generic;

////class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa los números separados por espacios: ");
//        string entrada = Console.ReadLine();

//        // Dividir la entrada en números
//        string[] numerosTexto = entrada.Split(' ');

//        // Convertir los números a enteros
//        int[] numeros = numerosTexto.Select(int.Parse).ToArray();

//        // Ordenar los números de menor a mayor
//        Array.Sort(numeros);

//        // Eliminar duplicados
//        List<int> numerosSinDuplicados = numeros.Distinct().ToList();

//        Console.WriteLine("Números ordenados de menor a mayor (sin duplicados):");
//        foreach (var numero in numerosSinDuplicados)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}

//20.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor. 
//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static bool EsPalindromo(string palabra)
//    {
//        palabra = palabra.ToLower(); // Convertimos a minúsculas para ser insensibles a mayúsculas
//        int izquierda = 0;
//        int derecha = palabra.Length - 1;

//        while (izquierda < derecha)
//        {
//            if (palabra[izquierda] != palabra[derecha])
//                return false;

//            izquierda++;
//            derecha--;
//        }

//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la longitud deseada para las palabras: ");
//        int longitudDeseada = int.Parse(Console.ReadLine());

//        string[] palabras = entrada.Split(' ');

//        var palindromosFiltrados = palabras.Where(palabra => EsPalindromo(palabra) && palabra.Length == longitudDeseada)        // Filtrar las palabras que son palíndromos y de la misma lomgitud

//                                           .OrderBy(palabra => palabra);

//        Console.WriteLine($"Palíndromos de longitud {longitudDeseada} ordenados de menor a mayor:");
//        foreach (var palindromo in palindromosFiltrados)
//        {
//            Console.WriteLine(palindromo);
//        }
//    }
//}



