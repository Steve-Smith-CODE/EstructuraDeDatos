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
            string a�osAntiguedad = txtA�osAntiguedad.Text;
            jefe = new Jefe(nombres, dni, cargo, area, a�osAntiguedad);
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
            txtResultado.AppendText("�rea: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("A�os de Antig�edad: " + jefe.A�osAntiguedad + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + jefe.CalcularSueldoBase().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Bonificaci�n: " + jefe.CalcularBonificacion().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Movilidad: " + jefe.CalcularMovilidad().ToString("C") + Environment.NewLine);
            txtResultado.AppendText("Sueldo Final: " + jefe.CalcularSueldoFinal().ToString("C") + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtDNI.Text = "";
            txtA�osAntiguedad.Text = "";
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
