////Pregunta-01: Pedir de un rombo para que me imprima en la pantalla un rombo
////DECLARAR VARIABLES
//Console.WriteLine("Ingrese el lado del número:");
//int tamaño = int.Parse(Console.ReadLine());
////Resolver
//for (int i = 0; i < tamaño; i++)
//{
//    for (int j = 0; j < tamaño - i - 1; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 0; k < 2 * i + 1; k++)
//    {
//        Console.Write("0");
//    }
//    Console.WriteLine();
//}

//for (int i = tamaño - 2; i >= 0; i--)
//{
//    for (int j = 0; j < tamaño - i - 1; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 0; k < 2 * i + 1; k++)
//    {
//        Console.Write("0");
//    }
//    Console.WriteLine();
//}


////Pregunta-02: Pedir la creación de una matriz de 4Dimensiones y realizar la suma y promedio.








////Pregunta-03: Crear un programa para ingresar un número y hacer su equivalencia en letras

//Declarar variables
//Console.WriteLine("===Programa para convertir un número a letra===");
//Console.WriteLine("Ingrese un número entero y positivo: ");
//int numero = int.Parse(Console.ReadLine());

//string equivalencia = ObtenerEquivalenciaEnLetras(numero);
//Console.WriteLine($"El número {numero} se escribe como: {equivalencia}");
////Resolver
//static string ObtenerEquivalenciaEnLetras(int numero)
//{
//    string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
//    string[] decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
//    string[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

//    if (numero < 10)
//    {
//        return unidades[numero];
//    }
//    else if (numero < 100)
//    {
//        int unidad = numero % 10;
//        int decena = numero / 10;
//        return $"{decenas[decena]} {unidades[unidad]}";
//    }
//    else if (numero < 1000)
//    {
//        int unidad = numero % 10;
//        int decena = (numero / 10) % 10;
//        int centena = numero / 100;
//        return $"{centenas[centena]} {decenas[decena]} y {unidades[unidad]}";
//    }
//    else
//    {
//        return "Número fuera de rango (debe ser entre 1 y 999)";
//    }
//}



////Pregunta-04: Realizar un programa de pedidos de platos donde el usuario realice por la consola el plato y me vote el costo de lo pedid

////Declarar variables
//Console.WriteLine("Bienvenido");
//Console.WriteLine("==Restaurante El Buen Paladar==");
//Console.WriteLine("A continuación presentamos nuestros platos:");
//Console.WriteLine("Chaufa = 8 soles");
//Console.WriteLine("Lomo = 10 soles");
//Console.WriteLine("Arroz con Pollo = 12 soles");
//Console.WriteLine("Chicharrón = 15 soles");
//decimal chaufa = 8;
//decimal lomo = 10;
//decimal arrozConPollo = 12;
//decimal chicharron = 15;

//int cantidadPlatos = 0;
//decimal costoTotal = 0;

//Resolver
//while (true)
//{
//    Console.WriteLine("Elija un plato (1: Chaufa, 2: Lomo, 3: Arroz con Pollo, 4: Chicharrón, 0: Finalizar pedido):");
//    int opcion = int.Parse(Console.ReadLine());

//    if (opcion == 0)
//        break;

//    decimal costoPlato = 0;
//    switch (opcion)
//    {
//        case 1:
//            costoPlato = chaufa;
//            break;
//        case 2:
//            costoPlato = lomo;
//            break;
//        case 3:
//            costoPlato = arrozConPollo;
//            break;
//        case 4:
//            costoPlato = chicharron;
//            break;
//        default:
//            Console.WriteLine("Opción inválida. Por favor, seleccione un plato válido.");
//            continue;
//    }

//    Console.WriteLine($"Agregado al pedido: {costoPlato} soles");
//    cantidadPlatos++;
//    costoTotal += costoPlato;
//}
//Imprimir solución
//Console.WriteLine($"Total del pedido ({cantidadPlatos} platos): {costoTotal} soles");



