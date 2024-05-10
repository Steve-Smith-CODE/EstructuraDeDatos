//Desarrollo y Actividades Ejercicio: 

////Recursividad:
////1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 
//using System;
//namespace Recursividad
//{
//    class Program
//    {
//        static void Main(string[] argss)
//        {
//            Declarar variables
//            int contador = 1;
//            Resolver
//            while (contador <= 100)
//            {
//                if (contador % 2 == 0)
//                {
//                    Console.WriteLine(contador);
//                }
//                contador++;
//            }
//            Mostrar resultado
//            Console.WriteLine("!Very you much thanks");
//            Console.ReadKey();
//        }
//    }
//}


////2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 

//using System;

//namespace RecursiSuma
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 10;//Declarar variable
//            int suma = Sum(n); // Calcular la suma de los números del 1 al n
//            Console.WriteLine($"La suma de los números del 1 al {n} es: {suma}");
//            Console.ReadLine();
//        }

//        static int Sum(int n)//Resolver
//        {
//            if (n == 0)
//            {
//                return 0; // Caso base: la suma de los números del 1 al 0 es 0
//            }
//            else
//            {
//                return n + Sum(n - 1); // Llamada recursiva para sumar del 1 al n
//            }
//        }
//    }
//}

////3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 

//using System;
//namespace RecursiPirámide
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 10;//Definir variable el número de filas de la pirámide
//            ImprimirPiramide(n, 1); // Llamada inicial  para imprimir la pirámide
//        }

//        public static void ImprimirPiramide(int n, int m)//Imprime las filas de la pirámide
//        {
//            if (m > n)
//            {
//                return;
//            }
//            // Imprimir espacios en blanco para alinear los números en la pirámide
//            ImprimirEspacios(n - m);

//            // Llamada recursiva para imprimir los números en la fila actual
//            ImprimirNumeros(1, m);

//            Console.WriteLine(); // Salto de línea después de imprimir la fila

//            // Llamada recursiva para imprimir la siguiente fila de la pirámide
//            ImprimirPiramide(n, m + 1);
//        }

//        public static void ImprimirEspacios(int contador)//Imprime una cantidad de espacios blanco
//        {
//            if (contador <= 0)
//            {
//                return;
//            }

//            Console.Write(" "); // Imprimir un espacio en blanco
//            ImprimirEspacios(contador - 1); // Llamada recursiva para imprimir el siguiente espacio
//        }

//        public static void ImprimirNumeros(int inicio, int final)//Imprime números consecutivos
//        {
//            if (inicio > final)
//            {
//                return;
//            }

//            Console.Write(inicio + " "); // Imprimir el número actual seguido de un espacio
//            ImprimirNumeros(inicio + 1, final); // Llamada recursiva para imprimir el siguiente número
//        }
//    }
//}


////using System;

////public class Program
////{
////    public static void Main()
////    {
////        int n = 5; // Definir el número de filas de la pirámide
////        ImprimirPiramideDeUnos(n, 1); // Llamada inicial a la función recursiva para imprimir la pirámide
////    }

////    public static void ImprimirPiramideDeUnos(int n, int currentRow)
////    {
////        if (currentRow > n)
////        {
////            return; // Caso base: detener la recursión cuando llegamos a la última fila
////        }

////        // Imprimir espacios en blanco para alinear los números en la pirámide
////        ImprimirEspacios(n - currentRow);

////        // Llamada recursiva para imprimir los números en la fila actual (todos son 1)
////        ImprimirNumeros(1, currentRow);

////        Console.WriteLine(); // Salto de línea después de imprimir la fila

////        // Llamada recursiva para imprimir la siguiente fila de la pirámide
////        ImprimirPiramideDeUnos(n, currentRow + 1);
////    }

////    public static void ImprimirEspacios(int count)
////    {
////        if (count <= 0)
////        {
////            return; // Caso base: detener la recursión cuando no quedan más espacios por imprimir
////        }

////        Console.Write(" "); // Imprimir un espacio en blanco
////        ImprimirEspacios(count - 1); // Llamada recursiva para imprimir el siguiente espacio
////    }

