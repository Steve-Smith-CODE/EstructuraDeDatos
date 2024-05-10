

//int f = Factorial(5);
//Console.WriteLine("El factorial de 5 es " + f);
//Console.ReadKey();
//// esta la función permite calcular factorial en forma recursiva
//int Factorial(int fact)
//{
//    if (fact > 0) //evalua si el número es mayor a cero
//    {
//        int valor = fact * Factorial(fact - 1);
//        return valor;
//    }
//    else
//        return 1;
//}


//int Fibonacci(int n)
//{
//    if ((n == 0) || (n == 1))
//    {
//        return n;
//    }
//    else
//    {
//        return Fibonacci(n - 1) + Fibonacci(n - 2);
//    }
//}
//Console.Write("ESCRIBA LA CANTIDAD DE LOS NUMEROS DE FIBONACCI QUE DESEA IMPRIMIR:");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 2; i <= n + 1; i++)
//{
//    Console.WriteLine(Fibonacci(i));
//}


//Console.Write("Ingrese tamaño del array : ");
//int n = int.Parse(Console.ReadLine());
//int[] m = new int[n];
//Console.WriteLine("Ingrese elementos : ");
//bool multiplo = false; int temp = 0;
//for (int i = 0; i < m.Length; i++)
//{
//    multiplo = false;
//    while (multiplo == false)
//    {
//        Console.Write("Ingrese elemento [" + i + "] : ");
//        temp = int.Parse(Console.ReadLine());
//        if (temp % 5 == 0)
//        { m[i] = temp; multiplo = true; }
//        else
//        { Console.WriteLine(temp + " no es múltiplo de 5"); }
//    }
//}
//Console.WriteLine("Los elementos del array son :");
//foreach (int i in m)//Recorrer arreglos y colecciones
//{ Console.Write(i + " "); }
//Console.ReadLine();

////2.Crear un array que permita ingresar 20 números enteros, calcular la suma de todos los elementos y la media aritmética.
//double[] m = new double[20];
//Console.WriteLine("Ingrese elementos : ");
//double temp = 0;
//for (int i = 0; i < m.Length; i++)
//{
//    Console.Write("Ingrese elemento [" + i + "] : ");
//    m[i] = double.Parse(Console.ReadLine());
//    temp += m[i];
//}
//Console.WriteLine("La suma de elementos es : " + temp);
//Console.WriteLine("El media aritmética es : " + (temp / 20));
//Console.ReadLine();




////Declarar variables
//Console.Write("Ingrese los elementos: ");
//int n =int.Parse(Console.ReadLine());
//int[] m = new int[n];
//int temp = 0;
////Resolver
//for (int i  = 0; i< n; i ++)
//{
//    Console.WriteLine("Ingrese elemento[" + i + "]: ");
//    m[i] = int.Parse (Console.ReadLine());
//    temp += m[i];

//}
////Mostrar resultados
//Console.WriteLine("La suma de elementos es : " + temp);
//Console.WriteLine("La cantidad de elementos es : " + n);
//Console.ReadLine() ;


//Console.Write("Ingrese el tamaño del Array: ");
//int n = int.Parse(Console.ReadLine());
//int[] m = new int[n];
//Console.WriteLine("Ingrese elementos: ");
//int total = 0; // declare total as an integer
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Ingrese elemento[" + i + "]: ");
//    m[i] = int.Parse(Console.ReadLine());
//    total += m[i];
//}

//Console.WriteLine("La suma de los elementos es: " + total);
//Console.WriteLine("La cantidad de elementos son: " + n);
//foreach (int i in m)
//{
//    Console.WriteLine(i);
//}


//Console.Write("Ingrese el tamaño del primer Array: ");
//int n = int.Parse(Console.ReadLine());
//int[] m = new int[n];
//Console.WriteLine("Ingrese elementos: ");
//int totalM = 0;
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Ingrese elemento[" + i + "]: ");
//    m[i] = int.Parse(Console.ReadLine());
//    totalM += m[i];
//}

//Console.Write("Ingrese el tamaño del segundo Array: ");
//int a = int.Parse(Console.ReadLine());
//int[] b = new int[a];
//Console.WriteLine("Ingrese elementos: ");
//int totalB = 0;
//for (int j = 0; j < a; j++)
//{
//    Console.Write("Ingrese elemento[" + j + "]: ");
//    b[j] = int.Parse(Console.ReadLine());
//    totalB += b[j];
//}

//int resolver_a = totalM + totalB;
//Console.WriteLine("La suma de la primer Array es: " + totalM);
//Console.WriteLine("La suma de los elementos del primer Array es: " + string.Join(" + ", m) + " = " + totalM);
//Console.WriteLine("La suma de la segundo Array es: " + totalB);
//Console.WriteLine("La suma de los elementos del segundo Array es: " + string.Join(" + ", b) + " = " + totalB);
//Console.WriteLine("La suma total de ambos arrays es: " + resolver_a);

//Console.WriteLine("Elementos del primer Array:");
//foreach (int i in m)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Elementos del segundo Array:");
//foreach (int i in b)
//{
//    Console.WriteLine(i);
//}
//Console.Write("Ingrese el primer arreglo (separado por espacios): ");
//string[] input1 = Console.ReadLine().Split(' ');
//int[] array1 = new int[input1.Length];
//for (int i = 0; i < input1.Length; i++)
//{
//    array1[i] = int.Parse(input1[i]);
//}

