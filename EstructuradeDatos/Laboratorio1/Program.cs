//Console.WriteLine("===Calcular el cociente entero de dos enteros positivos===");

//// Declarar variables
//Console.Write("Ingrese el dividendo: ");
//int dividendo = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el divisor: ");
//int divisor = int.Parse(Console.ReadLine());

//int cuenta = 0;
//int resto = dividendo;

//// Resolver
//for (; resto >= divisor; resto -= divisor)
//{
//    cuenta++;
//}

//int cociente = cuenta;
//int resto_final = resto;

//// Mostrar resultados
//Console.WriteLine($"Dividendo: {dividendo}");
//Console.WriteLine($"Divisor: {divisor}");
//Console.WriteLine($"Cociente: {cociente}");
//Console.WriteLine($"Resto: {resto_final}");
//Console.ReadLine();





//Console.WriteLine("Calcular el producto de dos enteros negativos * e");
////Declarar variable
//Console.Write("Ingrese el Multiplicando: ");
//int multiplicando = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese el Multiplicador: ");
//int multiplicador = int.Parse(Console.ReadLine());
//int producto = 0;
//bool multiplicandoNegativo = multiplicando < 0;
//bool multiplicadorNegativo = multiplicador < 0;
//multiplicando = Math.Abs(multiplicando);
//multiplicador = Math.Abs(multiplicador);

////Resolver
//for (int i = 0; i < multiplicando; i++)
//{
//    producto += multiplicador;
//}
//if ((multiplicandoNegativo && !multiplicadorNegativo) || (!multiplicandoNegativo && multiplicadorNegativo))
//{
//    producto = -producto;
//}
//Console.WriteLine($"Producto: {producto}");
//Console.ReadKey();

var decimales = new double[3] { 1.2, 2.5, 2.8 };
var sumad = sumaDecimales(decimales);
Console.WriteLine(sumad.ToString());

double sumaDecimales(double[] w)
{
    double s = 0.0;
    for (int i = 0; i < w.Length; i++)
        s += w[i];
    return s;
}

