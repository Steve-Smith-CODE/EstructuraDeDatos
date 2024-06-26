namespace Laboratorio07
{
    public partial class Form1 : Form
    {
        Empleado empleado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipoSeguro.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)//Crear c�digo
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string seguro = cboTipoSeguro.Text;
            decimal sueldo = decimal.Parse(txtSueldo.Text);
            decimal horasExtras = decimal.Parse(txtHorasExtras.Text);
            string area = cboArea.Text;

            empleado = new Empleado(codigo, nombre, area, sueldo, horasExtras, seguro);
            MessageBox.Show("Objeto Creado");

        }

        private void btnMostrar_Click(object sender, EventArgs e)//Mostrar informaci�n
        {
            txtResultado.AppendText("Objeto Nro: " + Empleado.GetContador().ToString() + Environment.NewLine);
            txtResultado.AppendText("C�digo: " + empleado.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + empleado.Nombre + Environment.NewLine);
            txtResultado.AppendText("Seguro: " + empleado.TipoSeguro + Environment.NewLine);
            txtResultado.AppendText("Sueldo: " + empleado.SueldoBase + Environment.NewLine);
            txtResultado.AppendText("Horas Extras: " + empleado.HorasExtras + Environment.NewLine);
            txtResultado.AppendText("�rea: " + empleado.Area + Environment.NewLine);
            txtResultado.AppendText("Monto Extra: " + empleado.CalcularHorasExtras() + Environment.NewLine);
            txtResultado.AppendText("Monto Seguro: " + empleado.CalcularMontoSeguro() + Environment.NewLine);
            txtResultado.AppendText("Monto Essalud: " + empleado.CalcularMontoEssalud() + Environment.NewLine);
            txtResultado.AppendText("Monto Descuento: " + empleado.CalularDescuento() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + empleado.SueldoBruto() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + empleado.SueldoNeto() + Environment.NewLine);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Clear();
            txtHorasExtras.Clear();
            txtSueldo.Clear();
            txtResultado.Clear();
            txtCodigo.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