//Console.Write("Ingrese el segundo arreglo (separado por espacios): ");
//string[] input2 = Console.ReadLine().Split(' ');
//int[] array2 = new int[input2.Length];
//for (int i = 0; i < input2.Length; i++)
//{
//    array2[i] = int.Parse(input2[i]);
//}


//int[] sum = new int[array1.Length];
//for (int i = 0; i < array1.Length; i++)
//{
//    sum[i] = array1[i] + array2[i];
//}

//Console.WriteLine("La suma de los 2 arreglos es: ");
//foreach (int i in sum)
//{
//    Console.Write(i + " ");
//}









//Console.WriteLine("SUMA Y MULTIPLICACIÓN DE MATRICES");
//Console.WriteLine("\n");

////MATRIZZ [1]
//Console.WriteLine("➤ Matriz A");
//Console.WriteLine("Digite Nº de Filas: ");
//int f1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite Nº de Columnas: ");
//int c1 = int.Parse(Console.ReadLine());
//Console.WriteLine("\n");

////MATRIZZ [2]
//Console.WriteLine("➤ Matriz B");
//Console.WriteLine("Digite Nº de Filas: ");
//int f2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite Nº de Columnas: ");
//int c2 = int.Parse(Console.ReadLine());

////DECLARACION
////filas y columnas +1 para comenzar desde posición 1
//int[,] MatrizA = new int[f1 + 1, c1 + 1];
//int[,] MatrizB = new int[f2 + 1, c2 + 1];
//int[,] Multi = new int[f1 + 1, c2 + 1];
//int[,] Suma = new int[f1 + 1, c2 + 1];
//Console.WriteLine("\n");

////Llenar matriz A
//Console.WriteLine("Matriz A: ");
//for (int i = 1; i <= f1; i++)
//{
//    for (int j = 1; j <= c1; j++)
//    {
//        Console.WriteLine("Digite número 《 Fila: {0} - Columna: {1} 》: ", i, j);
//        MatrizA[i, j] = int.Parse(Console.ReadLine());
//    }
//}
//Console.WriteLine("\n");

////Llenar matriz B
//Console.WriteLine("Matriz B: ");
//for (int i = 1; i <= f2; i++)
//{
//    for (int j = 1; j <= c2; j++)
//    {
//        Console.WriteLine("Digite número 《 Fila: {0} - Columna: {1} 》: ", i, j);
//        MatrizB[i, j] = int.Parse(Console.ReadLine());
//    }
//}
//Console.WriteLine("\n");
////Condiciones 1 Suma 2 Multi
//Console.WriteLine("Elige una opción.");
//Console.WriteLine("1- Suma");
//Console.WriteLine("2- Multiplicación");
//Console.WriteLine("Seleccione una opción: ");

//switch (Console.Read())
//{
//    case '1':
//        Console.WriteLine("Suma...");
//        Console.WriteLine("\n");
//        //Si la matrices tiene el mismo tamaño, la misma cantidad de columnas y de filas.            
//        if (c1 == c2 && f1 == f2)
//        {
//            //Sumar
//            for (int i = 1; i <= f1; i++)
//            {
//                for (int j = 1; j <= c2; j++)
//                {
//                    Suma[i, j] = MatrizA[i, j] + MatrizB[i, j];//Operación
//                }
//            }

//            Console.WriteLine("La suma de las dos matriz es: ");
//            for (int i = 1; i <= f1; i++)
//            {
//                Console.Write("\n");
//                for (int j = 1; j <= c2; j++)
//                {
//                    Console.Write("{0}    ", Suma[i, j]); //Muestra la matriz resultante
//                }
//            }
//        }
//        //Si la matrices NO tiene el mismo tamaño, la misma cantidad de columnas y de filas. 
//        else
//        {
//            Console.WriteLine("Error: Para sumar matrices deben tener el mismo tamaño, la misma cantidad de columnas y de filas." + " Columnas: {0}! = Filas: {1}", c1, f2);
//        }
//        Console.WriteLine("\n");
//        Console.Read();
//        break;
//    case '2':
//        Console.WriteLine("Multiplicación...");
//        Console.WriteLine("\n");
//        //Si el número de columnas de la primera matriz debe coincidir con el número de filas de la segunda matriz.
//        if (c1 == f2)
//        {
//            //Multiplicando las 2 matrices 
//            for (int i = 1; i <= f1; i++)
//            {
//                for (int j = 1; j <= c2; j++)
//                {
//                    Multi[i, j] = 0;
//                    for (int x = 1; x <= c1; x++)
//                    {
//                        Multi[i, j] = MatrizA[i, x] * MatrizB[x, j] + Multi[i, j]; //Operación
//                    }
//                }
//            }

//            Console.WriteLine("\n");
//            Console.WriteLine("Multiplicación de matrices:");
//            Console.WriteLine("\n");
//            for (int i = 1; i <= f1; i++)
//            {
//                for (int j = 1; j <= c2; j++)
//                {
//                    Console.Write("{0}    ", Multi[i, j]); //Muestra la matriz resultante
//                }
//                Console.WriteLine();
//            }
//        }
//        //Si el número de columnas de la primera matriz NO coincide con el número de filas de la segunda matriz. 
//        else
//        {
//            Console.WriteLine("Error: Para multiplicar el número de columnas de la primera matriz debe coincidir con el número de filas de la segunda matriz." + " Columnas: {0}! = Filas: {1}", c1, f2);
//        }
//        Console.WriteLine("\n");
//        Console.Read();
//        break;
//}