////    public static void ImprimirNumeros(int num, int count)
////    {
////        if (count <= 0)
////        {
////            return; // Caso base: detener la recursión cuando no quedan más números por imprimir en la fila
////        }

////        Console.Write(num + " "); // Imprimir el número (en este caso, siempre es 1)
////        ImprimirNumeros(num, count - 1); // Llamada recursiva para imprimir el siguiente número en la fila
////    }
////}


//4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 

//using System;
//namespace RecursiInvertidos
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 5; // Declarar variable y número de filas 
//            ImprimirPiramideInvertida(n, 1);
//        }

//        public static void ImprimirPiramideInvertida(int n, int m)//Imprime filas de la piramide
//        {
//            if (m > n)
//            {
//                return; 
//            }

//            // Llamada recursiva para imprimir la siguiente fila de la pirámide invertida
//            ImprimirPiramideInvertida(n, m + 1);

//            // Imprimir espacios en blanco para alinear los números en la fila actual
//            ImprimirEspacios(n - m);

//            // Llamada recursiva para imprimir los números en la fila actual
//            ImprimirNumeros(1, m);

//            Console.WriteLine(); // Salto de línea después de imprimir la fila
//        }

//        public static void ImprimirEspacios(int contador)//Imprime la cantidad de espacios en blanco
//        {
//            if (contador <= 0)
//            {
//                return; 
//            }

//            Console.Write(" "); // Imprimir un espacio en blanco
//            ImprimirEspacios(contador - 1); 
//        }

//        public static void ImprimirNumeros(int inicio, int final)//Imprime los números consecutivos
//        {
//            if (inicio > final)
//            {
//                return; 
//            }

//            Console.Write(inicio + " "); // Imprimir el número actual seguido de un espacio
//            ImprimirNumeros(inicio + 1, final); // Llamada recursiva para imprimir el siguiente número
//        }
//    }
//}






//5) Ejercicio 5: Escribe una función recursiva que imprima la tabla de multiplicar del n. 
//using System;
//namespace RecursiMutltiplicar
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Console.WriteLine("===TABLA DE MULTIPLICAR==");
//            int n = 12;// Definir el número para el cual se imprimirá la tabla de multiplicar
//            ImprimirTablaMultiplicar(n, 1); 
//            Console.ReadKey();
//        }

//        public static void ImprimirTablaMultiplicar(int n, int multiplicador)
//        {
//            if (multiplicador > 10)
//            {
//                return; // Caso base: detener la recursión cuando se han impreso todas las filas (del 1 al 10)
//            }

//            int resultado = n * multiplicador;
//            Console.WriteLine($"{n} x {multiplicador} = {resultado}");
//            ImprimirTablaMultiplicar(n, multiplicador + 1);
//        }
//    }
//}

//Arreglos y Matrices: 
//6) Crea una matriz de números reales. 

//using System;

//namespace MatrizNumerosReales
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Declarar variable
//            Console.WriteLine("Ingrese el número de filas y columnas de la matriz (separados por un espacio):");
//            string input = Console.ReadLine();
//            string[] dimensions = input.Split(' ');


//            int rows = int.Parse(dimensions[0]);
//            int cols = int.Parse(dimensions[1]);


//            double[,] matrix = new double[rows, cols];

//            //Resolver
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write($"Ingrese el elemento de la matriz ({i}, {j}): ");
//                    string elementInput = Console.ReadLine();

//                    if (double.TryParse(elementInput, out double value))
//                    {
//                        matrix[i, j] = value;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Error al ingresar el valor. Intente de nuevo.");
//                        j--; 
//                    }
//                }
//            }
//            // Imprime la matriz ingresada por el usuario
//            Console.WriteLine("Matriz ingresada:");
//            ImprimirMatriz(matrix);
//        }
//        // Función para imprimir una matriz de números reales
//        static void ImprimirMatriz(double[,] matrix)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);

//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write($"{matrix[i, j]} \t");
//                }
//                Console.WriteLine();
//            }
//        }

//    }
//}




//7) Crea una matriz de números complejos. 





//8) Crea una matriz de matrices. 

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("== Matriz de Matrices ==");//Declarar variables
//        Console.Write("Ingrese el número de filas: ");
//        int filas = int.Parse(Console.ReadLine());

