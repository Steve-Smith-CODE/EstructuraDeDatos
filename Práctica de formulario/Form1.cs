using System;
using System.Windows.Forms;

namespace Práctica_de_formulario
{
    public partial class Form1 : Form
    {
        Arquitecto arquitecto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboContrato.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            cboSupervision.SelectedIndex = 0;
            cboAfiliacion.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicionContrato = cboContrato.Text;
            string especialidad = cboEspecialidad.Text;
            string tipoSupervision = cboSupervision.Text;
            string tipoAfiliacion = cboAfiliacion.Text;

            decimal sueldoBase;

            if (!decimal.TryParse(txtSueldo.Text, out sueldoBase))
            {
                MessageBox.Show("Ingrese un valor válido para el sueldo base.");
                return;
            }

            arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoSupervision, tipoAfiliacion, sueldoBase);
            MessageBox.Show("Objeto Arquitecto Creado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (arquitecto == null)
            {
                MessageBox.Show("Primero debe crear un objeto Arquitecto.");
                return;
            }

            txtResultado.AppendText("Código: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + arquitecto.Nombres + Environment.NewLine);
            txtResultado.AppendText("Condición de Contrato: " + arquitecto.CondicionContrato + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Supervisión: " + arquitecto.TipoSupervision + Environment.NewLine);
            txtResultado.AppendText("Monto Descuento: " + arquitecto.Descuento.ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + arquitecto.SueldoBruto().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + arquitecto.SueldoNeto().ToString("C") + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtResultado.Text = "";
            txtSueldo.Text = "";

            cboContrato.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            cboSupervision.SelectedIndex = 0;
            cboAfiliacion.SelectedIndex = 0;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
