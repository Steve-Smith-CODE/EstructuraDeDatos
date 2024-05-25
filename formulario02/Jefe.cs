using System;

public class Jefe
{
    // Atributos
    public string Nombres { get; set; }
    public string DNI { get; set; }
    public string Cargo { get; set; }
    public string Area { get; set; }
    public string AñosAntiguedad { get; set; }

    // Constructor
    public Jefe(string nombres, string dni, string cargo, string area, string añosAntiguedad)
    {
        Nombres = nombres;
        DNI = dni;
        Cargo = cargo;
        Area = area;
        AñosAntiguedad = añosAntiguedad;
    }

    public decimal CalcularSueldoBase()
    {
        if (Cargo == "Gerente")
        {
            if (Area == "Contabilidad") return 6000;
            if (Area == "Planificación") return 7000;
        }
        else if (Cargo == "Subgerente")
        {
            if (Area == "Contabilidad") return 5000;
            if (Area == "Planificación") return 6000;
        }

        throw new Exception("Cargo o área no válidos");
    }

    public decimal CalcularMovilidad()
    {
        if (Cargo == "Gerente") return 700;
        if (Cargo == "Subgerente") return 400;

        throw new Exception("Cargo no válido");
    }

    public decimal CalcularBonificacion()
    {
        decimal sueldoBase = CalcularSueldoBase();

        if (int.Parse(AñosAntiguedad) <= 7) return sueldoBase * 0.05m;
        if (int.Parse(AñosAntiguedad) >= 8) return sueldoBase * 0.04m;

        throw new Exception("Años de antigüedad no válidos");
    }

    public decimal CalcularSueldoFinal()
    {
        decimal sueldoBase = CalcularSueldoBase();
        decimal bonificacion = CalcularBonificacion();
        decimal movilidad = CalcularMovilidad();

        return sueldoBase + bonificacion + movilidad;
    }

    // Método para mostrar la información del Jefe
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"DNI: {DNI}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Área: {Area}");
        Console.WriteLine($"Años de Antigüedad: {AñosAntiguedad}");
        Console.WriteLine($"Sueldo Base: {CalcularSueldoBase()}");
        Console.WriteLine($"Bonificación: {CalcularBonificacion()}");
        Console.WriteLine($"Movilidad: {CalcularMovilidad()}");
        Console.WriteLine($"Sueldo Final: {CalcularSueldoFinal()}");
    }
}