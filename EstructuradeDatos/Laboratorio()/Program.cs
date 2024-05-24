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



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingrese el ancho del rectángulo: ");
//        int ancho = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Ingrese el largo del rectángulo: ");
//        int largo = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < largo; i++)
//        {
//            for (int j = 0; j < ancho; j++)
//            {
//                Console.Write("* ");
//            }
//            Console.WriteLine();
//        }
//    }
//}



using System;

public class Arquitecto
{
    public string Codigo { get; set; }
    public string Nombres { get; set; }
    public string CondicionContrato { get; set; }
    public string Especialidad { get; set; }
    public string TipoActividad { get; set; }
    public string TipoAfiliacion { get; set; }
    public double SueldoBase { get; set; }
    public double Bonificacion { get; set; }
    public double Descuento { get; set; }
    public double SueldoBruto { get; set; }
    public double SueldoNeto { get; set; }

    public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
    {
        Codigo = codigo;
        Nombres = nombres;
        CondicionContrato = condicionContrato;
        Especialidad = especialidad;
        TipoActividad = tipoActividad;
        TipoAfiliacion = tipoAfiliacion;
        SueldoBase = CalcularSueldoBase();
        Bonificacion = CalcularBonificacion();
        SueldoBruto = SueldoBase + Bonificacion;
        Descuento = CalcularDescuento();
        SueldoNeto = SueldoBruto - Descuento;
    }

    private double CalcularSueldoBase()
    {
        double sueldoBase = 0;
        if (CondicionContrato == "Estable")
        {
            if (TipoActividad == "Supervisión de Obras")
            {
                sueldoBase = 4000;
            }
            else if (TipoActividad == "Supervisión de Vías")
            {
                sueldoBase = 6000;
            }
        }
        else if (CondicionContrato == "Contratado")
        {
            if (TipoActividad == "Supervisión de Obras")
            {
                sueldoBase = 2000;
            }
            else if (TipoActividad == "Supervisión de Vías")
            {
                sueldoBase = 4500;
            }
        }
        return sueldoBase;
    }

    private double CalcularBonificacion()
    {
        double porcentajeBonificacion = 0;
        if (Especialidad == "Estructuras")
        {
            porcentajeBonificacion = 0.16;
        }
        else if (Especialidad == "Recursos Hídricos")
        {
            porcentajeBonificacion = 0.18;
        }
        return SueldoBase * porcentajeBonificacion;
    }

    private double CalcularDescuento()
    {
        double porcentajeDescuento = TipoAfiliacion == "AFP" ? 0.15 : 0.08;
        return SueldoBruto * porcentajeDescuento;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Condición de Contrato: {CondicionContrato}");
        Console.WriteLine($"Especialidad: {Especialidad}");
        Console.WriteLine($"Tipo de Actividad: {TipoActividad}");
        Console.WriteLine($"Tipo de Afiliación: {TipoAfiliacion}");
        Console.WriteLine($"Sueldo Base: {SueldoBase}");
        Console.WriteLine($"Bonificación: {Bonificacion}");
        Console.WriteLine($"Descuento: {Descuento}");
        Console.WriteLine($"Sueldo Bruto: {SueldoBruto}");
        Console.WriteLine($"Sueldo Neto: {SueldoNeto}");
    }
}

// Ejemplo de uso
public class Program
{
    public static void Main()
    {
        Arquitecto arquitecto1 = new Arquitecto(
            "A001",
            "Juan Perez",
            "Estable",
            "Estructuras",
            "Supervisión de Obras",
            "AFP"
        );

        arquitecto1.MostrarInformacion();
    }
}