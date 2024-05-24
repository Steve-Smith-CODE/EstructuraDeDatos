using System;
using System.Windows.Forms;

namespace formulario_1
{
    public partial class Form1 : Form
    {
        private Arquitecto arquitecto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCondicion.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            cboActividad.SelectedIndex = 0;
            cboAfiliacion.SelectedIndex = 0;
        }



        private void CrearArquitecto()
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicionContrato = cboCondicion.Text;
            string especialidad = cboEspecialidad.Text;
            string tipoActividad = cboActividad.Text;
            string tipoAfiliacion = cboAfiliacion.Text;

            arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);
            MessageBox.Show("Objeto Creado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (arquitecto == null)
            {
                MessageBox.Show("Primero cree un objeto Arquitecto.");
                return;
            }

            MostrarInformacion();
        }

        private void MostrarInformacion()
        {
            txtResultado.Clear();
            txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + arquitecto.Nombres + Environment.NewLine);
            txtResultado.AppendText("Condicion de Contrato: " + arquitecto.CondicionContrato + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Actividad: " + arquitecto.TipoActividad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Afiliacion: " + arquitecto.TipoAfiliacion + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + arquitecto.SueldoBase + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + arquitecto.Bonificacion + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + arquitecto.SueldoBruto + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + arquitecto.SueldoNeto + Environment.NewLine);
        }



        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtResultado.Clear();
            cboCondicion.SelectedIndex = -1;
            cboEspecialidad.SelectedIndex = -1;
            cboActividad.SelectedIndex = -1;
            cboAfiliacion.SelectedIndex = -1;
            txtCodigo.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            //para crear obejto
            CrearArquitecto();


        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            //Mostrar informacion 

            MostrarInformacion();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            //Para borrar el formulario
            LimpiarFormulario();

        }



        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
