using System;

namespace formulario02
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string dni = txtDNI.Text;
            string cargo = cboCargo.Text;
            string area = cboArea.Text;
            string añosAntiguedad = txtAñosAntiguedad.Text;
            jefe = new Jefe(nombres, dni, cargo, area, añosAntiguedad);
            MessageBox.Show("Objeto Jefe Creado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (jefe == null)
            {
                MessageBox.Show("Primero debe crear un objeto Jefe.");
                return;
            }

            txtResultado.AppendText("Nombres: " + jefe.Nombres + Environment.NewLine);
            txtResultado.AppendText("DNI: " + jefe.DNI + Environment.NewLine);
            txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultado.AppendText("Área: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("Años de Antigüedad: " + jefe.AñosAntiguedad + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + jefe.CalcularSueldoBase().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Bonificación: " + jefe.CalcularBonificacion().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Movilidad: " + jefe.CalcularMovilidad().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Sueldo Final: " + jefe.CalcularSueldoFinal().ToString("C") + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtDNI.Text = "";
            txtAñosAntiguedad.Text = "";
            txtResultado.Text = "";

            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