//        Console.Write("Ingrese el número de columnas: ");
//        int columnas = int.Parse(Console.ReadLine());

//        int[][][] matrizDeMatrices = new int[filas][][];


//        for (int i = 0; i < filas; i++)
//        {
//            matrizDeMatrices[i] = new int[columnas][];
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write($"Ingrese el número de elementos para la matriz en la posición [{i},{j}]: ");
//                int numElementos = int.Parse(Console.ReadLine());

//                matrizDeMatrices[i][j] = new int[numElementos];
//                Console.WriteLine($"Ingrese los {numElementos} elementos para la matriz en la posición [{i},{j}]:");
//                for (int k = 0; k < numElementos; k++)
//                {
//                    Console.Write($"Elemento {k + 1}: ");
//                    matrizDeMatrices[i][j][k] = int.Parse(Console.ReadLine());
//                }
//            }
//        }

//        Console.WriteLine("\nMatriz de Matrices ingresada:");

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write($"[{i},{j}]: ");
//                MostrarMatriz(matrizDeMatrices[i][j]);
//                Console.WriteLine();
//                Console.WriteLine();

//                Console.ReadKey();
//            }
//            // Método para mostrar una matriz (array)
//            static void MostrarMatriz(int[] matriz)
//            {
//                Console.Write("[");
//                for (int i = 0; i < matriz.Length; i++)
//                {
//                    Console.Write(matriz[i]);
//                    if (i < matriz.Length - 1)
//                    {
//                        Console.Write(", ");
//                    }
//                }
//                Console.Write("]");

//            }
//        }
//    }
//}

//9) Accede al elemento central de una matriz. 
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese el número de filas de la matriz:");
//        int filas;
//        while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
//        {
//            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo para las filas:");
//        }

//        Console.WriteLine("Ingrese el número de columnas de la matriz:");
//        int columnas;
//        while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
//        {
//            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo para las columnas:");
//        }

//        int[,] matriz = new int[filas, columnas];
//        int contador = 1;

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                matriz[i, j] = contador;
//                contador++;
//            }
//        }

//        // Calcular el elemento central de la matriz
//        int indiceFilaCentral = filas / 2;
//        int indiceColumnaCentral = columnas / 2;
//        int elementoCentral = matriz[indiceFilaCentral, indiceColumnaCentral];

//        Console.WriteLine($"El elemento central de la matriz es: {elementoCentral}");
//        Console.WriteLine("Matriz:");

//        // Imprimir la matriz
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}



//10) Suma dos matrices de diferentes tamaños. 

//using System;

//namespace MatrixSum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ingrese el número de f1 de la primera matriz: ");
//            int filas1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese el número de c1 de la primera matriz: ");
//            int columnas1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Ingrese el número de f2 de la segunda matriz: ");
//            int filas2 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese el número de c2 de la segunda matriz: ");
//            int columnas2 = int.Parse(Console.ReadLine());

//            // Resolver
//            if (columnas1 != filas2)
//            {
//                Console.WriteLine("No se puede sumar las matrices porque tienen diferentes dimensiones!!!");
//                return;
//            }

//            int[,] matriz1 = new int[filas1, columnas1];
//            Console.WriteLine("Ingrese los elementos de la primera matriz:");
//            for (int i = 0; i < filas1; i++)
//            {
//                string[] input = Console.ReadLine().Split(' ');
//                for (int j = 0; j < columnas1; j++)
//                {
//                    matriz1[i, j] = int.Parse(input[j]);
//                }
//            }

//            int[,] matriz2 = new int[filas2, columnas2];
//            Console.WriteLine("Ingrese los elementos de la segunda matriz:");
//            for (int i = 0; i < filas2; i++)
//            {
//                string[] input = Console.ReadLine().Split(' ');
//                for (int j = 0; j < columnas2; j++)
//                {
//                    matriz2[i, j] = int.Parse(input[j]);
//                }
//            }

