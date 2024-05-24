namespace Laboratorio07
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboTipoSeguro = new ComboBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtSueldo = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtHorasExtras = new TextBox();
            label6 = new Label();
            cboArea = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // cboTipoSeguro
            // 
            cboTipoSeguro.BackColor = SystemColors.ScrollBar;
            cboTipoSeguro.FormattingEnabled = true;
            cboTipoSeguro.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoSeguro.Location = new Point(555, 49);
            cboTipoSeguro.Name = "cboTipoSeguro";
            cboTipoSeguro.Size = new Size(186, 28);
            cboTipoSeguro.TabIndex = 1;
            cboTipoSeguro.Text = "AFP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 26);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Seguro";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(30, 49);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(134, 27);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 99);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(30, 122);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(134, 27);
            txtSueldo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 25);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 99);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 8;
            label5.Text = "Hora extras";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(199, 122);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(196, 27);
            txtHorasExtras.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 99);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(40, 20);
            label6.TabIndex = 10;
            label6.Text = "Aréa";
            // 
            // cboArea
            // 
            cboArea.BackColor = SystemColors.ScrollBar;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "ADMINISTRACIÓN", "INFORMÁTICA", "CONTABILIDAD", "ALMACÉN" });
            cboArea.Location = new Point(555, 121);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(186, 28);
            cboArea.TabIndex = 11;
            cboArea.Text = "ADMINISTRACIÓN";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ControlLightLight;
            txtResultado.Location = new Point(30, 171);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(711, 211);
            txtResultado.TabIndex = 12;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(30, 388);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(134, 32);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(199, 388);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(243, 32);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar información del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(461, 388);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 32);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(607, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(134, 32);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 429);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboArea);
            Controls.Add(label6);
            Controls.Add(txtHorasExtras);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtSueldo);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(cboTipoSeguro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTipoSeguro;
        private Label label2;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtSueldo;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtHorasExtras;
        private Label label6;
        private ComboBox cboArea;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
