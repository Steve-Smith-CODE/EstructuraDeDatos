using System;

namespace Práctica_de_formulario
{
    public class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string CondicionContrato { get; set; }
        public string Especialidad { get; set; }
        public string TipoSupervision { get; set; }
        public string TipoAfiliacion { get; set; }

        private decimal sueldoBase; // Cambiado a privado para ser establecido manualmente
        private decimal bonificacion;
        private decimal descuento;

        public decimal Descuento { get { return descuento; } }
        public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoSupervision, string tipoAfiliacion, decimal sueldoBase)
        {
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoSupervision = tipoSupervision;
            TipoAfiliacion = tipoAfiliacion;
            this.sueldoBase = sueldoBase; // Asignar sueldo base ingresado manualmente
            CalcularBonificacion();
            CalcularDescuento();
        }

        public void CalcularBonificacion()
        {
            if (Especialidad == "Estructuras")
            {
                bonificacion = sueldoBase * 0.16m;
            }
            else if (Especialidad == "Recursos Hídricos")
            {
                bonificacion = sueldoBase * 0.18m;
            }
        }

        private void CalcularDescuento()
        {
            if (TipoAfiliacion == "AFP")
            {
                descuento = sueldoBase * 0.15m;
            }
            else if (TipoAfiliacion == "SNP")
            {
                descuento = sueldoBase * 0.08m;
            }
        }

        public decimal SueldoBruto()
        {
            return sueldoBase + bonificacion;
        }

        public decimal SueldoNeto()
        {
            return SueldoBruto() - descuento;
        }
    }
}
