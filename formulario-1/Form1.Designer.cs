namespace formulario_1
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
            txtCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            cboCondicion = new ComboBox();
            label4 = new Label();
            cboEspecialidad = new ComboBox();
            label5 = new Label();
            cboActividad = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label6 = new Label();
            cboAfiliacion = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.Location = new Point(47, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(212, 27);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 62);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.Info;
            txtNombres.Location = new Point(47, 85);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(212, 27);
            txtNombres.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 115);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 4;
            label3.Text = "Condición de contrato";
            // 
            // cboCondicion
            // 
            cboCondicion.BackColor = SystemColors.Info;
            cboCondicion.FormattingEnabled = true;
            cboCondicion.Items.AddRange(new object[] { "ESTABLE", "CONTRATADO" });
            cboCondicion.Location = new Point(47, 138);
            cboCondicion.Name = "cboCondicion";
            cboCondicion.Size = new Size(212, 28);
            cboCondicion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 9);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "Especialidad";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.BackColor = SystemColors.Info;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "ESTRUCTURA", "RECURSOS HÍDRICOS" });
            cboEspecialidad.Location = new Point(488, 31);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(223, 28);
            cboEspecialidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 63);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 8;
            label5.Text = " Tipo de Actividad";
            // 
            // cboActividad
            // 
            cboActividad.BackColor = SystemColors.Info;
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "SUPERIVISIÓN DE OBRAS", "SUPERIVISIÓN  DE VÍAS" });
            cboActividad.Location = new Point(502, 84);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(223, 28);
            cboActividad.TabIndex = 9;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Window;
            txtResultado.Location = new Point(47, 226);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(678, 214);
            txtResultado.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.ForeColor = SystemColors.MenuHighlight;
            btnCrear.Location = new Point(47, 446);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(110, 32);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear objeto";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.ForeColor = SystemColors.MenuHighlight;
            btnMostrar.Location = new Point(172, 446);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(220, 32);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.Highlight;
            btnLimpiar.Location = new Point(470, 446);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 32);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.ForeColor = SystemColors.Highlight;
            btnSalir.Location = new Point(601, 446);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 32);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 115);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 15;
            label6.Text = " Tipo de Afiliación";
            // 
            // cboAfiliacion
            // 
            cboAfiliacion.BackColor = SystemColors.Info;
            cboAfiliacion.FormattingEnabled = true;
            cboAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliacion.Location = new Point(502, 138);
            cboAfiliacion.Name = "cboAfiliacion";
            cboAfiliacion.Size = new Size(223, 28);
            cboAfiliacion.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 115);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 490);
            Controls.Add(label7);
            Controls.Add(cboAfiliacion);
            Controls.Add(label6);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboActividad);
            Controls.Add(label5);
            Controls.Add(cboEspecialidad);
            Controls.Add(label4);
            Controls.Add(cboCondicion);
            Controls.Add(label3);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private Label label2;
        private TextBox txtNombres;
        private Label label3;
        private ComboBox cboCondicion;
        private Label label4;
        private ComboBox cboEspecialidad;
        private Label label5;
        private ComboBox cboActividad;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label6;
        private ComboBox cboAfiliacion;
        private Label label7;
    }
}
