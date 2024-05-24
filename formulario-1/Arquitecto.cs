using System;

namespace formulario_1
{
    public class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string CondicionContrato { get; set; }
        public string Especialidad { get; set; }
        public string TipoActividad { get; set; }
        public string TipoAfiliacion { get; set; }
        public double SueldoBase { get; private set; }
        public double Bonificacion { get; private set; }
        public double SueldoBruto { get; private set; }
        public double SueldoNeto { get; private set; }

        public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
        {
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;
            CalcularSalarios();
        }

        private void CalcularSalarios()
        {
            SueldoBase = CalcularSueldoBase();
            Bonificacion = CalcularBonificacion();
            SueldoBruto = SueldoBase + Bonificacion;
            SueldoNeto = CalcularSueldoNeto();
        }

        private double CalcularSueldoBase()
        {
            if (CondicionContrato == "Estable")
            {
                if (TipoActividad == "Supervisión de Obras")
                {
                    return 4000;
                }
                else if (TipoActividad == "Supervisión de Vías")
                {
                    return 6000;
                }
            }
            else if (CondicionContrato == "Contratado")
            {
                if (TipoActividad == "Supervisión de Obras")
                {
                    return 2000;
                }
                else if (TipoActividad == "Supervisión de Vías")
                {
                    return 4500;
                }
            }
            return 0;
        }

        private double CalcularBonificacion()
        {
            if (Especialidad == "Estructuras")
            {
                return SueldoBase * 0.16;
            }
            else if (Especialidad == "Recursos Hídricos")
            {
                return SueldoBase * 0.18;
            }
            return 0;
        }

        private double CalcularSueldoNeto()
        {
            double descuento = TipoAfiliacion == "AFP" ? 0.15 : 0.08;
            return SueldoBruto * (1 - descuento);
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
            Console.WriteLine($"Sueldo Bruto: {SueldoBruto}");
            Console.WriteLine($"Sueldo Neto: {SueldoNeto}");
        }
    }
}