//            int[,] sumMatrix = new int[filas1, columnas2];
//            for (int i = 0; i < filas1; i++)
//            {
//                for (int j = 0; j < columnas2; j++)
//                {
//                    sumMatrix[i, j] = matriz1[i, j] + matriz2[i, j];
//                }
//            }

//            Console.WriteLine("La suma de las matrices es:");
//            for (int i = 0; i < filas1; i++)
//            {
//                for (int j = 0; j < columnas2; j++)
//                {
//                    Console.Write(sumMatrix[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}



//11) Multiplica una matriz por un número. 
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese las dimensiones de la matriz:");//Declarar variables
//        Console.Write("Número de filas: ");
//        int filas = int.Parse(Console.ReadLine());
//        Console.Write("Número de columnas: ");
//        int columnas = int.Parse(Console.ReadLine());

//        Console.WriteLine("Ingrese los elementos de la matriz:");
//        int[,] matriz = LeerMatriz(filas, columnas);

//        Console.Write("Ingrese el número escalar para multiplicar la matriz: ");
//        int escalar = int.Parse(Console.ReadLine());

//        int[,] resultado = MultiplicarMatrizPorEscalar(matriz, filas, columnas, escalar);

//        Console.WriteLine($"La matriz resultante de multiplicar por {escalar} es:");
//        MostrarMatriz(resultado, filas, columnas);

//        Console.ReadKey();
//    }

//    static int[,] LeerMatriz(int filas, int columnas)//INGRESA LOS NÚMEROS POR CONSOLA
//    {
//        int[,] matriz = new int[filas, columnas];

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write($"Elemento [{i},{j}]: ");
//                matriz[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        return matriz;
//    }

//    static int[,] MultiplicarMatrizPorEscalar(int[,] matriz, int filas, int columnas, int escalar)//MULTPLICA LA MATRIZ CON EL NÚMERO ESCALAR
//    {
//        int[,] resultado = new int[filas, columnas];

//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                resultado[i, j] = matriz[i, j] * escalar;
//            }
//        }

//        return resultado;
//    }

//    static void MostrarMatriz(int[,] matriz, int filas, int columnas)//IMPRIME LA MATRIZ
//    {
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}



////12) Calcula la media de los elementos de una matriz.
//using System;

//namespace Matriz
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] matriz = new int[3, 3] { { 10, 20, 35 }, { 14, 15, 6 }, { 7, 18, 9 } };
//            double media = CalcularMedia(matriz);
//            Console.WriteLine($"La media de los elementos de la matriz es: {media}");
//        }

//        static double CalcularMedia(int[,] matriz)
//        {
//            int suma = 0;
//            int total = matriz.Length;

//            for (int i = 0; i < matriz.GetLength(0); i++)
//            {
//                for (int j = 0; j < matriz.GetLength(1); j++)
//                {
//                    suma += matriz[i, j];
//                }
//            }

//            return (double)suma / total;
//        }
//    }
//}






//Ejercicio Matrices: 

//Ejercicio 1: 
//Crea una matriz de números aleatorios de tamaño 10x10.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Tamaño de la matriz
//        int filas = 10;
//        int columnas = 10;

//        // Crear una instancia de Random para generar números aleatorios
//        Random random = new Random();

//        // Crear una matriz de tamaño 10x10 para almacenar números aleatorios
//        int[,] matriz = new int[filas, columnas];

//        // Llenar la matriz con números aleatorios
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                matriz[i, j] = random.Next(1, 20); // Genera un número aleatorio entre 1 y 100
//            }
//        }

//        // Mostrar la matriz en la consola
//        Console.WriteLine("Matriz de números aleatorios de tamaño 10x10:");
//        MostrarMatriz(matriz, filas, columnas);
//    }

//    static void MostrarMatriz(int[,] matriz, int filas, int columnas)
//    {
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//Ejercicio 2: 
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 

//using System;

//namespace Matriz
//{
//    class Program
//    {
//        private static double contador;

//        static void Main(string[] args)
//        {
//            // Declara variables
//            Console.WriteLine("Ingrese el número de filas y columnas de la matriz (separados por un espacio):");
//            string input = Console.ReadLine();
//            string[] dimensions = input.Split(' ');
//            int filas = int.Parse(dimensions[0]);
//            int columnas = int.Parse(dimensions[1]);

