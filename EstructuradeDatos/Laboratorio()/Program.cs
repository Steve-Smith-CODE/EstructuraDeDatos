//using System;

//class Program
//{
//    static void Main()
//    {
//        int tamaño = 20;
//        for (int i = 0; i < tamaño; i++)
//        {
//            for (int j = 0; j < tamaño - i - 1; j++)
//            {
//                Console.Write(" ");
//            }
//            for (int k = 0; k < 2 * i + 1; k++)
//            {
//                Console.Write("g");
//            }
//            Console.WriteLine();
//        }

//        for (int i = tamaño - 2; i >= 0; i--)
//        {
//            for (int j = 0; j < tamaño - i - 1; j++)
//            {
//                Console.Write(" ");
//            }
//            for (int k = 0; k < 2 * i + 1; k++)
//            {
//                Console.Write("g");
//            }
//            Console.WriteLine();
//        }
//    }
//}



using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el ancho del rectángulo: ");
        int ancho = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el largo del rectángulo: ");
        int largo = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < largo; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}