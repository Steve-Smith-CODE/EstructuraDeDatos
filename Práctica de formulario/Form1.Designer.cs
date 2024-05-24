namespace Práctica_de_formulario
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
            txtCodigo = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label4 = new Label();
            cboContrato = new ComboBox();
            label5 = new Label();
            cboEspecialidad = new ComboBox();
            label6 = new Label();
            cboSupervision = new ComboBox();
            label7 = new Label();
            cboAfiliacion = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtSueldo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(23, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(23, 85);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 27);
            txtNombres.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 9);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 6;
            label4.Text = "Condición de contrato";
            // 
            // cboContrato
            // 
            cboContrato.FormattingEnabled = true;
            cboContrato.Items.AddRange(new object[] { "Estable", "Contratado" });
            cboContrato.Location = new Point(506, 32);
            cboContrato.Name = "cboContrato";
            cboContrato.Size = new Size(191, 28);
            cboContrato.TabIndex = 7;
            cboContrato.Text = "Estable";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 62);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 8;
            label5.Text = "Especialidad";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hídricos" });
            cboEspecialidad.Location = new Point(507, 85);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(190, 28);
            cboEspecialidad.TabIndex = 9;
            cboEspecialidad.Text = "Estructuras";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 116);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 10;
            label6.Text = "Tipo de Supervisión";
            // 
            // cboSupervision
            // 
            cboSupervision.FormattingEnabled = true;
            cboSupervision.Items.AddRange(new object[] { "Superivisión de Obras", "Supervisión de Vías" });
            cboSupervision.Location = new Point(505, 139);
            cboSupervision.Name = "cboSupervision";
            cboSupervision.Size = new Size(192, 28);
            cboSupervision.TabIndex = 11;
            cboSupervision.Text = "Superivisión de Obras";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 170);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 12;
            label7.Text = "Tipo de Afiliación";
            // 
            // cboAfiliacion
            // 
            cboAfiliacion.FormattingEnabled = true;
            cboAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliacion.Location = new Point(505, 193);
            cboAfiliacion.Name = "cboAfiliacion";
            cboAfiliacion.Size = new Size(192, 28);
            cboAfiliacion.TabIndex = 13;
            cboAfiliacion.Text = "AFP";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(23, 227);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(674, 170);
            txtResultado.TabIndex = 14;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(28, 407);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(120, 29);
            btnCrear.TabIndex = 15;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(170, 407);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(202, 29);
            btnMostrar.TabIndex = 16;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(405, 407);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 29);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(603, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(23, 138);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 115);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 20;
            label3.Text = "Sueldo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 466);
            Controls.Add(label3);
            Controls.Add(txtSueldo);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboAfiliacion);
            Controls.Add(label7);
            Controls.Add(cboSupervision);
            Controls.Add(label6);
            Controls.Add(cboEspecialidad);
            Controls.Add(label5);
            Controls.Add(cboContrato);
            Controls.Add(label4);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtNombres;
        private Label label4;
        private ComboBox cboContrato;
        private Label label5;
        private ComboBox cboEspecialidad;
        private Label label6;
        private ComboBox cboSupervision;
        private Label label7;
        private ComboBox cboAfiliacion;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtSueldo;
        private Label label3;
    }
}