//            int[,] matriz = new int[filas, columnas];

//            //Resolver
//            for (int i = 0; i < filas; i++)
//            {
//                for (int j = 0; j < columnas; j++)
//                {
//                    Console.Write("Ingrese el elemento de la matriz ({0}, {1}): ", i, j);
//                    matriz[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            // Variables
//            double media = CalcularMedia(matriz);
//            int mediana = CalcularMediana(matriz);
//            double desviacionEstandar = CalcularDesviacionEstandar(matriz, media);

//            // Imprime
//            Console.WriteLine("Media de la matriz: " + media);
//            Console.WriteLine(" Mediana de la matriz: " + mediana);
//            Console.WriteLine(" Desviación estándar de la matriz: " + desviacionEstandar);
//        }

//        //  Calcula la media de los elementos de la matriz
//        static double CalcularMedia(int[,] matriz)
//        {
//            int sum = 0;
//            int contador = matriz.GetLength(0) * matriz.GetLength(1);

//            foreach (int num in matriz)
//            {
//                sum += num;
//            }

//            return (double)sum / contador;
//        }

//        // Calcula la mediana de los elementos de la matriz
//        static int CalcularMediana(int[,] matrix)
//        {
//            // Crear una lista para almacenar todos los elementos de la matriz
//            List<int> elementos = new List<int>();

//            foreach (int num in matrix)
//            {
//                elementos.Add(num);
//            }

//            // Ordenar la lista de elementos
//            elementos.Sort();

//            int n = elementos.Count;
//            if (n % 2 == 1)
//            {
//                return elementos[n / 2];
//            }
//            else
//            {
//                return (elementos[n / 2 - 1] + elementos[n / 2]) / 2;
//            }
//        }

//        //Calcula la desviación estándar de los elementos de la matriz
//        static double CalcularDesviacionEstandar(int[,] matriz, double media)
//        {
//            int count = matriz.GetLength(0) * matriz.GetLength(1);
//            double sumOfSquares = 0;

//            foreach (int num in matriz)
//            {
//                sumOfSquares += Math.Pow(num - media, 2);
//            }

//            double variance = sumOfSquares / contador;
//            return Math.Sqrt(variance);
//        }
//    }
//}


//Ejercicio 3: 


//using System;


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Declarar matriz
//            Console.WriteLine("Ingrese el número de filas y columnas de la matriz (separados por un espacio):");
//            string input = Console.ReadLine();
//            string[] dimensions = input.Split(' ');
//            int filas = int.Parse(dimensions[0]);
//            int columnas = int.Parse(dimensions[1]);

//            int[,] matrix = new int[filas, columnas];

//            // Resolver
//            for (int i = 0; i < filas; i++)
//            {
//                for (int j = 0; j < columnas; j++)
//                {
//                    Console.Write("Ingrese el elemento de la matriz ({0}, {1}):", i, j);
//                    matrix[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            // Sirve el max para el valor máximo
//            int max = FindMax(matrix);
//            Console.WriteLine("El máximo elemento de la matriz es: " + max);
//        }

//        //  el máximo elemento de una matriz dada
//        static int FindMax(int[,] matrix)
//        {
//            int max = matrix[0, 0];
//            for (int i = 0; i < matrix.GetLength(0); i++)
//            {
//                for (int j = 0; j < matrix.GetLength(1); j++)
//                {
//                    // Si el elemento actual es mayor que el máximo actual, actualiza el máximo
//                    if (matrix[i, j] > max)
//                    {
//                        max = matrix[i, j];
//                    }
//                }
//            }
//            return max;
//        }
//}

//Ejercicio 4: 
//Escribe una función que encuentre la sub matriz de mayor suma de una matriz. 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = {
//            { 1, 2, -1, -4, -20 },
//            { -8, -3, 4, 2, 1 },
//            { 3, 8, 10, 1, 3 },
//            { -4, -1, 1, 7, -6 }
//        };

//        int[,] maxSubmatrix = FindMaximumSumSubmatrix(matrix);
//        PrintMatrix(maxSubmatrix);
//    }

//    static int[,] FindMaximumSumSubmatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        int maxSum = int.MinValue;
//        int top = 0, bottom = 0, left = 0, right = 0;

//        for (int t = 0; t < rows; t++)
//        {
//            int[] temp = new int[cols];

//            for (int b = t; b < rows; b++)
//            {
//                for (int i = 0; i < cols; i++)
//                {
//                    temp[i] += matrix[b, i];
//                }

//                var (sum, start, end) = KadaneAlgorithm(temp);

//                if (sum > maxSum)
//                {
//                    maxSum = sum;
//                    top = t;
//                    bottom = b;
//                    left = start;
//                    right = end;
//                }
//            }
//        }

//        return ConstructSubmatrix(matrix, top, bottom, left, right);
//    }

//    static (int, int, int) KadaneAlgorithm(int[] array)
//    {
//        int maxEndingHere = array[0];
//        int maxSoFar = array[0];
//        int startIndex = 0;
//        int endIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (maxEndingHere + array[i] < array[i])
//            {
//                maxEndingHere = array[i];
//                startIndex = i;
//            }
//            else
//            {
//                maxEndingHere += array[i];
//            }

//            if (maxEndingHere > maxSoFar)
//            {
//                maxSoFar = maxEndingHere;
//                endIndex = i;
//            }
//        }

//        return (maxSoFar, startIndex, endIndex);
//    }

//    static int[,] ConstructSubmatrix(int[,] matrix, int top, int bottom, int left, int right)
//    {
//        int submatrixRows = bottom - top + 1;
//        int submatrixCols = right - left + 1;
//        int[,] submatrix = new int[submatrixRows, submatrixCols];

//        for (int i = top; i <= bottom; i++)
//        {
//            for (int j = left; j <= right; j++)
//            {
//                submatrix[i - top, j - left] = matrix[i, j];
//            }
//        }

//        return submatrix;
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        Console.WriteLine("Submatriz de mayor suma:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//Ejercicio 5: 
//Escribe una función que encuentre la matriz de covarianza de dos matrices.

//using System;

//namespace Matriz
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] X = { { 10, 20, 3 }, { 14, 5, 6 }, { 17, 8, 9 } };
//            int[,] Y = { { 9, 8, 7 }, { 6, 5, 14 }, { 3, 2, 1 } };

//            double[,] covXY = CalcularMatrizCovarianza(X, Y);

//            Console.WriteLine("Matriz de Covarianza entre X y Y:");
//            MostrarMatriz(covXY);
//        }

//        // calcula  la matriz de covarianza entre dos matrices X y Y
//        static double[,] CalcularMatrizCovarianza(int[,] X, int[,] Y)
//        {
//            int m = X.GetLength(0); 
//            int n = X.GetLength(1); 

//            double[] meanX = CalcularMediaPorColumna(X);
//            double[] meanY = CalcularMediaPorColumna(Y);

//            // Inicializar la matriz de covarianza
//            double[,] covXY = new double[n, n];

//            // Resolver
//            for (int j = 0; j < n; j++)
//            {
//                for (int k = 0; k < n; k++)
//                {
//                    double sum = 0;

//                    for (int i = 0; i < m; i++)
//                    {
//                        sum += (X[i, j] - meanX[j]) * (Y[i, k] - meanY[k]);
//                    }

//                    covXY[j, k] = sum / m;
//                }
//            }

//            return covXY;
//        }

//        // calcula la media por columna de una matriz
//        static double[] CalcularMediaPorColumna(int[,] matrix)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);
//            double[] mean = new double[cols];

//            for (int j = 0; j < cols; j++)
//            {
//                double sum = 0;

//                for (int i = 0; i < rows; i++)
//                {
//                    sum += matrix[i, j];
//                }

//                mean[j] = sum / rows;
//            }

//            return mean;
//        }

//        static void MostrarMatriz(double[,] matriz)//Imprime la matriz
//        {
//            int filas = matriz.GetLength(0);
//            int columnas = matriz.GetLength(1);

//            for (int i = 0; i < filas; i++)
//            {
//                for (int j = 0; j < columnas; j++)
//                {
//                    Console.Write(matriz[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
